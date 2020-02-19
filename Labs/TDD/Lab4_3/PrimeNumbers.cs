using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_3
{
    public class PrimeNumbers
    {
        public static int GeneratePRime(int a)
        {
            int i = 0;
            List<int> primeList = new List<int>();

            while (primeList.Count < a)
            {
                if (CheckPrime(i))
                {
                    if (!primeList.Contains(i))
                    {
                        primeList.Add(i);
                    }
                }
                i++;
            }
            return primeList[a - 1];
        }

        public static int PrimeIndex(int a)
        {
            int count = 1;
            if (a == 2)
            {
                return 1;
            }

            if (CheckPrime(a))
            {
                for (int i = 2; i < a; i++)
                {
                    if (CheckPrime(i))
                    {
                        count++;
                    }
                }
            }
            else
            {
                return 0;
            }
            return count;
        }

        public static bool CheckPrime(int a)
        {
            if (a == 1)
            {
                return false;
            }
            if (a == 2)
            {
                return true;
            }

            if (a % 2 == 0)
            {
                return false;
            }

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
