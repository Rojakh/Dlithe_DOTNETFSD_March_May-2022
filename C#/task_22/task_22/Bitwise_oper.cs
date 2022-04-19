using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_22
{
    internal class Bitwise_oper
    {

        public static void Main()
        {
            int a = 60;    /* 60 = 0011 1100 */
            int b = 13;    /* 13 = 0000 1101 */
            int c = 0;

            //And operator
            c = a & b;      /* 12 = 0000 1100 */
            Console.WriteLine("Value of AND operator is {0}", c);

            //Or operator
            c = a | b;      /* 61 = 0011 1101 */
            Console.WriteLine("Value of OR operator is {0}", c);

            //XOR operator
            c = a ^ b;      /* 49 = 0011 0001 */
            Console.WriteLine("Value of XOR operator is {0}", c);
     
            //Bitwise compliment
            c = ~a;        /*-61 = 1100 0011 */
            Console.WriteLine(" Value of Bitwise compliment is {0}", c);

            //Left shift 
            c = a << 2;    /* 240 = 1111 0000 */
            Console.WriteLine("Value of Left shift is {0}", c);

            //Right shift
            c = a >> 2;    /* 15 = 0000 1111 */
            Console.WriteLine("Value of Right shift is {0}", c);
            Console.ReadLine();

        }
    }
}


