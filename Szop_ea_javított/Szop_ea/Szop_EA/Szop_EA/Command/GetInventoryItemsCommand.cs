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
    class GetInventoryItemsCommand : ICommand
    {
        private DataGridView dgv_purchase;
        private DataGridView dgv_inventory;
        public void execute()
        {
            if (!DBconn.Check(Login.Client))
            {
                return;
            }
            RestRequest request = new RestRequest("inventory", Method.Get);
            RestResponse response = Login.Client.Execute(request);
            List<GoodsData> goods = JsonSerializer.Deserialize<List<GoodsData>>(response.Content);
            dgv_purchase.DataSource = goods;
            dgv_inventory.DataSource = goods;
            dgv_inventory.Columns[0].Visible = false;
            dgv_purchase.Columns[0].Visible = false;
        }
        public GetInventoryItemsCommand(DataGridView dgv_purchase, DataGridView dgv_inventory)
        {
            this.dgv_purchase = dgv_purchase;
            this.dgv_inventory = dgv_inventory;
        }
    }
}
