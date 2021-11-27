using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turing.Interfaces;
using Turing.Misc;
using Turing.Reader;
using Turing.Validator;
using TuringMachine.Writer;

namespace Turing
{
    class Program
    {
        static void Main(string[] args)
        {
            if (ArgumentValidator.Validate(args))  //Single Responsibility Principle(SRP)
            {
                TuringManager turingManager = new TuringManager(new DataWriter(), new TuringCPU());
                turingManager.Manage(args);
            }

            //Single Responsibility Principle(SRP) - every class, or similar structure, in your code should have only one job to do
            //Open closed Principle(OSP) - A software module/class is open for extension and closed for modification
            //Liskov substitution Principle(LSP) - you should be able to use any derived class instead of a parent class and have it behave in the same manner without modification
            //Interface Segregation Principle(ISP) - clients should not be forced to implement interfaces they don't use
            //Dependency Inversion Principle(DIP) - high-level modules/classes should not depend on low-level modules/classes
        }
    }
}
