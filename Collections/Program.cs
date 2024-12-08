using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            //List();
            Dictionary<string,string> sözlük = new Dictionary<string, string>();
            sözlük.Add("id", "numara");
            sözlük.Add("name", "isim");

            //Console.WriteLine(sözlük["key"]);
            //Console.WriteLine(sözlük["çay"]);

            foreach (var item in sözlük)
            {
                Console.WriteLine("Anahtar:{0}\nDeğer:{1}",item.Key,item.Value);
                
            }

            Console.WriteLine(sözlük.ContainsKey("id"));
            Console.WriteLine(sözlük.ContainsValue("soyisim"));



            Console.ReadKey();
        }

        private static void List()
        {
            //List<string> cities = new List<string>();
            //cities.Add("Ankara");
            //cities.Add("Adana");

            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 10, FirstName = "Harun", Surname = "Karal" });
            //customers.Add(new Customer { Id = 20, FirstName = "Ali", Surname = "Veli" });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 10, FirstName = "Harun", Surname = "Karal" },
                new Customer { Id = 20, FirstName = "Ali", Surname = "Veli" }
            };

            var count = customers.Count;
            var customer2 = new Customer
            {
                Id = 30,
                FirstName = "Ayşe",
                Surname = "Karal"

            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer { Id = 40, FirstName = "Asya", Surname = "Karal" },
                new Customer { Id = 50, FirstName = "Zeynep", Surname = "Karal" }
            });

            //customers.Clear();

            //Console.WriteLine(customers.Contains(customer2));

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index:{0}", index);

            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("Index2:{0}", index2);

            customers.Insert(0, customer2);

            customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "Harun");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Şanlıurfa");
            cities.Add("Mardin");
            cities.Add('A');
            cities.Add(63);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }

}
