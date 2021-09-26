using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm_CS
{/// <summary>
/// finds the number guessed by user by using binary search
/// </summary>
    class FindNumber
    {
        //instance variables
        int start = 1, end = 100, yourNum = 0;
        bool foundNum = false;
       
        //method for ask user to think a number, calculate to do binary search to find the number
        public void UserThinkNumber()
        {
            Console.WriteLine("Think of a number between 1 and 100");
            while (start <= end && foundNum == false)
            {
                //Binary search concept 
                int mid = start + (end - start) / 2;
                //Pass parameter to checknumber method
                CheckNumber(mid);
            }
            //If number is found then print 
            if (foundNum == true)
            {
                Console.WriteLine("Your number is {0}", yourNum);
            }
        }

        //Method to check number is middle or less than or greater than by taking user input
        public void CheckNumber(int mid)
        {
            Console.WriteLine("Enter your choice: \n1-Is found number is your number {0}?\n 2-Is your number is less than {0}? \n 3-Is your number is greater than {0}?", mid);
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //User number is at the middle position so print that
                    yourNum = mid;
                    foundNum = true;
                    break;
                case 2:
                    //If number is less than middle, it will update end position
                    end = mid - 1;
                    break;
                case 3:
                    //If number is greater than middle it will update start position
                    start = mid + 1;
                    break;
                default:
                    Console.WriteLine("Please provide a valid input");
                    break;
            }
        }
    }
}
