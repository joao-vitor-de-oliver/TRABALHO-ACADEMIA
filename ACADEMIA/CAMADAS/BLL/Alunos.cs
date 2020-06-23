using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACADEMIA.CAMADAS.BLL
{
    class Alunos
    {
        public List<MODEL.Alunos> Select()
        {
            DAL.Alunos dalAlunos = new DAL.Alunos();
            return dalAlunos.Select();
        }
        public void Insert(MODEL.Alunos alunos)
        {
            DAL.Alunos dalAlunos = new DAL.Alunos();
           // if (alunos.Nome != String.Empty)
           // MessageBox.Show("Informe um nome para cadastrar um Aluno");
            dalAlunos.Insert(alunos);
        }
        public void Update(MODEL.Alunos alunos)
        {
            DAL.Alunos dalAlunos = new DAL.Alunos();
            dalAlunos.Update(alunos);
        }
        public void Delete(int idAlunos)
        {
            DAL.Alunos dalAlunos = new DAL.Alunos();
            dalAlunos.Delete(idAlunos);
        }
    }
}
