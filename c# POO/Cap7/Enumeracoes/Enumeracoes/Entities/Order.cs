using System;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            // Interpolação limpa e direta para imprimir o relatório
            return $"Pedido: {Id} | Data: {Moment} | Status: {Status}";
        }
    }
}