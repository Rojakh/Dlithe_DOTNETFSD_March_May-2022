using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_22
{
    internal class floyd
    {
        public static void Main()
        {

            int i, j, k = 1;
            for (i = 1; i <= 3; i++)
            {
                for (j = 1; j < i + 1; j++)
                {
                    Console.Write(k++ + " ");
                }

                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}

