using System;
using System.Linq;
using System.Windows.Forms;
using ginastica.BLL;
using ginastica.Model;

namespace ginastica.UI
{
    public partial class PagamentoForm : Form
    {
        private readonly PagamentoService _service = new PagamentoService();

        public PagamentoForm()
        {
            InitializeComponent();
            LoadList();
        }

        private void LoadList()
        {
            var items = _service.GetAll().ToList();
            listBoxInstrutores.DataSource = items;
            listBoxInstrutores.DisplayMember = "Display";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new Pagamento
                {
                    SocioId = int.Parse(txtSocioId.Text.Trim()),
                    DataPagamento = dateTimePicker.Value,
                    Valor = decimal.Parse(txtValor.Text.Trim()),
                    Metodo = txtMetodo.Text.Trim(),
                    Observacoes = txtObservacoes.Text.Trim()
                };
                _service.RegistrarPagamento(p);
                MessageBox.Show("Pagamento registado");
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
