using System;
namespace Project0
{
    public class BusinessAccount : Account, IAccount
    {
        Random r = new Random();
        public int BusinessID { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal _interest = 0.039M;

        public BusinessAccount()
        {
        }


        public void CreateAccount()
        {
            
            this.BusinessID = r.Next();
            Console.WriteLine($"Business ID: {this.BusinessID}");

        }

        public void MakeDeposit()
        {
            Console.Write("\nAmount you want to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (this.AccountBalance < 0)
            {
                this.AccountBalance += amount - (100 * _interest);
            }
            else
            { 
                this.AccountBalance += amount;
            }

            Console.WriteLine($"Business balance: ${this.AccountBalance}");
        }

        public void MakeWithdrawal()
        {
            Console.Write("\nAmount you want to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (this.AccountBalance - amount < -100)
            {
                Console.WriteLine("You cant go below -100");
            }
            else
                this.AccountBalance -= amount;

            Console.WriteLine($"Business balance: ${this.AccountBalance}");
        }

        public void BusinessInfo()
        {
            Console.WriteLine($"Business ID: {this.BusinessID} | Business balance: ${this.AccountBalance}");
        }
    }
}
