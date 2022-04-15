using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAppDBO
{
    class Program
    {

        static void Main(String[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=DESKTOP-A4JQ9DE;Initial Catalog=empDb;Integrated Security=True";

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Connection Establish Sucessfully");

                string ans;
                do
                {

                    Console.WriteLine("Enter your choice \n 1. Create \n 2. Read \n 3. Update \n 4. Delete ");
                    int ch = int.Parse(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:




                            //create --- c 
                            Console.WriteLine("Enter Emp id");
                            int empId = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Emp Name");
                            string empName = Console.ReadLine();


                            Console.WriteLine("Enter Emp Sal");
                            int empSal = int.Parse(Console.ReadLine());

                            string insertQuery = "INSERT INTO emp(empId,empName,empSal) VALUES(" + empId + ", ' " + empName + " ', " + empSal + " )";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);

                            insertCommand.ExecuteNonQuery();

                            Console.WriteLine("Data inserted ...");
                            break;

                        case 2:
                            //Retrive --- R
                            string displayQuery = "SELECT * FROM emp";
                            SqlCommand displayCommand = new SqlCommand(displayQuery, sqlConnection);
                            SqlDataReader dataReader = displayCommand.ExecuteReader();
                            while (dataReader.Read())
                            {
                                Console.WriteLine("EmpId : " + dataReader.GetValue(0).ToString());
                                Console.WriteLine("EmpName : " + dataReader.GetValue(1).ToString());
                                Console.WriteLine("EmpSal : " + dataReader.GetValue(2).ToString());

                            }
                            dataReader.Close();
                            break;

                        case 3:

                            //update --- u

                            int empid;
                            String empname;
                            int empsal;
                            Console.WriteLine("Enter the emp id you would like to update");
                            empid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Updated Sal");
                            empsal = int.Parse(Console.ReadLine());

                            string updateQuery = "update emp SET empsal = " + empsal + "where empid= " + empid + "";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                            updateCommand.ExecuteNonQuery();

                            Console.WriteLine("Data updated ....");

                            break;

                        case 4:


                            int d_empid;
                            Console.WriteLine("Enetr emp id to delete the record");
                            d_empid = int.Parse(Console.ReadLine());
                            string deleteQuery = "delete from emp where empid = " + d_empid;
                            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                            deleteCommand.ExecuteNonQuery();
                            Console.WriteLine("Record Deleted");
                            break;




                        default:
                            Console.WriteLine("invalid Choice");
                            break;

                    }
                    Console.WriteLine("Do you want to continue?");
                    ans = Console.ReadLine();

                }
                while (ans != "No");

                sqlConnection.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
