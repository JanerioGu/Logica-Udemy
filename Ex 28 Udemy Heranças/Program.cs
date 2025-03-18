using Ex_28_Udemy;
using Ex_28_Udemy.Entities;

List<Employee> employee =  new List<Employee>();

Console.WriteLine("Enter number of employee");
int numberEmployee = int.Parse(Console.ReadLine());

for (int i = 0; i < numberEmployee; i++)
{
    Console.WriteLine($"Employer number {i +1} is outsorced (y/n): ");
    string response = Console.ReadLine();

    if (response == "y")
    {
        Console.WriteLine("Name : ");
        string name = Console.ReadLine();

        Console.WriteLine("Hours: ");
        int hours = int.Parse(Console.ReadLine());

        Console.WriteLine("Value per hour: ");
        double valuePerHour = double.Parse(Console.ReadLine());

        Console.WriteLine("Adicional: ");
        double adicional = double.Parse(Console.ReadLine());
        Employee emp = new OutsorcedEmployee(name, hours, valuePerHour, adicional);

        employee.Add(emp);
    }

    else
    {
        Console.WriteLine("Name : ");
        string name = Console.ReadLine();

        Console.WriteLine("Hours: ");
        int hours = int.Parse(Console.ReadLine());

        Console.WriteLine("Value per hour: ");
        double valuePerHour = double.Parse(Console.ReadLine());

        Employee emp = new Employee(name, hours, valuePerHour);

        employee.Add(emp);
    }

}

Console.WriteLine();
Console.WriteLine("PAYMENTS: ");

foreach(Employee emp in employee)
{
    Console.WriteLine($"{emp.Name} $ {emp.Paymennt().ToString("F2")}");
}

