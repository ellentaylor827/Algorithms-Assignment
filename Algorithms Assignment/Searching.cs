using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assignment
{
    class Searching
    {
        public int BinarySearch(int[] textToSearch, int key)
        {
            int minNum = 0;
            int maxNum = textToSearch.Length - 1;
            foreach (int line in textToSearch)
                Console.WriteLine(line);
            Console.WriteLine("key = " + key);

            while (minNum <= maxNum)
            {
                int midNum = (minNum + maxNum) / 2;
                Console.WriteLine("mid = " + midNum);
                Console.WriteLine("key = " + key);
                int searchVal = textToSearch[midNum];
                Console.WriteLine(searchVal);

                if (key == searchVal)
                {
                    return ++midNum;
                }
                else if (key > searchVal)
                {
                    maxNum = midNum - 1;
                    Console.WriteLine("greater");
                }
                else
                {
                    minNum = midNum + 1;
                    Console.WriteLine("lesser");
                }
            }
            return (-1);
        }

    }
}
