// 1. faça um programa que pegue os valores da matriz e faça as 4 operações basicas;

int qtdLinhas = 3, qtdColunas = 3;
float[,] matriz1 = new float[qtdLinhas,qtdColunas];
float[,] matriz2 = new float[qtdLinhas,qtdColunas];
float[,] matriz3 = new float[qtdLinhas,qtdColunas];

Console.WriteLine("Matriz 1:");
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz1[linha, coluna] = new Random().Next(0, 5);
        Console.Write($"{matriz1[linha, coluna]}, ");
    } 
}

Console.WriteLine("\n\nMatriz 2:");
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz2[linha, coluna] = new Random().Next(0, 5);
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
        if (matriz2[linha,coluna] != 0)
        {
            matriz3[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
        Console.Write($"{matriz3[linha, coluna]}, ");
        }
        else
        {
            matriz3[linha, coluna] = float.NaN;
            Console.Write($"{matriz3[linha, coluna]}, ");
        }
        
    }
}