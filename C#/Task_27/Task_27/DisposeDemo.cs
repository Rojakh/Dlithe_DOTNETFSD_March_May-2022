using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task_27
{
    class dp : IDisposable
    {
       
       
        public void Dispose()
        {
            Console.WriteLine("this is dispose method()");
        }
         
       
       }
    class addition
    {
        public addition()
        {
            int a = 20, b = 10,c=a+b;
            Console.WriteLine("{0} + {1} = {2}", a, b, c);
            
        }
        ~addition()
        {
            Console.WriteLine("Im destructor");
        }


    }
    class demo
    {
        public static void Main()
        {
            addition a = new addition();
            dp d=new dp();
            d.Dispose();

        }
    }
    }

