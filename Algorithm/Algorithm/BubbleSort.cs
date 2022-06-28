using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class BubbleSort<T> where T : IComparable
    {
        public void Bubble()
        {
            BubbleSort<T> bubbleSort = new BubbleSort<T>();
            Console.Write("Enter integers values separated by spaces to sort : ");

            //Taking input from user and storing it to strings array of type string
            string[] strings = Console.ReadLine().Split();

            int[] sortArray = new int[strings.Length];
            //Converting each string value in strings array to integer type and storing it to sortArray for further calculation
            for (int i = 0; i < strings.Length; i++)
            {
                sortArray[i] = Convert.ToInt32(strings[i]);
            }

            Console.Write("Array before sorting is : ");
            bubbleSort.PrintArray(sortArray);
            
            for (int i = 0; i < sortArray.Length - 2; i++)
            {
                
                for (int j = 0; j < sortArray.Length - i - 1; j++)
                {
                    //If current element is greater than the next element
                    if (sortArray[j] > sortArray[j + 1])
                    {
                        //Swap logic
                        int temp = sortArray[j];
                        sortArray[j] = sortArray[j + 1];
                        sortArray[j + 1] = temp;
                    }
                }
            }
            Console.Write("Sorted Array usin Bubble sort is : ");
            bubbleSort.PrintArray(sortArray);
        }

        public void PrintArray(int[] sortArray)
        {
            for (int i = 0; i < sortArray.Length; i++)
            {
                Console.Write(" " + sortArray[i]);
            }
            Console.WriteLine();
        }
    

    }
}
