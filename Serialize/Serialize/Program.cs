using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            [Serializable]
            class Program
        {
            public int ID;
            public String Name;
            public int Sal;
            static void Main(string[] args)
            {
                Program obj = new Program();
                obj.ID = 1;
                obj.Name = "Deviprasad";
                obj.Sal = 50000;

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@"C:\Users\devip\source\repos\CollectionFrameworkAssignment\Serialize\ExampleNew.txt", FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, obj);
                stream.Close();

                stream = new FileStream(@"C:\Users\devip\source\repos\CollectionFrameworkAssignment\Serialize\ExampleNew.txt", FileMode.Open, FileAccess.Read);
                Program objnew = (Program)formatter.Deserialize(stream);

                Console.WriteLine(objnew.ID);
                Console.WriteLine(objnew.Name);
                Console.WriteLine(objnew.Sal);

                Console.ReadKey();
            }
        }
    }
}

