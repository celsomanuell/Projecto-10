using System;

namespace ginastica.Model
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int SocioId { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal Valor { get; set; }
        public string? Metodo { get; set; }
        public string? Observacoes { get; set; }
        public string? SocioNome { get; set; }
        public string Nome => SocioNome ?? string.Empty;
        public string Display => $"{Nome} | {Valor} | {Metodo} | {DataPagamento:dd/MM/yyyy HH:mm} | {Observacoes}";

        public Pagamento()
        {
            DataPagamento = DateTime.Now;
        }
    }
}
