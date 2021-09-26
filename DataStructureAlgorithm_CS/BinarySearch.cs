using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm_CS
{/// <summary>
/// Template for finding a word from a given list using Binary serach
/// </summary>
    class BinarySearch
    {
        //Method for taking user input as word to find in the list
        public void UserInput()
        {
            Console.WriteLine("Enter a word to search in the list");
            string input = Console.ReadLine();
            //calling binary search word by putting input as parameter to that method
            BinarySearchWord(input);  
        }

        //Create method for Binaryserach for a word in a given array of list
        public void BinarySearchWord(string input)
        {
            //array of list of fruits 
            string[] list = { "beans", "apple", "banana", "carrot", "pineapple", "mango" };
            //Using Array sort to sort the elements in the list
            Array.Sort(list);
            //Declaring local variables
            int start = 0;
            //Initializing end as list.Length-1 means as array index start from 0  
            int end = list.Length - 1;
            bool foundItem = false;
            //Condition of if will run when length of the array greater than and equal to 1
            if (list.Length >= 1)
            {
                //Initialize mid position of array
                int mid = start + end / 2;
                //declaring a variable res, and use CompareTo method to check between input and array words
                //Tolower() method to convert the string to lower case 
                int res = input.ToLower().CompareTo(list[mid]);
                //If condition to check res==0,according to compared method if two strings same it gives res as 0
                if (res == 0)
                {
                    //This means the given word is at the mid position,so the given word is found
                    foundItem = true;
                }
                //From the compareTo method res=1, this condition will run
                if (res > 0)
                {
                    //The start position will update as next index after mid
                    start = mid + 1;
                }
                else
                {
                    //The end position will update as the index before mid
                    end = mid - 1;
                }
            }

            //When the word is not present in the list, this will execute and give mesage
            if (foundItem != true)
            {
                Console.WriteLine("{0} is not present in list", input);
            }
            else
            {
                Console.WriteLine("{0} is present in list", input);
            } 
        }    
    }
}
