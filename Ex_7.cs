using Biblioteca_Matriz;
using System;

class Ex_7
{
    static void Main()
    {
        int cols1, linhas1;
        Console.WriteLine("Quantidades de linhas e colunas da matriz 1:");
        linhas1 = int.Parse(Console.ReadLine());
        cols1 = int.Parse(Console.ReadLine());
        int[,] matriz1 = new int[linhas1, cols1];
        Matriz.gera(matriz1); 
        int cols2, linhas2;
        Console.WriteLine("Quantidades de linhas e colunas da matriz 2:");
        linhas2 = int.Parse(Console.ReadLine());
        cols2 = int.Parse(Console.ReadLine());
        int[,] matriz2 = new int[linhas2, cols2];
        Matriz.gera(matriz2); 
        
        Console.WriteLine("Digite a opção que você quer:\n1) Somar\n2) Subtrair\n3) Adicionar constante\n4) Mostrar");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                if (linhas1 == linhas2 && cols1 == cols2)
                {
                    int[,] soma = Matriz.SomaMatrix(matriz1, matriz2);
                    Console.WriteLine("*** MATRIZ SOMA ***");
                    Matriz.mostra(soma);
                }
                else
                {
                    Console.WriteLine("As matrizes devem ter as mesmas dimensões para serem somadas.");
                }
                break;

            case 2:
                if (linhas1 == linhas2 && cols1 == cols2)
                {
                    int[,] sub = Matriz.SubtrairMatriz(matriz1, matriz2);
                    Console.WriteLine("*** MATRIZ SUBTRAÇÃO ***");
                    Matriz.mostra(sub);
                }
                else
                {
                    Console.WriteLine("As matrizes devem ter as mesmas dimensões para serem subtraídas.");
                }
                break;

            case 3:
                Console.WriteLine("Digite a constante que você deseja adicionar:");
                int constante = int.Parse(Console.ReadLine());
                Matriz.AdicionarConstante(matriz1, constante);
                Matriz.AdicionarConstante(matriz2, constante);
                Console.WriteLine("*** MATRIZ 1 APÓS ADICIONAR CONSTANTE ***");
                Matriz.mostra(matriz1);
                Console.WriteLine("*** MATRIZ 2 APÓS ADICIONAR CONSTANTE ***");
                Matriz.mostra(matriz2);
                break;

            case 4:
                Console.WriteLine("*** MATRIZ 1 ***");
                Matriz.mostra(matriz1);
                Console.WriteLine("*** MATRIZ 2 ***");
                Matriz.mostra(matriz2);
                break;

            default:
                Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida.");
                break;
        }
    }
}
