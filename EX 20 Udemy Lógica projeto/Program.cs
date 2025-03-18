using EX_20_Udemy_PROJETINHO;

Console.WriteLine("Insira o nome do usuario: ");
string nome = Console.ReadLine();

Console.WriteLine("Insira o numero da conta do cidadão: ");
int numeroConta = int.Parse(Console.ReadLine());

Console.WriteLine("Deseja insirir um saldo inicial S/N: ");
string escolha  = Console.ReadLine();

DadosBancarios dadosBancarios = DadosBancarios.Escolha(escolha, nome, numeroConta);

Console.WriteLine($"******* Dados do usuario ******** \n {dadosBancarios}");

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n******* Menu de Operações *******");
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Exibir dados da conta");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite o valor que deseja depositar: ");
            double vlrDeposito = double.Parse(Console.ReadLine());
            dadosBancarios.Depositar(vlrDeposito);
            Console.WriteLine($"Depósito realizado com sucesso! Novo saldo: {dadosBancarios}");
            break;

        case 2:
            Console.WriteLine("Digite o valor que deseja sacar: ");
            double vlrSaque = Double.Parse(Console.ReadLine());
            dadosBancarios.Sacar(vlrSaque);
            Console.WriteLine($"Saque realizado com sucesso! Novo saldo: {dadosBancarios}");
            break;

        case 3:
            Console.WriteLine(dadosBancarios);
            break;

        case 4:
            continuar = false;
            break;

        default:
            Console.WriteLine("Opção invalida");
            return;
    }
}