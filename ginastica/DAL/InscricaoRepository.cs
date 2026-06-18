using ginastica.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ginastica.DAL
{
    internal class InscricaoRepository
    {
        private readonly AulaRepository _repo = new AulaRepository();
        public IEnumerable<Inscricao> GetAll()
        {
            var list = new List<Inscricao>();
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand(@"SELECT i.Id, i.SocioId, s.Nome AS SocioNome, i.AulaId, a.Nome AS AulaNome, i.DataInscricao
FROM Inscricoes i
LEFT JOIN Socios s ON s.Id = i.SocioId
LEFT JOIN AulasColectivas a ON a.Id = i.AulaId", conn);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Inscricao
                {
                    Id = reader.GetInt32(0),
                    SocioId = reader.GetInt32(1),
                    SocioNome = reader.IsDBNull(2) ? null : reader.GetString(2),
                    AulaId = reader.GetInt32(3),
                    AulaNome = reader.IsDBNull(4) ? null : reader.GetString(4),
                    DataInscricao = reader.IsDBNull(5) ? null : reader.GetDateTime(5)
                });
            }
            return list;
        }

        public void Inscrever(Inscricao inscricao)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                // verificar vagas
                using (var cmdVagas = new SqlCommand("SELECT Vagas FROM AulasColectivas WHERE Id=@Id", conn, tx))
                {
                    cmdVagas.Parameters.AddWithValue("@Id", inscricao.AulaId);
                    var vagasObj = cmdVagas.ExecuteScalar();
                    if (vagasObj == null) throw new Exception("Aula não encontrada");
                    var vagas = Convert.ToInt32(vagasObj);
                    if (vagas <= 0) throw new Model.AulaLotadaException("Aula lotada");
                }

                // verificar inscrição existente
                using (var cmdCheck = new SqlCommand("SELECT COUNT(1) FROM Inscricoes WHERE SocioId=@SocioId AND AulaId=@AulaId", conn, tx))
                {
                    cmdCheck.Parameters.AddWithValue("@SocioId", inscricao.SocioId);
                    cmdCheck.Parameters.AddWithValue("@AulaId", inscricao.AulaId);
                    var exists = Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0;
                    if (exists) throw new Exception("Sócio já inscrito nesta aula");
                }

                // inserir inscrição
                using (var cmdIns = new SqlCommand("INSERT INTO Inscricoes (SocioId, AulaId,DataInscricao) VALUES (@SocioId, @AulaId,@DataInscricao)", conn, tx))
                {
                    cmdIns.Parameters.AddWithValue("@SocioId", inscricao.SocioId);
                    cmdIns.Parameters.AddWithValue("@AulaId", inscricao.AulaId);
                    cmdIns.Parameters.AddWithValue("@DataInscricao", inscricao.DataInscricao);
                    cmdIns.ExecuteNonQuery();
                }

                // decrementar vagas
                using (var cmdUp = new SqlCommand("UPDATE AulasColectivas SET Vagas = Vagas - 1 WHERE Id=@Id", conn, tx))
                {
                    cmdUp.Parameters.AddWithValue("@Id", inscricao.AulaId);
                    cmdUp.ExecuteNonQuery();
                }

                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }
    }
}
