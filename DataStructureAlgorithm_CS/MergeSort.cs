using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm_CS
{//Template for sort list of elements by merge sort 
    class MergeSort
    {
        //Method for taking user input as a list of integer to sort them
        public void UserInput()
        {
            int[] list = { 25, 1, 5, 9, 8, 75, 65, 85 };
            Sort(list,0,list.Length-1);
            Console.WriteLine("The sorted array is:");
            Display(list);
        }
        //Method to sort the array by finding its middle index 
        //Divide the list by two halves :left and right,indivisually sort them and merge them
        public void Sort(int[] list, int start, int end)
        {
            if (start < end)
            {
                //Find the middle position
                int mid = start + (end - start) / 2;
                //Sort two halves
                Sort(list, start, mid);
                Sort(list, mid + 1, end);
                //merge the sorted halves
                Merge(list, start, mid, end);
            }
        }

        //Method to merge to halves of the array after sorting
        public void Merge(int[] list, int low, int middle, int high)
        {
            //Finding sizes of two subarrays
            int leftHalf = middle - low + 1;
            int rightHalf = high - middle;
            //create left and right array
            int[] leftArray = new int[leftHalf];
            int[] rightArray = new int[rightHalf];
            int i, j;
            //Adding data to Leftarray and rightarray
            for ( i = 0; i < leftHalf; ++i)
            {
                leftArray[i] = list[low + i];
            }
            for ( j = 0; j < rightHalf; ++j)
            {
                rightArray[j] = list[middle + 1 + j];
            }
            //initial index of two subarrays
            i = 0;
            j = 0;
            //Initial index of merged subarray
            int k = low;
            while (i < leftHalf && j < rightHalf)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    list[k] = leftArray[i];
                    i++;
                }
                else
                {
                    list[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            //Add remaining element of Left array, if any present
            while (i < leftHalf)
            {
                list[k] = leftArray[i];
                i++;
                k++;
            }
            //Add remaining element of Right array, if any present
            while (j < rightHalf)
            {
                list[k] = rightArray[j];
                j++;
                k++;
            }
        }
        
        //Display for printing sorted array
        public void Display(int[] list)
        {
            foreach (var element in list)
            {
                Console.Write(element + " ");
            }
        }
    }
}
