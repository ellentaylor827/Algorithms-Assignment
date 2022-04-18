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
                    //returns ++midNum as it starts from an index of 0
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

        public List<int> linearSearch(int[] textToSearch, int key, int checkPosition)
        {
            List<int> foundPositions = new List<int>();
            bool startPosition = false;

            //finds the first position of the key
            while (startPosition == false)
            {
                if ( textToSearch[checkPosition] == key)
                {
                    startPosition = true;
                }
                else
                {
                    --checkPosition;
                }
            }
            
            //adds positions of items until all positions of the key are found
            while (textToSearch[checkPosition] == key)
            {
                foundPositions.Add(checkPosition);
                ++checkPosition;
            }
            return foundPositions;
        }

    }
}
