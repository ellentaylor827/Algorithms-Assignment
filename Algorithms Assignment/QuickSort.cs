using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assignment
{
    class QuickSort
    {
        //sorts small data into ascending
        public int[] quickSort(int[] textToSort, int left, int right)
        {
            if (left < right)
            {
                int pivot = partition(textToSort, left, right);
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
        public int partition(int[] textToSort, int start, int end)
        {
            int temp;
            int right = textToSort[end];
            int left = start - 1;

            for (int i = start; i <= end - 1; i++)
            {
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
            return left + 1;
        }
    }
}

    

