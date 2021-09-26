using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm_CS
{/// <summary>
/// Template to check anagram of two strings by comparing them
/// </summary>
    class Anagram
    {
        //Method for comparing two given strings
        public void CompareString()
        {
            //Taking user input 
            Console.WriteLine("Enter first string");
            string first = Console.ReadLine();
            Console.WriteLine("Enter first string");
            string second= Console.ReadLine();
            //Store the string in the char array after converting to lower case
            char[] ch1 = first.ToLower().ToCharArray();
            char[] ch2 = second.ToLower().ToCharArray();
            //Sort the characters in the char array
            Array.Sort(ch1);
            //reating object of string by passing the char array to it
            string String1 = new string(ch1);
            Array.Sort(ch2);
            string String2 = new string(ch2);
            //Condition to check if strings are anagram or not
            if (String1 == String2)
            {
                Console.WriteLine("Given strings are anagram");

            }
            else
            {
                Console.WriteLine("Given strings are not anagram");
            }
        }
    }
}
