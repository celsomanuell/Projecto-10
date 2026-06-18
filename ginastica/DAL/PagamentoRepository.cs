using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using ginastica.Model;

namespace ginastica.DAL
{
    public class PagamentoRepository
    {
        public IEnumerable<Pagamento> GetAll()
        {
            var list = new List<Pagamento>();
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand(@"SELECT p.Id, p.SocioId,s.Nome AS SocioNome, p.DataPagamento, p.Valor, p.Metodo, p.Observacoes FROM Pagamentos p
            LEFT JOIN Socios s ON s.Id = p.SocioId", conn);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Pagamento
                {
                    Id = reader.GetInt32(0),
                    SocioId = reader.GetInt32(1),
                    SocioNome = reader.IsDBNull(2) ? null : reader.GetString(2),
                    DataPagamento = reader.GetDateTime(3),
                    Valor = reader.GetDecimal(4),
                    Metodo = reader.IsDBNull(5) ? null : reader.GetString(5),
                    Observacoes = reader.IsDBNull(6) ? null : reader.GetString(6)
                });
            }
            return list;
        }

        public IEnumerable<Pagamento> GetBySocio(int socioId)
        {
            var list = new List<Pagamento>();
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("SELECT Id, SocioId, DataPagamento, Valor, Metodo, Observacoes FROM Pagamentos WHERE SocioId=@SocioId", conn);
            cmd.Parameters.AddWithValue("@SocioId", socioId);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Pagamento
                {
                    Id = reader.GetInt32(0),
                    SocioId = reader.GetInt32(1),
                    DataPagamento = reader.GetDateTime(2),
                    Valor = reader.GetDecimal(3),
                    Metodo = reader.IsDBNull(4) ? null : reader.GetString(4),
                    Observacoes = reader.IsDBNull(5) ? null : reader.GetString(5)
                });
            }
            return list;
        }

        public int Insert(Pagamento p)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("INSERT INTO Pagamentos (SocioId, DataPagamento, Valor, Metodo, Observacoes) OUTPUT INSERTED.Id VALUES (@SocioId, @DataPagamento, @Valor, @Metodo, @Observacoes)", conn);
            cmd.Parameters.AddWithValue("@SocioId", p.SocioId);
            cmd.Parameters.AddWithValue("@DataPagamento", p.DataPagamento);
            cmd.Parameters.AddWithValue("@Valor", p.Valor);
            cmd.Parameters.AddWithValue("@Metodo", (object)p.Metodo ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Observacoes", (object)p.Observacoes ?? DBNull.Value);
            conn.Open();
            return (int)cmd.ExecuteScalar();
        }
    }
}
