using Newtonsoft.Json;
using System.IO;
using System.Linq;
using Turing.Configs;
using Turing.Interfaces;
using Turing.Misc;

namespace Turing.Reader
{
    //Interface Segregation Principle(ISP)
    internal class JsonReader : IDataReader
    {
        public MachineConfig ReadTuringMachineConfigData(string[] args)
        {
            JsonConfig json = JsonConvert.DeserializeObject<JsonConfig>(File.ReadAllText(args.First()));

            return MapJsonToConfig(json);
        }

        private static MachineConfig MapJsonToConfig(JsonConfig json)
        {
            MachineConfig turingMachineConfig = new MachineConfig();

            string tape = string.Empty;

            if (json != null)
            {
                tape = json.Tape;
                turingMachineConfig.HeadPosition = int.Parse(json.HeadStartPosition);
                turingMachineConfig.Rules = new string[json.Rules.Count, 5];
                turingMachineConfig.Tape = new char[json.Tape.Length];
                turingMachineConfig.TapeLength = json.Tape.Length;
                turingMachineConfig.State = "0";
            }


            for (int i = 0; i < turingMachineConfig.TapeLength; i++)
                turingMachineConfig.Tape[i] = tape[i];

            if (json == null) return turingMachineConfig;
            foreach (Rule rule in json.Rules)
            {
                turingMachineConfig.Rules[turingMachineConfig.RulesCount, 0] = rule.State;
                turingMachineConfig.Rules[turingMachineConfig.RulesCount, 1] = rule.Read;
                turingMachineConfig.Rules[turingMachineConfig.RulesCount, 2] = rule.Write;
                turingMachineConfig.Rules[turingMachineConfig.RulesCount, 3] = rule.Move;
                turingMachineConfig.Rules[turingMachineConfig.RulesCount, 4] = rule.NextState;
                turingMachineConfig.RulesCount++;
            }

            return turingMachineConfig;
        }
    }
}
