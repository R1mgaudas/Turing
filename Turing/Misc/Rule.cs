using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing.Misc
{
    class Rule
    {
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("read")]
        public string Read { get; set; }
        [JsonProperty("write")]
        public string Write { get; set; }
        [JsonProperty("move")]
        public string Move { get; set; }

        [JsonProperty("next-state")]
        public string NextState { get; set; }
    }
}
