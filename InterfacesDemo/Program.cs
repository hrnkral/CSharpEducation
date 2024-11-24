using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] worker = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var item in worker)
            {
                item.Work();
            }

            IEat[] eat = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var item in eat)
            {
                item.Eat();
            }

            ISalary[] salary = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var item in salary)
            {
                item.GetSalary();
            }

            Console.ReadLine();

        }
    }

    interface IWorker 
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }

    interface IRobot 
    {
        void Work();
    }

    class Worker : IWorker, IEat, ISalary 
    {
        public void Work()
        {
            Console.WriteLine("Work");
        }
        public void Eat()
        {
            Console.WriteLine("Eat");
        }
        public void GetSalary()
        {
            Console.WriteLine("Get Salary");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Work");
        }
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Work()
        {
            Console.WriteLine("Work");
        }
        public void Eat()
        {
            Console.WriteLine("Eat");
        }
        public void GetSalary()
        {
            Console.WriteLine("Get Salary");
        }
    }
}
