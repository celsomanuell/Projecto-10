using ginastica.DAL;
using ginastica.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ginastica.BLL
{
    internal class InscricaoService
    {
        private readonly InscricaoRepository _repo = new InscricaoRepository();

        public System.Collections.Generic.IEnumerable<Inscricao> GetAll() => _repo.GetAll();


        public void Create(Inscricao inscricao)
        {
            _repo.Inscrever(inscricao);
        }

        public void Update(Socio socio)
        {
            //_repo.Update(socio);
        }

        public void Delete(int id)
        {
            //_repo.Delete(id);
        }
    }
}
