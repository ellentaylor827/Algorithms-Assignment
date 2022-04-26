using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assignment
{
    class QuickSort
    {
        Steps steps = new Steps();
        //sorts small data into ascending
        public int[] quickSort(int[] textToSort, int left, int right)
        {
            int steps = 0;
            if (left < right)
            {
                int pivot = partitionArray(textToSort, left, right);

                if (pivot > 1)
                {
                    quickSort(textToSort, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(textToSort, pivot + 1, right);
                }
            }

            return textToSort;

        }
        public int partitionArray(int[] textToSort, int start, int end)
        {
            //used to locate the pivot point

            int temp;
            int right = textToSort[end];
            int left = start - 1;

            for (int i = start; i <= end - 1; i++)
            {
                //if in the wrong order, it swaps the places
                if (textToSort[i] <= right)
                {
                    left++;

                    temp = textToSort[left];
                    textToSort[left] = textToSort[i];
                    textToSort[i] = temp;
                }
            }

            temp = textToSort[left + 1];
            textToSort[left + 1] = textToSort[end];
            textToSort[end] = temp;

            return (left + 1);
        }
    }
}

    

