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
    class GetTransferDataCommand : ICommand
    {
        private DataGridView dgv_purchase;
        public void execute()
        {
            RestRequest request = new RestRequest($"php/{Login.uName}&{Login.password}", Method.Get);
            RestResponse response = Login.Client.Execute(request);
            List<TransferData> adatok = JsonSerializer.Deserialize<List<TransferData>>(response.Content);
            dgv_purchase.DataSource = adatok;
        }
        public GetTransferDataCommand(DataGridView dgv_purchase)
        {
            this.dgv_purchase = dgv_purchase;
        }
    }
}
