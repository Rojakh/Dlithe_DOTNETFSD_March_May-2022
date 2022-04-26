using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_27
{
    internal class passbyref
    {
        public static void Main()
        {
            Console.WriteLine("this is a pass by reference");
            int value = 100;
            Console.WriteLine("Variable value before calling the method: " +value);
            AddingNumberByFive(ref value);
            Console.WriteLine("Variable value after calling the method: " + value);
            Console.WriteLine("enter to exit");
            Console.ReadLine();
        }
        public static void AddingNumberByFive(ref int value)
        {
            value = value + value;
            Console.WriteLine("Variable value inside the method : " + value);
        }
    }
}
