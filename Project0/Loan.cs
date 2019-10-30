using System;
namespace Project0
{
    public class Loan
    {
        public decimal LoanAmount { get; set; }
        private decimal interest = 3.9M;

        public Loan()
        {
        }

        public void GetLoan()
        {
            Console.WriteLine("You can take a loan between $10.000 and $100.000");

            var loan = new Loan();

            var amount = decimal.Parse(Console.ReadLine());
            while (amount < 10000 || amount > 100000)
            {
                Console.WriteLine("Please try again!");
                amount = decimal.Parse(Console.ReadLine());
            }

            this.LoanAmount += amount;
            this.interest = this.LoanAmount * (interest / 100) * (1 / 12);

            Console.WriteLine($"Loun amount is: ${this.LoanAmount}");
        }

        public void PayLoan()
        {
            Console.WriteLine($"Amount left to pay: {this.LoanAmount}");
            Console.WriteLine("Please insert the amount of money you want to pay: ");
            var amount = Decimal.Parse(Console.ReadLine());
            

            if (amount > this.LoanAmount)
            {
                Console.WriteLine($"You try to pay: ${amount} but amount left to pay is: ${this.LoanAmount}");
                Console.WriteLine("Please insert the amount of money you want to pay: ");
                amount = Decimal.Parse(Console.ReadLine());
            }
            else
            {
                this.LoanAmount -= amount;
                this.LoanAmount += this.interest;
                Console.WriteLine($"Amount left to pay: ${this.LoanAmount}");
            }

            if (this.LoanAmount == 0)
            {
                Console.WriteLine("Loan paid in full!");
            }
        }
    }
}
