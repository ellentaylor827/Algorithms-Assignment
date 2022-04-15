using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Algorithms_Assignment
{
    class Sorting
    {
        public int[] BubbleSortAscending(int[] textToSort)
        {
            int temp;
            for (int i = 0; i < textToSort.Length - 1; i++)
            {
                for (int j = 0; j < textToSort.Length - 1 - i; j++)
                {
                    if (textToSort[j] > textToSort[j + 1])
                    {
                        temp = textToSort[j];
                        textToSort[j] = textToSort[j + 1];
                        textToSort[j + 1] = temp;
                    }
                }
            }
            return textToSort;
        }
        public int[] BubbleSortDescending(int[] textToSort)
        {
            int temp;
            for (int i = 0; i < textToSort.Length - 1; i++)
            {
                for (int j = 0; j < textToSort.Length - 1 - i; j++)
                {
                    if (textToSort[j] < textToSort[j + 1])
                    {
                        temp = textToSort[j];
                        textToSort[j] = textToSort[j + 1];
                        textToSort[j + 1] = temp;
                    }
                }
            }
            return textToSort;
        }
    }
}
