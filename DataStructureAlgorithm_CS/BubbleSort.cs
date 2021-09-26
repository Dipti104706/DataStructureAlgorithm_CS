using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm_CS
{/// <summary>
/// Template for sorting a list by using bubble sort
/// </summary>
    class BubbleSort
    {
        //Method for taking user input as a list of integer to sort them
        public void UserInput()
        {
            int[] list = { 25, 1, 5, 9, 8, 75, 65, 8 };
            SortList(list);
        }

        //Method for sorting of the given array of elements 
        public void SortList(int[] list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = i; j < list.Count(); j++)
                    if (list[i] > list[j])
                    {
                        int temp =list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
            }
            Console.WriteLine("The sorted array is:");
            display(list);
        }

        //method for print the list after sorting
        public void display(int[] list)
        {
            foreach (var element in list)
            {
                Console.Write(element + "\n");
            }
        }
    }
}
