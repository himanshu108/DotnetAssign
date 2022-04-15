using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    internal class Avg
    {
     public static void Main()
        {
            int highestMarks = 0;
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter the marks of student:" + i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                if(highestMarks < a[i])
                {
                    highestMarks = a[i];
                }
            }
            Console.WriteLine("the highest marks is:" + highestMarks);
            Console.ReadKey();
        }
    }
}
