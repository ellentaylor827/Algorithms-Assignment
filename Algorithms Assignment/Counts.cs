using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assignment
{
    class Counts
    {
        //contains methods to print every10th/50th values in an array

        public void countTenth(int[] textToSort)
        {
            Console.WriteLine("every 10th value in this sorted array: ");
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
            Console.WriteLine("every 50th value in this sorted array: ");
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
