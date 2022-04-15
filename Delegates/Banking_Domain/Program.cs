using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Domain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Account Domain---");
            Account a = new Account();
            a.SetBalance(10);
            Console.WriteLine("\n Account balance =  " + a.GetBalance());

            a.Deposit(10);

            Console.WriteLine("\n\n ---ICICI Bank Domain---");
            ICICIBank i = new ICICIBank();
            i.SetBalance(10);
            Console.WriteLine("\n Account balance = " + i.GetBalance());
            i.Deposit(100);

            Console.WriteLine("\n\n");

            Console.WriteLine("---HDFC Bank Domain---");
            HDFCBank h = new HDFCBank();
            h.SetBalance(100);
            Console.WriteLine("\n Account balance= " + h.GetBalance());
            h.Withdraw(100);

            Console.WriteLine("\n\n");
        }
    }
}
