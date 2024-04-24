// 1. faça um programa que pegue os valores da matriz e faça as 4 operações basicas;

int qtdLinhas = 3, qtdColunas = 3;
int[,] matriz1 = new int[qtdLinhas,qtdColunas];
int[,] matriz2 = new int[qtdLinhas,qtdColunas];
int[,] matriz3 = new int[qtdLinhas,qtdColunas];

Console.WriteLine("Matriz 1:");
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz1[linha, coluna] = new Random().Next(1, 5);
        Console.Write($"{matriz1[linha, coluna]}, ");
    } 
}

Console.WriteLine("\n\nMatriz 2:");
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz2[linha, coluna] = new Random().Next(1, 5);
        Console.Write($"{matriz2[linha, coluna]}, ");
    }
}

Console.WriteLine("\n\nMatriz 3 - Soma:");
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
        Console.Write($"{matriz3[linha, coluna]}, ");
    }
}

Console.WriteLine("\n\nMatriz 3 - Subtração:");
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
        Console.Write($"{matriz3[linha, coluna]}, ");
    }
}

Console.WriteLine("\n\nMatriz 3 - Multiplicação:");
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
        Console.Write($"{matriz3[linha, coluna]}, ");
    }
}

Console.WriteLine("\n\nMatriz 3 - Divisão:");
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz3[linha, coluna] = matriz3[linha, coluna] / matriz2[linha, coluna];
        Console.Write($"{matriz1[linha, coluna]}, ");
    }
}