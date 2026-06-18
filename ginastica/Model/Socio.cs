using System;

namespace ginastica.Model
{
    public class Socio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public TipoPlano Plano { get; set; }
        public EstadoPagamento EstadoPagamento { get; set; }

        public Socio()
        {
            Nome = string.Empty;
            Telefone = string.Empty;
            Email = string.Empty;
            DataNascimento = DateOnly.FromDateTime(DateTime.Today);
            Plano = TipoPlano.Misto;
            EstadoPagamento = EstadoPagamento.EmDia;
        }
    }
}
