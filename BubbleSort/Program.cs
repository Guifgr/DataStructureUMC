using System;

namespace BubbleSort
{
    class Program
    {
        static void Main()
        {
            long[] x = new long[5];
            long n, i, aux;
            
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("o "+(i+1)+"º número: ");
                x[i] = Convert.ToInt64(Console.ReadLine());
            }
            
            for (n = 1; n <= 5; n++)
            {
                for (i = 0; i <= 3; i++)
                {
                    if (x[i] > x[i + 1])
                    {
                        aux = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = aux;
                    }
                }
            }

            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine(i+1+"º número: "+x[i]);
            }
        }
    }
}