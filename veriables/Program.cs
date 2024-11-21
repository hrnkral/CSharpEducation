using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typesAndVeriables
{
    class Program
    {
        static void Main(string[] args)
        {

            //Value Types
            decimal sayi5 = 10.923m;
            double sayi6 = 10.4;
            byte sayi1 = 255;
            short sayi2 = 32767;
            int sayi3 = 2147483647;
            long sayi4 = 9223372036854775807;
            bool dogruMu = true;
            char character = 'A';
            var sayi7 = 10;

            Console.WriteLine($"Sayı1 :{sayi1} ");
            Console.WriteLine($"Sayı2 :{sayi2} ");
            Console.WriteLine($"Sayı3 :{sayi3} ");
            Console.WriteLine($"Sayı4 :{sayi4} ");
            Console.WriteLine($"Character :{character}");
            Console.WriteLine("Sayı5 :{0}", sayi5);
            Console.WriteLine("Sayı6 :{0}", sayi6);
            Console.WriteLine("Sayı7 :{0}", sayi7);







            Console.ReadKey();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}

