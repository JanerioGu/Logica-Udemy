int n = 0;

Console.WriteLine("Insira o tamanho da matriz: ");
n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Insira os numeros da linha {i+1} da sua matriz, separados por espaço: ");
    string[] value = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++)
    {
        mat[i,j] = int.Parse(value[j]);
    }
}


for (int i = 0;i < n; i++)
{
    Console.WriteLine($"{mat[i,i]}");
}

int count = 0;
for (int i = 0; i< n; i++)
{
    for (int j = 0;j < n; j++)
    {
        if (mat[i,j] < 0)
        {
            count++;
        }
    }
}

Console.WriteLine($"Numero de negativos: {count}");