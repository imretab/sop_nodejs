using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Szop_EA
{
        public class UtalasAdatok
        {
            [JsonPropertyName("id")]
            public int ID { get; set; }
            [JsonPropertyName("kitol")]
            public string Kitol { get; set; }
            [JsonPropertyName("kinek")]
            public string Kinek { get; set; }
            [JsonPropertyName("szamlaszam")]
            public string Szamlaszam { get; set; }
            [JsonPropertyName("osszeg")]
            public int Osszeg { get; set; }
            [JsonPropertyName("kozlemeny")]
            public string Kozlemeny { get; set; }
        }
}
