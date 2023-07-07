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
                if (!DBconn.Check(Client)) { 
                    return; 
                } 
                string ROUTE = $"login/{name}&{passwd}";
                RestRequest request = new RestRequest(ROUTE, Method.Get);
                request.RequestFormat = DataFormat.Json;
                    RestResponse response = Client.Execute(request);
                    uName = name;
                    password = passwd;
                    Response res = Client.Deserialize<Response>(response).Data;
                    if(res is null)
                    {
                        MessageBox.Show("Input fields are empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                        return;
                    }
                    if (res.Status == 1)
                    {
                        MessageBox.Show(res.Msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Shop b = new Shop();
                        b.ShowDialog();
                        this.Close();
                    }
                    MessageBox.Show(res.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }

        }
    }
}
