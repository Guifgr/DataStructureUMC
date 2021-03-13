using System;

namespace Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] x = new long[5];
            long j, i, eleito;
            
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("o "+(i+1)+"º número: ");
                x[i] = Convert.ToInt64(Console.ReadLine());
            }

            for (i = 1; i <= 4; i++)
            {
                eleito = x[i];
                j = i - 1;
                while ((j >= 0) &&
                       (x[j] > eleito))
                {
                    x[j + 1] = x[j];
                    j -= 1;
                }
                
                x[j + 1] = eleito;
            }
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine(i+1+"º número: "+x[i]);
            }
        }
    }
}