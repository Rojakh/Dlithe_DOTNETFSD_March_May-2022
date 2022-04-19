using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_22
{
    internal class OneD_Array
    {
        public static void Main()
        {
            int[] a = new int[100];
            int i, n, sum = 0;

            Console.WriteLine("Enter the number of elements to be stored: ");
            n=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array :\n", n);
            for(i=0;i<n;i++)
            {
                Console.Write("element is- {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i=0;i<n;i++)
            {
                sum += a[i];
            }
            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
        }
    }
}
