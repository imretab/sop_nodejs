using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using RestSharp;
using System.Windows.Forms;

namespace Szop_EA.Command
{
    class PurchaseCommand : ICommand
    {
        private DataGridView dgv_purchase;
        private NumericUpDown num_amount;
        public void execute()
        {
            RestRequest request = new RestRequest("purchase", Method.Put);
            GoodsData goods = dgv_purchase.CurrentRow.DataBoundItem as GoodsData;
            if (goods == null) { throw new Exception(); }
            if (num_amount.Value <= 0)
            {
                MessageBox.Show("You can't buy items if the value of quantity is less or equals to 0", "ERROR");
                return;
            }
            if (num_amount.Value > goods.Quantity)
            {
                MessageBox.Show("You can't buy more than what's in stock", "ERROR");
                return;
            }
            request.AddJsonBody(new
            {
                username = Login.uName,
                password = Login.password,
                id = goods.ID,
                productName = goods.ProductName,
                quantity = num_amount.Value
            });
            GetResponse.GetResp(request);
        }
        public PurchaseCommand(DataGridView dgv_purchase, NumericUpDown num_amount)
        {
            this.dgv_purchase = dgv_purchase;
            this.num_amount = num_amount;
        }
    }
}
