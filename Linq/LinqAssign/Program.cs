using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssign
{
    class EmpList
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }


    class Program
    {
        public static List<EmpList> employee = new List<EmpList>
        {
            new EmpList{EmpId=1001,FirstName="Malcolm",LastName="Daruwalla",Title="Manager",DOB=DateTime.Parse("16/11/1984"),DOJ=DateTime.Parse("8/6/2011"),City="Mumbai"},
            new EmpList{EmpId=1002,FirstName="Asdin",LastName="Dhalla",Title="AsstManager",DOB=DateTime.Parse("20/08/1984"),DOJ=DateTime.Parse("7/7/2012"),City="Mumbai"},
            new EmpList{EmpId=1003,FirstName="Madhavi",LastName="Oza",Title="Consultant",DOB=DateTime.Parse("14/11/1987"),DOJ=DateTime.Parse("12/4/2015"),City="Pune"},
            new EmpList{EmpId=1004,FirstName="Saba",LastName="Shaikh",Title="SE",DOB=DateTime.Parse("3/6/1990"),DOJ=DateTime.Parse("2/2/2016"),City="Pune"},
            new EmpList{EmpId=1005,FirstName="Nazia",LastName="Shaikh",Title="SE",DOB=DateTime.Parse("8/3/1991"),DOJ=DateTime.Parse("2/2/2016"),City="Mumbai"},
            new EmpList{EmpId=1006,FirstName="Amit",LastName="Pathak",Title="Consultant",DOB=DateTime.Parse("7/11/1989"),DOJ=DateTime.Parse("8/8/2014"),City="Chennai"},
            new EmpList{EmpId=1007,FirstName="Vijay",LastName="Natrajan",Title="Consultant",DOB=DateTime.Parse("2/12/1989"),DOJ=DateTime.Parse("1/6/2015"),City="Mumbai"},
            new EmpList{EmpId=1008,FirstName="Rahul",LastName="Dubey",Title="Associate",DOB=DateTime.Parse("11/11/1993"),DOJ=DateTime.Parse("6/11/2014"),City="MumbaChennaii"},
            new EmpList{EmpId=1009,FirstName="Suresh",LastName="Mistry",Title="Associate",DOB=DateTime.Parse("12/8/1992"),DOJ=DateTime.Parse("3/12/2014"),City="Chennai"},
            new EmpList{EmpId=1010,FirstName="Sumit",LastName="Shah",Title="Manager",DOB=DateTime.Parse("12/4/1991"),DOJ=DateTime.Parse("2/1/2016"),City="Pune"}

        };

        static void Main(string[] args)
        {
            var basicQuery = employee.ToList();

            foreach (var item in basicQuery)
            {
                Console.WriteLine($"Id = {item.EmpId}, FirstName = {item.FirstName}, LastName = {item.LastName}, Title = {item.Title}, DOB= {item.DOB}, DOJ={item.DOJ},city={item.City}");
            }


            Console.WriteLine("-------------------------------Assinment2------------------------------------");

            foreach (var item in employee.Where(y => y.City != "Mumbai"))
            {
                Console.WriteLine($"Id = {item.EmpId}, FirstName = {item.FirstName}, LastName = {item.LastName}, Title = {item.Title}, DOB= {item.DOB}, DOJ={item.DOJ},city={item.City}");
            }

            Console.WriteLine("----------------------------------Assinment3----------------------------------");

            foreach (var item in employee.Where(y => y.Title == "AsstManager"))
            {
                Console.WriteLine($"Id = {item.EmpId}, FirstName = {item.FirstName}, LastName = {item.LastName}, Title = {item.Title}, DOB= {item.DOB}, DOJ={item.DOJ},city={item.City}");
            }

            Console.WriteLine("----------------------------------A--------------------------------------------");

            IEnumerable<EmpList> Query =
                from emp in employee
                where emp.LastName[0] == 'S'
                select emp;


            foreach (var item in Query)
            {
                Console.WriteLine($"Id = {item.EmpId}, FirstName = {item.FirstName}, LastName = {item.LastName}, Title = {item.Title}, DOB= {item.DOB}, DOJ={item.DOJ},city={item.City}");
            }
            Console.WriteLine("----------------------------------AJJJ--------------------------------------------");

            Console.WriteLine(employee.OrderByDescending(y => y.LastName.StartsWith("S")));

            Console.WriteLine("----------------------------------A--------------------------------------------");

            foreach (var item in employee.Where(y => y.DOJ > DateTime.Parse("1/1/2015")))
            {
                Console.WriteLine($"Id = {item.EmpId}, FirstName = {item.FirstName}, LastName = {item.LastName}, Title = {item.Title}, DOB= {item.DOB}, DOJ={item.DOJ},city={item.City}");
            }

            Console.WriteLine("----------------------------------A--------------------------------------------");

            foreach (var item in employee.Where(y => y.DOB > DateTime.Parse("1/1/1990")))
            {
                Console.WriteLine($"Id = {item.EmpId}, FirstName = {item.FirstName}, LastName = {item.LastName}, Title = {item.Title}, DOB= {item.DOB}, DOJ={item.DOJ},city={item.City}");
            }

            Console.WriteLine("----------------------------------A--------------------------------------------");

            foreach (var item in employee.Where(y => y.Title == "Consultant" || y.Title == "Associate"))
            {
                Console.WriteLine($"Id = {item.EmpId}, FirstName = {item.FirstName}, LastName = {item.LastName}, Title = {item.Title}, DOB= {item.DOB}, DOJ={item.DOJ},city={item.City}");
            }

            Console.WriteLine("----------------------------------A--------------------------------------------");

            Console.WriteLine(employee.Count);

            Console.WriteLine("----------------------------------A--------------------------------------------");

            foreach (var item in employee.Where(y => y.City == "Chennai"))
            {
                Console.WriteLine($"Id = {item.EmpId}, FirstName = {item.FirstName}, LastName = {item.LastName},city={item.City}");
            }
            Console.WriteLine("----------------------------------A--------------------------------------------");

            /*foreach (var item in employee.Where(y => y.EmpId))
            {
                Console.WriteLine($"Id = {item.EmpId}, FirstName = {item.FirstName}, LastName = {item.LastName}, Title = {item.Title}, DOB= {item.DOB}, DOJ={item.DOJ},city={item.City}");
            }*/
            Console.WriteLine("----------------------------------A--------------------------------------------");

            foreach (var item in employee.Where(y => y.DOJ > DateTime.Parse("1/1/2015")))
            {
                Console.WriteLine($"Id = {item.EmpId}");
            }
            Console.WriteLine("----------------------------------A--------------------------------------------");

            foreach (var item in employee.Where(y => y.Title != "Associate"))
            {
                Console.WriteLine($"Id = {item.EmpId}, FirstName = {item.FirstName}, LastName = {item.LastName}, Title = {item.Title}, DOB= {item.DOB}, DOJ={item.DOJ},city={item.City}");
            }
            Console.WriteLine("----------------------------------A--------------------------------------------");

            var Query1 = from emp in employee.GroupBy(emp => emp.City)
                         select new
                         {
                             count = emp.Count(),
                             emp.First().City,
                         };
            Console.WriteLine(Query1);

            Console.WriteLine("----------------------------------A--------------------------------------------");

            Console.ReadLine();
        }
    }
}
