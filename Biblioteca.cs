using System;
using Biblioteca_Matriz;


namespace Biblioteca_Matriz
{
    class Matriz
    {
        public static void leia(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Digite para [{i},{j}]:");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }// fim for j
            }// fim for i

        }// fim leia
        //--------------------------------------------------
        public static void gera(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);
            Random random = new Random();
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < cols; j++)
                    mat[i, j] = random.Next(0, 100);

        }// fim gera
        //-----------------------------------------------------
        public static void mostra(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{mat[i, j],3} |");
                }// fim for j
                Console.WriteLine();
            }// fim for i
        }// fim mostra
        public static int[,] SomaMatrix(int[,] mat1, int[,] mat2)
        {
            int linhas1 = mat1.GetLength(0);
            int cols1 = mat1.GetLength(1);
            int linhas2 = mat2.GetLength(0);
            int cols2 = mat2.GetLength(1);

            if (linhas1 != linhas2 || cols1 != cols2)
                Console.WriteLine("As matrizes tem que ser iguais");

            int[,] resultado = new int[linhas1, cols1];

            for (int i = 0; i < linhas1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    resultado[i, j] = mat1[i, j] + mat2[i, j];
                }
            }

            return resultado;
        }
        public static int[,] SubtrairMatriz(int[,] mat1, int[,] mat2)
        {
            int linhas1 = mat1.GetLength(0);
            int cols1 = mat1.GetLength(1);
            int linhas2 = mat2.GetLength(0);
            int cols2 = mat2.GetLength(1);

            if (linhas1 != linhas2 || cols1 != cols2)
                Console.WriteLine("As matrizes tem que ser iguais");

            int[,] resultado = new int[linhas1, cols1];

            for (int i = 0; i < linhas1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    resultado[i, j] = mat1[i, j] - mat2[i, j];
                }
            }

            return resultado;
        }


        public static void AdicionarConstante(int[,] matriz, int constante)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matriz[i, j] += constante;
                }
            }

        }
    }
}
