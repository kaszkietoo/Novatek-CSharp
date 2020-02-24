using System;

namespace Novatek._5BC
{
    class Program
    {
        static void Main(string[] args)
        {
            WritePrimeNumbers(1, 1000);
        }

        static void WritePrimeNumbers(int start, int end)
        {
            bool isFirst = true;
            int first = 0, second = 0;

            for (int i = end; i >= start; i--)
            {
                if (IsPrime(i))
                {
                    if (isFirst)
                    {
                        first = i;
                        isFirst = false;
                    }                        
                    else
                    {
                        second = i;
                        Console.WriteLine("Średnia liczb {0} i {1} = {2:0.00000}", first, second, (first + second) / 2f);
                        first = second;
                        
                    }
                    Console.WriteLine(i);
                }                    
            }            
        }

        static bool IsPrime(int candidate)
        {            
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }

            return candidate != 1;
        }
    }
}
