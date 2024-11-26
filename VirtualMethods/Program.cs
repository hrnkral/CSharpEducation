using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Save();
            sqlServer.Update();
            MySql mySql = new MySql();
            mySql.Save();
            mySql.Update();
            Console.ReadLine();

        }
    }

    class Database
    {
        public virtual void Save()
        {
            Console.WriteLine("Database saved");
        }

        public virtual void Update()
        {
            Console.WriteLine("Database updated");
        }
    }

    class SqlServer : Database
    {
        override public void Save()
        {
            //base.Save();
            Console.WriteLine("SqlServer saved");
        }

    }

    class MySql : Database
    {
        

    }


}
