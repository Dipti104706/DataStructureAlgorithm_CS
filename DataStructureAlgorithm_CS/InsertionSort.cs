using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm_CS
{/// <summary>
/// Template for sorting a list by using insertion sort
/// </summary>
    class InsertionSort
    {
        //Method for taking user input as list of word to sort them
        public void UserInput()
        {
            string[] list = { "beans", "apple", "pig", "pineapple", "mango" };
            InsertionSortList(list);
        }

        //Method for sorting of the given array of elements and display the sorted array
        public void InsertionSortList(string[] list)
        {
            for (int i = 1; i < list.Count(); i++)
            {
                string word = list[i];
                int j = i - 1;
                while (j >= 0 && list[j].CompareTo(word) > 0)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = word;
            }
            Console.WriteLine("The sorted array is:");
            Display(list);
        }
        //method for print the list after sorting
        public void Display(string[] list)
        {
            foreach (var element in list)
            {
                Console.Write(element + "\n");
            }
        }
    }
}
