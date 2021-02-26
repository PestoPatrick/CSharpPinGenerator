using System;
using System.Collections;
using System.IO;
using System.Text.Json;

namespace CSharpPinGenerator
{
    public static class DataHandler
    {
        // Serialize and write pin numbers to a JSON document titled Pins.json. All the functions use this same document.
        public static void SaveData(PinHashTables pinClass)
        {

            string pinsFile = @"./Pins.json";

            var generatedPinsJSON = JsonSerializer.Serialize(pinClass.PinsAlreadyGenned);
            File.WriteAllText(pinsFile,generatedPinsJSON);
            
            Console.WriteLine("Pins have been saved");

        }


        // Load pin numbers from json storage file called Pins.json and deserialize them into a Hashtable and return it. 
        public static Hashtable LoadData()
        {
            string pinsFile = @"./Pins.json";

            CheckFileExists();

            var jsonString = File.ReadAllText(pinsFile);

            var generatedPinsJSON = JsonSerializer.Deserialize<Hashtable>(jsonString);

            return generatedPinsJSON;
            

        }



        // Function to check if the Pin storage file (A JSON document) exists. If not it populates a new one with a dummy pin number entry.
        public static void CheckFileExists()
        {
            string pinFile = @"./Pins.json";
            
            if (File.Exists(pinFile)){ return;}
            var nullJsonTable = new Hashtable
            {
                {1,"0000"},
            };
            string nullJson = JsonSerializer.Serialize(nullJsonTable);
            File.WriteAllText(pinFile,nullJson);

        }

        // Validate if the pin numbers document has placeholder number in it and if so clear the hashtable in the existingPins parameter and return to method caller.
        public static Hashtable ValidateData(PinHashTables existingPins)
        {
            if (existingPins.PinsAlreadyGenned.ContainsValue("0000"))
            {
                existingPins.PinsAlreadyGenned.Clear();
                return existingPins.PinsAlreadyGenned;

            }
            else
            {
                return existingPins.PinsAlreadyGenned;
            }
        }
    }
}