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

            while (minNum <= maxNum)
            {
                int midNum = (minNum + maxNum) / 2;
                int searchVal = textToSearch[midNum];

                if (key == searchVal)
                {
                    return ++midNum;
                }
                else if (key > searchVal)
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
