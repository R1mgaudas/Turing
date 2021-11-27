
using Turing.Configs;

namespace Turing.Interfaces
{
    internal interface IDataReader
    {
        public MachineConfig ReadTuringMachineConfigData(string[] args);
    }
}
