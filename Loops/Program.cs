using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            if (IsPrimeNumber(15))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadKey();
        }

        private static bool IsPrimeNumber(int number)
        {
            if (number <=1)
            {
                return false;
            }
            bool result = true;
            for (int i = 2; i < number-1; i++) 
            {
                if (number % 2 == 0)
                {
                    result = false;
                    break;
                }

            }
            return result;

        }

        public static void foreachLoop()
        {
            string[] names = { "Harun", "Merve", "Asya", "Said" };

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void doWhileLoop()
        {
            int a = 10;
            do
            {
                Console.WriteLine(a);
                a--;
            } while (a > 0);
        }

        public static void whileLoop()
        {
           

            int number = 100;

            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        public static void forLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

            }


            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
