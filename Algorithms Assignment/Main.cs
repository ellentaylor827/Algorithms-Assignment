using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Algorithms_Assignment
{
    public class Program
    {
        public static int[] textToSort;
        public static int key;
        static void Main()
        {
            string[] share1 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_1_256.txt");
            string[] share2 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_2_256.txt");
            string[] share3 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_3_256.txt");

            //converts all items to int values
            int[] text1 = Array.ConvertAll(share1, int.Parse);
            int[] text2 = Array.ConvertAll(share2, int.Parse);
            int[] text3 = Array.ConvertAll(share3, int.Parse);

            //allows the user to choose what array they want to read from
            string userChoice;
            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine("Which array do you select: 1, 2, 3?");
                userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    textToSort = text1;
                    valid = true;
                }
                else if (userChoice == "2")
                {
                    textToSort = text2;
                    valid = true;
                }
                else if (userChoice == "3")
                {
                    textToSort = text3;
                    valid = true;
                }
                else
                {
                    Console.WriteLine("invalid choice, please input again");
                }
            }

            //bubble sort text
            Sorting sortText = new Sorting();
            int[] ascendingText = sortText.BubbleSortAscending(textToSort);

            //writes every 10th value in the ascending list
            int count = 0;
            Console.WriteLine("Every 10th number in ascending order from the chosen array: ");
            foreach (int item in ascendingText)
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

            int[] descendingText = sortText.BubbleSortDescending(textToSort);

            //gets user to input a key and checks if it is a valid input
            bool keyValid = false;
            while (keyValid == false)
            {
                Console.WriteLine("input a number to search for");
                string userKey = Console.ReadLine();
                Console.WriteLine("user key = " + userKey);
                try
                {
                    key = Int32.Parse(userKey);
                    Console.WriteLine("keyy: " + key);
                    keyValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("not a valid key");
                }
            }


            //binary search for key
            Searching searchtext = new Searching();
            int findKey = searchtext.BinarySearch(ascendingText, key);
            if (findKey != -1)
            {
                Console.WriteLine("Key found in position " + findKey);
            }
            else
            {
                Console.WriteLine("key not found");
            }

        }
    }

}
