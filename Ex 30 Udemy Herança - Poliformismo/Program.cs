using Ex_30_Udemy.Entities;
using Ex_30_Udemy.Entities.Enums;

Console.WriteLine("Enter the number of figures");
int figureNumber = int.Parse(Console.ReadLine());

List<Rectangle> rectangles = new List<Rectangle>();
List<Circle> circles = new List<Circle>();

for (int i = 0; i < figureNumber; i++)
{
    Console.WriteLine($"Shape of {i+1} figure: ");

    Console.WriteLine("Rectangule or Circle: ");
    string form = Console.ReadLine();

    if ( form == "r")
    {
        Console.Write("Color (Black/Blue/Red): ");
        string input = Console.ReadLine();

        if (Enum.TryParse(input, true, out Color selectedColor))
        {
            Console.WriteLine($"You selected: {selectedColor}");
        }
        else
        {
            Console.WriteLine("Invalid color. Please enter Black, Blue, or Red.");
        }

        Console.WriteLine("Width: ");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Height: ");
        double height = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(width, height, selectedColor);

        rectangles.Add(rectangle);

    }
    else
    {
        Console.Write("Color (Black/Blue/Red): ");
        string input = Console.ReadLine();

        if (Enum.TryParse(input, true, out Color selectedColor))
        {
            Console.WriteLine($"You selected: {selectedColor}");
        }
        else
        {
            Console.WriteLine("Invalid color. Please enter Black, Blue, or Red.");
        }

        Console.WriteLine("Radius: ");
        double radius = double.Parse(Console.ReadLine());


        Circle circle = new Circle(radius, selectedColor);

        circles.Add(circle);
    }

}

Console.WriteLine("SHAPE AREAS:");

for (int i = 0; i < circles.Count; i++)
{
    Console.WriteLine($"Circle at position {i + 1} has area {circles[i].Area()}");
}

for(int i = 0;i < rectangles.Count; i++)
{
    Console.WriteLine($"Rectangle at position {i+1} has sizes {rectangles[i].Area()}");
}
