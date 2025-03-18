using Ex_22_1_Udemy;

Console.WriteLine("Insira os numeros que deseja somar: ");
int numerosDesejado = int.Parse(Console.ReadLine());

int soma = 0;

int[] numeroSoma = new int[numerosDesejado];
for (int i = 0; i < numerosDesejado; i++)
{
    Console.WriteLine("Insira os numeros que deseja somar");
    numeroSoma[i] = int.Parse(Console.ReadLine());

    soma += numeroSoma[i];
}

Calculadora.Soma(soma);