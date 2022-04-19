using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_22
{
    internal class str_bui
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder("Roja",20);

            //append method

            sb.Append("welcome");
            Console.WriteLine(sb);

            //insert method

            sb.Insert(3, "C#");
            Console.WriteLine(sb);

            //Remove method

            sb.Remove(3, 5);
            Console.WriteLine(sb);

         
        }
    }
}
