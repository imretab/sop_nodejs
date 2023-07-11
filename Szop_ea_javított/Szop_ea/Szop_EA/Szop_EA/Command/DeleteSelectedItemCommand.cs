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
    class DeleteSelectedItemCommand : ICommand
    {
        private DataGridView dgv_inventory;
        public void execute()
        {
            GoodsData adatok = dgv_inventory.CurrentRow.DataBoundItem as GoodsData;
            int id = adatok.ID;
            RestRequest request = new RestRequest($"inventory/{id}", Method.Delete);
            if (adatok == null) { throw new Exception(); }
            request.AddJsonBody(new
            {
                username = Login.uName,
                password = Login.password,
            });
            GetResponse.GetResp(request);
        }
        public DeleteSelectedItemCommand(DataGridView dgv_inventory)
        {
            this.dgv_inventory = dgv_inventory;
        }
    }
}
