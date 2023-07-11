using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using RestSharp;
using System.Windows.Forms;

namespace Szop_EA
{
    static class GetResponse
    {
        public static void GetResp(RestRequest request)
        {
            RestResponse response = Login.Client.Execute(request);
            if (!DBconn.Check(Login.Client))
            {
                return;
            }
            Response res = Login.Client.Deserialize<Response>(response).Data;
            if (res.Status == 1)
            {
                MessageBox.Show(res.Msg, "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(res.Msg, "Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
    }
}
