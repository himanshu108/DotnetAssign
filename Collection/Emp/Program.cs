using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp
{
    class Employee
    {
        protected int id;
        protected string name;
        protected double sal;


        public Employee(int eid, String ename, double esal)
        {
            this.id = eid;
            this.name =ename;
            this.sal = esal;

        }
        public void PrintEmp()
        {
            Console.WriteLine("Id : {0}", id);
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Salary: {0}", sal);
        }
    }
    class EmployeeArr : Employee
    {
        private Employee[] a;
        private int Size;
        private const int SIZE = 100;

        public EmployeeArr(int s, int id, string name, double sal) : base(id, name, sal)
        {
            a= new Employee[SIZE];
            if (s > SIZE)
                Console.WriteLine("overflow");
            else if (s==SIZE)
                Console.WriteLine("Full");
            else
                Size = s;

        }
        public void Input()
        {
            a = new Employee[3];
            for (int i = 0; i < Size; i++)
            {
                a[i] = new Employee(id, name, sal);

            }
        }




    }

    class Programe
    {
        static void Main()
        {
            Console.WriteLine("Enter num of emp :");
            int i = 0;
            int s = Convert.ToInt32(Console.ReadLine());

            while (i<s)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter id : ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name :");
                String name = Console.ReadLine();

                Console.WriteLine("Enter Salary : ");
                double sal = Convert.ToDouble(Console.ReadLine());

                EmployeeArr arr = new EmployeeArr(s, id, name, sal);
                arr.PrintEmp();
                i++;


            }
            Console.ReadLine();
        }
    }
}







