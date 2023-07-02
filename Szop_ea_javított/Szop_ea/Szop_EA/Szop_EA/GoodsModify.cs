using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szop_EA
{
    public partial class GoodsModify : Form
    {
        private GoodsData adatok;
        public GoodsModify(GoodsData adatok = null)
        {
            InitializeComponent();
            this.adatok = adatok;
            tb_termek.Text = adatok.Termek;
            num_ar.Value = adatok.Ar;
            num_mennyiseg.Value = adatok.Mennyiseg;
        }
        private bool areAllEmpty()
        {
            return tb_termek.Text.Length <= 0 ||
                num_ar.Value.ToString().Length <= 0 ||
                num_mennyiseg.Value.ToString().Length <= 0;
        }
        private bool lessThanZero()
        {
            return num_ar.Value <= 0 ||
                num_mennyiseg.Value <= 0;
        }
        public void FeltoltAru(string goodsName, int price, int quantity)
        {
            try
            {
                int arC, mennyisegC;
                if (areAllEmpty())
                {
                    MessageBox.Show("All the fields should be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!(int.TryParse(price.ToString(), out arC)) && !(int.TryParse(quantity.ToString(), out mennyisegC)))
                {
                    MessageBox.Show("Quantity should be number type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (lessThanZero())
                {
                    MessageBox.Show("Value of price or quantity should be higher than 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string route = "inventory";
                    RestRequest request = new RestRequest(route, Method.Put);
                    request.RequestFormat = DataFormat.Json;
                    request.AddJsonBody(
                        new
                        {
                            username = Login.uName,
                            password = Login.password,
                            id = adatok.ID,
                            aruNev = goodsName,
                            ar = price,
                            mennyiseg = quantity
                        }
                    );
                    RestResponse response = Login.Client.Execute(request);
                    if (response.StatusCode == 0)
                    {
                        MessageBox.Show("Connection to server failed!");
                        return;
                    }
                    else if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"ERROR: {response.ErrorMessage}");
                        return;
                    }
                    Response res = Login.Client.Deserialize<Response>(response).Data;
                    if (res.Status == 1)
                        MessageBox.Show(res.Msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(res.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "KONVERZIÓ HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_modosit_Click(object sender, EventArgs e)
        {
            FeltoltAru(tb_termek.Text, (int)num_ar.Value, (int)num_mennyiseg.Value);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
