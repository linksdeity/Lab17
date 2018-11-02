using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrandCircusLab17;


namespace Lab17Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PrintPrimeNumber_PrintsOutCorrectPrimeNumber_true()
        {

            PrintPrimeNumber numberPrinter = new PrintPrimeNumber();

            numberPrinter.UserInput = 10;

            int output = numberPrinter.Output();

            Assert.AreEqual(29 , output);

        }
    }
}
