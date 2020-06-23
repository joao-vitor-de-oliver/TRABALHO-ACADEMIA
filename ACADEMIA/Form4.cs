using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACADEMIA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Cadastro_de_tutores_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Tutores tutor = new CAMADAS.MODEL.Tutores();
            tutor.Nome = txtNome.Text;
            tutor.Salario = Convert.ToInt32(txtSalario.Text);
            CAMADAS.DAL.Tutores dalTut = new CAMADAS.DAL.Tutores();
            dalTut.Insert(tutor);
            DtGrvTutores.DataSource = " ";
            DtGrvTutores.DataSource = dalTut.Select();
        }

        private void Editar_tutores_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Tutores tutor = new CAMADAS.MODEL.Tutores();
            tutor.Id = Convert.ToInt32(txtId.Text);
            tutor.Nome = txtNome.Text;
            tutor.Salario = Convert.ToInt32(txtSalario.Text);
            CAMADAS.DAL.Tutores dalTut = new CAMADAS.DAL.Tutores();
            dalTut.Update(tutor);

            DtGrvTutores.DataSource = " ";
            DtGrvTutores.DataSource = dalTut.Select();

        }

        private void Remover_tutores_Click(object sender, EventArgs e)
        {
            int idTut = Convert.ToInt32(txtId.Text);
            CAMADAS.DAL.Tutores dalTut = new CAMADAS.DAL.Tutores();
            dalTut.Delete(idTut);

            DtGrvTutores.DataSource = " ";
            DtGrvTutores.DataSource = dalTut.Select();
        }

        private void Voltar_a_tela_inicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtGrvTutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Tutores tutores = new CAMADAS.DAL.Tutores();
            DtGrvTutores.DataSource = "";
            DtGrvTutores.DataSource = tutores.Select();
        }

        private void DtGrvTutores_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = DtGrvTutores.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = DtGrvTutores.SelectedRows[0].Cells["nome"].Value.ToString();
            txtSalario.Text = DtGrvTutores.SelectedRows[0].Cells["salario"].Value.ToString();
        }
    }
}
