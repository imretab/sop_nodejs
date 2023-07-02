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
        [JsonPropertyName("termek")]
        public string Termek { get; set; }
        [JsonPropertyName("ar")]
        public int Ar { get; set; }
        [JsonPropertyName("mennyiseg")]
        public int Mennyiseg { get; set; }
    }
}
