using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing.Configs
{
    class MachineConfig
    {
        public string State { get; set; }
        public int HeadPosition { get; set; }
        public char[] Tape { get; set; }
        public int TapeLength { get; set; }
        public int RulesCount { get; set; }
        public string[,] Rules { get; set; }
    }
}
