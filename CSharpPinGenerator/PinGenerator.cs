using System;
using System.Net.NetworkInformation;

namespace CSharpPinGenerator
{
    public class PinGenerator
    {
        private readonly Random _random = new Random();

        
        
        

        private string GenRandomPinNumber()
        {
         
            int pin = _random.Next(10000);
            string stringPin = pin.ToString();
            return stringPin;
        }

        public string Generate(PinHashTables pinClass)
        {
            string pin = GenRandomPinNumber();
            string pinPadded = pin.PadLeft(4, '0');
            while (pinClass.PinsNotToGen.ContainsValue(pinPadded) || pinClass.PinsAlreadyGenned.ContainsValue(pinPadded))
            {
                pin = GenRandomPinNumber();
                pinPadded = pin.PadLeft(4, '0');
            }

            if (Int32.Parse(pinPadded) < 1000)
            {
                pinClass.PinsAlreadyGenned.Add(DateTimeOffset.Now.ToUnixTimeMilliseconds(), pinPadded);
                return pinPadded;


            }
            else
            {
                if (pinClass.PinsAlreadyGenned.Count == 9980)
                {
                    pinClass.PinsAlreadyGenned.Clear();
                }

                pinClass.PinsAlreadyGenned.Add(DateTimeOffset.Now.ToUnixTimeMilliseconds(), pinPadded);
                return pinPadded;
            }
        }


    }
}