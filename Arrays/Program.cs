using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[5];
            students[0] = "Harun";
            students[1] = "Asya";
            students[2] = "Salih";
            students[3] = "Hüseyin";
            students[4] = "Ahmet";

            string[] students2 = new string[5] { "Hasan", "Asya", "Merve", "Said", "Ahmet" };

            string[] students3 = { "Zeliha", "Asya", "Merve", "Said", "Hasan" };
            /*
            foreach (var student in students3)
            {
                Console.WriteLine(student);
            }
            */
            string[,] sehirler = new string[4, 2]
            {

                {"Ankara", "İstanbul"},
                {"İzmir", "Bursa"},
                {"Adana", "Antalya"},
                {"Rize", "Trabzon" }
            };

            var sayac = 1;


            //foreach (var sehir in sehirler)
            //{
            //    Console.WriteLine($"{sayac}.Şehir :{sehir}");
            //    sayac++;
            //}

            for (int i = 0; i <= sehirler.GetUpperBound(0); i++) 
            {
                Console.WriteLine($"*****{sayac}.Bölge*****");
                sayac++;

                for (int j = 0; j <= sehirler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(sehirler[i, j]);
                }

                

            }

            Console.ReadKey();

        }
    }
}
