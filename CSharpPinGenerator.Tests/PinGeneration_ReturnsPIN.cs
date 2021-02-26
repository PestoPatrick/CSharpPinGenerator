using System.Net.NetworkInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpPinGenerator.Tests
{   [TestClass]
    public class PinGeneration_ReturnsPIN
    {
        [TestMethod]
        public void PinGenerator_PinGeneration()
        {
            var randomGenerator = new CSharpPinGenerator.PinGenerator();
            string comparisonDigitString = "0000";
            string result = randomGenerator.Generate();

            Assert.AreEqual(comparisonDigitString.Length, result.Length);
        }
    }
}