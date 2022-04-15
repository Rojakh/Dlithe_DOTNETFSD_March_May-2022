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
            Console.Write("Input  the marks of sub1 : ");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of sub2 : ");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of sub3 : ");
            sub3 = Convert.ToInt32(Console.ReadLine());

            total = sub1 + sub2 + sub3;
            Console.Write("total marks of the subjects is: ", total);

            avg = total/3.0;


        }
    }
}
