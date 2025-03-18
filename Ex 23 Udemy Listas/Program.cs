using Ex_23_Udemy;
using System.ComponentModel.Design;

List<Funcionario> funcionarios = new List<Funcionario>();

Console.WriteLine("Insira o ID do funcionario: ");
int id = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o nome do funcionario: ");
string nome = Console.ReadLine();

Console.WriteLine("Insira o salario do funcionario: ");
double salario = double.Parse(Console.ReadLine());

if (funcionarios.Any(x => x.Id == id))
{
    Console.WriteLine($"Já existe funcionario com o ID {id}");
}
else
{
    Funcionario novoFuncionario = new Funcionario(id, nome, salario);
    funcionarios.Add(novoFuncionario);
}

bool vamo = true;
while (vamo)
{
    Console.WriteLine("Deseja adicionar um novo funcionario S/N");
    string escolha = Console.ReadLine();

    if (escolha.ToUpper() == "S")
    {
        Console.WriteLine("Insira o ID do funcionario: ");
        id = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o nome do funcionario: ");
        nome = Console.ReadLine();

        Console.WriteLine("Insira o salario do funcionario: ");
        salario = double.Parse(Console.ReadLine());

        if (funcionarios.Any(x => x.Id == id))
        {
            Console.WriteLine($"Já existe funcionario com o ID {id}");
        }
        else
        {
            Funcionario novoFuncionario = new Funcionario(id, nome, salario);
            funcionarios.Add(novoFuncionario);

        }
    }
    else
    {

        Console.WriteLine("Continuando para alteração de salario");
    }
    bool continuar = true;
    while (continuar)
    {
        Console.WriteLine("Quer alterar o salario de alguém S/N: ");
        escolha = Console.ReadLine();

        if (escolha.ToUpper() == "S")
        {
            Console.WriteLine("Insira o ID do funcionario para fazer a alteração do salario: ");
            int idEscolhido = int.Parse(Console.ReadLine());

            Funcionario funcionario = funcionarios.FirstOrDefault(x => x.Id == idEscolhido);
            if (funcionario != null)
            {
                Console.WriteLine("Qual o percentual do salario você deseja aumentar: ");
                double percentual = double.Parse(Console.ReadLine());

                funcionario.AumentarSalario(percentual);
                Console.WriteLine(funcionario);
            }
            else
            {
                Console.WriteLine("Funcionario não encontrado");
            }
        }
        else
        {
            vamo = false;
            continuar = false;

        }
    }
}
