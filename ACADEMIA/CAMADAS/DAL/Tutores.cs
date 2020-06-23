using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMIA.CAMADAS.DAL
{
    public class Tutores
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Tutores> Select()
        {
            List<MODEL.Tutores> lstTutores = new List<MODEL.Tutores>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Tutores";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Tutores tutor = new MODEL.Tutores();
                    tutor.Id = Convert.ToInt32(dados["id"].ToString());
                    tutor.Nome = dados["nome"].ToString();
                    tutor.Salario = Convert.ToInt32(dados["salario"].ToString());
                    lstTutores.Add(tutor);
                }
            }
            catch
            {
                Console.WriteLine("Bug na consulta de Tutores");
            }
            finally
            {
                conexao.Close();
            }

            return lstTutores;
        }

        public void Insert(MODEL.Tutores tutor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Tutores VALUES(@nome, @salario); ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", tutor.Nome);
            cmd.Parameters.AddWithValue("@salario", tutor.Salario);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Bug na insclusão de tutores");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Tutores tutor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Tutores SET nome=@nome, salario=@salario";
            sql += " WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", tutor.Id);
            cmd.Parameters.AddWithValue("@nome", tutor.Nome);
            cmd.Parameters.AddWithValue("@salario", tutor.Salario);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Bug na edição de tutores");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Tutores WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Bug na remoção de tutores");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}

