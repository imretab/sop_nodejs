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
    public partial class GoodsInsert : Form
    {
        public GoodsInsert()
        {
            InitializeComponent();
        }
        private bool areAllEmpty()
        {
            return tb_product.Text.Length <= 0 ||
                num_price.Value.ToString().Length <= 0 ||
                num_quantity.Value.ToString().Length <= 0;
        }
        private bool lessThanZero()
        {
            return num_price.Value <= 0||
                num_quantity.Value <=0;
        }
        public void InsertGoods(string goodsName, int price, int quantity)
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
                    RestRequest request = new RestRequest(route, Method.Post);
                    request.RequestFormat = DataFormat.Json;
                    request.AddJsonBody(
                        new
                        {
                            username = Login.uName,
                            password = Login.password,
                            productName = goodsName,
                            price = price,
                            quantity = quantity
                        }
                    );
                    RestResponse response = Login.Client.Execute(request);
                    if (!DBconn.Check(Login.Client))
                    {
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
                MessageBox.Show(e.Message, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_feltolt_Click(object sender, EventArgs e)
        {
            InsertGoods(tb_product.Text, (int)num_price.Value,(int)num_quantity.Value);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
