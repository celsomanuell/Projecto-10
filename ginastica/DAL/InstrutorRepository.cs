using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using ginastica.Model;

namespace ginastica.DAL
{
    public class InstrutorRepository
    {
        public IEnumerable<Instrutor> GetAll()
        {
            var list = new List<Instrutor>();
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("SELECT Id, Nome, Telefone, Email, Especialidade FROM Instrutores", conn);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Instrutor
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    Telefone = reader.IsDBNull(2) ? null : reader.GetString(2),
                    Email = reader.IsDBNull(3) ? null : reader.GetString(3),
                    Especialidade = reader.IsDBNull(4) ? null : reader.GetString(4)
                });
            }
            return list;
        }

        public int Insert(Instrutor i)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("INSERT INTO Instrutores (Nome, Telefone, Email, Especialidade) OUTPUT INSERTED.Id VALUES (@Nome, @Telefone, @Email, @Especialidade)", conn);
            cmd.Parameters.AddWithValue("@Nome", i.Nome);
            cmd.Parameters.AddWithValue("@Telefone", (object)i.Telefone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)i.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Especialidade", (object)i.Especialidade ?? DBNull.Value);
            conn.Open();
            return (int)cmd.ExecuteScalar();
        }

        public void Update(Instrutor i)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("UPDATE Instrutores SET Nome=@Nome, Telefone=@Telefone, Email=@Email, Especialidade=@Especialidade WHERE Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Nome", i.Nome);
            cmd.Parameters.AddWithValue("@Telefone", (object)i.Telefone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)i.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Especialidade", (object)i.Especialidade ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Id", i.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("DELETE FROM Instrutores WHERE Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
