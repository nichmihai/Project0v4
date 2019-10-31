using System;
namespace Project0
{
    public class TermDeposit : Account
    {
        public int TermDepositID { get; set; }
        public decimal AccountBalance { get; set; }
        decimal interest = 3.9M;
        public DateTime _time;
        


        public TermDeposit()
        {
        }

        public void CreateTermDeposit()
        {
            Random r = new Random();
            this.TermDepositID = r.Next();
            Console.WriteLine("Please insert the amount you want to deposit?");

            decimal amount = decimal.Parse(Console.ReadLine());
           
            if (amount < 0)
            {
                Console.WriteLine("We dont accept negative amount!");
            }
            else
            {
                this.AccountBalance += amount;
                this._time = DateTime.Now;
                Console.WriteLine($"Temporary Deposit ID: {this.TermDepositID} | Amount on balance: ${this.AccountBalance} | Time of depositing: {this._time}");
            }
        }

        public bool ExtractMoney()
        {
            bool ans = false;
            DateTime tempTime = DateTime.Now;
            Console.WriteLine(tempTime);
            Console.WriteLine(this._time);

            if (tempTime > this._time.AddMinutes(1))
            {
                Console.WriteLine("Your deposit can be extracted!");
                this.interest = (interest / 12) * this.AccountBalance;

                this.AccountBalance += interest;

                Console.WriteLine($"Amount on balance: ${this.AccountBalance}");
                ans = true;
            }
            else
            {
                Console.WriteLine("You cannot withdraw amount from a Temporary Deposit before maturity!");
                Console.WriteLine($"Amount on balance: ${this.AccountBalance}");
                ans = false;
            }
            return ans;
        }

        public void TempDepInfo()
        {
            Console.WriteLine($"Temporary ID: {this.TermDepositID} | Account balance: {this.AccountBalance}");
        }
    }
}
