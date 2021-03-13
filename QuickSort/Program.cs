using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] x = new long[10];
            long i;
            for (i = 0; i <= 9; i++)
            {
                Console.WriteLine("o "+(i+1)+"º número: ");
                x[i] = Convert.ToInt64(Console.ReadLine());
            }
            for (i = 0; i <= 9; i++)
            {
                Console.WriteLine(i+1+"º número: "+x[i]);
            }
        }

        public long[] Troca(long[] x, long i, long j){
            var aux = x[i];
            x[i] = x[j];
            x[j] = aux;
            return x;
        }

        public long particao(long[] x, long p, long r)
        {
            long pivo, i, j;
            pivo = x[(p + r) / 2];
            i = p - 1;
            j = r + 1;
            while (i < j)
            {
             //Parei aqui
            }
            return j;
        }
 
    }
}