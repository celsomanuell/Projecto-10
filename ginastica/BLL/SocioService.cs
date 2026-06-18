using System.Collections.Generic;
using ginastica.DAL;
using ginastica.Model;

namespace ginastica.BLL
{
    public class SocioService
    {
        private readonly SocioRepository _repo = new SocioRepository();

        public IEnumerable<Socio> GetAll() => _repo.GetAll();

        public Socio? GetById(int id) => _repo.GetById(id);

        public int Create(Socio socio)
        {
            Validate(socio);
            return _repo.Insert(socio);
        }

        public void Update(Socio socio)
        {
            Validate(socio);
            _repo.Update(socio);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        private void Validate(Socio socio)
        {
            if (string.IsNullOrWhiteSpace(socio.Nome)) throw new System.ArgumentException("Nome obrigatório");
            if (socio.DataNascimento > System.DateOnly.FromDateTime(System.DateTime.Today)) throw new System.ArgumentException("Data de nascimento inválida");
        }
    }
}
