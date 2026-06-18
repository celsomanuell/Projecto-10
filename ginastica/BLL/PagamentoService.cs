using ginastica.DAL;
using ginastica.Model;
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ginastica.BLL
{
    public class PagamentoService
    {
        private readonly PagamentoRepository _repo = new PagamentoRepository();
        private readonly SocioRepository _socioRepo = new SocioRepository();
        public System.Collections.Generic.IEnumerable<Pagamento> GetAll() => _repo.GetAll();

        public int RegistrarPagamento(Pagamento p)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                // inserir pagamento
                using (var cmd = new SqlCommand("INSERT INTO Pagamentos (SocioId, DataPagamento, Valor, Metodo, Observacoes) OUTPUT INSERTED.Id VALUES (@SocioId, @DataPagamento, @Valor, @Metodo, @Observacoes)", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@SocioId", p.SocioId);
                    cmd.Parameters.AddWithValue("@DataPagamento", p.DataPagamento);
                    cmd.Parameters.AddWithValue("@Valor", p.Valor);
                    cmd.Parameters.AddWithValue("@Metodo", (object)p.Metodo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Observacoes", (object)p.Observacoes ?? DBNull.Value);
                    var id = (int)cmd.ExecuteScalar();

                    // actualizar estado do socio para EmDia
                    using var cmdUp = new SqlCommand("UPDATE Socios SET EstadoPagamento=@Estado WHERE Id=@Id", conn, tx);
                    cmdUp.Parameters.AddWithValue("@Estado", "EmDia");
                    cmdUp.Parameters.AddWithValue("@Id", p.SocioId);
                    cmdUp.ExecuteNonQuery();

                    tx.Commit();
                    return id;
                }
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }
    }
}
