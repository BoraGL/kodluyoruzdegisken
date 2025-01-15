using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args){

            Console.WriteLine("");

            byte b = 0;
            sbyte s = 3;

            short c = 4;
            ushort d = 5; 
            
            Int16 i16 ;
            int i = 6;
            Int32 i32 = 2;
            Int64 i64 = 2;

            uint ui = 2; 
            long l = 0;

            float f = 0;
            double z = 0;  
            decimal de = 0;


            char ch = '2';
            string v = "aaa";

            bool b1 = true;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "2";

            string str1 = string.Empty;

            string datetime = DateTime.Now.ToString("dd/MM//yyyy");

            string hour = DateTime.Now.ToString("HH:mm");

            Console.WriteLine(hour);
        }

    }

}