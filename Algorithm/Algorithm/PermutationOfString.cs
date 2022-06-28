using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class PermutationOfString
    {
        public static void Permute(String enteredString, int leftIndex, int rightIndex)
        {
            
            if (leftIndex == rightIndex)
            {
                Console.WriteLine(enteredString);
            }
            
            else
            {
                
                for (int i = leftIndex; i <= rightIndex; i++)
                {
                    
                    enteredString = Swap(enteredString, leftIndex, i);

                    
                    Permute(enteredString, leftIndex + 1, rightIndex);

                    
                    enteredString = Swap(enteredString, leftIndex, i);

                }
            }
        }

        
        public static String Swap(String enteredString, int leftIndex, int rightIndex)
        {
            
            char[] tempString = enteredString.ToCharArray();

            
            char temp = tempString[leftIndex];
            tempString[leftIndex] = tempString[rightIndex];
            tempString[rightIndex] = temp;

            //Converting tempString array back to string
            string toReturn = new string(tempString);

            
            return toReturn;
        }

        public void Driver()
        {
            Console.Write("Enter the string to find all of it's permutations : ");
            string enteredString = Console.ReadLine();
            Console.WriteLine("Permutations of the string " + enteredString + " are :");
            Permute(enteredString, 0, enteredString.Length - 1);
        }
    }
}

