using System;
using Biblioteca_Matriz;

class Ex_4_e_5
{
    static void MostrarDiagonalPrincipal(int[,] mat)
    {

        int linhas = mat.GetLength(0);
        Console.WriteLine("*** ELEMENTOS DA DIAGONAL PRINCIPAL ***");
        for (int i = 0; i < linhas; i++)
            Console.Write($"{mat[i, i]}|");

        Console.WriteLine();
    }
    static void MostrarDiagonalSecundaria(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1);
        int j = cols - 1;

        Console.WriteLine("*** ELEMENTOS DA DIAGONAL SECUNDÁRIA ***");
        for (int i = 0; i < linhas; i++, j--)
        {
            Console.Write($"{mat[i, j]}|");

            Console.WriteLine();
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

