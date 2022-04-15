using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    internal class Employee1
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public Double Salary { get; set; }

        public Employee1(int empNo, string empName, double salary)
        {
            this.EmpNo = empNo;
            this.EmpName = empName;
            this.Salary = salary;
        }

        public void display()
        {
            Console.WriteLine(EmpNo + " " + EmpName + " " + Salary);
        }

        public double HRA, TA, DA, PF, TDS, NetSalary, GrossSalary;
        public void calculate()
        {
            if (Salary < 5000)
            {
                HRA = (Salary * 10 / 100);
                TA = (Salary * 10 / 100);
                DA = (Salary * 10 / 100);
            }
            else if (Salary < 10000)
            {
                HRA = (Salary * 15 / 100);
                TA = (Salary * 10 / 100);
                DA = (Salary * 20 / 100);
            }
            else if (Salary < 15000)
            {
                HRA = (Salary * 20 / 100);
                TA = (Salary * 15 / 100);
                DA = (Salary * 20 / 100);
            }
            else if (Salary < 20000)
            {
                HRA = (Salary * 25 / 100);
                TA = (Salary * 20 / 100);
                DA = (Salary * 30/ 100);
            }
            else
            {
                HRA = (Salary * 30/100);
                TA = (Salary * 25/100);
                DA = (Salary * 35/100);
            }

            GrossSalary = Salary + HRA + TA + DA;
            Console.WriteLine("Your GrossSalary is : " + GrossSalary);
            Console.ReadLine();
        }

        public void CalculateSalary()
        {
            PF = (GrossSalary * 10 / 100);
            TDS = (GrossSalary * 18 / 100);
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine(" Your NetSalary is :" + NetSalary);
            Console.ReadLine();
        }
    }
}
