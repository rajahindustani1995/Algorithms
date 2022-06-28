using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class PrimeNumbers
    {
        public void Prime()
        {
            Console.WriteLine("Prime numbers in the range 1 to 1000 are :");

            
            for (int i = 2; i < 1000; i += 2)
            {
                
                int nonPrime = 0;

                
                if (i == 2)
                {
                    Console.Write(2);
                    i++;
                }
                //Find prime number
                for (int j = 2; j <= i / 2; j++)
                {
                    
                    if (i % j == 0)
                    {
                        //the number is not prime
                        nonPrime = 1;

                        //break current loop, caculate for next number
                        break;
                    }
                }
                
                if (nonPrime == 0)
                {
                    Console.Write(" " + i);
                }
            }
        }
    }
}
