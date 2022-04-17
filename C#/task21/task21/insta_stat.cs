using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    internal class cycle
    {
    
        
            //Static method or class method
            public static void run()
            {
                Console.WriteLine("This is the static method");
            }

            //instanse method
            public void engine()
            {
                Console.WriteLine("This is the instance method");
            }

        }


        class Program
        {
            static void Main(string[] args)
            {
                //Call static method by class name 
                cycle.run();


                //Call non-static method. call method by object
                cycle c = new cycle();
                c.engine();
            }
        }
}

