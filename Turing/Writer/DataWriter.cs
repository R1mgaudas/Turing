using System;
using Turing.Interfaces;

namespace TuringMachine.Writer
{
    internal class DataWriter : IDataWriter
    {
        public void WriteData(string processedData)
        {
            Console.WriteLine(processedData);
        }
    }
}
