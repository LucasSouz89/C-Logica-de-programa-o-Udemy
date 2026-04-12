namespace DateTimeKindEPadraoISO8601Ex
{
    internal class Program
    {
        static void Main(string[] args) {
            //Ex 1
            string dataDaAPI = "2026-03-26T14:30:00Z";
            var dataSaida = DateTime.Parse(dataDaAPI);
            Console.WriteLine($"Data original da API: {dataSaida}");
            Console.WriteLine($"Horário em Guarulhos:: {dataSaida.ToLocalTime()}");
            //Ex2 
            DateTime inicioEvento = DateTime.Now;
            var eventoGlobal = inicioEvento.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
            Console.WriteLine(eventoGlobal);
            //Ex3
            DateTime erroDoSistema = new DateTime(2026, 3, 26, 22, 15, 0, DateTimeKind.Local);
            var DataConcertada = erroDoSistema.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
            Console.WriteLine(DataConcertada);
        }
        }
}
