using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    public class subjects
    {
        public static void Main()
        {
            int sub1, sub2, sub3;
            double total,avg;
            int option, temp = 0;
            Console.Write("Input  the marks of sub1 : ");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of sub2 : ");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of sub3 : ");
            sub3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1 To Calculate the Total or Enter 2 To Calculate the Avg");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                total = sub1 + sub2 + sub3;
                Console.WriteLine("Total = {0}", total);
            }
            else
            {
                temp = sub1 + sub2 + sub3;
                avg = temp / 3;
                Console.WriteLine("Avg = {0}", avg);
            }

        }

    }
}
