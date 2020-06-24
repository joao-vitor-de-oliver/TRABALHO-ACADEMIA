using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ACADEMIA.CAMADAS.DAL
{
    public class Alunos
    {
        public string StrCon = Conexao.getConexao();

        public List<MODEL.Alunos> Select()
        {    // Aqui recupera dados de um aluno 
            List<MODEL.Alunos> lstAlunos = new List<MODEL.Alunos>();
            SqlConnection conexao = new SqlConnection(StrCon);
            string sql = " SELECT * FROM Alunos;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (dados.Read()) {
                    MODEL.Alunos alunos = new MODEL.Alunos();
                    alunos.Id = Convert.ToInt32(dados["id"].ToString());
                    alunos.Nome = dados["nome"].ToString();
                    alunos.Idade = Convert.ToInt32 (dados["idade"].ToString());
                    alunos.Telefone = dados["telefone"].ToString();
                    alunos.Dias = Convert.ToInt32(dados["dias"].ToString());
                    alunos.Multa = Convert.ToSingle(dados["multa"].ToString());
                    lstAlunos.Add(alunos);
                }
            }
            catch{
                Console.WriteLine("Bugou a consulta de alunos.");
            }
            finally
            {
                    
            }
            return lstAlunos;
        }
        public List<MODEL.Alunos> SelectByID(int id)
        {    // Aqui recupera dados de um aluno por id
            List<MODEL.Alunos> lstAlunos = new List<MODEL.Alunos>();
            SqlConnection conexao = new SqlConnection(StrCon);
            string sql = " SELECT * FROM Alunos WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id",id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Alunos alunos = new MODEL.Alunos();
                    alunos.Id = Convert.ToInt32(dados["id"].ToString());
                    alunos.Nome = dados["nome"].ToString();
                    alunos.Idade = Convert.ToInt32(dados["idade"].ToString());
                    alunos.Telefone = dados["telefone"].ToString();
                    alunos.Dias = Convert.ToInt32(dados["dias"].ToString());
                    alunos.Multa = Convert.ToSingle(dados["multa"].ToString());
                    lstAlunos.Add(alunos);
                }
            }
            catch
            {
                Console.WriteLine("Bugou a consulta de alunos.");
            }
            finally
            {

            }
            return lstAlunos;
        }
        public List<MODEL.Alunos> SelectByNome(string nome)
        {    // Aqui recupera dados de um aluno por id
            List<MODEL.Alunos> lstAlunos = new List<MODEL.Alunos>();
            SqlConnection conexao = new SqlConnection(StrCon);
            string sql = " SELECT * FROM Alunos WHERE nome LIKE @nome";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome.Trim() + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Alunos alunos = new MODEL.Alunos();
                    alunos.Id = Convert.ToInt32(dados["id"].ToString());
                    alunos.Nome = dados["nome"].ToString();
                    alunos.Idade = Convert.ToInt32(dados["idade"].ToString());
                    alunos.Telefone = dados["telefone"].ToString();
                    alunos.Dias = Convert.ToInt32(dados["dias"].ToString());
                    alunos.Multa = Convert.ToSingle(dados["multa"].ToString());
                    lstAlunos.Add(alunos);
                }
            }
            catch
            {
                Console.WriteLine("Bugou a consulta de alunos.");
            }
            finally
            {

            }
            return lstAlunos;
        }

        public void Insert (MODEL.Alunos alunos)
        {     // metodo para inserir os dados na tabela dos alunos
            SqlConnection conexao = new SqlConnection(StrCon);
            String sql = "INSERT INTO Alunos VALUES (@nome, @idade, @telefone, @multa, @dias);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", alunos.Nome);
            cmd.Parameters.AddWithValue("@idade", alunos.Idade);
            cmd.Parameters.AddWithValue("@telefone", alunos.Telefone);
            cmd.Parameters.AddWithValue("@multa", alunos.Multa);
            cmd.Parameters.AddWithValue("@dias", alunos.Dias);

          
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Bugou a inserção de Alunos.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Alunos alunos)
        {     // metodo para atualizar dados os dados na tabela dos alunos
            SqlConnection conexao = new SqlConnection(StrCon);
            String sql = "UPDATE Alunos SET nome=@nome, idade=@idade, telefone=@telefone, multa=@multa, dias=@dias ";
            sql += " WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", alunos.Id);
            cmd.Parameters.AddWithValue("@nome", alunos.Nome);
            cmd.Parameters.AddWithValue("@idade", alunos.Idade);
            cmd.Parameters.AddWithValue("@telefone", alunos.Telefone);
            cmd.Parameters.AddWithValue("@multa", alunos.Multa);
            cmd.Parameters.AddWithValue("@dias", alunos.Dias);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Bugou a atualização de Alunos.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete (int idAlunos)
        {
            SqlConnection conexao = new SqlConnection(StrCon);
            String sql = "DELETE FROM Alunos WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idAlunos);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Bugou a exclusão de Alunos...");
            }
            finally
            {
                conexao.Close();
            }

        }


    }
}
