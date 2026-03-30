namespace Enumeracoes.Entities.Enums
{
    // O ': int' é opcional, mas garante que os valores base são inteiros.
    enum OrderStatus : int
    {
        PendingPayment = 8, // Você pode forçar o número que quiser! Muito útil se o banco de dados já tiver regras antigas.
        Processing = 1,     
        Shipped = 2,
        Delivered = 3
    }
}