using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_24
{
    public abstract class Plan
    {
        protected double rate;
        public abstract void getRate();
        public void calculation(int units)
        {
            Console.Write("BILL AMOUNT FOR " + units + " UNITS is: Rs.");
            Console.WriteLine(rate * units);
        }
    }
    class VillagePlan : Plan
    {
        public override void getRate()
        {
            rate = 5.00;
        }
    }
    class CityPlan : Plan
    {
        public override void getRate()
        {
            rate = 2.50;
        }
    }
    internal class Abstraction
    {
        static void Main()
        {
            Plan p;
            Console.WriteLine("VILLAGE CONNECTION");
            p = new VillagePlan();
            p.getRate();
            p.calculation(550);
            Console.WriteLine("CITY CONNECTION");
            p = new CityPlan();
            p.getRate();
            p.calculation(250);
            Console.ReadKey();
        }
    }
}

