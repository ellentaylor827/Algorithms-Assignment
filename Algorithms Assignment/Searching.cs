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

            Console.WriteLine("key = " + key);

            while (minNum <= maxNum)
            {
                int midNum = (minNum + maxNum) / 2;
                Console.WriteLine("mid = " + midNum);
                Console.WriteLine("key = " + key);

                if (key == textToSearch[midNum])
                {
                    return ++midNum;
                }
                else if (key < textToSearch[midNum])
                {
                    maxNum = midNum - 1;
                }
                else
                {
                    minNum = midNum + 1;
                }
            }
            return (-1);
        }
    }
}
