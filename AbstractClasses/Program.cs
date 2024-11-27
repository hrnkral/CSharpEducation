using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();
            MySql mySql = new MySql();
            mySql.Add();
            mySql.Delete();
            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public  void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class MySql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by MySql");
        }
    }


}
