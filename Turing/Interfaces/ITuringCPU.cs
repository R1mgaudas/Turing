using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turing.Configs;

namespace Turing.Interfaces
{
    internal interface ITuringCPU
    {
        IEnumerable<string> DoWork(MachineConfig machineConfig);
    }
}
