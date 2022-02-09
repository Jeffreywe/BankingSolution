using Banking; // using the banking namespace from Account.cs
using System;

namespace BankingProject 
{

    class Program // this tab/class is like an atm, where we input codes that calls the Account and is the user interface
    {
        static void Main(string[] args) 
        {

            Savings sav1 = new Savings();
            sav1.Deposit(100);
            sav1.CalculateAndPayInterest(1);
            sav1.CalculateAndPayInterest(1);
            sav1.Debug();

            //comment out down below for sav1 debug view
            // an instance of an account
            Account acct1 = new Account(); // new creates a constructor, new instance of an account
            acct1.Deposit(500); // gives an amount to Deposit method
            acct1.Withdraw(200); // withdraws 200 from account
            acct1.Debug();
            //acct1.Withdraw(600);
            //acct1.Debug(); // shows us what the amount ends up being in our balance

            Account acct2 = new Account();
            acct2.Description = "My 2nd Account";
            acct2.Deposit(1000);
            acct2.Withdraw(350);
            acct2.Debug();

            //transfer 100 from acct2 to acct1
            acct2.Transfer(100, acct1);
            acct1.Debug();// creates new line for acct1 balance
            acct2.Debug();// creates new line for acct2 balance
        }
    }
}
