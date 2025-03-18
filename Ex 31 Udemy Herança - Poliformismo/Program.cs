using Ex_31_Udemy.Entities;

Console.WriteLine("Enter the number of tax payers: ");
int tp = int.Parse(Console.ReadLine());

List<Pf> pessoaFisica = new List<Pf>();
List<Pj> pessoaJuridica = new List<Pj>();

for (int i = 0; i < tp; i++)
{
    Console.WriteLine($"Tax player #{i+1} data");

    Console.WriteLine("Pessoa FISICA ou JURIDICA: ");
    string pessoa = Console.ReadLine();

    if (pessoa == "f")
    {
        Console.WriteLine("Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Anual income: ");
        double income = double.Parse(Console.ReadLine());

        Console.WriteLine("Health expenditures: ");
        double health = double.Parse(Console.ReadLine());

        Pf pf = new Pf(name, income, health);

        pessoaFisica.Add(pf);

    }
    else
    {
        Console.WriteLine("Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Anual income: ");
        double income = double.Parse(Console.ReadLine());

        Console.WriteLine("Number of Employees: ");
        int employee = int.Parse(Console.ReadLine());

        Pj pj = new Pj(name, income, employee);

        pessoaJuridica.Add(pj);
    }
}

double totalIncome = 0;
Console.WriteLine("TAXES PAID: ");
for (int i = 0;i < pessoaFisica.Count; i++)
{
    totalIncome += pessoaFisica[i].CalculationTaxe();
    Console.WriteLine($"{pessoaFisica[i].Name} {pessoaFisica[i].CalculationTaxe()}");
}
for (int i = 0;i < pessoaJuridica.Count; i++)
{
    totalIncome += pessoaJuridica[i].CalculationTaxe();
    Console.WriteLine($"{pessoaJuridica[i].Name} {pessoaJuridica[i].CalculationTaxe()}");
}

Console.WriteLine($"Total taxes {totalIncome}");