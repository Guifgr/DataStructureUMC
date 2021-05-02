using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula7_ECA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do array");
            var arraySize = int.Parse(Console.ReadLine() ?? string.Empty);
            int[] dados = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("Digite o numero para ser adicionado na lista: ");
                var number = int.Parse(Console.ReadLine() ?? string.Empty);
                dados[i] = number;
            }

            bool result;
            while (true)
            {
                Console.WriteLine("Digite o número para pesquisa");
                var pesq = int.Parse(Console.ReadLine() ?? string.Empty);
                Console.WriteLine("Selecione o método de busca:");
                Console.WriteLine("Binária digite: 1");
                Console.WriteLine("Númerica digite: 2");
                var number = int.Parse(Console.ReadLine() ?? string.Empty);
                if (number == 1)
                {
                    result = binaria(pesq, dados);
                    break;
                }
                if(number == 2)
                {
                    result = busca_num(pesq, dados);
                    break;
                }
            }

            if (result)
            {
                Console.WriteLine("\nO dado foi encontrado!");
            }
            else
            {
                Console.WriteLine("\nO dado não foi encontrado!");
            }

        }
        
        static bool busca_num(int pesq, int[] dados)
        {
            for(int i=0; i<dados.Length;i++)
            {
                Console.WriteLine("\n"+pesq+" ?= "+dados[i]);
                if (pesq == dados[i])
                    return true;
            }
            return false;
        }

        static bool binaria(int pesq, int[] dados)
        {
            dados = ordena(dados);
            int inicio = 0, fim = dados.Length - 1, meio;
            while(inicio<=fim)
            {
                var cut = dados.Skip(inicio).Take(fim - inicio+1); 
                Console.WriteLine("\n["+ string.Join(" ", cut)+"]");
                meio = (inicio + fim) / 2;
                Console.WriteLine("\n"+pesq + " ?= " + dados[meio]);
                if (pesq == dados[meio])
                {
                    return true;   
                }

                if (pesq < dados[meio])
                {
                    fim = meio - 1;
                }
                else
                {
                    inicio = meio + 1;
                }
            }
            return false;
        }
        public static int[] ordena(int[] dados) {
            for (var j = 0; j <= dados.Length - 2; j++) {
                for (int i = 0; i <= dados.Length - 2; i++) {
                    if (dados[i] > dados[i + 1]) {
                        var temp = dados[i + 1];
                        dados[i + 1] = dados[i];
                        dados[i] = temp;
                    }
                }
            }

            return dados;
        }
    }
}