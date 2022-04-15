using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] IntegerArray = new int[5];
            string[] StringArray = new string[5];

            Console.WriteLine("Integer Array of size 5");
            Console.WriteLine("\n Type 5 integer elements\n");

            for (int i = 0; i<5; i++)
            {
                IntegerArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n String array of size 5");
            Console.WriteLine("\n Type 5 string elements\n");

            for (int i = 0; i < 5; i++)
            {
                StringArray[i] = Console.ReadLine();
            }

            int[] IntegerArray2 = new int[5] { 11, 12, 13, 14, 15 };

            Console.WriteLine("\n Array after using copying operation from System.Array in another array\n");
            Console.WriteLine("\n Integer Array 2: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(IntegerArray2[i]);
            }
            System.Array.Copy(IntegerArray, 1, IntegerArray2, 0, 3);

            Console.WriteLine("\n After copying elements 1-3 of Integer array into Integer array 2:\n");
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine(IntegerArray2[i]);
            }

            // Console.WriteLine("\n String array:\n");
            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine(StringArray[i]);
            // }


            Console.WriteLine("\nInteger Array after sort operation: \n");
            System.Array.Sort(IntegerArray);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(IntegerArray[i]);
            }


            Console.WriteLine("\n Integer array after reverse operation: \n");
            System.Array.Reverse(IntegerArray);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(IntegerArray[i]);
            }

            Console.WriteLine("\n Integer array after clear operation: \n");
            System.Array.Clear(StringArray, 1, 2);
            Console.WriteLine("\n After Clearing 1-2 elements of String array, we get the following array: \n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(StringArray[i]);
            }

        }
    }
}
