using System;
using System.Collections.Generic;
using CalculatorChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTests
{
    [TestClass]
    public class CalculatorInputTests
    {
        List<string> userInput = new List<string>();

        [TestInitialize]
        public void testInit()
        {
            userInput = new List<string>()
            {
                "20",
                "1,5000",
                "4,-3",
                "5,tytyt",
                "1,2,3,4,5,6,7,8,9,10,11,12",
                "1\\n2,3",
                "-500,-501",
                "2,1001,6",
                "//#\\n2#5",
                "//,\\n2,ff,100",
                "//[***]\\n11***22***33",
                "//[*][!!][r9r]\\n11r9r22*hh*33!!44"
            };

        }

        [TestMethod]
        public void Step1_ValidInputLength()
        {
            var stringCalculator = new StringProcessor();

            Assert.AreEqual(20, stringCalculator.getSum(userInput[0]));
            Assert.AreEqual(5001, stringCalculator.getSum(userInput[1]));
            Assert.AreEqual(1, stringCalculator.getSum(userInput[2]));
            Assert.AreEqual(5, stringCalculator.getSum(userInput[3]));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Step1_InvalidInputLength()
        {
            var stringCalculator = new StringProcessor();
            var result = stringCalculator.getSum(userInput[4]);
        }

        [TestMethod]
        public void Step2_InputContraintRemoved()
        {
            var stringCalculator = new StringProcessor2();

            Assert.AreEqual(78, stringCalculator.getSum(userInput[4]));
        }

        [TestMethod]
        public void Step3_NewLineCharDelimiter()
        {
            var stringCalculator = new StringProcessor3();

            Assert.AreEqual(6, stringCalculator.getSum(userInput[5]));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Negative numbers are not allowed: -500,-501")]
        public void Step4_DenyNegativeNumbers()
        {
            var stringCalculator = new StringProcessor4();

            Assert.AreEqual(6, stringCalculator.getSum(userInput[6]));
        }

        [TestMethod]
        public void Step5_InvalidOver1000()
        {
            var stringCalculator = new StringProcessor5();

            Assert.AreEqual(8, stringCalculator.getSum(userInput[7]));
        }

        [TestMethod]
        public void Step6_SupprtSingleCustomDelimiter()
        {
            var stringCalculator = new StringProcessor6();

            Assert.AreEqual(7, stringCalculator.getSum(userInput[8]));
            Assert.AreEqual(102, stringCalculator.getSum(userInput[9]));
        }

        [TestMethod]
        public void Step7_SupprtCustomDelimiterAnyLength()
        {
            var stringCalculator = new StringProcessor7();
            Assert.AreEqual(66, stringCalculator.getSum(userInput[10]));
        }

        [TestMethod]
        public void Step8_SupprtCustomDelimiterAnyLength()
        {
            var stringCalculator = new StringProcessor8();
            Assert.AreEqual(110, stringCalculator.getSum(userInput[11]));
        }



    }


}
