using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Szop_EA.Command
{
    class UpdateGoodsCommand : ICommand
    {
        private GoodsData data;
        private string goodsName;
        private int price, quantity;
        public void execute()
        {
            RestRequest request = new RestRequest("inventory", Method.Put);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(
                new
                {
                    username = Login.uName,
                    password = Login.password,
                    id = data.ID,
                    productName = goodsName,
                    price = price,
                    quantity = quantity
                }
            );
            GetResponse.GetResp(request);
        }
        public UpdateGoodsCommand(GoodsData data, string goodsName, int price, int quantity)
        {
            this.data = data;
            this.goodsName = goodsName;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
