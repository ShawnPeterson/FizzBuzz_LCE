using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FizzBuzz;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFizzBuzz fizzBuzzObject = new PrintFizzBuzz(Console.Out);

            List<TestAction> outputs = new List<TestAction>();
            outputs.Add(new TestAction(x => (x + 3) % 2 == 0, "Fizz"));
            outputs.Add(new TestAction(x => (x + 5) % 3 == 0, "Buzz"));

            fizzBuzzObject.GetOutputString(outputs, 1, 100);
            
            Console.ReadLine();
        }
    }
}
