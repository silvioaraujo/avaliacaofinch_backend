using Dapper;
using Finch.CumpridoresTerceirizados.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Finch.CumpridoresTerceirizados.Infraestrutura
{
    public class UsuariosRepository
    {
        public static IEnumerable<Usuario> Logar(Usuario usuario)
        {
            MySqlConnection conexao = new MySqlConnection("server=108.179.253.103;User Id=sbtech05_silviot;database=sbtech05_FinchSilvio; password=123@sbfc");
            conexao.Open();
            string sql = "SELECT * FROM Usuario WHERE CPF = @CPF AND Senha = @Senha";
            List<Usuario> resultado = conexao.Query<Usuario>(sql, new { usuario.CPF, usuario.Senha }).ToList();
            conexao.Close();
            return resultado;
        }

        public static void Cadastrar(Usuario usuario)
        {
            MySqlConnection conexao = new MySqlConnection("server=108.179.253.103;User Id=sbtech05_silviot;database=sbtech05_FinchSilvio; password=123@sbfc");
            conexao.Open();
            string sql = "INSERT INTO Usuario (Nome, CPF, Email, Senha) VALUES (@Nome, @CPF, @Email, @Senha)";
            _ = conexao.Execute(sql, new { usuario.Nome, usuario.CPF, usuario.Email, usuario.Senha});
            conexao.Close();
        }
    }
}