using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using ginastica.Model;

namespace ginastica.DAL
{
    public class AulaRepository
    {
        public IEnumerable<AulaColectiva> GetAll()
        {
            var list = new List<AulaColectiva>();
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("SELECT Id, Nome, InstrutorId, DataHora, Vagas, Sala FROM AulasColectivas", conn);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new AulaColectiva
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    InstrutorId = reader.IsDBNull(2) ? null : reader.GetInt32(2),
                    DataHora = reader.GetDateTime(3),
                    Vagas = reader.GetInt32(4),
                    Sala = reader.IsDBNull(5) ? null : reader.GetString(5)
                });
            }
            return list;
        }

        public int Insert(AulaColectiva a)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("INSERT INTO AulasColectivas (Nome, InstrutorId, DataHora, Vagas, Sala) OUTPUT INSERTED.Id VALUES (@Nome, @InstrutorId, @DataHora, @Vagas, @Sala)", conn);
            cmd.Parameters.AddWithValue("@Nome", a.Nome);
            cmd.Parameters.AddWithValue("@InstrutorId", (object)a.InstrutorId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@DataHora", a.DataHora);
            cmd.Parameters.AddWithValue("@Vagas", a.Vagas);
            cmd.Parameters.AddWithValue("@Sala", (object)a.Sala ?? DBNull.Value);
            conn.Open();
            return (int)cmd.ExecuteScalar();
        }

        public void Update(AulaColectiva a)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("UPDATE AulasColectivas SET Nome=@Nome, InstrutorId=@InstrutorId, DataHora=@DataHora, Vagas=@Vagas, Sala=@Sala WHERE Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Nome", a.Nome);
            cmd.Parameters.AddWithValue("@InstrutorId", (object)a.InstrutorId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@DataHora", a.DataHora);
            cmd.Parameters.AddWithValue("@Vagas", a.Vagas);
            cmd.Parameters.AddWithValue("@Sala", (object)a.Sala ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Id", a.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("DELETE FROM AulasColectivas WHERE Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
