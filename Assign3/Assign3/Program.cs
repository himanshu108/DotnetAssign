using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
        class Employee
        {

            protected double salary;
            protected double grossSalary = 0;

            public virtual double CalculateSalary() { return 0; }

        }

        class Manager : Employee, IPrintable
        {

            private double petrolAllowance;
            private double foodAllowance;
            private double otherAllowances;


            public Manager(double sal)
            {
                this.salary = sal;
            }

            public override double CalculateSalary()
            {

                petrolAllowance = 0.08 * salary;
                foodAllowance=0.13 * salary;
                otherAllowances = 0.03 * salary;
                grossSalary = petrolAllowance + foodAllowance + otherAllowances;
                return salary + grossSalary;
            }
            public void Print()
            {
                Console.WriteLine(CalculateSalary());

            }

        }

        public interface IPrintable
        {
            void Print();
        }
        class MarketingExecutive : Employee, IPrintable
        {

            private double kilometerTravel;
            private double tourAllowance;
            private int telephoneAllowance = 1000;


            public MarketingExecutive(double sal, double kilometerTravelled)
            {
                kilometerTravel =  kilometerTravelled;
                salary = sal;
            }
            public override double CalculateSalary()
            {
                tourAllowance = 5 * kilometerTravel;
                grossSalary = tourAllowance+ telephoneAllowance;
                return salary + grossSalary;
            }
            public void Print()
            {

                Console.WriteLine(CalculateSalary());
            }

        }


    }

