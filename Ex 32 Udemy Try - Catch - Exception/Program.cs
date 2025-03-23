using Ex_32_Udemy_Try___Catch___Exception.Entities;
using Ex_32_Udemy_Try___Catch___Exception.Entities.Exception;
using System.Globalization;

try
{
    while (true)
    {
        Console.WriteLine("Room number");
        int rn = int.Parse(Console.ReadLine());

        Console.WriteLine("Check-in date (dd/MM/yyyy): ");
        DateTime checkin;
        while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out checkin))
        {
            Console.WriteLine("Invalid format! Please enter the check-in date in the format dd/MM/yyyy:");
        }

        Console.WriteLine("Check-out date (dd/MM/yyyy): ");
        DateTime checkout;
        while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out checkout))
        {
            Console.WriteLine("Invalid format! Please enter the check-out date in the format dd/MM/yyyy:");
        }

        Reservation reservation = new Reservation(rn, checkin, checkout);
        Console.WriteLine($"reservation:  {reservation}");

        Console.WriteLine("Do you like to att the information (y/n): ");
        string response = Console.ReadLine();

        if (response == "y")
        {
            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation: ");
            Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out checkin))
            {
                Console.WriteLine("Invalid format! Please enter the check-in date in the format dd/MM/yyyy:");
            }

            Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out checkout))
            {
                Console.WriteLine("Invalid format! Please enter the check-out date in the format dd/MM/yyyy:");
            }

            reservation.UpdateDates(checkin, checkout);
            Console.WriteLine($"reservation:  {reservation}");
            break;
        }
        else
        {
            break;
        }
    }
}catch(DomainException e)
{
    Console.WriteLine($"Error in reservation: {e.Message}");
}

