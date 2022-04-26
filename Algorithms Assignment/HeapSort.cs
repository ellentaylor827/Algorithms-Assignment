using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assignment
{
    class HeapSort
    {
        Steps steps = new Steps();
        //sorts large data into ascending order
        public int[] heapSort(int[] textToSort)
        {
            int length = textToSort.Length;

            //builds the heap
            for (int i = (length / 2) - 1; i >= 0; i--)
                makeHeap(textToSort, length, i);

            //takes elements from the heap
            for (int i = length - 1; i > 0; i--)
            {
                int temp = textToSort[0];
                textToSort[0] = textToSort[i];
                textToSort[i] = temp;

                makeHeap(textToSort, i, 0);
            }

            return textToSort;
        }
        public void makeHeap(int[] textToSort, int length, int i)
        {
            int largestValue = i; //the root value
            int right = 2 * i + 2;
            int left = 2 * i + 1;

            // if right is larger than current root
            if (right < length && textToSort[right] > textToSort[largestValue])
                largestValue = right;

            //if left is larger than current root
            if (left < length && textToSort[left] > textToSort[largestValue])
                largestValue = left;

            //if the biggest number isn't the root
            if (largestValue != i)
            {
                int temp = textToSort[i];
                textToSort[i] = textToSort[largestValue];
                textToSort[largestValue] = temp;

                //repeats until the largest value is the root value
                makeHeap(textToSort, length, largestValue);
            }

        }
    }
}
