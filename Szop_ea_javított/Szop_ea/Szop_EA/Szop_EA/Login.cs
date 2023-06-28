using RestSharp;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Szop_EA
{
    public partial class Login : Form
    {
        public static RestClient Client = new RestClient($"http://{ConfigurationManager.AppSettings["server"]}:{ConfigurationManager.AppSettings["port"]}/");
        public static string uName, password;
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            LoginUser(tb_uName.Text, tb_pwd.Text);
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.ShowDialog();
            this.Close();
        }

        private void Btn_OpenAPI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://127.0.0.1:8080/api_docs");
        }

        private void LoginUser(string name, string passwd)
        {
            try
            {
                string ROUTE = $"login/{name}&{passwd}";
                RestRequest request = new RestRequest(ROUTE, Method.Get);
                request.RequestFormat = DataFormat.Json;
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(passwd))
                {
                    MessageBox.Show("A név és a jelszó nem lehet üres", "SHIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RestResponse response = Client.Execute(request);
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
                    uName = name;
                    password = passwd;
                    Response res = Client.Deserialize<Response>(response).Data;
                    if (res.Status == 1)
                    {
                        MessageBox.Show(res.Msg, "SIKER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Bolt b = new Bolt();
                        b.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(res.Msg, "SHIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
