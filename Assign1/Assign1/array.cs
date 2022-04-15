using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    internal class array
    {
        public static int Addition(int []arr, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += arr[i];
            return sum;
        }
    }
}
