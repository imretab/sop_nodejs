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
    public partial class AruMod : Form
    {
        private AruAdatok adatok;
        public AruMod(AruAdatok adatok = null)
        {
            InitializeComponent();
            this.adatok = adatok;
            tb_termek.Text = adatok.Termek;
            num_ar.Value = adatok.Ar;
            num_mennyiseg.Value = adatok.Mennyiseg;
        }
        private bool mindUresE()
        {
            return tb_termek.Text.Length <= 0 ||
                num_ar.Value.ToString().Length <=0 ||
                num_mennyiseg.Value.ToString().Length <=0;
        }
        private bool KisebbMintNulla()
        {
            return num_ar.Value <= 0 ||
                num_mennyiseg.Value <= 0;
        }
        public void FeltoltAru(string termek, int Ar, int Mennyiseg)
        {
            try
            {
                int arC, mennyisegC;
                if (mindUresE())
                {
                    MessageBox.Show("Minden mező kitöltése kötelező!", "SHIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!(int.TryParse(Ar.ToString(), out arC)) && !(int.TryParse(Mennyiseg.ToString(), out mennyisegC)))
                {
                    MessageBox.Show("A mennyiség szám lehet csak!", "SHIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (KisebbMintNulla())
                {
                    MessageBox.Show("A mennyiség és/vagy az ár nem lehet kisebb, mint 0!","SHIBA", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string route = "raktar";
                    RestRequest request = new RestRequest(route, Method.Put);
                    request.RequestFormat = DataFormat.Json;
                    request.AddJsonBody(
                        new
                        {
                            username = Login.uName,
                            password = Login.password,
                            id = adatok.ID,
                            aruNev = termek,
                            ar = Ar,
                            mennyiseg = Mennyiseg
                        }
                    );
                    RestResponse response = Login.Client.Execute(request);
                    if (response.StatusCode == 0)
                    {
                        MessageBox.Show("A szerverhez való csatlakozás sikertelen!");
                        return;
                    }
                    else if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"ERROR: {response.ErrorMessage}");
                        return;
                    }
                    Response res = Login.Client.Deserialize<Response>(response).Data;
                    if (res.Status == 1)
                        MessageBox.Show(res.Msg, "SIKER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(res.Msg,"SHIBA",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
