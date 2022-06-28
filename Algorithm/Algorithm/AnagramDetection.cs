using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class AnagramDetection
    {
        public void Detection()
        {
            Console.Write("Enter first string : ");
            string firstString = Console.ReadLine();
            Console.Write("Enter second string : ");
            string secondString = Console.ReadLine();

            
            if (firstString.Length != secondString.Length)
            {
                Console.WriteLine("The two strings are not anagram of each other");
            }

            
            char[] firstStringArray = firstString.ToCharArray();
            char[] secondStringArray = secondString.ToCharArray();

            
            Array.Sort(firstStringArray);
            Array.Sort(secondStringArray);

            
            if (String.Join("", firstStringArray) == String.Join("", secondStringArray))
            {
                Console.WriteLine("The two strings \"" + firstString + "\" and \"" + secondString + "\" are anagrams of each other");
            }
        }
    }
}
