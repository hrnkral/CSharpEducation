using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Harun";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            bool result3 = sentence.EndsWith("n");
            bool result4 = sentence.StartsWith("My");
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3);
            var result10 = sentence.Substring(11,5);
            var result11 = sentence.ToLower();
            var result12 = sentence.ToUpper();
            var result13 = sentence.Replace(" ", "-");
            var result14 = sentence.Remove(2, 5);
            var result15 = sentence.Remove(2);
            var result16 = sentence.Split(' ');




            Console.WriteLine(result);      // 16
            Console.WriteLine(result2);     // My name is Harun
            Console.WriteLine(result3);     // True
            Console.WriteLine(result4);     // True
            Console.WriteLine(result5);     // 3
            Console.WriteLine(result6);     // 2
            Console.WriteLine(result7);     // 10
            Console.WriteLine(result8);     // Hello, My name is Harun
            Console.WriteLine(result9);     // name is Harun
            Console.WriteLine(result10);    // Harun
            Console.WriteLine(result11);    // my name is harun
            Console.WriteLine(result12);    // MY NAME IS HARUN
            Console.WriteLine(result13);    // My-name-is-Harun
            Console.WriteLine(result14);    // My is Harun
            Console.WriteLine(result15);    // My
            Console.WriteLine(result16[3]); // Harun

            Console.ReadKey();
        }

        private static void examples()
        {
            string name = "Harun";

            Console.WriteLine(name);
            Console.WriteLine(name[0]);
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

            string name2 = "Merve";

            Console.WriteLine("{0} {1}", name, name2);
        }
    }
}
