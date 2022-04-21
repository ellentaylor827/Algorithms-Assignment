using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assignment
{
    //sorts large data into descending
    class MergeSort
    {
        public int[] mergeSort(int[] textToSort, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                mergeSort(textToSort, left, middle);
                mergeSort(textToSort, middle + 1, right);

                merge(textToSort, left, middle, right);
            }

            return textToSort;
        }

        public void merge(int[] textToSort, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(textToSort, left, leftArray, 0, middle - left + 1);
            Array.Copy(textToSort, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int z = left; z < right + 1; z++)
            {
                if (i == leftArray.Length)
                {
                    textToSort[z] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    textToSort[z] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] >= rightArray[j])
                {
                    textToSort[z] = leftArray[i];
                    i++;
                }
                else
                {
                    textToSort[z] = rightArray[j];
                    j++;
                }
            }
        }
       
    }
}
