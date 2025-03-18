using EX_22_Udemy;

//numero de estudantes
//new students com 9 espaços

Console.WriteLine("Insira a quantidade de estudantes que ficarão no hotel: ");
int quantidadeEstudantes = int.Parse(Console.ReadLine());

Student[] estudantes = new Student[9];

for (int i = 0; i < quantidadeEstudantes; i++)
{
    Console.WriteLine("Insira o nome do estudante: ");
    string nome = Console.ReadLine();

    Console.WriteLine("Insir o email de contato: ");
    string email = Console.ReadLine();


    int aparatamentoEscolhido;

    while (true)
    {
        Console.WriteLine("Insira o apartamento escolhido");
        aparatamentoEscolhido = int.Parse(Console.ReadLine());

        if (aparatamentoEscolhido >= 0 && aparatamentoEscolhido <= 9)
        {
            if (estudantes[aparatamentoEscolhido] == null)
            {
                break;
            }
            else
            {
                Console.WriteLine("AparTamento já escolhido");
            }
        }
        else
        {
            Console.WriteLine("Insira um apartamento de 0 a 9.");
        }

    }
    estudantes[aparatamentoEscolhido] = new Student(nome, email, aparatamentoEscolhido);

}

for (int i = 0; i < estudantes.Length; i++)
{
    if (estudantes[i] != null)
    {
        Console.WriteLine(estudantes[i].ToString());
    }
}