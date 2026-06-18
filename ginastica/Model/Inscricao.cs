
using System;

namespace ginastica.Model
{
    /// <summary>
    /// Representa uma inscrição de um sócio numa aula colectiva.
    /// </summary>
    public class Inscricao
    {
        public int Id { get; set; }
        public int SocioId { get; set; }
        public int AulaId { get; set; }
        public DateTime? DataInscricao { get; set; }

        // Campos de apoio para UI (nome do sócio / da aula) preenchidos pelo repositório
        public string? SocioNome { get; set; }
        public string? AulaNome { get; set; }

        // Propriedade usada como DisplayMember no ListBox
        public string Nome => SocioNome ?? string.Empty;

        /// <summary>
        /// Texto combinado exibido na lista: "Sócio - Aula".
        /// </summary>
        public string Display => $"{(SocioNome ?? string.Empty)} - {(AulaNome ?? string.Empty)}";
    }
}
