using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_26
{
    internal class Mul_catch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple catch");
            int a, b, c;
            Console.WriteLine("ENTER ANY TWO NUBERS");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }
            catch (DivideByZeroException dbe)
            {
                Console.WriteLine("DivideByZeroException occurs");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("hello this is finally block");
            }
            Console.ReadKey();
        }
    }
}

    

