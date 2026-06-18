using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ginastica.Model;

namespace ginastica.DAL
{
    public class SocioRepository
    {
        public IEnumerable<Socio> GetAll()
        {
            var list = new List<Socio>();
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("SELECT Id, Nome, DataNascimento, Telefone, Email, Plano, EstadoPagamento FROM dbo.Socios", conn);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var s = new Socio
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    DataNascimento = DateOnly.FromDateTime(reader.GetDateTime(2)),
                    Telefone = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    Email = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    Plano = Enum.Parse<TipoPlano>(reader.GetString(5)),
                    EstadoPagamento = Enum.Parse<EstadoPagamento>(reader.GetString(6))
                };
                list.Add(s);
            }
            return list;
        }

        public int Insert(Socio socio)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("INSERT INTO dbo.Socios (Nome, DataNascimento, Telefone, Email, Plano, EstadoPagamento) OUTPUT INSERTED.Id VALUES (@Nome, @DataNascimento, @Telefone, @Email, @Plano, @EstadoPagamento)", conn);
            cmd.Parameters.AddWithValue("@Nome", socio.Nome);
            cmd.Parameters.AddWithValue("@DataNascimento", socio.DataNascimento.ToDateTime(new TimeOnly(0)));
            cmd.Parameters.AddWithValue("@Telefone", (object)socio.Telefone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)socio.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Plano", socio.Plano.ToString());
            cmd.Parameters.AddWithValue("@EstadoPagamento", socio.EstadoPagamento.ToString());
            conn.Open();
            var id = (int)cmd.ExecuteScalar();
            return id;
        }

        public void Update(Socio socio)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("UPDATE dbo.Socios SET Nome=@Nome, DataNascimento=@DataNascimento, Telefone=@Telefone, Email=@Email, Plano=@Plano, EstadoPagamento=@EstadoPagamento WHERE Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Nome", socio.Nome);
            cmd.Parameters.AddWithValue("@DataNascimento", socio.DataNascimento.ToDateTime(new TimeOnly(0)));
            cmd.Parameters.AddWithValue("@Telefone", (object)socio.Telefone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)socio.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Plano", socio.Plano.ToString());
            cmd.Parameters.AddWithValue("@EstadoPagamento", socio.EstadoPagamento.ToString());
            cmd.Parameters.AddWithValue("@Id", socio.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("DELETE FROM dbo.Socios WHERE Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public Socio? GetById(int id)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("SELECT Id, Nome, DataNascimento, Telefone, Email, Plano, EstadoPagamento FROM dbo.Socios WHERE Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Socio
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    DataNascimento = DateOnly.FromDateTime(reader.GetDateTime(2)),
                    Telefone = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    Email = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    Plano = Enum.Parse<TipoPlano>(reader.GetString(5)),
                    EstadoPagamento = Enum.Parse<EstadoPagamento>(reader.GetString(6))
                };
            }
            return null;
        }
    }
}
