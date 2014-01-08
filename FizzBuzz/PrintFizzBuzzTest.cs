using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    class PrintFizzBuzzTest
    {
        [Test] public void PrintFizzBuzz_PrintFizzForMod3()
        {
            StringWriter testString = new StringWriter();
            PrintFizzBuzz fizzBuzz = new PrintFizzBuzz(testString);
            fizzBuzz.GetOutputString(3, 3);
            string expectedValue = "Fizz\r\n";
            Assert.AreEqual(expectedValue, testString.ToString());
        }

        [Test]
        public void PrintFizzBuzz_PrintFizzForMod5()
        {
            StringWriter testString = new StringWriter();
            PrintFizzBuzz fizzBuzz = new PrintFizzBuzz(testString);
            fizzBuzz.GetOutputString(5, 5);
            string expectedValue = "Buzz\r\n";
            Assert.AreEqual(expectedValue, testString.ToString());
        }

        [Test]
        public void PrintFizzBuzz_PrintFizzForMod15()
        {
            StringWriter testString = new StringWriter();
            PrintFizzBuzz fizzBuzz = new PrintFizzBuzz(testString);
            fizzBuzz.GetOutputString(15, 15);
            string expectedValue = "FizzBuzz\r\n";
            Assert.AreEqual(expectedValue, testString.ToString());
        }

        [Test]
        public void PrintFizzBuzz_PrintFizzForNotMod3or5()
        {
            StringWriter testString = new StringWriter();
            PrintFizzBuzz fizzBuzz = new PrintFizzBuzz(testString);
            fizzBuzz.GetOutputString(11, 11);
            string expectedValue = "11\r\n";
            Assert.AreEqual(expectedValue, testString.ToString());
        }


        [Test]
        public void PrintFizzBuzz_PrintFizzForMultipleNumbers()
        {
            StringWriter testString = new StringWriter();
            PrintFizzBuzz fizzBuzz = new PrintFizzBuzz(testString);
            fizzBuzz.GetOutputString(10, 20);
            string expectedValue = "Buzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n16\r\n17\r\nFizz\r\n19\r\nBuzz\r\n";
            Assert.AreEqual(expectedValue, testString.ToString());
        }
    }
}
