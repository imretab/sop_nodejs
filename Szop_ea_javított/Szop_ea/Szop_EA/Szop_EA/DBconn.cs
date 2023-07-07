using System;
using RestSharp;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szop_EA
{
    static class DBconn
    {
        public static bool Check(RestClient Client)
        {
            //for DB conn
            string connectionRoute = "";
            RestRequest checkConnection = new RestRequest(connectionRoute, Method.Get);
            RestResponse connectionRestResponse = Client.Execute(checkConnection);
            Response connectionResponse = Client.Deserialize<Response>(connectionRestResponse).Data;
            if (connectionResponse is null)
            {
                throw new DBconnectionException();
            }
            if (connectionResponse.Status == 500)
            {
                MessageBox.Show(connectionResponse.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
