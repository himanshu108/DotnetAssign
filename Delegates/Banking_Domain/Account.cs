using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Domain
{
    public delegate string Balance(string str);
    internal class Account
    {
        int accountNo;
        string customerName;
        double balance;

        public event Balance UnderBalance;
        public event Balance BalanceZero;

        public double GetBalance()
        {
            return balance;
        }

        public double SetBalance(double bal)
        {
            balance = bal;
            return balance;
        }

        public double Withdraw(double b)
        {
            balance = balance+b;
            return balance;
        }

        public string print(string b)
        {
            return b;
        }

        public double Deposit(double b)
        {
            balance = balance - b;

            Console.WriteLine("\n After depositing rupees " + b);
            Console.WriteLine("\n The remaining balance= " + balance);

            if (balance == 0)
            {
                this.BalanceZero += new Balance(this.print);
                Console.WriteLine(print("\n Zero Balance available."));
            }
            else if (balance < b)
            {
                this.UnderBalance += new Balance(this.print);
                Console.WriteLine(print("\n Insufficient Balance."));
            }

            return balance;
        }


    }
}

