using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_23
{
    internal class nullables
    {
        public static void Main()
        {
            int? a = null;
            Nullable<float> average = null;
            double? b= null;
            char? c = null;
            string?  d= null;

            //Printing the Null Values
            Console.WriteLine("Nullables\n");
            Console.WriteLine("integer value is : {0}", a);
            Console.WriteLine("floating value is : {0}", average);
            Console.WriteLine("double is : {0}", b);
            Console.WriteLine("char is : {0}", c);
            Console.WriteLine("String is : {0}", d);

            //Declaring variables for Coalescing usage
            int A = 1;
            float AVERAGE = 12.88f;
            double B = 3400.00;
            char C = 's';
            string D = "C#";

            //Coalescing the null values
            a = a?? A;
            average= average?? AVERAGE;
            b = b??B;
            c = c??C;
            d = d?? D;

            //Printing the updated value
            Console.WriteLine("\n\nCoalescing the Null values\n");

            Console.WriteLine("integer value is : {0}", a);
            Console.WriteLine("floating value is : {0}", average);
            Console.WriteLine("double is : {0}", b);
            Console.WriteLine("char is : {0}", c);
            Console.WriteLine("String is : {0}", d);

        }
    
       
    }

}

