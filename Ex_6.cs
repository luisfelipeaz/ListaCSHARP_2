using System;
using Biblioteca_Matriz;

    class Ex_6
    {
        static int[,] SomaMatriz(int[,] mat1, int[,]mat2)
        {
            int linhas1 = mat1.GetLength(0);
            int cols1 = mat1.GetLength(1);
            int linhas2 = mat2.GetLength(0);
            int cols2 = mat2.GetLength(1);

            if (linhas1 != linhas2 || cols1 != cols2)
            Console.WriteLine("As matrizes tem que ser iguais");

            int[,] resultado = new int[linhas1, cols1];

            for(int i = 0; i < linhas1; i++)
            {
                for(int j = 0; j < cols1; j++)
                {
                    resultado[i,j]= mat1[i,j] + mat2[i,j];
                }   
            }

            return resultado;
        }
        static void Main()
        {

            int cols1, linhas1;
            Console.WriteLine("Quantidades de linhas e colunas");
            linhas1 = int.Parse(Console.ReadLine());
            cols1 = int.Parse(Console.ReadLine());
            int[,] matriz1= new int[linhas1, cols1];
            Matriz.gera(matriz1);
            Matriz.mostra(matriz1); 
            
            int cols2, linhas2;
            Console.WriteLine("Quantidades de linhas e colunas");
            linhas2 = int.Parse(Console.ReadLine());
            cols2 = int.Parse(Console.ReadLine());
            int[,] matriz2 = new int[linhas2, cols2];
            Matriz.gera(matriz2);
            Matriz.mostra(matriz2);
            
            int[,] soma = SomaMatriz(matriz1, matriz2);
            
            Console.WriteLine();
            Matriz.mostra(soma);

        }
    }

