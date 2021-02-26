using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpPinGenerator.Tests
{   [TestClass]
    public class PinGeneration_ReturnsPIN
    {
        [TestMethod]
        public void PinGenerator_PinGeneration()
        {
            var pinClass = new PinHashTables();
            var randomGenerator = new PinGenerator();
            string comparisonDigitString = "0000";
            var result = randomGenerator.GeneratePinNumber(pinClass);

            Assert.AreEqual(comparisonDigitString.Length, result.Length);
        }
    }
}