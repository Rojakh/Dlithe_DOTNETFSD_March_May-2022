using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_22
{
    internal class string_builder
    {
        public static void Main()
        {
            //creation of StringBuilder
            StringBuilder sb = new StringBuilder("Hello", 50);

            //Append method
            sb.Append("Hello ");
            sb.AppendLine("World!");
            sb.AppendLine("Hello C#");
            Console.WriteLine(sb);

            //Insert method
            sb.Insert(10, "roja");
            Console.WriteLine(sb);

            //Remove method
            sb.Remove(5, 7);
            Console.WriteLine(sb);

            //Replace method
            sb.Replace("Hello", "haiii");
            Console.WriteLine(sb);
        }
    }
}
