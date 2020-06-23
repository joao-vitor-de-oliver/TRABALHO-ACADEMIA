using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMIA.CAMADAS.BLL
{
    class Atletas
    {
        public List<MODEL.Atletas> Select()
        {
            DAL.Atletas dalAtletas = new DAL.Atletas();
            return dalAtletas.Select();
        }
        public void Insert(MODEL.Atletas atleta)
        {
            DAL.Atletas dalAtletas = new DAL.Atletas();
            // if (Atleta.Nome != String.Empty)
            // MessageBox.Show("Informe um nome para cadastrar um Atleta");
            dalAtletas.Insert(atleta);
        }
        public void Update(MODEL.Atletas atleta)
        {
            DAL.Atletas dalAtletas = new DAL.Atletas();
            dalAtletas.Update(atleta);
        }
        public void Delete(int id)
        {
            DAL.Atletas dalAtletas = new DAL.Atletas();
            dalAtletas.Delete(id);
        }

    }
}
