using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class TestAction
    {
        public Func<int, bool> TestCriteria { get; set; }
        public string OutputOnTrue { get; set; } 
       
        public TestAction (Func<int, bool> testCriteria, string outputOnTrue )
        {
            TestCriteria = testCriteria;
            OutputOnTrue = outputOnTrue;
        }
    }
}
