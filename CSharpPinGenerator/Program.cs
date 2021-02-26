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
            PinClass pinClass = new PinClass();
            pinClass.PinsAlreadyGenned = DataHandler.LoadData().Result;
            Console.WriteLine(pinClass.PinsAlreadyGenned.Count);

            while (choice == "1")
            {
                
                Console.WriteLine("Type 1 to generate a PIN. 2 to Exit");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    string pinGenned = pinGenerator.Generate(pinClass);
                    Console.WriteLine("Number: {0}", pinGenned);
                } else if (choice == "2")
                {
                    DataHandler.SaveData(pinClass);
                    choice = "2";


                } else if (choice == "3")
                {
                    

                    foreach (DictionaryEntry item in pinClass.PinsAlreadyGenned)
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
