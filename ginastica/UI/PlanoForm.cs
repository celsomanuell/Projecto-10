using System;
using System.Linq;
using System.Windows.Forms;
using ginastica.BLL;
using ginastica.Model;

namespace ginastica.UI
{
    public partial class PlanoForm : Form
    {
        private readonly PlanoService _service = new PlanoService();

        public PlanoForm()
        {
            InitializeComponent();
            LoadList();
        }

        private void LoadList()
        {
            var items = _service.GetAll().ToList();
            listBoxPlanos.DataSource = items;
            listBoxPlanos.DisplayMember = "Nome";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new Plano
                {
                    Nome = txtNome.Text.Trim(),
                    Tipo = Enum.Parse<TipoPlano>(comboTipo.SelectedItem?.ToString() ?? "Misto"),
                    Preco = decimal.Parse(txtPreco.Text.Trim()),
                    Descricao = txtDescricao.Text.Trim()
                };
                _service.Create(p);
                MessageBox.Show("Plano criado");
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
