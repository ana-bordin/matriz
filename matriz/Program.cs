/* 
1. faça um programa que pegue os valores da matriz e faça as 4 operações basicas;
    Criar 3 metodos:
    a.definir um menu para seleção de operação; 
    b.função sorteio matriz; ok
    c.função que le o numero linha e coluna da matriz;
*/
int qtdLinhas = 0, qtdColunas = 0, operacao = 0, opcao = 0, opcaoSorteio = 0;

void LerTamanho()
{
    while (qtdLinhas <= 0)
    {
        Console.WriteLine("quantidade linhas maior que 0:");
        qtdLinhas = int.Parse(Console.ReadLine());
    }

    while (qtdColunas <= 0)
    {
        Console.WriteLine("quantidade colunas maior que 0:");
        qtdColunas = int.Parse(Console.ReadLine());
    }
}

void PreencherMatriz(int opcao, float[,] matriz)
{
    do
    {
        switch (opcao)
        {
            case 1:
                for (int linha = 0; linha < qtdLinhas; linha++)
                {
                    Console.WriteLine($"Linha {linha + 1}:");
                    for (int coluna = 0; coluna < qtdColunas; coluna++)
                        matriz[linha, coluna] = float.Parse(Console.ReadLine());
                }
                break;
            case 2:
                for (int linha = 0; linha < qtdLinhas; linha++)
                {
                    for (int coluna = 0; coluna < qtdColunas; coluna++)
                        matriz[linha, coluna] = new Random().Next(0, 5);
                }
                break;
            default:
                Console.WriteLine("Digite um número válido!");
                opcao = 0;
                break;
        }
    }
    while (opcao == 0);
}
void ImprimirMatriz(float[,] matriz)
{
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            Console.Write($"{matriz[linha, coluna]}, ");
    }
    Console.WriteLine("\n");
}
void CalcularMatriz(int operacao, float[,] matriz1, float[,] matriz2, float[,] matriz3)
{
    do
    {
        switch (operacao)
        {
            case 1:
                for (int linha = 0; linha < qtdLinhas; linha++)
                {
                    for (int coluna = 0; coluna < qtdColunas; coluna++)
                        matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
                }

                Console.WriteLine("\n\nMatriz Soma:");
                ImprimirMatriz(matriz3);
                break;
            case 2:
                for (int linha = 0; linha < qtdLinhas; linha++)
                {
                    for (int coluna = 0; coluna < qtdColunas; coluna++)
                        matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
                }

                Console.WriteLine("\n\nMatriz Subtração:");
                ImprimirMatriz(matriz3);
                break;
            case 3:
                for (int linha = 0; linha < qtdLinhas; linha++)
                {
                    for (int coluna = 0; coluna < qtdColunas; coluna++)
                        matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
                }

                Console.WriteLine("\n\nMatriz Multiplicação:");
                ImprimirMatriz(matriz3);
                break;
            case 4:
                for (int linha = 0; linha < qtdLinhas; linha++)
                {
                    for (int coluna = 0; coluna < qtdColunas; coluna++)
                    {
                        if (matriz2[linha, coluna] != 0)
                            matriz3[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
                        else
                            matriz3[linha, coluna] = float.NaN;
                    }
                }

                Console.WriteLine("\n\nMatriz Divisão:");
                ImprimirMatriz(matriz3);
                break;
            default:

                Console.WriteLine("Digite um número válido!");
                operacao = 0;
                break;
        }

    } while (operacao == 0);
}

do
{
    Console.WriteLine("-Calculadora de valores de Matrizes:-");
    Console.WriteLine("\n- definir tamanho das matrizes:");
    LerTamanho();

    Console.WriteLine("\n- definir números das posições das matrizes:");

    Console.WriteLine("Matriz 1:");
    Console.WriteLine("1 - para digitar todos elementos;");
    Console.WriteLine("2 - sortear números aleatórios;");
    opcao = int.Parse(Console.ReadLine());

    float[,] matriz1 = new float[qtdLinhas, qtdColunas];
    float[,] matriz2 = new float[qtdLinhas, qtdColunas];
    float[,] matriz3 = new float[qtdLinhas, qtdColunas];
    PreencherMatriz(opcao, matriz1);

    Console.WriteLine("Matriz 2:");
    Console.WriteLine("1 - para digitar todos elementos;");
    Console.WriteLine("2 - sortear números aleatórios;");
    opcao = int.Parse(Console.ReadLine());
    PreencherMatriz(opcao, matriz2);

    Console.WriteLine("\n- mostrar matrizes:");

    Console.WriteLine("Matriz 1:");
    ImprimirMatriz(matriz1);

    Console.WriteLine("Matriz 2:");
    ImprimirMatriz(matriz2);

    do
    {
        Console.WriteLine("\n- definir operação dos elementos da matriz:");
        Console.WriteLine("1 - adição;");
        Console.WriteLine("2 - subtração;");
        Console.WriteLine("3 - multiplicação;");
        Console.WriteLine("4 - divisão;");
        opcao = int.Parse(Console.ReadLine());

        CalcularMatriz(opcao, matriz1, matriz2, matriz3);

        Console.WriteLine("Se deseja fazer outra operação digite 0;\nse não, digite outro número;");
        opcao = int.Parse(Console.ReadLine());

    } while (opcao == 0);

    Console.WriteLine("Deseja começar de novo? Se deseja digite 0;\nse não, digite outro número;");

    opcao = int.Parse(Console.ReadLine());

} while (opcao == 0);