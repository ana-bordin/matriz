/* 
1. faça um programa que pegue os valores da matriz e faça as 4 operações basicas;
    Criar 3 metodos:
    a.definir um menu para seleção de operação; 
    b.função sorteio matriz;
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
int MenuPreencher()
{
    Console.WriteLine("1 - para digitar todos elementos;");
    Console.WriteLine("2 - sortear números aleatórios;");
    opcao = int.Parse(Console.ReadLine());
    return opcao;

}
float[,] PreencherMatriz(int qtdLinhas, int qtdColunas)
{
    opcao = MenuPreencher();

    switch (opcao)
    {
        case 1:
            return (PreencherManual(qtdLinhas, qtdColunas));
        case 2:
            return (PreencherAleatorio(qtdLinhas, qtdColunas));
        default:
            Console.WriteLine("Digite um número válido!");
            opcao = 0;
            return null;
    }
}
float[,] CriarMatriz(int qtdLinhas, int qtdColunas)
{
    float[,] matriz = new float[qtdLinhas, qtdColunas];
    return matriz;
}
float[,] PreencherAleatorio(int qtdLinhas, int qtdColunas)
{
    float[,] matriz = CriarMatriz(qtdLinhas, qtdColunas);
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            matriz[linha, coluna] = new Random().Next(0, 5);
    }
    return matriz;
}
float[,] PreencherManual(int qtdLinhas, int qtdColunas)
{
    float[,] matriz = CriarMatriz(qtdLinhas, qtdColunas);
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine($"Linha {linha + 1}:");
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            matriz[linha, coluna] = float.Parse(Console.ReadLine());
    }
    return matriz;
}
void ImprimirMatriz(float[,] matriz, string titulo)
{
    Console.WriteLine(titulo);
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            Console.Write($"{matriz[linha, coluna]}, ");
    }
    Console.WriteLine("\n");
}
void Menu()
{
    Console.WriteLine("\n- definir operação dos elementos da matriz:");
    Console.WriteLine("1 - adição;");
    Console.WriteLine("2 - subtração;");
    Console.WriteLine("3 - multiplicação;");
    Console.WriteLine("4 - divisão;");
}
void EscolherOperacao(float[,] m1, float[,] m2)
{
    do
    {
        Menu();
        opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                SomarMatriz(m1, m2);
                break;
            case 2:
                SubtrairMatriz(m1, m2);
                break;
            case 3:
                MultiplicarMatriz(m1, m2);
                break;
            case 4:
                DividirMatriz(m1, m2);
                break;
            default:
                Console.WriteLine("Dgite uma operação valida!");
                opcao = 0;
                break;
        }
    } while (opcao == 0);
}
void SomarMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizResultante = new float[qtdLinhas, qtdColunas];
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            matrizResultante[linha, coluna] = m1[linha, coluna] + m2[linha, coluna];
    }
    ImprimirMatriz(matrizResultante, "Matriz Adição:");
}
void SubtrairMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizResultante = new float[qtdLinhas, qtdColunas];
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            matrizResultante[linha, coluna] = m1[linha, coluna] - m2[linha, coluna];
    }
    ImprimirMatriz(matrizResultante, "Matriz Subtração:");
}
void MultiplicarMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizResultante = new float[qtdLinhas, qtdColunas];
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            matrizResultante[linha, coluna] = m1[linha, coluna] * m2[linha, coluna];
    }
    ImprimirMatriz(matrizResultante, "Matriz Multiplicação:");
}
void DividirMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizResultante = new float[qtdLinhas, qtdColunas];
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            if (matrizResultante[linha, coluna] != 0)
                matrizResultante[linha, coluna] = m1[linha, coluna] / m2[linha, coluna];
            else
                matrizResultante[linha, coluna] = float.NaN;
        }
    }
    ImprimirMatriz(matrizResultante, "Matriz Divisão:");
}

do
{
    Console.WriteLine("-Calculadora de valores de Matrizes:-");
    Console.WriteLine("\n- definir tamanho das matrizes:");
    LerTamanho();

    Console.WriteLine("\n- definir números das posições das matrizes:");
    Console.WriteLine("Matriz 1:");
    float[,] matriz1 = PreencherMatriz(qtdLinhas, qtdColunas);
    Console.WriteLine("Matriz 2:");
    float[,] matriz2 = PreencherMatriz(qtdLinhas, qtdColunas);

    Console.WriteLine("\n- mostrar matrizes:");
    ImprimirMatriz(matriz1, "Matriz 1:");
    ImprimirMatriz(matriz2, "Matriz 2:");

    EscolherOperacao(matriz1, matriz2);

    Console.WriteLine("Deseja começar de novo? Se deseja digite 0;\nse não, digite outro número;");
    opcao = int.Parse(Console.ReadLine());
} while (opcao == 0);