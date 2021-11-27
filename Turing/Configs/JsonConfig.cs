using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turing.Misc;

namespace Turing.Configs
{
    class JsonConfig
    {
        [JsonProperty("head-start-position")]
        public string HeadStartPosition { get; set; }
        [JsonProperty("tape")]
        public string Tape { get; set; }
        [JsonProperty("rules")]
        public List<Rule> Rules { get; set; }
    }
}
