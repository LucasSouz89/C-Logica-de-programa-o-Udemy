using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioFinalComposicao.Entites.Enuns;

namespace ExercicioFinalComposicao.Entites.Class
{
    internal class Order
    {
        public DateTime Date { get; private set; }
        public OrderStatus Status { get; private set; }

        public Client Client { get; private set; }

        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item) {
            Items.Remove(item); 
        }
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items) {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            sb.Append("ORDER SUMMARY");
            sb.AppendLine($"Order moment: {Date}");
            sb.AppendLine($"Order status: {Status.ToString()}");
            sb.AppendLine($"Client {Client.Name} {Client.BirthDate.ToString("dd/MM/yyyy")} - {Client.Email}");
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Items) {
                sb.AppendLine($"{item}");
            }
            sb.AppendLine($"Total price: ${Total().ToString("F2",CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
