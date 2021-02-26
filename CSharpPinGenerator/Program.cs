using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace CSharpPinGenerator
{
    class Program
    {
        static void Main()
        {

            string choice = "1";
            PinGenerator pinGenerator = new PinGenerator();
            PinClass loadPinClass = new PinClass();
            PinClass ValidatedpinClass = new PinClass();
            loadPinClass.PinsAlreadyGenned = DataHandler.LoadData();
            ValidatedpinClass.PinsAlreadyGenned = DataHandler.ValidateData(loadPinClass);
            Console.WriteLine(ValidatedpinClass.PinsAlreadyGenned.Count);

            while (choice == "1")
            {
                
                Console.WriteLine("Type 1 to generate a PIN. 2 to Exit");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    string pinGenned = pinGenerator.Generate(ValidatedpinClass);
                    Console.WriteLine("Number: {0}", pinGenned);
                } else if (choice == "2")
                {
                    DataHandler.SaveData(ValidatedpinClass);
                    choice = "2";


                } else if (choice == "3")
                {
                    

                    foreach (DictionaryEntry item in ValidatedpinClass.PinsAlreadyGenned)
                    {
                        Console.WriteLine("{0}, {1}", item.Key, item.Value);
                    }
                    choice = "1";
                }
                
                else
                {
                    Console.WriteLine("Please enter valid input");
                    choice = "1";
                }

            }
            

           
            
        }


        
    }
}
