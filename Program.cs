using System;

namespace DEGISKENLER
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;       // 1 byte
            sbyte sb = 5;     // 1 byte
                             
            short s = 5;      // 2 byte
            ushort us = 5;    // 2 byte
            
            int i = 2;        // 2 byte
            Int16 i16 = 2;    // 4 byte
            Int32 i32 = 2;    // 4 byte
            Int64 i64 = 2;    // 8 byte
            uint ui = 2;      // 4 byte

            long l = 4;       // 8 byte
            ulong ul = 4;     // 8 byte

            // Reel Sayılar
            float f = 5;      // 4 byte
            double d = 5;     // 8 byte
            decimal de = 5;   // 16 byte

            char c = '2';     // 2 byte
            string str = "Talha"; // Sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            // Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 2;
            object o3 = 5.8;
            object o4 = "Talha";

            string st = string.Empty;
            st = "Talha Yıldız";
            string ad = "Talha";
            string soyad = "Yıldız";
            string tamIsım = ad + " " + soyad;

            
            int integer1 = 5;
            int integer2 = 8;
            int integer3 = integer1 * integer2;
            
            bool bool1 = 10>2;
            // System.Console.WriteLine(bool1); // Çıktısı True

            string st58 = "58";
            int int58 = 58;
            string yeniDeğer = st58 + int58.ToString();
            // Console.WriteLine(yeniDeğer); // Çıktısı 5858

            int int60 = int58 + Convert.ToInt32(st58);
            // Console.WriteLine(int60); // Çıktısı 116

            int int62 = int58 + int.Parse(st58);

            // datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            System.Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            System.Console.WriteLine(datetime2);

            // saat
            string hour = DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(hour);

            Console.ReadLine();
        }
    }
}
