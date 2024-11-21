using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //int result = Add2(13, 25);
            //Console.WriteLine(result);

            //int result2 = cikart(13, 25);
            //Console.WriteLine(result2);

            //int number1 = 10;
            //int number2 = 70;
            ////int result3 = add3(ref number1, number2);
            //int result4 = add4(out number1, number2);

            //Console.WriteLine(result4);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(3,6));
            Console.WriteLine(Multiply(3, 6, 5));
            Console.WriteLine(Add4(1,2,3,4, 5, 6, 7, 8, 9));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Add method");
        }

        static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }

        static int cikart(int number1, int number2)
        {
            return number1 - number2;
        }

        static int add3(ref int number1, int number2)
        {
            number1 = 60;
            return number1 + number2;
        } 
        static int add4(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
