using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpList
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public int EmpSal;
        public Employee(int eid, string ename, int esal)



        {
            this.EmpId = eid;
            this.EmpName = ename;
            this.EmpSal = esal;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an List<Employee>
            List<Employee> listemp = new List<Employee>();
            listemp.Add(new Employee(1, "Himanshu", 30000));
            listemp.Add(new Employee(2, "Bhushan", 25000));
            listemp.Add(new Employee(3, "Gaurav", 20000));





            //listemp is collection of all employees with emp details
            foreach (Employee e in listemp)
            {
                Console.WriteLine(e.EmpId + " " + e.EmpName + " " + e.EmpSal);
            }

            Console.WriteLine("Numbers of emp in list " + listemp.Count);
            Console.ReadKey();




        }
    }
}