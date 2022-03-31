using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Degiskenler");

            byte b1 =byte.MaxValue; //1 byte +
            byte b2 =byte.MinValue;

            Console.WriteLine("");
            Console.WriteLine("byte MinValue: "+b2+" byte MaxValue: "+b1);

            sbyte sb1 =sbyte.MaxValue; //1 byte
            sbyte sb2 =sbyte.MinValue;

            Console.WriteLine("");
            Console.WriteLine("sbyte MinValue: "+sb2+" sbyte MaxValue: "+sb1);

            short s1 =short.MaxValue; //2 byte
            short s2 =short.MinValue;

            Console.WriteLine("");
            Console.WriteLine("short MinValue: "+s2+" short MaxValue: "+s1);

            ushort us1 =ushort.MaxValue; //2 byte +
            ushort us2 =ushort.MinValue;

            Console.WriteLine("");
            Console.WriteLine("ushort MinValue: "+us2+" ushort MaxValue: "+us1);

            Int16 i161 =Int16.MaxValue; //2 byte
            Int16 i162 =Int16.MinValue;
            
            Console.WriteLine("");
            Console.WriteLine("Int16 MinValue: "+i162+" Int16 MaxValue: "+i161);

            int i1 =int.MaxValue; //4 byte
            int i2 =int.MinValue;
            
            Console.WriteLine("");
            Console.WriteLine("int MinValue: "+i2+" int MaxValue: "+i1);

            uint ui1 =uint.MaxValue; //4 byte +
            uint ui2 =uint.MinValue;
            
            Console.WriteLine("");
            Console.WriteLine("uint MinValue: "+ui2+" uint MaxValue: "+ui1);

            Int32 i321 =Int32.MaxValue; //4 byte
            Int32 i322 =Int32.MinValue;
            
            Console.WriteLine("");
            Console.WriteLine("Int32 MinValue: "+i322+" Int32 MaxValue: "+i321);

            Int64 i641 =Int64.MaxValue; //8 byte
            Int64 i642 =Int64.MinValue;
            
            Console.WriteLine("");
            Console.WriteLine("Int64 MinValue: "+i642+" Int64 MaxValue: "+i641);

            long l1 =long.MaxValue; //8 byte
            long l2 =long.MinValue;
            
            Console.WriteLine("");
            Console.WriteLine("long MinValue: "+l2+" long MaxValue: "+l1);

            ulong ul1 =ulong.MaxValue; //8 byte +
            ulong ul2 =ulong.MinValue;
            
            Console.WriteLine("");
            Console.WriteLine("ulong MinValue: "+ul2+" ulong MaxValue: "+ul1);

            float f1 =float.MaxValue; //4 byte R
            float f2 =float.MinValue;
            
            Console.WriteLine("");
            Console.WriteLine("float MinValue: "+f2+" float MaxValue: "+f1);

            double d1 =double.MaxValue; //8 byte R
            double d2 =double.MinValue;
            
            Console.WriteLine("");
            Console.WriteLine("double MinValue: "+d2+" double MaxValue: "+d1);

            decimal dc1 =decimal.MaxValue; //16 byte R
            decimal dc2 =decimal.MinValue;
            
            Console.WriteLine("");
            Console.WriteLine("decimal MinValue: "+dc2+" decimal MaxValue: "+dc1);

            char c1 =char.MaxValue; //2 byte S
            char c2 =char.MinValue;
            
            Console.WriteLine("");
            Console.WriteLine("char MinValue: "+c2+" char MaxValue: "+c1);

            string st1 =" "; //sınırsız
            string st2 =" ";

            bool bo1 = true;
            bool bo2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine("");
            Console.WriteLine("Bugünün Tarihi: "+dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 3;
            object o4 = 3.14;

            string str3 = string.Empty;
            string st3  = st1 + st2;


            bool b3 = 10<2;

            int i3 = i1 + i2;

            //Değişken dönüşümleri

            string st20 ="20";
            int int20 = 20;
            string Strint = st20 + int20.ToString();
            int i21 = int20 + Convert.ToInt32(st20);
            int i22 = int20 + int.Parse(st20);


            string dateTime1 = DateTime.Now.ToString("dd.MM.yyyy");

            Console.WriteLine("");
            Console.WriteLine("Yeni Tarih Formatı 1: "+dateTime1);


            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");

            Console.WriteLine("");
            Console.WriteLine("Yeni Tarih Formatı 2: "+dateTime2);


            string hour = DateTime.Now.ToString("HH:mm");

            Console.WriteLine("");
            Console.WriteLine("Saat Formatı: "+hour);









            



            

            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
