using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    internal class swap
    {
     public static void Main()
    {
            int a = 20;
            int b = 40;
            Console.WriteLine("Before swap a= " +a+ " b= "+b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.Write("After swap a= " +a+ " b= " +b);
    }
}
}
