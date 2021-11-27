using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turing.Configs;
using Turing.Interfaces;

namespace Turing.Misc
{
    internal class TuringCPU : ITuringCPU
    {
        public IEnumerable<string> DoWork(MachineConfig machineConfig)
        {
            while (true)
            {
                for (var i = 0; i < machineConfig.RulesCount; i++)
                {
                    if (!machineConfig.Rules[i, 0].Equals(machineConfig.State) || char.Parse(machineConfig.Rules[i, 1]) != machineConfig.Tape[machineConfig.HeadPosition]) continue;
                    machineConfig.Tape[machineConfig.HeadPosition] = char.Parse(machineConfig.Rules[i, 2]);
                    if (char.Parse(machineConfig.Rules[i, 3]) == 'L') machineConfig.HeadPosition--;
                    else machineConfig.HeadPosition++;
                    machineConfig.State = machineConfig.Rules[i, 4];
                    yield return new string(machineConfig.Tape);
                }
            }
        }
    }
}
