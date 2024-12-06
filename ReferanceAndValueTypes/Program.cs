using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceAndValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;

            sayi2 = 65;

            Console.WriteLine("1.Sayı:{0}",sayi1);

            string[] cities1 = { "Ankara", "Adana", "Afyon" };
            string[] cities2 = { "Bursa", "Bolu", "Balıkesir" };

            cities1 = cities2;

            cities1[0] = "İstanbul";

            Console.WriteLine(cities1[0]);

            Console.ReadKey();
        }
    }
}
