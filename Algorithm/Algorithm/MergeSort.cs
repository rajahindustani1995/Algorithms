using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class MergeSort<T> where T : IComparable
    {
        public void Merge(T[] array, int leftMostIndex, int middleIndex, int rightMostIndex)
        {
            
            int leftSubArraySize = middleIndex - leftMostIndex + 1;

            //Calculating the size for the rightSubArray
            int rightSubArraySize = rightMostIndex - middleIndex;

            //Creating temporary arrays for storing leftPart and rightPart
            T[] leftSubArray = new T[leftSubArraySize];
            T[] rightSubArray = new T[rightSubArraySize];

            //Inserting all the elements in their respective SubArrays
            for (int i1 = 0; i1 < leftSubArraySize; i1++)
            {
                //insert elements in leftSubArray from left most element
                leftSubArray[i1] = array[leftMostIndex + i1];
            }
            for (int j1 = 0; j1 < rightSubArraySize; j1++)
            {
                //insert elements in rightSubArray from middle + 1 element
                rightSubArray[j1] = array[middleIndex + 1 + j1];
            }
            
            int i = 0, j = 0;

            
            //we will use k for indexing "array"
            int k = leftMostIndex;

            while (i < leftSubArraySize && j < rightSubArraySize)
            {
                
                if (leftSubArray[i].CompareTo(rightSubArray[j]) <= 0)
                {
                   array[k] = leftSubArray[i];
  
                    i++;
                }
                
                else
                {                  
                    array[k] = rightSubArray[j];
                    
                    j++;
                }
                k++;
            }

            
            while (i < leftSubArraySize)
            {
                //put the remaining elements from leftSubArray into the array
                array[k] = leftSubArray[i];
                i++;
                k++;
            }
            while (j < rightSubArraySize)
            {
                //put the remaining elements from rightSubArray into the array
                array[k] = rightSubArray[j];
                j++;
                k++;
            }
        }

        
        public void Sort(T[] array, int leftMostIndex, int rightMostIndex)
        {
            
            if (leftMostIndex < rightMostIndex)
            {
                //find the middle index of the array
                int middleIndex = leftMostIndex + (rightMostIndex - leftMostIndex) / 2;

                
                Sort(array, leftMostIndex, middleIndex);

                
                Sort(array, middleIndex + 1, rightMostIndex);

                //After sorting is done we are going to merge two parts
                Merge(array, leftMostIndex, middleIndex, rightMostIndex);
            }

        }

        public void PrintArray(T[] sortArray)
        {
            for (int i = 0; i < sortArray.Length; i++)
            {
                Console.Write(" " + sortArray[i]);
            }
            Console.WriteLine();
        }

        public void Driver(T[] sortArray)
        {
            MergeSort<T> mergeSort = new MergeSort<T>();



            Console.Write("Array before sorting is : ");
            mergeSort.PrintArray(sortArray);

            //Passing (array, 1st element index as leftMostIndex, last index/ rightMostIndex) to Sort method
            mergeSort.Sort(sortArray, 0, sortArray.Length - 1);

            Console.Write("Array using Merge sort is : ");
            mergeSort.PrintArray(sortArray);
        }
    

    }
}
