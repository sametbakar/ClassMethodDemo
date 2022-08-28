using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ali";
            customer1.SecondName = "Korkmaz";

            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.FirstName = "Ayşe";
            customer2.SecondName = "Gül";

            Customer customer3 = new Customer();
            customer3.Id = 2;
            customer3.FirstName = "Ahmet";
            customer3.SecondName = "Seven";



            CustomerManager manager = new CustomerManager();

            manager.Add(customer1);
            manager.Add(customer2);
            manager.Add(customer3);

            manager.List();
            Console.WriteLine("-----------------------");
            manager.Delete(customer2);
            Console.WriteLine("-----------------------");
            manager.List();
        }
    }
}