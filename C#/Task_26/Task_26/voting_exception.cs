using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_26
{
    internal class voting_exception
    {
        public class VotingEligibilityException : Exception
        {

            public VotingEligibilityException(String message) : base(message)
            {
            }
        }
        public class Voting
        {
            static void validate(int age)
            {

                if (age < 18)
                {
                    throw new VotingEligibilityException("\nException:You Are Not Eligible\n\n");

                }
                else
                {
                    Console.WriteLine("\nYou Are Elegible\n");
                }
            }
            public static void Main()
            {
                string name;
                int id, age;
                Console.WriteLine("\nVoting Process\n");
                try
                {
                    Console.Write("Enter your voter id:\t");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter your name:\t");
                    name = Console.ReadLine();
                    Console.Write("\nEnter your age:\t");
                    age = Convert.ToInt32(Console.ReadLine());
                    validate(age);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Console.WriteLine("voting successfull");
                }
            }
        }
    }
}
   