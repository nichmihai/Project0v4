using System;
using System.Collections.Generic;
using System.Linq;

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
            
            this.CustomerID = r.Next();
            Console.Write("First name: ");
            this.FirstName = Console.ReadLine();
            Console.Write("Last name: ");
            this.LastName = Console.ReadLine();
            Console.WriteLine($"Customer ID: {this.CustomerID} | First name: {this.FirstName} | Last name: {this.LastName}");

        }

        public void DisplayAccountList()
        {
            foreach (var acc in accounts)
            {
                if (acc is CheckingAccount)
                {
                    ((CheckingAccount)acc).CheckingInfo();
                }

                if (acc is BusinessAccount)
                {
                    ((BusinessAccount)acc).BusinessInfo();
                }

                if (acc is TermDeposit)
                {
                    ((TermDeposit)acc).TempDepInfo();
                }
            }

            foreach(var loan in loans)
            {
                if (loans.Count() != 0)
                {
                    Console.WriteLine(loan);
                }
            }
        }
    }
}
