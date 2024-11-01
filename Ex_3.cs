using System;
using Biblioteca_Matriz;

    class Ex_3
    {
        static void main()
        {
            int cols, linhas;
            Console.WriteLine("Quantidades de linhas e colunas");
            linhas = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[linhas, cols];
            Matriz.gera(matrix);
            Console.WriteLine("***MATRIZ GERADA***");
            Matriz.mostra(matrix);

            Console.WriteLine("digite um numero para ver quantas vezes ele aparece");
            int x = int.Parse(Console.ReadLine());

            int cont = 0;

            for (int i = 0; i < linhas; i++) 
            { 
               for(int j = 0; j < cols; j++)
               {
                    cont++;
               }
            }
            Console.WriteLine($"O numero {x} aparece {cont} vezes na matriz");
        }
    }

