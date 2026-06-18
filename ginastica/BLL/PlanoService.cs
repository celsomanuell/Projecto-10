using System.Collections.Generic;
using ginastica.DAL;
using ginastica.Model;

namespace ginastica.BLL
{
    public class PlanoService
    {
        private readonly PlanoRepository _repo = new PlanoRepository();

        public IEnumerable<Plano> GetAll() => _repo.GetAll();

        public void Create(Plano p)
        {
            Validate(p);
            _repo.Insert(p);
        }

        public void Update(Plano p)
        {
            Validate(p);
            _repo.Update(p);
        }

        public void Delete(string nome)
        {
            _repo.Delete(nome);
        }

        private void Validate(Plano p)
        {
            if (string.IsNullOrWhiteSpace(p.Nome)) throw new System.ArgumentException("Nome do plano obrigatório");
            if (p.Preco < 0) throw new System.ArgumentException("Preço inválido");
        }
    }
}
