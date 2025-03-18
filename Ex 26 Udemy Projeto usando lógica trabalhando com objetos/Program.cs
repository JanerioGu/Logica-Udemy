using Ex_26_Udemy_Projeto_usando_lógica_trabalhando_com_objetos.Entities;
using Ex_26_Udemy_Projeto_usando_lógica_trabalhando_com_objetos.Entities.Enums;

Console.WriteLine("Enter cliente data ");
Console.WriteLine("Name: ");
string name = Console.ReadLine();

Console.WriteLine("Email: ");
string email = Console.ReadLine();

Console.WriteLine("Birth Date (DD/MM/YYYY): ");
string input = Console.ReadLine();
DateTime birthDate = DateTime.ParseExact(input, "dd/MM/yyyy", null);

Cliente cliente1 = new Cliente(name, email, birthDate);

Console.WriteLine("Enter order data ");
Console.WriteLine("Status: ");
string statusInput = Console.ReadLine();
OrderStatus status;
Enum.TryParse(statusInput, true, out status);

Console.WriteLine("How many itens in this order: ");
int itensNumber = int.Parse(Console.ReadLine());

Order order = new Order(status, cliente1);

for (int i = 0; i < itensNumber; i++)
{
    Console.WriteLine($"Enter #{i + 1} item data");

    Console.WriteLine("Product Name: ");
    string productName = Console.ReadLine();

    Console.WriteLine("Product Price: ");
    double productPrice = double.Parse(Console.ReadLine());

    Console.WriteLine("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product product = new Product(productName, productPrice);

    OrderItem orderItem = new OrderItem(quantity, productPrice, product);

    order.AddItem(orderItem);
}

Console.WriteLine($"{order}");

