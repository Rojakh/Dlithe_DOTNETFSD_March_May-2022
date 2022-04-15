using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    internal class const_over
    {
        // constructor with no parameter
        const_over()
        {
            Console.WriteLine("pen constructor");
        }
        // constructor with one parameter
        const_over(string brand)
        {
            Console.WriteLine("pen constructor with one parameter");
            Console.WriteLine("Brand: " + brand);
        }

        public static void Main()
        {
            // call with no parameter
             const_over pen = new const_over();

            Console.WriteLine();

            // call with one parameter 
            const_over pen2 = new const_over("Reynolds Bright");

            Console.ReadLine();

        }

    }
}
