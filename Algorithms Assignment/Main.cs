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
        public static bool choseShort; //checks whether the user selected a long or short array
        public static int[] ascendingText;
        public static int[] descendingText;

        static void Main()
        {
            string[] short1 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_1_256.txt");
            string[] short2 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_2_256.txt");
            string[] short3 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_3_256.txt");
            string[] long1 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_1_2048.txt");
            string[] long2 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_2_2048.txt");
            string[] long3 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_3_2048.txt");

            //converts all items to int values
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
                Console.WriteLine("Which array do you select: short(1, 2, 3), long(4, 5, 6)?");
                userChoice = Console.ReadLine();
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
                else
                {
                    Console.WriteLine("invalid choice, please input again");
                }
            }

            //bubble sort text for short arrays
            Sorting sortText = new Sorting();
            if (choseShort == true)
            {
                int[] ascendSort = textToSort;
                ascendingText = sortText.BubbleSortAscending(ascendSort);
                descendingText = sortText.BubbleSortDescending(textToSort);
            }
            else
            {
                Console.WriteLine("long sort");
            }

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

            //gets user to input a key and checks if it is a valid input
            bool keyValid = false;
            while (keyValid == false)
            {
                Console.WriteLine("input a number to search for");
                string userKey = Console.ReadLine();
                try
                {
                    key = Int32.Parse(userKey);
                    keyValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("not a valid key");
                }
            }

            //binary search for key to check it exists in the list
            Searching searchText = new Searching();
            int findKey = searchText.BinarySearch(ascendingText, key);

            if (findKey != -1)
            {
                Console.WriteLine("Key found in position " + findKey);
                //finds all positions with that number
                List<int> findAllPositions = searchText.linearSearch(ascendingText, key, findKey);
                Console.WriteLine("Key found in positions:");
                foreach (int position in findAllPositions)
                {
                    Console.WriteLine(position);
                }
            }
            else
            {
                Console.WriteLine("key not found");
            }
        }
    }

}