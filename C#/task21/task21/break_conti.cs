using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    internal class break_conti
    {
        static void Main()

        {



            int i;

            for (i = 0; i <= 10; i++)

            {

                if (i == 5)

                    continue;



                if (i == 8)

                    break;

                Console.WriteLine("value is" + i);

            }

            Console.ReadLine();
        }
    }
}
