using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_27
{
    internal class passbyvalue
    {
        public static void Main()
        {
            int X = 100;
            Console.WriteLine("Variable value before calling the method: " +X);
            AddingNumberByFive(X);
            Console.WriteLine("Variable value after calling the method: " +X);
            Console.WriteLine("enter to exit");
            Console.ReadLine();
        }
        public static void AddingNumberByFive(int number)
        {
            number = number + 5;
            Console.WriteLine("Variable value inside the method : " +number);
        }

       
    }
}


