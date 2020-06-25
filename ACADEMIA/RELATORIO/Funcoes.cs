using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMIA.RELATORIO
{
    public class Funcoes
    {
        public static string deretorioPasta()
        {
            string pasta = @"c:\RELACADEMIA";
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            return pasta;
        }

    }

}
