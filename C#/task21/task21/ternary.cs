using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    internal class ternary
    {
		public static void Main()
		{
			int number = 2;
			bool isEven;

			isEven = (number % 2 == 0) ? true : false;
			Console.WriteLine(isEven);
		}
	}
}
