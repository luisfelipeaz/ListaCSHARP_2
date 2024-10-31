using System;
using Biblioteca_Matriz;

class Ex_1_e_2
{
    static int maiorValorMatriz(int[,]mat)
    {
        int linhas = mat.GetLength(0);//pega linhas
        int cols = mat.GetLength(1);
        int maior = mat[0,0];
        for (int i = 0;i<linhas; i++)
            for (int j = 0; j < cols; j++)
                if (mat[i,j]>maior)
                    maior = mat[i,j];

        //terminou percorrer funcao 
        return maior;
    }
       static int menorValorMatriz(int[,]mat)
    {
        int linhas = mat.GetLength(0);//pega linhas
        int cols = mat.GetLength(1);
        int menor = mat[0,0];
        for (int i = 0;i<linhas; i++)
            for (int j = 0; j < cols; j++)
                if (mat[i,j]<menor)
                    menor = mat[i,j];

        //terminou percorrer funcao 
        return menor;
    }
   
    static void Main()
    {
        int cols, linhas;
        Console.WriteLine("Quantidades de linhas e colunas");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[linhas, cols];
        Matriz.gera(matrix);
        Matriz.mostra(matrix);
        Console.WriteLine($"O maior numero da matriz:{maiorValorMatriz(matrix)}");
        Console.WriteLine($"O menor numero da matriz:{menorValorMatriz(matrix)}");

    } 
}
