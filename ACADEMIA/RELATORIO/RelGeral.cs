using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACADEMIA.CAMADAS;
using System.Threading.Tasks;
using System.IO;
using ACADEMIA.CAMADAS.MODEL;
using ACADEMIA.CAMADAS.BLL;
using ACADEMIA.CAMADAS.DAL;

namespace ACADEMIA.RELATORIO
{
    public class RelGeral
    {
        public static void relAluno()
        {
            CAMADAS.BLL.Alunos bllAlunos = new CAMADAS.BLL.Alunos();
            List<CAMADAS.MODEL.Alunos> lstAlunos = new List<CAMADAS.MODEL.Alunos>();
            lstAlunos = bllAlunos.Select();
            string pasta = Funcoes.deretorioPasta();
            string arquivo = pasta + @"\RelAlunos.html";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' " +
                             "content='text/html; charset=utf-8'/>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatório dos Alunos</h1>");
                sw.WriteLine("<hr align='left' border: '8px' />");
                sw.WriteLine("<table>");
                // cabeçalho 
                sw.WriteLine("<tr>");
                sw.WriteLine("<td align = 'right' width = '250px'>");
                sw.WriteLine("ID");
                sw.WriteLine("</th>");

                sw.WriteLine("<td align = 'right' width = '250px'>");
                sw.WriteLine("Nome");
                sw.WriteLine("</th>");

                sw.WriteLine("<td align = 'right' width = '250px'>");
                sw.WriteLine("Idade");
                sw.WriteLine("</th>");

                sw.WriteLine("<td align = 'right' width = '250px'>");
                sw.WriteLine("Telefone");
                sw.WriteLine("</th>");

                sw.WriteLine("<td align = 'right' width = '250px'>");
                sw.WriteLine("Multa");
                sw.WriteLine("</th>");

                sw.WriteLine("<td align = 'right' width = '250px'>");
                sw.WriteLine("Dias");
                sw.WriteLine("</th>");
                sw.WriteLine("</tr>");

                foreach (CAMADAS.MODEL.Alunos alunos in lstAlunos)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align = 'right' width = '30px'>");
                    sw.WriteLine(alunos.Id);
                    sw.WriteLine("</td>");

                    sw.WriteLine("<td align = 'right' width = '250px'>");
                    sw.WriteLine(alunos.Nome);
                    sw.WriteLine("</td>");

                    sw.WriteLine("<td align = 'right' width = '250px'>");
                    sw.WriteLine(alunos.Idade);
                    sw.WriteLine("</td>");

                    sw.WriteLine("<td align = 'right' width = '250px'>");
                    sw.WriteLine(alunos.Telefone);
                    sw.WriteLine("</td>");

                    sw.WriteLine("<td align = 'right' width = '250px'>");
                    sw.WriteLine(alunos.Multa);
                    sw.WriteLine("</td>");

                    sw.WriteLine("<td align = 'right' width = '250px'>");
                    sw.WriteLine(alunos.Dias);
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                }

                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border: '15px' />");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");

            }
            System.Diagnostics.Process.Start(arquivo);

        }
        public static void relAtletas()
        {
            CAMADAS.BLL.Atletas bllAtletas = new CAMADAS.BLL.Atletas();
            List<CAMADAS.MODEL.Atletas> lstAtletas = new List<CAMADAS.MODEL.Atletas>();
            lstAtletas = bllAtletas.Select();
            string pasta = Funcoes.deretorioPasta();
            string arquivo = pasta + @"\RelAtletas.html";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' " +
                             "content='text/html; charset=utf-8'/>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatório dos Atletas</h1>");
                sw.WriteLine("<hr align='left' border: '8px' />");
                sw.WriteLine("<table>");
                // cabeçalho 
                sw.WriteLine("<tr>");
                sw.WriteLine("<td align = 'right' width = '150px'>");
                sw.WriteLine("ID");
                sw.WriteLine("</th>");

                sw.WriteLine("<td align = 'right' width = '250px'>");
                sw.WriteLine("Nome");
                sw.WriteLine("</th>");

                sw.WriteLine("<td align = 'right' width = '250px'>");
                sw.WriteLine("Telefone");
                sw.WriteLine("</th>");
                sw.WriteLine("</tr>");

                foreach (CAMADAS.MODEL.Atletas atletas in lstAtletas)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align = 'right' width = '30px'>");
                    sw.WriteLine(atletas.Id);
                    sw.WriteLine("</td>");

                    sw.WriteLine("<td align = 'right' width = '250px'>");
                    sw.WriteLine(atletas.Nome);
                    sw.WriteLine("</td>");

                    sw.WriteLine("<td align = 'right' width = '250px'>");
                    sw.WriteLine(atletas.Telefone);
                    sw.WriteLine("</td>");

                }

                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border: '15px' />");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");

            }
            System.Diagnostics.Process.Start(arquivo);
        }
        public static void relTutores()
        {
            CAMADAS.BLL.Tutores bllTutores = new CAMADAS.BLL.Tutores();
            List<CAMADAS.MODEL.Tutores> lstTutores = new List<CAMADAS.MODEL.Tutores>();
            lstTutores = bllTutores.Select();
            string pasta = Funcoes.deretorioPasta();
            string arquivo = pasta + @"\RelTutores.html";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' " +
                             "content='text/html; charset=utf-8'/>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatório dos Tutores</h1>");
                sw.WriteLine("<hr align='left' border: '8px' />");
                sw.WriteLine("<table>");
                // cabeçalho 
                sw.WriteLine("<tr>");
                sw.WriteLine("<td align = 'right' width = '150px'>");
                sw.WriteLine("ID");
                sw.WriteLine("</th>");

                sw.WriteLine("<td align = 'right' width = '250px'>");
                sw.WriteLine("Nome");
                sw.WriteLine("</th>");

                sw.WriteLine("<td align = 'right' width = '250px'>");
                sw.WriteLine("Salario");
                sw.WriteLine("</th>");
                sw.WriteLine("</tr>");

                foreach (CAMADAS.MODEL.Tutores tutores in lstTutores)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align = 'right' width = '30px'>");
                    sw.WriteLine(tutores.Id);
                    sw.WriteLine("</td>");

                    sw.WriteLine("<td align = 'right' width = '250px'>");
                    sw.WriteLine(tutores.Nome);
                    sw.WriteLine("</td>");

                    sw.WriteLine("<td align = 'right' width = '250px'>");
                    sw.WriteLine(tutores.Salario);
                    sw.WriteLine("</td>");

                }

                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border: '15px' />");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");

            }
            System.Diagnostics.Process.Start(arquivo);
        }


    }
}
