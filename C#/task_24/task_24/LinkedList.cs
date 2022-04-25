using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_24
{
    internal class LinkedListdemo
    {
        public static void Main()
        {
            LinkedList<String> name= new LinkedList<String>();

            name.AddLast("roja");
            name.AddLast("ram");
            name.AddLast("ragini");
            name.AddLast("ramya");
            Console.WriteLine("using addfirst keyword:");
            name.AddFirst("sowmya");
            name.AddFirst("sagar");
            name.AddFirst("yamuna");
            name.AddFirst("deepa");


            Console.WriteLine("student names are:");
            foreach(String s in name)
            {
                Console.WriteLine(s);
            }

            
           
             

        }
    }
}
