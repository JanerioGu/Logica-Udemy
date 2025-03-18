Console.WriteLine("Digite a quantidade de alturas que deseja calcular: ");
int n = int.Parse(Console.ReadLine());

double[] alturas = new double[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Insira a altura numero {i + 1}: ");
    alturas[i] = double.Parse(Console.ReadLine());
}

double soma = 0;

for (int i = 0; i < n; i++)
{
    soma += alturas[i];
}

double media = soma / n;

Console.WriteLine($"A media é igual a {media:F2}");

