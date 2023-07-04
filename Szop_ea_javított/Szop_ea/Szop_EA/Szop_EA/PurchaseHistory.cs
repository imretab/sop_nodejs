using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace Szop_EA
{
    class PurchaseHistory
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("Buyer")]
        public string Buyer { get; set; }
        [JsonPropertyName("ProductName")]
        public string Product { get; set; }
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }
}
