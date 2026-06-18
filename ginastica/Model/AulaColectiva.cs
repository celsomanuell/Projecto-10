using System;

namespace ginastica.Model
{
    public class AulaColectiva
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? InstrutorId { get; set; }
        public DateTime DataHora { get; set; }
        public int Vagas { get; set; }
        public string? Sala { get; set; }

        public AulaColectiva()
        {
            Nome = string.Empty;
            DataHora = DateTime.Now;
        }

        /// <summary>
        /// Texto combinado para exibição em listas: inclui nome, data/hora, número de vagas e sala.
        /// </summary>
        public string Display => $"{Nome} - {DataHora:dd/MM/yyyy HH:mm} | Vagas: {Vagas} | Sala: {(string.IsNullOrEmpty(Sala) ? "-" : Sala)}";
    }
}
