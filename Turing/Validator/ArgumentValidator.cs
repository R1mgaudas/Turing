using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing.Validator
{
    static class ArgumentValidator
    {
        public static bool Validate(string[] args)
        {
            if (args.Length != 0) return true;
            Console.WriteLine("No file!");
            return false;
        }
    }
}
