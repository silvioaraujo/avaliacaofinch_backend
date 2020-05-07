using Dapper;
using Finch.CumpridoresTerceirizados.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Infraestrutura
{
    public class ServicosRepository
    {
        public static IEnumerable<Servico> GetServicos()
        {
            MySqlConnection conexao = new MySqlConnection("server=108.179.253.103;User Id=sbtech05_silviot;database=sbtech05_FinchSilvio; password=123@sbfc");
            conexao.Open();
            string sql = "SELECT * FROM Servico";
            var resultado = conexao.Query<Servico>(sql).ToList();
            conexao.Close();
            return resultado;
        }
        public static void SetServico(Servico servico)
        {
            MySqlConnection conexao = new MySqlConnection("server=108.179.253.103;User Id=sbtech05_silviot;database=sbtech05_FinchSilvio; password=123@sbfc");
            conexao.Open();
            string sql = "INSERT INTO Servico (ID_Servico, Status_Servico, ID_Usuario) VALUES (@ID_Servico, @Status_Servico, @ID_Usuario)";
            _ = conexao.Execute(sql, new { servico.ID_Servico, servico.Status_Servico, servico.ID_Usuario });
            conexao.Close();
        }
    }
}
