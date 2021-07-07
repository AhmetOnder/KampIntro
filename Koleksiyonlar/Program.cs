using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Ahmet","Mehmet","Ali","Veli"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];//Burada yeni referans adresi tanımlandığından
            //                        //yukarıdaki tanımlama geçersiz oldu
            //isimler[4] = "Harun";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            //Yukarıdaki problem burada olmaz. Bu sonradan bu problemleri çözmek için yazılmış koleksiyondur.
            //Biz kendi koleksiyonumuzu nasıl yazarız ?
            List<string> isimler2 = new List<string> { "Ahmet", "Mehmet", "Ali", "Veli" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Harun");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
