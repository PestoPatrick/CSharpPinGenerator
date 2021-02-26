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
        
        public static void SaveData(PinClass pinClass)
        {

            string pinsFile = @"./Pins.json";

            var generatedPinsJSON = JsonSerializer.Serialize(pinClass.PinsAlreadyGenned);
            File.WriteAllText(pinsFile,generatedPinsJSON);
            
            Console.WriteLine("Pins have been saved");

        }

        public static async Task<Hashtable> LoadData()
        {
            string pinsFile = @"./Pins.json";

            using FileStream openStream = File.OpenRead(pinsFile);
            var generatedPinsJSON = await JsonSerializer.DeserializeAsync<Hashtable>(openStream);

            return generatedPinsJSON;


        }
    }
}