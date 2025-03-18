Console.WriteLine("Insira a quantidade de linhas da matriz: ");
int l = int.Parse(Console.ReadLine());

Console.WriteLine("Insira a quantidade de colunas da matriz: ");
int c = int.Parse(Console.ReadLine());

int[,] mat = new int[l, c];

Console.WriteLine("Insira o numero que deseja encontrar seus vizinhos: ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < l; i++)
{
    for (int j = 0; j < c; j++)
    {
        Console.WriteLine($"Insira o numero equivalente a posição {i}{j} da matriz");
        int numero = int.Parse(Console.ReadLine());

        mat[i, j] = numero;
    }

}

for (int i = 0;i < l; i++)
{
    for (int j = 0; j < c; j++)
    {
        if (mat[i, j] == x)
        {
            if (i > 0)
                Console.WriteLine($"Vizinho acima: {mat[i - 1, j]}");

            if (i < l - 1)
                Console.WriteLine($"Vizinho abaixo: {mat[i + 1, j]}");

            if (j > 0)
                Console.WriteLine($"Vizinho à esquerda: {mat[i, j - 1]}");

            if (j < c - 1)
                Console.WriteLine($"Vizinho à direita: {mat[i, j + 1]}");
        }
    }
}