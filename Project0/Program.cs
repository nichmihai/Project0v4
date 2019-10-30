using System;

namespace Project0
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount bankAccount = new BankAccount();

            Console.WriteLine("Welcome to Revature Bank!");
            ShowMenu();

            try {
                int option = int.Parse(Console.ReadLine());
                while (option != 0)
                {
                    if (option == 1)
                    {
                        bankAccount.CreateBankAccount();
                        Console.WriteLine("\nBank account opened with succes!");
                        ShowMenu();
                        option = Int32.Parse(Console.ReadLine());
                    }

                    if (option == 2)
                    {

                        bankAccount.CreateCheckingAccount();
                        Console.WriteLine("Checking account opened with success!\n");
                        ShowMenu();
                        option = Int32.Parse(Console.ReadLine());
                    }

                    if (option == 3)
                    {
                        bankAccount.CreateBusinessAccount();
                        Console.WriteLine("Business account opened with success!\n");
                        ShowMenu();
                        option = Int32.Parse(Console.ReadLine());
                    }

                    if (option == 4)
                    {

                        bankAccount.GetLoan();
                        Console.WriteLine("You've got a loan!\n");
                        ShowMenu();
                        option = Int32.Parse(Console.ReadLine());
                    }

                    if (option == 5)
                    {
                        bankAccount.MakeChekingDeposit();
                        ShowMenu();
                        option = Int32.Parse(Console.ReadLine());
                    }

                    if (option == 6)
                    {
                        bankAccount.MakeChekingWithdrawal();
                        ShowMenu();
                        option = Int32.Parse(Console.ReadLine());
                    }


                    if (option == 7)
                    {
                        bankAccount.MakeBusinessDeposit();
                        ShowMenu();
                        option = Int32.Parse(Console.ReadLine());
                    }

                    if (option == 8)
                    {
                        bankAccount.MakeBusinessWithdrawal();
                        ShowMenu();
                        option = Int32.Parse(Console.ReadLine());
                    }

                    if (option == 9)
                    {
                        bankAccount.PayLoan();
                        ShowMenu();
                        option = Int32.Parse(Console.ReadLine());
                    }

                    //    if (option == 10)
                    //    {
                    //        bankAccount.Transfer();
                    //        bankAccount.ShowCustomer();
                    //        bankAccount.ShowAccountInfo();
                    //        ShowMenu();
                    //        option = Int32.Parse(Console.ReadLine());
                    //    }

                    if (option == 11)
                    {
                        bankAccount.CreateTempDeposit();
                        ShowMenu();
                        option = Int32.Parse(Console.ReadLine());
                    }

                    if (option == 12)
                    {
                        bankAccount.WithdrawFromTD();
                        ShowMenu();
                        option = Int32.Parse(Console.ReadLine());
                    }

                    if (option == 13)
                    {
                        bankAccount.ListAccounts();
                        ShowMenu();
                        option = Int32.Parse(Console.ReadLine());
                    }

                    if (option == 14)
                    {
                        bankAccount.TransferChkToBs();
                        ShowMenu();
                        option = Int32.Parse(Console.ReadLine());
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Wrong choice!");
            }
           

 
            Console.WriteLine("Good Bye!");
        }

       
        public static void ShowMenu()
        {
            Console.WriteLine("\nPlease choose one of the options" +
                              "\n0.Quit" +
                              "\n1. Create Bank Account" +
                              "\n2. Create Checking Account" +
                              "\n3. Create Business Account" +
                              "\n4. Get a Loan from Bank" +
                              "\n5. Deposit money in Checking Account" +
                              "\n6. Withdraw money from Checking Account" +
                              "\n7. Deposit money in Business Account" +
                              "\n8. Withdraw money from Business Account" +
                              "\n9. Pay loan" +
                              "\n10. Make  a transfer" +
                              "\n11. Create a temporary deposit" +
                              "\n12. Withdraw money from Temporary Account" +
                              "\n13. Show the accounts!" +
                              "\n14. Transfer from Checking Account to Business Account" +
                              "\n15. Transfer from Business Account to Checking Account" +
                              "\n16. Transfer from Temporary to Checking Account");
        }
    }
}