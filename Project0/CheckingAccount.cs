using System;
namespace Project0
{
    public class CheckingAccount : Account, IAccount
    {
        Random r = new Random();
        public int CheckingID { get; set; }
        public decimal AccountBalance { get; set; }

        public CheckingAccount()
        {
            
        }

        public void CreateAccount()
        {
            var checking = new CheckingAccount();

            checking.CheckingID = r.Next();
            Console.WriteLine($"CheckingID: {checking.CheckingID}");

        }

        public void MakeDeposit()
        {
            Console.Write("\nAmount you want to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            this.AccountBalance += amount;
            Console.WriteLine($"Checking balance: ${this.AccountBalance}");
        }

        public void MakeWithdrawal()
        {
            Console.Write("\nAmount you want to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (amount > this.AccountBalance)
                Console.WriteLine("Not enough resources!");
            else
                this.AccountBalance -= amount;

            Console.WriteLine($"Checking balance: ${this.AccountBalance}");
        }

        public void CheckingInfo()
        {
            Console.WriteLine($"Checking ID: {this.CheckingID} | Checking balance: ${this.AccountBalance}");
        }
    }
}
