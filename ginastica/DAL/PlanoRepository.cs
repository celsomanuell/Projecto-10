using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using ginastica.Model;

namespace ginastica.DAL
{
    public class PlanoRepository
    {
        public IEnumerable<Plano> GetAll()
        {
            var list = new List<Plano>();
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("SELECT Nome, TipoPlano, Preco, Descricao FROM Planos", conn);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Plano
                {
                    Nome = reader.GetString(0),
                    Tipo = Enum.Parse<TipoPlano>(reader.GetString(1)),
                    Preco = reader.GetDecimal(2),
                    Descricao = reader.IsDBNull(3) ? null : reader.GetString(3)
                });
            }
            return list;
        }

        public int Insert(Plano p)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("INSERT INTO Planos (Nome, TipoPlano, Preco, Descricao) VALUES (@Nome, @TipoPlano, @Preco, @Descricao)", conn);
            cmd.Parameters.AddWithValue("@Nome", p.Nome);
            cmd.Parameters.AddWithValue("@TipoPlano", p.Tipo.ToString());
            cmd.Parameters.AddWithValue("@Preco", p.Preco);
            cmd.Parameters.AddWithValue("@Descricao", (object)p.Descricao ?? DBNull.Value);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public void Update(Plano p)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("UPDATE Planos SET TipoPlano=@TipoPlano, Preco=@Preco, Descricao=@Descricao WHERE Nome=@Nome", conn);
            cmd.Parameters.AddWithValue("@TipoPlano", p.Tipo.ToString());
            cmd.Parameters.AddWithValue("@Preco", p.Preco);
            cmd.Parameters.AddWithValue("@Descricao", (object)p.Descricao ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Nome", p.Nome);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(string nome)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("DELETE FROM Planos WHERE Nome=@Nome", conn);
            cmd.Parameters.AddWithValue("@Nome", nome);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
