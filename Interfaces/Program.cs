using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer { Address = "Ankara", FirstName = "Engin", LastName = "Demiroğ", Id = 1 };
            //PersonManager personManager = new PersonManager();
            //Student student = new Student { Departmant = "Computer Science", FirstName = "Derin", LastName = "Demiroğ", Id = 2 };
            //Student student2 = new Student { Departmant = "Bilgisayar Mühendisliği", FirstName = "Harun", LastName = "Karal", Id = 3 };

            //personManager.Add(customer);
            //personManager.Add(student);
            //personManager.Add(student2);

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleCustomerDal());
            //customerManager.Add(new SqlServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
               
            }




            Console.ReadLine();

        }
    }

    interface IPerson
    {
         int Id { get; set; }
         string FirstName { get; set; }
         string LastName { get; set; }
         string Departmant { get; set; }



    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Kişinin Adı:{0}\nKişinin Soyadı:{1}\nKişinin id:{2}\nKişinin Departmanı:{3}",person.FirstName,person.LastName,person.Id,person.Departmant);
         
        }
    }
}
