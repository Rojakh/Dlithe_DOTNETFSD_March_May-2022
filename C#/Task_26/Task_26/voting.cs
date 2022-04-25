using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_26
{
    internal class voting
    {
        public class InvalidAgeException : Exception
        {
            public InvalidAgeException(String message)
                : base(message)
            {

            }
        }
        public static void Main()
            {
                int age;
                Console.Write("\n\n");
                Console.Write("Check here for a eligible for voting:\n");
                Console.Write("----------------------------------------");
                Console.Write("\n\n");


                Console.Write("Enter your age? : ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
            else
                    Console.Write("Congratulation! You are eligible for voting.\n\n");
            }
        }
    }


