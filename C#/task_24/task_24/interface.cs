using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_24
{
    internal class area_peri
    {
        interface area
        {
            double res(int w, int h);
            
        }
        interface perimeter
        {
            int res2(int a, int b, int c);
        }
        class Calculation : area , perimeter
        {
            public double result1;
            public double res(int w, int h)
            {
                return result1 =0.5 * w * h;
            }
            public int result2;
            public int res2(int a, int b,int c)
            {
                return result2 = a + b + c;
            }
           internal class Program
            {
                static void Main()
                {
                    Calculation c = new Calculation();
                    c.res(8, 2);
                    c.res2(20, 18, 45);
                    Console.WriteLine("Area of triangle is " + c.result1);
                    Console.WriteLine("Perimeter of triangle is " + c.result2);
                }
            }
        }
    }
}
