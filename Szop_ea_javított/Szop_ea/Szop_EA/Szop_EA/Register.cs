using System;
using RestSharp;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private bool areAllFilled()
        {
            return tb_fullName.Text.Length <= 0 ||
                tb_username.Text.Length <= 0 ||
                tb_pwd.Text.Length <= 0 ||
                tb_pwd_again.Text.Length <= 0 ||
                tb_email.Text.Length <= 0;
        }
        private bool doPasswordsMatch(string pwd, string pwdAgain)
        {
            return pwd == pwdAgain;
        }
        public void RegisterU(string fullName,string uname, string pwd, string pwdAgain, string Email)
        {
            if (areAllFilled())
            {
                MessageBox.Show("You must fill all the fields!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!doPasswordsMatch(pwd,pwdAgain))
            {
                MessageBox.Show("The two password fields must match!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string route = "register";
                RestRequest request = new RestRequest(route, Method.Post);
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(
                    new
                    {
                        fullName = fullName,
                        username = uname,
                        password = pwd,
                        email = Email,
                        role = "user"
                    }
                );
                RestResponse response = Login.Client.Execute(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"ERROR: {response.ErrorMessage}");
                    return;
                }
                Response res = Login.Client.Deserialize<Response>(response).Data;
                if (res.Status == 1)
                    MessageBox.Show(res.Msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(res.Msg,"Fail");
            }
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            RegisterU(tb_fullName.Text, tb_username.Text, tb_pwd.Text, tb_pwd_again.Text, tb_email.Text);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }
    }
}
