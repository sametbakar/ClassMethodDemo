using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi!");
            Console.WriteLine(customer.FirstName + " " + customer.SecondName);
            Console.WriteLine("-----------------------");
            customers.Add(customer);
        }
        public void List()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.SecondName);
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.SecondName + " adlı müşteri silindi!");
            customers.Remove(customer);
        }
    }
}