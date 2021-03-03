using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpPinGenerator.Tests
{
    [TestClass]
    public class GeneratePins_100000Pins_RestartsAfter9980_EndWith21
    {
        [TestMethod]
        public void PinGenerator_PinGeneration()
        {
            var pinClass = new PinHashTables();
            var randomGenerator = new PinGenerator();
            for (int i = 0; i < 10000; i++)
            {
                randomGenerator.GeneratePinNumber(pinClass);

            }


            Assert.AreEqual(20, pinClass.PinsAlreadyGenned.Count);
            
        }
    }
}
