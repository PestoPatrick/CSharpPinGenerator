using System;

namespace CSharpPinGenerator
{
    public class PinGenerator
    {
        private readonly Random _random = new Random();

        public string GenPin()
        {
         
            int pin = _random.Next(10000);
            string stringPin = pin.ToString();
            return stringPin;
        }
    }
}