using System;

namespace CSharpPinGenerator
{
    class Program
    {
        static void Main()
        {

            // Declare choice as a string variable to make the infinite loop true
            string choice = "1";

            // Instantiate the PinGenerator and 2 PinHashTables classes 
            PinGenerator pinGenerator = new PinGenerator();
            PinHashTables loadPinHashTables = new PinHashTables();
            PinHashTables validatedPin = new PinHashTables();

            // Load data and Validate Data functions applied to data
            loadPinHashTables.PinsAlreadyGenned = DataHandler.LoadData();
            validatedPin.PinsAlreadyGenned = DataHandler.ValidateData(loadPinHashTables);
            Console.WriteLine(validatedPin.PinsAlreadyGenned.Count);


            // Infinite menu loop giving user options.
            while (choice == "1")
            {
                
                Console.WriteLine("Type 1 to generate a PIN. 2 to Save and Exit");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    // Generates a new pin and displays it on the command line
                    string pinGenned = pinGenerator.GeneratePinNumber(validatedPin);
                    Console.WriteLine("Number: {0}", pinGenned);
                } else if (choice == "2")
                {
                    // Save the generated pins and set choice to exit the program
                    DataHandler.SaveData(validatedPin);
                    choice = "2";
                }
                else
                {
                    // Validate user input
                    Console.WriteLine("Please enter valid input");
                    choice = "1";
                }

            }
            

           
            
        }


        
    }
}
