using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Text.Json;
using System.Windows.Forms;

namespace Szop_EA.Command
{
    class GetPurchaseHistoryCommand : ICommand
    {
        private DataGridView dgv_PurchaseHistory;
        public void execute()
        {
            RestRequest request = new RestRequest("purchase", Method.Post);
            request.AddJsonBody(new
            {
                username = Login.uName,
                password = Login.password
            });
            RestResponse response = Login.Client.Execute(request);
            List<PurchaseHistory> purchaseHistories = JsonSerializer.Deserialize<List<PurchaseHistory>>(response.Content);
            dgv_PurchaseHistory.DataSource = purchaseHistories;
            dgv_PurchaseHistory.Columns[0].Visible = false;
        }
        public GetPurchaseHistoryCommand(DataGridView dgv_PurchaseHistory)
        {
            this.dgv_PurchaseHistory = dgv_PurchaseHistory;
        }
    }
}
