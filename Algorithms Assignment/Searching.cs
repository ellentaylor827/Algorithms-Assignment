using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assignment
{
    class Searching
    {
        public bool foundKey = false;
        private int midNum = 0;

        public void BinarySearch(int[] textToSearch, int key)
        {
            int minNum = 0;
            int maxNum = textToSearch.Length - 1;

            while (minNum <= maxNum)
            {
                midNum = (minNum + maxNum) / 2;
                if (key == textToSearch[midNum])
                {
                    //return midNum;
                    foundKey = true;
                    break;
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

            if (foundKey == true)
            {
                Console.WriteLine("Key found in position" + textToSearch[midNum]);
            }
            else
            {
                Console.WriteLine("Key not found");
            }

        }
    }
}
