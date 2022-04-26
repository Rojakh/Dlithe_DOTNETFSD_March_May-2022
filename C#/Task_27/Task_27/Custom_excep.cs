using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_27
{
    internal class Custom_excep
    { 
            public static void name()
            {
                string[] names = { "chaithra", "swathi" };
                var result = new Regex(@".ha", RegexOptions.Compiled);
                foreach (string word in names)
                {
                    if (result.IsMatch(word))
                    {
                        Console.WriteLine(word + "   Valid Name");
                    }
                    else
                    {
                        Console.WriteLine(word + "   Invalid Name");
                    }
                }

            }
            public static void MobileValidation()
            {
                string[] mobile = { "2545414854", "62656516221" };
                foreach (string m in mobile)
                {
                    Console.WriteLine(m);
                    Console.WriteLine(checkMobile(m));
                }
            }
            public static bool checkMobile(string mobile)
            {
                string mregexp = @"(^[0-9]{10}$)";
                Regex r = new Regex(mregexp);
                if (r.IsMatch(mobile))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static void Main()
            {


                name();
                MobileValidation();
                Console.ReadLine();
            }
        }

    }

