using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFizzBuzz()
        {
            string[] expected = {"1", "2", "Fizz", "4", "Buzz", 
                "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", 
                "13", "14", "Fizz Buzz", "16", "17", "Fizz", "19", "Buzz"};
            for (var i = 1; i < 20; i++)
            {
                var result = FizzBuzz.FizzBuzz.FizzBuzzEvaluate(i);
                if(expected[i-1] != result)
                    throw new Exception("Validation Failed");
            }
        }
    }
}