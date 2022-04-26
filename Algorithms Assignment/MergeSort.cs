using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assignment
{
    //sorts large data into descending
    class MergeSort
    {
        public static int steps = 0;
        public int[] mergeSort(int[] textToSort, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                mergeSort(textToSort, left, middle);
                mergeSort(textToSort, middle + 1, right);

                merge(textToSort, left, middle, right);
            }
            Steps.stepsTemp = steps;
            return textToSort;
        }

        public void merge(int[] textToSort, int left, int middle, int right)
        {
            //creates left and right arrays
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(textToSort, left, leftArray, 0, middle - left + 1);
            Array.Copy(textToSort, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int z = left; z < right + 1; z++)
            {
                steps++;
                //if left array is full, it adds to the right array
                if (i == leftArray.Length)
                {
                    textToSort[z] = rightArray[j];
                    j++;
                }
                //if right array is full, it adds to the left array
                else if (j == rightArray.Length)
                {
                    textToSort[z] = leftArray[i];
                    i++;
                }
                //if left is bigger than right, it adds to the left array
                else if (leftArray[i] >= rightArray[j])
                {
                    textToSort[z] = leftArray[i];
                    i++;
                }
                else
                //if right is bigger than left, it adds to the right array
                {
                    textToSort[z] = rightArray[j];
                    j++;
                }
            }
        }
       
    }
}
