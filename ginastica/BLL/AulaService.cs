using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ginastica.DAL;
using ginastica.Model;

namespace ginastica.BLL
{
    public class AulaService
    {
        private readonly AulaRepository _repo = new AulaRepository();
        private readonly SocioRepository _socioRepo = new SocioRepository();

        public System.Collections.Generic.IEnumerable<AulaColectiva> GetAll() => _repo.GetAll();

        public int Create(AulaColectiva aula)
        {
            if (string.IsNullOrWhiteSpace(aula.Nome)) throw new ArgumentException("Nome da aula obrigatório");
            if (aula.Vagas < 0) throw new ArgumentException("Vagas inválidas");
            return _repo.Insert(aula);
        }

        public void InscreverSocio(int aulaId, int socioId)
        {
            var inscricaoService = new InscricaoService();
            var inscr = new Model.Inscricao
            {
                SocioId = socioId,
                AulaId = aulaId,
                DataInscricao = DateTime.Now
            };
            inscricaoService.Create(inscr);
        }
    
    }
}
