// namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// a namespace of our project
namespace Banking {

    // the class we are using, uniquely named
    // references means where the data is being used, rather referenced by in the class
    public class Account {

        // Static Properties
        private static int NextAccountNumber { get; set; } = 1; // static creates multiple instances in the same property, so gives 1 account, 2 account, 3 account, and all can be changed within this property
        // Instance properties Properties, is a data identifier, the data type is a return type
        public decimal Balance { get; set; }
        public int AccountNumber { get; set; }// instance variables/properties, setting one has nothing to do with the other
        public string Description { get; set; }

        // Methods, are actions, and are returned with a return type
        public bool Deposit(decimal Amount) {
            if(Amount <= 0) {
                throw new Exception("Amount must be positive."); //sends a message to the user that the information returned was false
            }
            Balance = Balance + Amount;
            return true;
        }
        public bool Withdraw(decimal Amount) {
            if (Amount <= 0) {
                throw new Exception("Amount must be positive."); 
            }
            if(Amount > Balance) {
                throw new Exception("Insufficient funds!");
            }
            Balance = Balance - Amount;
            return true;
        }
        public bool Transfer(decimal Amount, Account ToAccount) {// sets up the code for the program to run from one account to another
            try { //catch can only catch exceptions. way to handle errors in your program
            Withdraw(Amount); //uses withdraw method code, and tries to withdraw an amount
            } catch(Exception) { // if exceptions threw in withdraw method then this statement catches and throws a new exception
                throw new Exception("Withdraw failed in Transfer"); 
            }
            ToAccount.Deposit(Amount); // calls perimeter ToAccount and uses deposit method to deposit the amount
            return true;
        }
        public void Debug() { // mostly used for us, the programmer to see data
            Console.WriteLine($"{AccountNumber}|{Description}|{Balance:c}");
        }
        // Constructors, always the name of the class, 
        public Account() { // default constructor, sets properties to default values based on the data type
            AccountNumber = NextAccountNumber; // links AccountNumber to NextAccountNumber            
            NextAccountNumber++; // increments AccountNumber by 1 starting at 1 given the static assigned
            Description = "New Account"; // sets Description to New Account
            Balance = 0; // sets balance to start at 0
        }

    }
}
