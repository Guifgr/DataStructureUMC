using System;

namespace SelectionSort
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

            for (i = 0; i <= 3; i++)
            {
                eleito = x[i];
                var menor = x[i + 1];
                var pos = i + 1;

                for (j = i; j <= 4; j++)
                {
                    if (x[j] < menor)
                    {
                        menor = x[j];
                        pos = j;
                    }
                }

                if (menor < eleito)
                {
                    x[i] = x[pos];
                    x[pos] = eleito;
                }
            }

            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine(i+1+"º número: "+x[i]);
            }
        }
    }
}