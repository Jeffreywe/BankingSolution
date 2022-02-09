using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject {
    public class Savings : Account { // inheritance

        public decimal InterestRate { get; set; } = 0.12m; // interest rate, exclusive to savings account

        public void CalculateAndPayInterest(int months) { // method created to "readname"
            decimal interest = Balance * (InterestRate / 12) * months;
            Deposit(interest);
        }
    }
}
