using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACADEMIA.CAMADAS.DAL
{
    public class Conexao
    {
        public static string getConexao()
            {
            return @"Data Source=.\sqlexpress;Initial Catalog=ACADEMIA;Integrated Security=True";
            }
    }
}
