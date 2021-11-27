using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turing.Configs;
using Turing.Interfaces;
using Turing.Reader;

namespace Turing.Misc
{
    class TuringManager
    {
        private readonly IDataWriter _turingDataWriter;
        private readonly ITuringCPU _turingProcessor;

        public TuringManager(IDataWriter turingDataWriter, ITuringCPU turingProcessor)
        {
            _turingDataWriter = turingDataWriter;
            _turingProcessor = turingProcessor;
        }
        public void Manage(string[] args)
        {
            IDataReader dataReader = args[0].Contains(".txt") ? (IDataReader)new TxtReader() : (IDataReader)new JsonReader(); //Open closed Principle(OSP) //Liskov substitution Principle(LSP)
            MachineConfig machineConfig = dataReader.ReadTuringMachineConfigData(args);
            foreach (string processedLine in _turingProcessor.DoWork(machineConfig))
                _turingDataWriter.WriteData(processedLine);
        }
    }
}
