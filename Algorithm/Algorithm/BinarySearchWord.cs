using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class BinarySearchWord<T> where T : IComparable
    {
        static int BinarySearch(List<T> wordArray, int leftIndex, int rightIndex, String findIndexOfWord)
        {
            
            while (leftIndex <= rightIndex)
            {
                //Find the middle index of the array
                int middelIndex = leftIndex + (rightIndex - leftIndex) / 2;

                //Declaring variable IsPresent to check that the entered word is present at the middle index or not
                int IsPresent = findIndexOfWord.CompareTo(wordArray[middelIndex]);
                
                if (IsPresent == 0)
                {
                    //return it's position
                    return middelIndex;
                }
                
                if (IsPresent > 0)
                {
                    //set leftIndex to the next index of the middle i.e. search the word in the rightSubArray
                    leftIndex = middelIndex + 1;
                }
                
                else
                {
                    //set rightIndex to the middle index of array i.e. search the word in the leftSubArray
                    rightIndex = middelIndex;
                }
            }
            //If word we are looking for is not present in the array
            return -1;
        }

        public void DriverMethod(List<T> wordArray)
        {
            

            Console.Write("Words present in the list are : ");
            foreach (T word in wordArray)
            {
                Console.Write(" " + word);
            }
            Console.Write("\nEnter the word you want to find : ");
            String findIndexOfWord = Console.ReadLine();
           
            int foundAtPosition = BinarySearch(wordArray, 0, wordArray.Count - 1, findIndexOfWord);

            //BinarySearch method returns -1 when the entered word is not present in the list
            if (foundAtPosition == -1)
            {
                Console.WriteLine("Word is not present in the array");
            }
            //The entered word is present in the list
            else
            {
                Console.WriteLine("Starting from 0'th index the word " + findIndexOfWord + " is found at position/index " + foundAtPosition + " in the list");
            }
        }
    }
}
