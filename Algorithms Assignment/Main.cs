using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms_Assignment
{
    public class Program
    {
        public static int[] textToSort;
        public static int key;
        public static bool choseShort; //checks whether the user selected a long or short array
        public static int[] ascendingText;
        public static int[] descendingText;
        public static int findKey;

        static void Main()
        {
            //puts all text files into arrays
            string[] short1 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_1_256.txt");
            string[] short2 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_2_256.txt");
            string[] short3 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_3_256.txt");
            string[] long1 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_1_2048.txt");
            string[] long2 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_2_2048.txt");
            string[] long3 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_3_2048.txt");

            //converts all items in the arrays to int values
            int[] text1 = Array.ConvertAll(short1, int.Parse);
            int[] text2 = Array.ConvertAll(short2, int.Parse);
            int[] text3 = Array.ConvertAll(short3, int.Parse);
            int[] text4 = Array.ConvertAll(long1, int.Parse);
            int[] text5 = Array.ConvertAll(long2, int.Parse);
            int[] text6 = Array.ConvertAll(long3, int.Parse);


            //allows the user to choose what array they want to read from
            string userChoice;
            bool valid = false; //checks if the array selected is valid
            while (valid == false)
            {
                Console.WriteLine("Which array do you select: short(1, 2, 3), long(4, 5, 6), mergeShort or mergeLong?");
                userChoice = Console.ReadLine();
                //checks if the user input is valid and checks if they chose a short or long array
                if (userChoice == "1")
                {
                    textToSort = text1;
                    valid = true;
                    choseShort = true;
                }
                else if (userChoice == "2")
                {
                    textToSort = text2;
                    valid = true;
                    choseShort = true;
                }
                else if (userChoice == "3")
                {
                    textToSort = text3;
                    valid = true;
                    choseShort = true;
                }
                else if (userChoice == "4")
                {
                    textToSort = text4;
                    valid = true;
                    choseShort = false;
                }
                else if (userChoice == "5")
                {
                    textToSort = text5;
                    valid = true;
                    choseShort = false;
                }
                else if (userChoice == "6")
                {
                    textToSort = text5;
                    valid = true;
                    choseShort = false;
                }
                else if (userChoice == "mergeShort")
                {
                    textToSort = (int[])text1.Concat(text3);
                    valid = true;
                    choseShort = true;
                }
                else if (userChoice == "mergeLong")
                {
                    textToSort = (int[])text1.Concat(text3);
                    valid = true;
                    choseShort = false;
                }
                else
                {
                    Console.WriteLine("invalid choice, please input again");
                }
            }

            BubbleSort sortBubble = new BubbleSort();
            QuickSort sortQuick = new QuickSort();
            Counts countClass = new Counts();
            HeapSort sortHeap = new HeapSort();
            MergeSort sortMerge = new MergeSort();

            if (choseShort == true)
            {

                //sorts in descending and ascending order (short arrays)
                descendingText = sortBubble.bubbleSort(textToSort);
                countClass.countTenth(descendingText, 1);
                ascendingText = sortQuick.quickSort(textToSort, 0, textToSort.Length - 1);
                countClass.countTenth(ascendingText, 0);
                
            }
            else
            {
                //sorts in descending and ascending order (long arrays)
                descendingText = sortMerge.mergeSort(textToSort, 0, textToSort.Length - 1);
                countClass.countFifty(descendingText, 1);
                ascendingText = sortHeap.heapSort(textToSort);
                countClass.countFifty(ascendingText, 0);
                
            }

            //gets user to input a key and checks if it is a valid input
            bool keyValid = false;
            while (keyValid == false)
            {
                Console.WriteLine("input a number to search for");
                string userKey = Console.ReadLine();
                if (Int32.Parse(userKey) < 0) //ensures the input isn't negative
                {
                    Console.WriteLine("Input must be greater than 0");
                }
                else
                {
                    try
                    {
                        //checks if the input is a number
                        key = Int32.Parse(userKey);
                        keyValid = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("not a valid key");
                    }
                }
                
            }

            //searchs for key to check it exists in the list
            Searching searchText = new Searching();
            if (choseShort == true)
            {
                findKey = searchText.linearSearch(ascendingText, key);
            }
            else
            {
                findKey = searchText.binarySearch(ascendingText, key);
            }
            

            //checks if a number was or wasn't found
            if (findKey != -1)
            {
                //number is found
                //finds all positions with that number
                List<int> findAllPositions = searchText.findKeyPositions(ascendingText, key, findKey);
                Console.WriteLine("Key found in positions:");
                foreach (int position in findAllPositions)
                {
                    Console.WriteLine(position);
                }
            }
            else
            {
                //number isn't found
                Console.WriteLine("key not found");

                List<int> closestHigher = new List<int>();
                List<int> closestLower = new List<int>();

                //finds the next higher/lower value in the array
                closestHigher = searchText.findClosestHigher(ascendingText, key);
                closestLower = searchText.findClosestLower(ascendingText, key);

                //checks if numbers have been found higher/lower
                if (closestHigher[0] == -1)
                {
                    Console.WriteLine("No higher value in the list");
                }
                else
                {
                    Console.WriteLine("Next highest value: " + closestHigher[0]);
                    Console.WriteLine("Position of next highest value: " + closestHigher[1]);
                }

                if (closestLower[0] == -1)
                {
                    Console.WriteLine("No lower value in the list");
                }
                else
                {
                    Console.WriteLine("Next lower value: " + closestLower[0]);
                    Console.WriteLine("Position of next lower value: " + closestLower[1]);
                }

            }
        }
    }

}