using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_26
{
    internal class dict_hash
    {
        public static void Main()
        {
            Console.WriteLine("This is for dictionary ");
            Dictionary<Int16, string> StudentNames = new Dictionary<Int16, string>();
            StudentNames.Add(101, "roja");
            StudentNames.Add(102, "shanthi");
            StudentNames.Add(103, "ramya");
            StudentNames.Add(104, "aarathi");
            StudentNames.Add(105, "bharath");

            // Get and display keys  

            Dictionary<Int16, string>.KeyCollection keys = StudentNames.Keys;
            foreach (Int16 key in keys)
            {
                Console.WriteLine("Keys are: {0}", key);
            }
            Dictionary<Int16, string>.ValueCollection values = StudentNames.Values;
            foreach (string value in values)
            {
                Console.WriteLine("Values are: {0}\n", value);
            }
            Console.WriteLine("This is for Hashtable to storing key value pairs\n");
            Hashtable employee = new Hashtable();

            // Adding key/value pair
            // in the hashtable
            // Using Add() method
            employee.Add("INFOSYS", "Ram");
            employee.Add("HCl", "Lalitha");
            employee.Add("DATALYZER", "Sandhya");
            employee.Add("MPHASIS", "Sagar");

            Console.WriteLine("Key and Value pairs from employee:\n");

            foreach (DictionaryEntry de in employee)
            {
                Console.WriteLine("{0} and {1} ", de.Key, de.Value);
            }
        }

    }
}
