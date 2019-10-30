using System;
using System.Collections.Generic;

namespace Project0
{
    public class Customer
    {
        Random r = new Random();
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Account> accounts = new List<Account>();
        public List<Loan> loans = new List<Loan>();

        public Customer()
        {
        }

        public void CreateCustomer()
        {
            var cust = new Customer();
            cust.CustomerID = r.Next();
            Console.Write("First name: ");
            cust.FirstName = Console.ReadLine();
            Console.Write("Last name: ");
            cust.LastName = Console.ReadLine();
            Console.WriteLine($"Customer ID: {cust.CustomerID} | First name: {cust.FirstName} | Last name: {cust.LastName}");

        }
    }
}
