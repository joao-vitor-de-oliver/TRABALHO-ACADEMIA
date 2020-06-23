using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMIA.CAMADAS.MODEL
{
    public class Contas_pagar
    {
        public int id { get; set; }
        public string desricao { get; set; }
        public DateTime vencimento { get; set; }
        public float valor { get; set; }
      
    }
}
