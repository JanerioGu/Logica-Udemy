using Ex_25_Udemy_Projeto.Entities;
using Ex_25_Udemy_Projeto.Entities.Enums;
using System.Diagnostics.Contracts;

Console.WriteLine("Enter departament name: ");
string departamentName = Console.ReadLine();

Departament dpt = new Departament(departamentName);

Console.WriteLine("Enter de worker data");
Console.WriteLine("Name: ");
string name = Console.ReadLine();

Console.WriteLine("Level: (Junior, MidLevel or Senior)");
string levelInput = Console.ReadLine();

WorkerLevel level;

if (!Enum.TryParse(levelInput, true, out level))
{
    Console.WriteLine("Invalid format. ");
    level = WorkerLevel.Junior;
}

Console.WriteLine("Base salary: ");
double salary = Double.Parse(Console.ReadLine());

Worker employ1 = new Worker(name, level, salary, dpt);

Console.WriteLine("How many contracts to this worker: ");
int contracts = int.Parse(Console.ReadLine());


for (int i = 0; i < contracts; i++)
{
    Console.WriteLine($"Enter {i + 1} contract data: ");
    Console.WriteLine("Date (DD/MM/YYYY): ");
    string dateInput = Console.ReadLine();
    if (DateTime.TryParseExact(dateInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dateContract))
    {
        Console.WriteLine($"Date entered successfully: {dateContract}");
    }
    else
    {
        Console.WriteLine("Invalid date format. Please use DD/MM/YYYY.");
    }

    Console.WriteLine("Value per hour: ");
    double ValuePerHour = Double.Parse(Console.ReadLine());

    Console.WriteLine("Duration: ");
    int hours = int.Parse(Console.ReadLine());

    HourContract hourContract = new HourContract(dateContract, ValuePerHour, hours);

    employ1.AddContract(hourContract);
}

Console.WriteLine("Enter month and year to calculate income (MM:YYYY): ");
Console.WriteLine("Month: ");
int date = int.Parse(Console.ReadLine());

Console.WriteLine("Year: ");
int year = int.Parse(Console.ReadLine());

double totalIncome = employ1.Income(year, date);

Console.WriteLine($"Name: {employ1.Name}");
Console.WriteLine($"Departament: {employ1.Departament.Name}");
Console.WriteLine($"Income for day {date} Year {year} is {totalIncome}");
