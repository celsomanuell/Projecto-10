using System.Collections.Generic;
using ginastica.DAL;
using ginastica.Model;

namespace ginastica.BLL
{
    public class InstrutorService
    {
        private readonly InstrutorRepository _repo = new InstrutorRepository();

        public IEnumerable<Instrutor> GetAll() => _repo.GetAll();

        public int Create(Instrutor i)
        {
            if (string.IsNullOrWhiteSpace(i.Nome)) throw new System.ArgumentException("Nome do instrutor obrigatório");
            return _repo.Insert(i);
        }

        public void Update(Instrutor i)
        {
            if (string.IsNullOrWhiteSpace(i.Nome)) throw new System.ArgumentException("Nome do instrutor obrigatório");
            _repo.Update(i);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}
