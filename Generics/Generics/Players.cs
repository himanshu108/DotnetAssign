using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    public class Players<T, U>
    {
        List<T> Name;
        List<U> RunScore;
        public Players()
        {
            Name = new List<T>();
            RunScore = new List<U>();
        }
        public void AddToList(T item1, U item2)
        {
            Name.Add(item1);
            RunScore.Add(item2);
        }


        public void DisplayList()
        {
            foreach (var ele in this.Name)
            {
                Console.Write("{0}\t", ele);
            }
            Console.WriteLine("\n");
            foreach (var ele in this.RunScore)
            {
                Console.Write("{0}\t", ele);
            }
        }

        public class Program
        {
            public static void Main()
            {
                Players<string, int> India = new Players<string, int>();
                India.AddToList("Dhoni", 56);
                India.AddToList("Sachin", 45);
                India.AddToList("Dinesh", 34);

                India.DisplayList();

            }
        }
    }
}
