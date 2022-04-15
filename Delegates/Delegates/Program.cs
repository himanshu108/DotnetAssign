using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // Delegate Definition  
    public delegate double EmployeeDelegate(double sal);

    internal class Program
    {
        // Method that is passes as an Argument  
        // It has same signature as Delegates   

        static double ManagerDetails(double s)
        {
            double petrolAllowance, foodAllowance, otherAllowances, grossSalary;

            petrolAllowance = 0.08 * s;
            foodAllowance = 0.13 * s;
            otherAllowances = 0.03 * s;

            grossSalary = petrolAllowance + foodAllowance + otherAllowances;

            return grossSalary;

        }

        static double MarketingExecutiveDetails(double kil)
        {
            double tourAllowances, telephoneAllowance, grossSalary;

            tourAllowances = 5 * kil;
            telephoneAllowance = 1000;

            grossSalary = tourAllowances + telephoneAllowance;
            return grossSalary;

        }
        static void Main(string[] args)
        {
            // Delegate instantiation  
            EmployeeDelegate obj1 = new EmployeeDelegate(Program.ManagerDetails);
            EmployeeDelegate obj2 = new EmployeeDelegate(Program.MarketingExecutiveDetails);

            // output  
            Console.WriteLine("\n Gross Salary of manager = " + obj1(50000));
            Console.WriteLine("\n Gross Salary of Marketing Executive= " + obj2(200));
        }
    }
}
