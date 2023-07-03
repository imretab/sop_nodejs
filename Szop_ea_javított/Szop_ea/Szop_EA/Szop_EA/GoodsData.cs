using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Szop_EA
{
    public class GoodsData
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("goods")]
        public string Termek { get; set; }
        [JsonPropertyName("price")]
        public int Ar { get; set; }
        [JsonPropertyName("quantity")]
        public int Mennyiseg { get; set; }
    }
}
