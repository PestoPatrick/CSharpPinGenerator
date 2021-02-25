using System;
using System.ComponentModel.Design;

namespace CSharpPinGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pinClass = new PinClass();
            var pinGenerator = new PinGenerator();

            // for when it needs to run once, use the date offset as the key value in the hashtable 
            for (long i = 0; i < 9980; i++)
            {
                string pin = pinGenerator.GenPin();
                string pinPadded = pin.PadLeft(4, '0');
                while (pinClass.pinsNotToGen.ContainsValue(pinPadded) || pinClass.PinsAlreadyGenned.ContainsValue(pinPadded))
                {
                    pin = pinGenerator.GenPin();
                    pinPadded = pin.PadLeft(4, '0');
                }

                if (Int32.Parse(pinPadded) < 1000)
                {
                    pinClass.PinsAlreadyGenned.Add(i, pinPadded);
                    Console.WriteLine("Number: {0}",pinPadded);
                }
                else
                {
                    pinClass.PinsAlreadyGenned.Add(i,pinPadded);
                    Console.WriteLine("Number: {0}",pinPadded);
                }
            }
            Console.WriteLine(pinClass.PinsAlreadyGenned.Count);
        }
    }
}
