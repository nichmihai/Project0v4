﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Project0
{
    public class BankAccount
    {
        Customer cust = new Customer();
        CheckingAccount ck = new CheckingAccount();
        BusinessAccount bs = new BusinessAccount();
        TermDeposit tempDep = new TermDeposit();
        Loan loan = new Loan();

        public static List<Customer> customers = new List<Customer>();

        public static List<Customer> AllCustomers
        {
            get { return customers; }
        }

        public BankAccount()
        {

        }

        public void CreateBankAccount()
        {
            cust.CreateCustomer();
            customers.Add(cust);

        }

        public void CloseAccount()
        {
            foreach (var csut in customers)
            {
                if (cust.accounts.Count() != 0)
                {
                    Console.WriteLine("Deal with your accounts before closing account!");
                }
                else
                {
                    customers.Remove(cust);
                    Console.WriteLine("Customer Account closed!");
                }
          
            }
        }


        public void CreateCheckingAccount()
        {
            ck.CreateAccount();
            cust.accounts.Add(ck);
        }

        public void CreateBusinessAccount()
        {
            bs.CreateAccount();
            cust.accounts.Add(bs);
        }

        public void MakeChekingDeposit()
        {
            if (cust.accounts.Contains(ck))
            {
                ck.MakeDeposit();
            }
            else
            {
                Console.WriteLine("You dont have a cheking account");
            }
        }

        public void MakeChekingWithdrawal()
        {
            if (cust.accounts.Contains(ck))
            {
                ck.MakeWithdrawal();
            }
            else
            {
                Console.WriteLine("You dont have a cheking account");
            }
        }

        public void CloseCheckingAcc()
        {
            if (cust.accounts.Contains(ck))
            {
                if (ck.AccountBalance > 0)
                {
                    Console.WriteLine("Withdraw all money from account before deleting it!");
                    ck.CheckingInfo();
                }
                else
                {
                    cust.accounts.Remove(ck);
                    Console.WriteLine("Account deleted!");
                }
            }
            else
            {
                Console.WriteLine("You dont have checking account");
            }
        }

        public void CloseBusinessAcc()
        {
            if (cust.accounts.Contains(bs))
            {
                if (bs.AccountBalance == 0)
                {
                    cust.accounts.Remove(bs);
                    Console.WriteLine("Account deleted!");
                }

                else if (bs.AccountBalance > 0 || bs.AccountBalance > -100)
                {
                    Console.WriteLine("Before closing business account deal with the amount on it!");
                    bs.BusinessInfo();
                }
            }
            else
                Console.WriteLine("You dont have a business account!");
        }

        public void CloseLoanAccount()
        {
            foreach (var cust in customers)
            {
                if (cust.loans.Count() != 0)
                {
                    if (loan.LoanAmount > 0)
                    {
                        Console.WriteLine("Pay loan in total and then you can close the loan account!");
                    }
                }
                else
                { 
                    cust.loans.Remove(loan);
                    Console.WriteLine("Loan account closed!");
                }
            }
        }

        public void MakeBusinessDeposit()
        {
            if (cust.accounts.Contains(bs))
            {
                bs.MakeDeposit();
            }
            else
            {
                Console.WriteLine("You dont have a business account");
            }
        }

        public void MakeBusinessWithdrawal()
        {
            if (cust.accounts.Contains(bs))
            {
                bs.MakeWithdrawal();
            }
            else
            {
                Console.WriteLine("You dont have a business account");
            }
        }

        public void GetLoan()
        {
            if (cust.loans.Contains(loan))
            {
                Console.WriteLine("You already have a loan from our bank");
            }
            else
            { 
                loan.GetLoan();
                cust.loans.Add(loan);
            }
        }

        public void PayLoan()
        {
            if (cust.loans.Contains(loan))
            {
                loan.PayLoan();
            }
            else
            {
                Console.WriteLine("You dont have a loan!");
            }
        }

        public void CreateTempDeposit()
        {
            tempDep.CreateTermDeposit();
            cust.accounts.Add(tempDep);
        }

        public void WithdrawFromTD()
        {
            if (cust.accounts.Contains(tempDep))
            {
                tempDep.ExtractMoney();
            }
            else
            {
                Console.WriteLine("You dont have a temporary deposit!");
            }
        }

        public void TransferChkToBs()
        {
            Console.WriteLine("Amount you want to transfer on Business Account");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (cust.accounts.Contains(ck) && cust.accounts.Contains(bs))
            {
                if (amount > ck.AccountBalance)
                {
                    Console.WriteLine("Not enough resources on Checking account");
                }
                else
                {
                    ck.AccountBalance -= amount;
                    bs.AccountBalance += amount;
                    Console.WriteLine($"Checking Balance: {ck.AccountBalance} | Business Balance: {bs.AccountBalance}");
                }
            }
            else
                Console.WriteLine("Imposible to transfer because one of the accounts wasnt created!");
        }

        public void TransferBsToChk()
        {
            Console.WriteLine("Amount you want to transfer on Checking Account");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (cust.accounts.Contains(ck) && cust.accounts.Contains(bs))
            {
                if (amount > bs.AccountBalance  && bs.AccountBalance <= -100)
                {
                    Console.WriteLine("Not enough resources on Business account");
                }
                else
                {
                    bs.AccountBalance -= amount;
                    ck.AccountBalance += amount;
                    Console.WriteLine($"Business Balance: {bs.AccountBalance} | Checking Balance: {ck.AccountBalance}");
                }
            }
            else
                Console.WriteLine("Imposible to transfer because one of the accounts wasn't created!");
        }

        public void TransferFromCdToChK()
        {
            if (tempDep.ExtractMoney())
            {
                decimal tempAmount = tempDep.AccountBalance;
                tempDep.AccountBalance = 0;
                ck.AccountBalance +=tempAmount;
                Console.WriteLine("Transaction completed with succes!");
                Console.WriteLine($"CD Balance: {tempDep.AccountBalance} | Checking Balance: {ck.AccountBalance}");
            }
            else
                Console.WriteLine("Transaction did not successed!");
            

        }

        public void ListAccounts()
        {
            if (cust.accounts.Count() == 0)
            {
                Console.WriteLine("You dont have any accounts! Please create some and then try again!");
            }
            else
                cust.DisplayAccountList();
        }
    }
}
