﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assignment
{
    class Searching
    {
        public static int midNum;
        public static int searchVal;

        //used for searching small arrays
        public int linearSearch(int[] textToSearch, int key)
        {
            for (int i = 0; i < textToSearch.Length - 1; i++)
            {
                if (textToSearch[i] == key)
                {
                    return i;
                }
            }
            return (-1);
        }

        //used for searching large arrays
        public int binarySearch(int[] textToSearch, int key)
        {
            int minNum = 0;
            int maxNum = textToSearch.Length - 1;

            while (minNum <= maxNum)
            {
                midNum = (minNum + maxNum) / 2;
                searchVal = textToSearch[midNum];
                //Console.WriteLine(searchVal);

                if (key == searchVal)
                {
                    //returns ++midNum as it starts from an index of 0
                    return ++midNum;
                }
                else if (key < searchVal)
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

        //used for finding all positions in which the key occurs in the array
        public List<int> findKeyPositions(int[] textToSearch, int key, int checkPosition)
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

        public List<int> findClosestLower(int[] textToSearch, int key)
        {
            List<int> closestLower = new List<int>();
            bool inListLower = false;

            //finds the value in the list below the key
            while (inListLower == false && key > 0)
            {
                //finds the next number below it
                --key;

                int findLower = binarySearch(textToSearch, key); //searches for the new key
                if (findLower != -1)
                {
                    inListLower = true;
                    closestLower.Add(key);
                    closestLower.Add(textToSearch[key]);
                }
            }
            //if nothing has been added to the array, it means there is nothing lower than the key
            if (closestLower.Count == 0)
            {
                closestLower.Add(-1);
            }
            
            return (closestLower);
            
        }

        public List<int> findClosestHigher(int[] textToSearch, int key)
        {
            List<int> closestHigher = new List<int>();
            bool inListHigher = false;

            //finds the value in the list above the key
            while (inListHigher == false && key < textToSearch.Length - 1 && key >=0)
            {
                //finds the next number above it
                ++key;

                int findLower = binarySearch(textToSearch, key); //searches for the new key
                if (findLower != -1)
                {
                    inListHigher = true;
                    closestHigher.Add(key);
                    closestHigher.Add(textToSearch[key]);
                }
            }
            //if nothing has been added to the array, it means there is nothing higher than the key
            if (closestHigher.Count == 0)
            {
                closestHigher.Add(-1);
            }

            return (closestHigher);
        }

    }
}
