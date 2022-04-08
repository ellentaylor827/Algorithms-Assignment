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
        static void Main()
        {
            string[] share1 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_1_256.txt");
            string[] share2 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_2_256.txt");
            string[] share3 = System.IO.File.ReadAllLines(@"C:\Users\ellen\source\repos\Algorithms Assignment\Algorithms Assignment\Share_3_256.txt");

            int[] text1 = Array.ConvertAll(share1, int.Parse);
            int[] text2 = Array.ConvertAll(share2, int.Parse);
            int[] text3 = Array.ConvertAll(share3, int.Parse);

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
            int[] descendingText = sortText.BubbleSortDescending(textToSort);
            


        }


    }

}
