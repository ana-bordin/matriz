int qtdLinhas = 30, qtdColunas = 30;
int[,] matriz1 = new int[qtdLinhas,qtdColunas];
int[,] matriz2 = new int[qtdLinhas,qtdColunas];
int[,] matriz3 = new int[qtdLinhas,qtdColunas];

// criação matriz
for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz1[linha, coluna] = new Random().Next(0, 3);
    }
}

for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz2[linha, coluna] = new Random().Next(0, 3);
    }
}
for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
    }
}
// criação matriz impressão
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        Console.Write($"{matriz1[linha, coluna]}, ");
    }
}
Console.WriteLine();
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        Console.Write($"{matriz2[linha, coluna]}, ");
    }
}
Console.WriteLine();
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        Console.Write($"{matriz3[linha, coluna]}, ");
    }
}
