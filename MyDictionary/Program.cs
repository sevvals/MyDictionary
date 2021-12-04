using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(15, "dsdadsasd");
            ogrenciler.Add(18, "epwepweopwe");
            ogrenciler.Yazdır();
        }
    }
}
