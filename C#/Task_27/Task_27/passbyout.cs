using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_27
{
    internal class passbyout
    {
        public static void Main()
        {
            Console.WriteLine("This is a pass by out");
            int i;
            addition(out i);

            Console.WriteLine("Addition of the value is : {0}", i);
        }
        public static void addition(out int i)
        {
            i = 20;
            i += i;
        }
    }
}
