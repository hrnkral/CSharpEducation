using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            //var number = 10;
            //var number = 201;


            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("Number is 20");
            //}
            //else 
            //{
            //    Console.WriteLine("Number is not 10");
            //}
            //// Output: Number is not 10

            //// Single line if statement
            //var number2 = 10;
            //Console.WriteLine(number2 == 10 ? "Number2 is 10" : "Number2 is not 10");

            // Output: Number2 is 10

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}

            // Output: Number is not 10 or 20

            //var number = 201;
            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 101-200");
            //}
            //else if (number > 200 || number < 0)
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not between 0-300");
            //}

            // Output: Number is less than 0 or greater than 200

            var number = 10;


            if (number >= 0 && number <= 30) 
            {
                if (number>=20)
                {
                    Console.WriteLine("Number is greater than 20");
                }
                else if (number>10)
                {
                    Console.WriteLine("Number is greater than 10");
                }
                else
                {
                    Console.WriteLine("Number is between 0-10");
                }

            }



            Console.ReadKey();
        }
    }


}
