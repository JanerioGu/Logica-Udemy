using Ex_24_Udemy_Enum.Entities;
using Ex_24_Udemy_Enum.Entities.Enums;


Order order = new Order
{
    Id = 1,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayament
};

Console.WriteLine(order);