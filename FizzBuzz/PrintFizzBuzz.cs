using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class PrintFizzBuzz
    {
        private TextWriter streamToSaveString;

        public PrintFizzBuzz(TextWriter stringStream)
        {
            streamToSaveString = stringStream;
        }

        public void PopulateStream(List<TestAction> outputActions, int minNumber, int maxNumber)
        {
            GetOutputString(outputActions, minNumber, maxNumber);
        }

        public void GetOutputString(List<TestAction> outputActions, int minNumber, int maxNumber)
        {
            for (int i = minNumber; i <= maxNumber; i++)
            {
                string output = "";
                foreach (TestAction action in outputActions)
                {
                    if(action.TestCriteria(i) == true)
                    {
                        output += action.OutputOnTrue;
                    }
                }

                if (output == "")
                {
                    output += i.ToString();
                }
                streamToSaveString.WriteLine(output);
            }
        }

        public void GetOutputString(int minNumber, int maxNumber)
        {
            List<TestAction> outputs = new List<TestAction>();
            outputs.Add(new TestAction(x => x % 3 == 0, "Fizz"));
            outputs.Add(new TestAction(x => x % 5 == 0, "Buzz"));

            GetOutputString(outputs, minNumber, maxNumber);
        }
    }
}
