using Ex_26_Udemy_Projeto_usando_lógica_trabalhando_com_objetos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex_26_Udemy_Projeto_usando_lógica_trabalhando_com_objetos.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItens { get; set; } = new List<OrderItem>();
        public Cliente Cliente { get; set; }


        public Order() { }

        public Order(OrderStatus status, Cliente cliente)
        {
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(OrderItem item)
        {
            OrderItens.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItens.Remove(item);
        }

        public double Total()
        {
            double sum = 0;

            foreach (OrderItem item in OrderItens)
            {
                sum += item.SubTotal();

            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"***** Order Sumary *****");
            stringBuilder.Append("Order moment: ");
            stringBuilder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.AppendLine("Order Status: ");
            stringBuilder.AppendLine(Status.ToString());
            stringBuilder.AppendLine("Cliente: ");
            stringBuilder.AppendLine(Cliente.ToString());
            stringBuilder.AppendLine("***** Order itens ***** ");

            foreach (OrderItem orderItem in OrderItens)
            {
                stringBuilder.AppendLine("Produtct name: ");
                stringBuilder.AppendLine(orderItem.Product.Name);
                stringBuilder.AppendLine("Price: ");
                stringBuilder.AppendLine(orderItem.Product.Price.ToString());
                stringBuilder.AppendLine("Quantity: ");
                stringBuilder.AppendLine(orderItem.Quantity.ToString());
                stringBuilder.AppendLine("SubTotal: ");
                stringBuilder.AppendLine(orderItem.SubTotal().ToString());
            }

            stringBuilder.AppendLine("Order Total: ");
            stringBuilder.AppendLine(Total().ToString("F2"));

            return stringBuilder.ToString();

        }
    }
}
