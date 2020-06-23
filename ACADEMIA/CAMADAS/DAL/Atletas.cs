using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMIA.CAMADAS.DAL
{
    public class Atletas
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Atletas> Select()
        {
            List<MODEL.Atletas> lstAtletas = new List<MODEL.Atletas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Atletas";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Atletas atleta = new MODEL.Atletas();
                    atleta.Id = Convert.ToInt32(dados["id"].ToString());
                    atleta.Nome = dados["nome"].ToString();
                    atleta.Telefone = dados["telefone"].ToString();
                    lstAtletas.Add(atleta);
                }
            }
            catch
            {
                Console.WriteLine("Bug na consulta de Atletas");
            }
            finally
            {
                conexao.Close();
            }

            return lstAtletas;
        }
        
        public void Insert(MODEL.Atletas atleta)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Atletas VALUES(@nome, @telefone); ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", atleta.Nome);
            cmd.Parameters.AddWithValue("@telefone", atleta.Telefone);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Bug na insclusão de atletas");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Atletas atleta)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Atletas SET nome=@nome, telefone=@telefone";
            sql += " WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", atleta.Id);
            cmd.Parameters.AddWithValue("@nome", atleta.Nome);
            cmd.Parameters.AddWithValue("@telefone", atleta.Telefone);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Bug na edição de atletas");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Atletas WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);       
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Bug na remoção de atletas");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
