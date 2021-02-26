using System;
using System.ComponentModel.Design;

namespace CSharpPinGenerator
{
    class Program
    {
        static void Main()
        {

            string choice = "1";
            PinGenerator pinGenerator = new PinGenerator();

            while (choice == "1")
            {
                
                Console.WriteLine("Type 1 to generate a PIN. 2 to Exit");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    string pinGenned = pinGenerator.Generate();
                    Console.WriteLine("Number: {0}", pinGenned);
                } else if (choice == "2")
                {
                    choice = "2";
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
