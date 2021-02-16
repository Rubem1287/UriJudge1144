using System;

namespace Uri1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,soma;
            int[] vetor;

            soma = 0;

            vetor = new int[46];

            n = int.Parse(Console.ReadLine());

            while (n > 46)
            {
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                

                if(i==0)
                {
                    Console.Write("0 ");
                }
                if (i == 1)
                {
                    Console.Write("1 ");
                }
                if (i == 2)
                {
                    Console.Write("1 ");
                    vetor[i] = 1;
                }

                if (i == 3)
                {
                    Console.Write("2 ");
                    vetor[i] = 2;
                }
                if (i>3)
                {
                    
                    soma = vetor[i-1] + vetor[i - 2];
                    Console.Write(soma+" ");
                    vetor[i] = soma;
                }

            }
        }
    }
}
