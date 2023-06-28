using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szop_EA
{
    public partial class Bolt : Form
    {
        public Bolt()
        {
            InitializeComponent();
            UpdateVasarlasLista();
            logged.Text = $"Üdv {Login.uName}";
        }
        private void UpdateVasarlasLista()
        {
            RestRequest request = new RestRequest("raktar", Method.Get);

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
            List<AruAdatok> aruk = JsonSerializer.Deserialize<List<AruAdatok>>(response.Content);
            dgv_vasarolt.DataSource = aruk;
            dgv_raktar.DataSource = aruk;
            dgv_raktar.Columns[0].Visible = false;
            dgv_vasarolt.Columns[0].Visible = false;
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            Login.uName = null;
            Login.password = null;
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void Btn_feltolt_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AruFeltolt feltolt = new AruFeltolt();
            feltolt.ShowDialog();
            //this.Close();
        }

        private void Btn_frissit_Click(object sender, EventArgs e)
        {
            try
            {
                
                AruAdatok adatok = dgv_raktar.CurrentRow.DataBoundItem as AruAdatok;
                if (adatok == null)
                {
                    throw new Exception();
                }
                else
                {
                    //this.Hide();
                    AruMod mod = new AruMod(adatok);
                    mod.ShowDialog();
                    UpdateVasarlasLista();
                    //this.Close();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Torol()
        {
            try
            {
                AruAdatok adatok = dgv_raktar.CurrentRow.DataBoundItem as AruAdatok;
                int id = adatok.ID;
                RestRequest request = new RestRequest($"raktar/{id}", Method.Delete);
                if(adatok == null) { throw new Exception(); }
                request.AddJsonBody(new
                {
                    username = Login.uName,
                    password = Login.password,
                });

                RestResponse response = Login.Client.Execute(request);
                if (response.StatusCode == 0)
                {
                    MessageBox.Show("A szerverhez való csatlakozás sikertelen!");
                    return;
                }
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"ERROR: {response.ErrorMessage}");
                    return;
                }
                Response res = Login.Client.Deserialize<Response>(response).Data;
                if (res.Status == 1)
                {
                    MessageBox.Show(res.Msg, "Siker");
                }
                else
                {
                    MessageBox.Show(res.Msg, "Hiba");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Btn_aruTorles_Click(object sender, EventArgs e)
        {
            DialogResult torolE = MessageBox.Show("Biztos törölni akarod ezt a terméket?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(torolE == DialogResult.Yes)
            {
                Torol();
                UpdateVasarlasLista();
            }
        }
        private void Vasarlas()
        {
            try
            {
                RestRequest request = new RestRequest("vasarlas", Method.Put);
                AruAdatok adatok = dgv_vasarolt.CurrentRow.DataBoundItem as AruAdatok;
                if (adatok == null) { throw new Exception(); }
                if (num_mennyit.Value <= 0)
                {
                    MessageBox.Show("0-t, vagy kevesebb, mint 0-t képtelenség venni", "SHIBA");
                    return;
                }
                if (num_mennyit.Value > adatok.Mennyiseg)
                {
                    MessageBox.Show("Nem vehetsz többet, mint amennyi a raktáron van", "SHIBA");
                    return;
                }
                request.AddJsonBody(new
                {
                    username = Login.uName,
                    password = Login.password,
                    id = adatok.ID,
                    mennyiseg = num_mennyit.Value
                });
                RestResponse response = Login.Client.Execute(request);
                if (response.StatusCode == 0)
                {
                    MessageBox.Show("A szerverhez való csatlakozás sikertelen!");
                    return;
                }
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"ERROR: {response.ErrorMessage}");
                    return;
                }
                Response res = Login.Client.Deserialize<Response>(response).Data;
                if (res.Status == 1)
                {
                    MessageBox.Show(res.Msg, "Siker");
                }
                else
                {
                    MessageBox.Show(res.Msg, "Hiba");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                php.Checked = false;
            }
        }
        private void Btn_vasarlas_Click(object sender, EventArgs e)
        {
            Vasarlas();
            UpdateVasarlasLista();
        }

        private void Php_CheckedChanged(object sender, EventArgs e)
        {
            RestRequest request = null;
            if (php.Checked)
            {
                request = new RestRequest("php", Method.Get);
                RestResponse response = Login.Client.Execute(request);
                if (response.StatusCode == 0)
                {
                    MessageBox.Show("A szerverhez való csatlakozás sikertelen!");
                    php.Checked = false;
                    return;
                }
                else if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"ERROR: {response.ErrorMessage}");
                    php.Checked = false;
                    return;
                }
                List<UtalasAdatok> adatok = JsonSerializer.Deserialize<List<UtalasAdatok>>(response.Content);
                dgv_vasarolt.DataSource = adatok;
            }
            else
            {
                request = new RestRequest("raktar", Method.Get);
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
                List<AruAdatok> aruk = JsonSerializer.Deserialize<List<AruAdatok>>(response.Content);
                dgv_vasarolt.DataSource = aruk;
            }
            dgv_raktar.Columns[0].Visible = false;
        }
    }
}
