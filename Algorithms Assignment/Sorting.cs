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

            //writes every 10th value in the ascending list
            Console.WriteLine("Every 10th number in ascending order from the chosen array: ");
            countTenth(textToSort);
            return textToSort;
        }

        public void BubbleSortDescending(int[] textToSort)
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
            //writes every 10th value in the descending list
            Console.WriteLine("Every 10th number in descending order from the chosen array: ");
            countTenth(textToSort);

        }
        public void countTenth(int[] textToSort)
        {
            int count = 0;

            //every 10th item is printed
            foreach (int item in textToSort)
            {
                if (count == 10)
                {
                    Console.WriteLine(item);
                    count = 0;
                }
                else
                {
                    count++;
                }
            }
        }

        public void countFifty(int[] textToSort)
        {
            int count = 0;

            //every 50th item is printed
            foreach (int item in textToSort)
            {
                if (count == 50)
                {
                    Console.WriteLine(item);
                    count = 0;
                }
                else
                {
                    count++;
                }
            }
        }
    }
}
