using Ex_29_Udemy;
using System.Globalization;

Console.WriteLine("Enter the number of products");
int qtd = int.Parse(Console.ReadLine());

List<Product> product = new List<Product>();

for (int i = 0; i < qtd; i++)
{
    Console.WriteLine($"Product {i+1} data: ");

    Console.WriteLine("Common, used or imported (C/U/I)");
    string productChosse = Console.ReadLine();

    Console.WriteLine("Name: ");
    string productName = Console.ReadLine();

    Console.WriteLine("Price: ");
    double price = double.Parse(Console.ReadLine());

    Product prod3 = new Product(productName, price);
    product.Add(prod3);

    if (productChosse == "i")
    {
        Console.WriteLine("Custom fee: ");
        double cf = double.Parse(Console.ReadLine());

        Product prod1 = new ImportedProduct(cf, productName, price);
        product.Add(prod1);
    }
    if (productChosse == "u")
    {
        Console.WriteLine("Manufacture date (dd/MM/yyyy): ");
        string inputDate = Console.ReadLine();
        DateTime data;

        if (DateTime.TryParseExact(inputDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
        {
            Product prod2 = new UsedProduct(data, productName, price);
            product.Add(prod2);
        }
    }
}

Console.WriteLine("Price tag: ");
foreach (Product prod in product)
{
    Console.WriteLine($"{prod.PriceTag()}");
}