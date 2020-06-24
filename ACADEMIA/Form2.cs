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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Alunos dalAlu = new CAMADAS.DAL.Alunos();
            DtGrvAlunos.DataSource = dalAlu.Select();
        }

        private void TxtCadastrar_aluno_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Alunos bllAlunos = new CAMADAS.BLL.Alunos();
            CAMADAS.MODEL.Alunos alunos = new CAMADAS.MODEL.Alunos();
            //String msg = "";
            // string caixa = "ATENÇÃO";
            // if (idtxt.Text != "-1")
            // msg = "Deseja realizar um novo cadastro?";
            alunos.Nome = Nometxt.Text;
            alunos.Idade = Convert.ToInt32(Idadetxt.Text);
            alunos.Telefone = Telefonetxt.Text;
            alunos.Dias = Convert.ToInt32(Diastxt.Text);
            alunos.Multa = Convert.ToInt32(Multatxt.Text);
            CAMADAS.DAL.Alunos dalAlu = new CAMADAS.DAL.Alunos();
            dalAlu.Insert(alunos);

            DtGrvAlunos.DataSource = "";
            DtGrvAlunos.DataSource = dalAlu.Select();

        }

        private void TxtVoltar_a_tela_inicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtEditar_aluno_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Alunos alunos = new CAMADAS.MODEL.Alunos();
            CAMADAS.BLL.Alunos bllAlunos = new CAMADAS.BLL.Alunos();
            alunos.Id = Convert.ToInt32(idtxt.Text);
            alunos.Nome = Nometxt.Text;
            alunos.Idade = Convert.ToInt32(Idadetxt.Text);
            alunos.Telefone = Telefonetxt.Text;
            alunos.Dias = Convert.ToInt32(Diastxt.Text);
            alunos.Multa = Convert.ToInt32(Multatxt.Text);
            CAMADAS.DAL.Alunos dalAlu = new CAMADAS.DAL.Alunos();
            dalAlu.Update(alunos);

            DtGrvAlunos.DataSource = "";
            DtGrvAlunos.DataSource = dalAlu.Select();
        }

        private void TxtRemover_aluno_Click(object sender, EventArgs e)
        {
            int idAlu = Convert.ToInt32(idtxt.Text);
            CAMADAS.BLL.Alunos bllAlunos = new CAMADAS.BLL.Alunos();
            CAMADAS.DAL.Alunos dalAlu = new CAMADAS.DAL.Alunos();
            dalAlu.Delete(idAlu);

            DtGrvAlunos.DataSource = "";
            DtGrvAlunos.DataSource = dalAlu.Select();
        }

        private void DtGrvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtGrvAlunos_DoubleClick(object sender, EventArgs e)
        {
            idtxt.Text = DtGrvAlunos.SelectedRows[0].Cells["id"].Value.ToString();
            Nometxt.Text = DtGrvAlunos.SelectedRows[0].Cells["nome"].Value.ToString();
            Idadetxt.Text = DtGrvAlunos.SelectedRows[0].Cells["idade"].Value.ToString();
            Telefonetxt.Text = DtGrvAlunos.SelectedRows[0].Cells["telefone"].Value.ToString();
            Multatxt.Text = DtGrvAlunos.SelectedRows[0].Cells["multa"].Value.ToString();
            Diastxt.Text = DtGrvAlunos.SelectedRows[0].Cells["dias"].Value.ToString();

        }

        private void TxtBuscar_Click(object sender, EventArgs e)
        {
           
            GpBPesquisa.Visible = !GpBPesquisa.Visible;
        }

        private void RdbId_CheckedChanged(object sender, EventArgs e)
        {
            LblFiltrar.Text = "Informe ID";
            TxtFiltro.Text = "";
            LblFiltrar.Visible = true;
            TxtFiltro.Visible = true;
            TxtFiltro.Focus();
        }

        private void RdbNome_CheckedChanged(object sender, EventArgs e)
        {
            LblFiltrar.Text = "Informe o Nome";
            TxtFiltro.Text = "";
            LblFiltrar.Visible = true;
            TxtFiltro.Visible = true;
            TxtFiltro.Focus();
        }

        private void RdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            LblFiltrar.Visible = false;
            TxtFiltro.Visible = false;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Alunos bllAlunos = new CAMADAS.BLL.Alunos();
            List<CAMADAS.MODEL.Alunos> lstAlunos = new List<CAMADAS.MODEL.Alunos>();
            if (RdbTodos.Checked)
                lstAlunos = bllAlunos.Select();

            else if (RdbId.Checked)
            {
                int id = Convert.ToInt32(TxtFiltro.Text);
                lstAlunos = bllAlunos.SelectByID(id);
            }
            else lstAlunos = bllAlunos.SelectByNome(TxtFiltro.Text);
            DtGrvAlunos.DataSource = "";
            DtGrvAlunos.DataSource = lstAlunos;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        // private void habilitaControles(bool status)
        //{
        //  txtNome.Enabled = status;
        //  TxtIdade.Enabled = status;
        //  txtTelefone.Enabled = status;
        //  txtMulta.Enabled = status;
        //  txtDias.Enabled = status;
        //}
        // habilitacontroles(true ou false);
    }
}
