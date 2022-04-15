using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Employee Details: ");
            Console.WriteLine("Enter Employee Id: ");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            String ename = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary : ");
            Double esal = Convert.ToDouble(Console.ReadLine());
            Employee1 employee = new Employee1(empid, ename, esal);

            employee.display();
            employee.calculate();
            employee.CalculateSalary();
            Console.ReadKey();
        }
    }
}
