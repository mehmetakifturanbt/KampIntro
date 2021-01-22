using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ali");

            Console.WriteLine(isimler.Length);

            isimler.Add("Irmak");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }


            //List<string> liste = new List<string>();
            //Console.WriteLine(liste.Count);

            Console.WriteLine("Hello World!");
        }
    }
}
