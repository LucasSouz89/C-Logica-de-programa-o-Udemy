using System;
using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Criando o pedido e passando o Enum direto (Fácil e seguro)
            var request = new Order
            {
                Id = 333,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(request);

            // 2. ENUM -> STRING (Transformando em texto para mostrar na tela/API)
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine("\nTexto gerado do Enum: " + txt);

            // 3. STRING -> ENUM (O Parse! Lendo texto da API e transformando em Enum)
            OrderStatus o = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine("Enum gerado do texto: " + o);
        }
    }
}