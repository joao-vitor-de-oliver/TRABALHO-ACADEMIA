using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMIA.CAMADAS.MODEL
{
    public class Alunos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public float Multa { get; set; }
        public int Dias { get; set; }
    }
}
