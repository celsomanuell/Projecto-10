namespace ginastica.Model
{
    public class Plano
    {
        public string Nome { get; set; }
        public TipoPlano Tipo { get; set; }
        public decimal Preco { get; set; }
        public string? Descricao { get; set; }

        public Plano()
        {
            Nome = string.Empty;
            Tipo = TipoPlano.Misto;
            Preco = 0m;
            Descricao = null;
        }
    }
}
