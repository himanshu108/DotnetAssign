using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    internal class Class1
    {
        static void Main()
        {
            Manager em = new Manager(20000);
            Console.WriteLine("Net Salary Of Manager:");
            em.Print();
            MarketingExecutive me = new MarketingExecutive(20000, 100);
            Console.WriteLine("Net Salary Of MarketingExecutive:");
            me.Print();
            Console.ReadLine();
        }
    }
}

