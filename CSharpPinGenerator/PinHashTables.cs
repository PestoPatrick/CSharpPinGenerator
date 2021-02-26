using System.Collections;

namespace CSharpPinGenerator
{
    public class PinHashTables
    {
        public Hashtable PinsNotToGen;
        public Hashtable PinsAlreadyGenned { get; set; }

        public PinHashTables()
        {
            PinsNotToGen = new Hashtable
            {
                {1, "1234"},
                {2, "1111"},
                {3, "0000"},
                {4, "1212"},
                {5, "7777"},
                {6, "1004"},
                {7, "2000"},
                {8, "4444"},
                {9, "2222"},
                {10, "6969"},
                {11, "9999"},
                {12, "3333"},
                {13, "5555"},
                {14, "6666"},
                {15, "1122"},
                {16, "1313"},
                {17, "8888"},
                {18, "4321"},
                {19, "2001"},
                {20, "1010"},

            };

            PinsAlreadyGenned = new Hashtable();
        }


    }
}