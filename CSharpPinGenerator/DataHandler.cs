using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.IO.Enumeration;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSharpPinGenerator
{
    public static class DataHandler
    {
        
        public static void SaveData(PinHashTables pinClass)
        {

            string pinsFile = @"./Pins.json";

            var generatedPinsJSON = JsonSerializer.Serialize(pinClass.PinsAlreadyGenned);
            File.WriteAllText(pinsFile,generatedPinsJSON);
            
            Console.WriteLine("Pins have been saved");

        }

        public static Hashtable LoadData()
        {
            string pinsFile = @"./Pins.json";

            CheckFileExists();

            var jsonString = File.ReadAllText(pinsFile);

            var generatedPinsJSON = JsonSerializer.Deserialize<Hashtable>(jsonString);

            return generatedPinsJSON;


        }

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