using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    internal class insta_stat
    {

        public class method
        {
            //Static method
            public static void mul(int k, int m)
            {
                int result = k*m;
                Console.WriteLine("{0} * {1} = {2}", k, m, result);
            }

            //Instance method
            public void div(int k, int m)
            {
                int result = k/m;
                Console.WriteLine("{0} / {1} = {2}", k, m, result);
            }

            public static void Main()
            {
                //Invoking static method
                mul(20, 30);

                //Invoking instance method
                method n = new method();
                n.div(30, 3);
            }
        }

    }
}