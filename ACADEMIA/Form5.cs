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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void TxtVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtRelatório_alunos_Click(object sender, EventArgs e)
        {
            RELATORIO.RelGeral.relAluno();
        }

        private void TxtRelatório_atleta_Click(object sender, EventArgs e)
        {
            RELATORIO.RelGeral.relAtletas();
        }

        private void TxtRelatorio_tutores_Click(object sender, EventArgs e)
        {
            RELATORIO.RelGeral.relTutores();
        }
    }
}
