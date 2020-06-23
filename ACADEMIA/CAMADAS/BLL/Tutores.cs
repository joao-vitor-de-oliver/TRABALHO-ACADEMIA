using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMIA.CAMADAS.BLL
{
    class Tutores
    {
        public List<MODEL.Tutores> Select()
        {
            DAL.Tutores dalTutores = new DAL.Tutores();
            return dalTutores.Select();
        }
        public void Insert(MODEL.Tutores tutor)
        {
            DAL.Tutores dalTutores = new DAL.Tutores();
            // if (Tutores.Nome != String.Empty)
            // MessageBox.Show("Informe um nome para cadastrar um Tutor");
            dalTutores.Insert(tutor);
        }
        public void Update(MODEL.Tutores tutor)
        {
            DAL.Tutores dalTutores = new DAL.Tutores();
            dalTutores.Insert(tutor);
        }
        public void Delete(int id)
        {
            DAL.Tutores dalTutores = new DAL.Tutores();
            dalTutores.Delete(id);
        }
    }
}
