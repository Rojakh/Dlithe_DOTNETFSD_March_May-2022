using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    internal class trainee_Details
    {
        public static void Main()
        {
            int TID;
            string TName;
            string TDes;
            string TAddr;
            Console.WriteLine("Enter the Trainee ID");
            TID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Trainee Name and Designation");
            TName = Console.ReadLine();
            TDes = Console.ReadLine();
            Console.WriteLine($"The Trainee ID is {TID}.\nTrainee Name is {TName}.\nTrainee Designation is {TDes}");

        }
    }


}


