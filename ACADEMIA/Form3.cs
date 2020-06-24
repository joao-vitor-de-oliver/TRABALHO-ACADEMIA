using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACADEMIA.CAMADAS.DAL;

namespace ACADEMIA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void TxtCadastrar_Atleta_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Atletas atleta = new CAMADAS.MODEL.Atletas();
            CAMADAS.BLL.Atletas bllAtletas = new CAMADAS.BLL.Atletas();
            atleta.Nome = Nometxt.Text;
            atleta.Telefone = Telefonetxt.Text;
            CAMADAS.DAL.Atletas dalAtle = new CAMADAS.DAL.Atletas();
            dalAtle.Insert(atleta);

            DtGrvAtletas.DataSource = " ";
            DtGrvAtletas.DataSource = dalAtle.Select();           
        }

        private void TxtEditar_Atleta_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Atletas atleta = new CAMADAS.MODEL.Atletas();
            CAMADAS.BLL.Atletas bllAtletas = new CAMADAS.BLL.Atletas();
            atleta.Id = Convert.ToInt32(Idtxt.Text);
            atleta.Nome = Nometxt.Text;
            atleta.Telefone = Telefonetxt.Text;
            CAMADAS.DAL.Atletas dalAtle = new CAMADAS.DAL.Atletas();
            dalAtle.Update(atleta);

            DtGrvAtletas.DataSource = "";
            DtGrvAtletas.DataSource = dalAtle.Select();

        }

        private void TxtRemover_Atleta_Click(object sender, EventArgs e)
        {
            int idAtle =  Convert.ToInt32(Idtxt.Text);
            CAMADAS.BLL.Atletas bllAtletas = new CAMADAS.BLL.Atletas();
            CAMADAS.DAL.Atletas dalAtle = new CAMADAS.DAL.Atletas();
            dalAtle.Delete(idAtle);

            DtGrvAtletas.DataSource = "";
            DtGrvAtletas.DataSource = dalAtle.Select();

        }

        private void TxtVoltar_a_tela_inicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtGrvAtletas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //CAMADAS.DAL.Atletas dalAtle = new CAMADAS.DAL.Atletas();
            //DtGrvAtletas.DataSource = dalAtle.Select();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aCADEMIADataSet.Atletas'. Você pode movê-la ou removê-la conforme necessário.
            this.atletasTableAdapter.Fill(this.aCADEMIADataSet.Atletas);

        }

        private void DtGrvAtletas_DoubleClick(object sender, EventArgs e)
        {
            Idtxt.Text = DtGrvAtletas.SelectedRows[0].Cells["id"].Value.ToString();
            Nometxt.Text = DtGrvAtletas.SelectedRows[0].Cells["nome"].Value.ToString();
            Telefonetxt.Text = DtGrvAtletas.SelectedRows[0].Cells["telefone"].Value.ToString();
        }
    }
}
