using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm_CS
{/// <summary>
/// Template find the prime numbers with in 0-1000
/// </summary>
    class PrimeNumber
    {
        //Decalring instance variables
        int range = 1000, factor = 0;
        int num, divisor;
        public void FindingPrimeNumber()
        {
            for (num = 1; num < range; num++)
            {
                for ( divisor = 1; divisor < range; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        factor++;
                    }
                }
                //If the number has only two factor, then only it is a prime number
                if (factor == 2)
                {
                    Console.Write(num + " ");
                }
                factor = 0;
            }
        }
    }
}
