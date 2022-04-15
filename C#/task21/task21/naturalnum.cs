using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    internal class naturalnum
    {
        public static void Main()
        {
            int n, sum = 0;
            Console.Write("enter the number : ");
            n=int.Parse(Console.ReadLine());

            int i = 1;
            while (i <= n)
            {

                sum = sum + i;
                i++;

                Console.WriteLine("the sum of natural numbers is: " + sum);
                Console.ReadLine();
            }
        }

    }
}
