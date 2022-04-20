using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_23
{
    internal class param_constr
    {
        public static void Main()
        {
            Console.WriteLine("parameterized constructor");
            Coordinate point = new Coordinate(50, 20);

            Console.WriteLine(point.x); //output: 50  
            Console.WriteLine(point.y); //output: 20  
        }
    }

    struct Coordinate
    {
        public int x;
        public int y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
