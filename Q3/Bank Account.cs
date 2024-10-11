using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Bank_Account
    {
        private int _accountNum;
        private string _accountHolder;
        private double _balance;

        public int AccountNum
        { get; set; }

        public string AccountHolder
        { get; set; }
        public double Balance
        { get; set; }

        public Bank_Account(int accountNum , string accountHold , double balance)
        {
            AccountHolder = accountHold;
            Balance = balance;  
            AccountNum = accountNum;
        }
        public void Deposit()
        {
            double deposit = 1000;
            Balance += deposit;
            Console.WriteLine($"Adding {deposit:C} to {AccountNum}");
            Console.WriteLine(ToString());
        }
        public void Withdraw()
        {
            double deposit = 500;
            Balance -= deposit;
            Console.WriteLine($"Withdrawing {deposit:C} to {AccountNum}");
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Account Number: {AccountNum}  \nAccount Holder: {AccountHolder}  \nAccount Balance: {Balance:c} ";

        }

    }
}
