using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_24
{
	//base class

	class GradFather
	{

		public void land()
		{
			Console.WriteLine("GradFather's land");
		}

	}

	class Father : GradFather
	{

		public void home()
		{
			Console.WriteLine("Father's home");
		}

		public void Car()
		{
			Console.WriteLine("Father's Car");
		}
	}

	// Inherit /derived / extends
	class Son : Father
	{

		// son constructor
		public Son()
		{
			Console.WriteLine("Son...");
		}

		public void mobile()
		{
			Console.WriteLine("Son's mobile");
		}
	}

	class Daughter : Father
	{

		// Daughter constructor
		public Daughter()
		{
			Console.WriteLine("Daughter...");
		}

		public void purse()
		{
			Console.WriteLine("Daughter's purse");
		}
	}

	public class HybridInheritance
	{

		public static void Main(String[] args)
		{

			// Son object
			Son s = new Son();
			s.land();// Grand father method
			s.Car(); // Father method
			s.home();// Father method
			s.mobile();// son method

			// Daughter object
			Daughter d = new Daughter();
			d.land();// Grand father method
			d.Car(); // Father method
			d.home();// Father method
			d.purse();// son method

		}

	}

	internal class hybrid_inheritance
    {
    }
}
