using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_22
{
    internal class str_oper
    {
        public static void Main()
        {
            //creation of string
            string str1 = "roja";
            string str2 = "lakshmi";

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            // get length of str1
            int length = str1.Length;
            Console.WriteLine("Length : "+length);

            //concatinating two strings
            string a = string.Concat(str1, str2);
            Console.WriteLine("concating the two strings: "+a);

            //comparison of two strings
            Boolean b = str1.Equals(str2);
            Console.WriteLine("str1 and str2 are equal: "+b);

            //string interpolation
            // create string
            string name = "C# String";

            // string interpolation
            string message = $"Welcome to {name}";
            Console.WriteLine(message);

                     
        }
    }
}
