using System;

namespace CSharpPinGenerator
{
    public class PinGenerator
    {
        private readonly Random _random = new Random();




        // Generate random number between 0 and 10000 and convert it to a string.
        private string GenRandomNumber()
        {
            int pin = _random.Next(10000);
            string stringPin = pin.ToString();
            return stringPin;
        }


        // This function will return and validate the pin number to be generated for the user
        public string GeneratePinNumber(PinHashTables pinClass)
        {
            // Retrieve random number as a string and add zeroes if below 1000
            string pin = GenRandomNumber();
            string pinPadded = pin.PadLeft(4, '0');

            // While the generated number is a forbidden pin number or one that has been generated already, generate a new number
            while (pinClass.PinsNotToGen.ContainsValue(pinPadded) || pinClass.PinsAlreadyGenned.ContainsValue(pinPadded))
            {
                pin = GenRandomNumber();
                pinPadded = pin.PadLeft(4, '0');
            }

            // if all possible numbers except forbidden numbers have been generated, clear the hashtable
            if (pinClass.PinsAlreadyGenned.Count == 9981)
            {
                    pinClass.PinsAlreadyGenned.Clear();
            }

            // Add new pin number to hashtable of previously generated numbers and return to output to display
            pinClass.PinsAlreadyGenned.Add(DateTimeOffset.Now.ToUnixTimeMilliseconds(), pinPadded);
            return pinPadded;
            
        }


    }
}