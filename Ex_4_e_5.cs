using System;
using Biblioteca_Matriz;

    class Ex_4_e_5
    {
        static void MostrarDiagonalPrincipal(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);   

            Console.WriteLine("*** ELEMENTOS DA DIAGONAL PRINCIPAL ***");
            for (int i = 0; i < Math.Min(linhas, cols); i++)
            {
                Console.WriteLine($"Elemento na posição [{i}, {i}] = {mat[i, i]}");
            }
        }
        static void MostrarDiagonalSecundaria(int[,] mat)
        {
            int linhas = mat.GetLength(0); 
            int cols = mat.GetLength(1);   

            Console.WriteLine("*** ELEMENTOS DA DIAGONAL SECUNDÁRIA ***");
            for (int i = 0; i < linhas; i++)
            {
                
                Console.WriteLine($"Elemento na posição [{i}, {cols - 1 - i}] = {mat[i, cols - 1 - i]}");
            }
        }

    static void Main() 
        {
            int cols, linhas;
            Console.WriteLine("Quantidades de linhas e colunas");
            linhas = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            int[,] matriz = new int[linhas, cols];
            Matriz.gera(matriz);
            Matriz.mostra(matriz);

            MostrarDiagonalPrincipal(matriz);
            MostrarDiagonalSecundaria(matriz);
        }
    }


