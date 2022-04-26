using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Algorithms_Assignment
{
    class BubbleSort
    {
        Steps steps = new Steps();
        //sorts small data into descending order
        public int[] bubbleSort(int[] textToSort)
        {
            int steps = 0;
            int temp;
            for (int i = 0; i < textToSort.Length - 1; i++)
            {
                for (int j = 0; j < textToSort.Length - 1 - i; j++)
                {
                    //if not in the correct order, it switches the places of i and j
                    if (textToSort[j] < textToSort[j + 1])
                    {
                        steps++;
                        temp = textToSort[j];
                        textToSort[j] = textToSort[j + 1];
                        textToSort[j + 1] = temp;
                    }
                }
            }
            Steps.stepsTemp += steps;
            return textToSort;
        }
    }
}
