using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Szop_EA
{
        public class TransferData
        {
            [JsonPropertyName("id")]
            public int ID { get; set; }
            [JsonPropertyName("from")]
            public string From { get; set; }
            [JsonPropertyName("to")]
            public string To { get; set; }
            [JsonPropertyName("account_number")]
            public string AccountNumber { get; set; }
            [JsonPropertyName("money")]
            public int Money { get; set; }
            [JsonPropertyName("information")]
            public string Information { get; set; }
        }
}
