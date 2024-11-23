using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Harun";
            customer.LastName = "Karal";
            customer.City = "Şanlıurfa";

            Customer customer2 = new Customer
            {
               Id = 2, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara"
            };

            Console.WriteLine(customer.FirstName);


            Console.ReadKey();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer added!");
        }

        public void Update() 
        {
            Console.WriteLine("Customer updated!"); 
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product added!");
        }

        public void Update()
        {
            Console.WriteLine("Product updated!");
        }
    }
}
