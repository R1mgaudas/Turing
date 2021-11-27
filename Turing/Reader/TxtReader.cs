using System.IO;
using System.Linq;
using Turing;
using Turing.Configs;
using Turing.Interfaces;

namespace Turing.Reader
{
    //Following the Interface Segregation Principle because a class must not have to implement any interface element that is not required by the particular class.
    internal class TxtReader : IDataReader
    {
        public MachineConfig ReadTuringMachineConfigData(string[] args)
        {
            string[] lines = File.ReadLines(args.First()).ToArray();

            return MapTxtToConfig(lines);
        }

        private static MachineConfig MapTxtToConfig(string[] lines)
        {
            MachineConfig turingMachineConfig = new MachineConfig();

            string tape = lines.Skip(1).First();
            turingMachineConfig.HeadPosition = int.Parse(lines.First());
            turingMachineConfig.Rules = new string[lines.Skip(2).Count(), 5];
            turingMachineConfig.Tape = new char[lines.Skip(1).First().Length];
            turingMachineConfig.TapeLength = lines.Skip(1).First().Length;
            turingMachineConfig.State = "0";

            for (int i = 0; i < turingMachineConfig.TapeLength; i++)
                turingMachineConfig.Tape[i] = tape[i];

            foreach (var rule in lines.Skip(2))
            {
                string[] tokens = rule.Split(' ');
                for (int i = 0; i < 5; i++)
                {
                    turingMachineConfig.Rules[turingMachineConfig.RulesCount, i] = tokens[i];
                }

                turingMachineConfig.RulesCount++;
            }

            return turingMachineConfig;
        }
    }
}
