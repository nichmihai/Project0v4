using System;
namespace Project0
{
    public class TermDeposit : Account
    {
        public int TermDepositID { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime _time;
        private decimal interest = 3.9M;


        public TermDeposit()
        {
        }

        public void CreateTermDeposit()
        {
            Random r = new Random();
            var termDeposit = new TermDeposit();
            termDeposit.TermDepositID = r.Next();
            Console.WriteLine("Please insert the amount you want to deposit?");

            decimal amount = decimal.Parse(Console.ReadLine());

            if (amount < 0)
            {
                Console.WriteLine("We dont accept negative amount!");
            }
            else
            {
                termDeposit.AccountBalance += amount;
                termDeposit._time = DateTime.Now;
                Console.WriteLine($"Temporary Deposit ID: {termDeposit.TermDepositID} | Amount on balance: ${termDeposit.AccountBalance} | Time of depositing: {termDeposit._time}");
            }
        }

        public void ExtractMoney()
        {
            DateTime tempTime = DateTime.Now;
            Console.WriteLine(tempTime);
            Console.WriteLine(this._time);

            if (tempTime > this._time.AddMinutes(1))
            {
                Console.WriteLine("Your deposit can be extracted!");
                this.interest = this.AccountBalance * (interest / 100) * (1 / 12);
                this.AccountBalance += interest;

                Console.WriteLine($"Amount on balance: ${this.AccountBalance}");
            }
            else
            {
                Console.WriteLine("You cannot withdraw amount from a Term Deposit before maturity!");
                Console.WriteLine($"Amount on balance: ${this.AccountBalance}");
            }
        }

        public void TempDepInfo()
        {
            Console.WriteLine($"Account ID: {this.AccountID} | Account balance: {this.AccountBalance}");
        }
    }
}
