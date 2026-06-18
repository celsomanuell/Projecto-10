using System;
using System.Windows.Forms;

namespace ginastica.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            var f = new SocioForm();
            f.ShowDialog();
        }

        private void btnPlanos_Click(object sender, EventArgs e)
        {
            var f = new PlanoForm();
            f.ShowDialog();
        }

        private void btnInstrutores_Click(object sender, EventArgs e)
        {
            var f = new InstrutorForm();
            f.ShowDialog();
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            var f = new AulaForm();
            f.ShowDialog();
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            var f = new PagamentoForm();
            f.ShowDialog();
        }

        private void btnInscrever_Click(object sender, EventArgs e)
        {
            var f = new InscricaoForm();
            f.ShowDialog();
        }
    }
}
