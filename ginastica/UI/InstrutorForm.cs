using System;
using System.Linq;
using System.Windows.Forms;
using ginastica.BLL;
using ginastica.Model;

namespace ginastica.UI
{
    public partial class InstrutorForm : Form
    {
        private readonly InstrutorService _service = new InstrutorService();

        public InstrutorForm()
        {
            InitializeComponent();
            LoadList();
        }

        private void LoadList()
        {
            var items = _service.GetAll().ToList();
            listBoxInstrutores.DataSource = items;
            listBoxInstrutores.DisplayMember = "Nome";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var i = new Instrutor
                {
                    Nome = txtNome.Text.Trim(),
                    Telefone = txtTelefone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Especialidade = txtEspecialidade.Text.Trim()
                };
                var id = _service.Create(i);
                MessageBox.Show($"Instrutor criado com Id {id}");
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxInstrutores.SelectedItem is not Instrutor selected) return;
            try
            {
                _service.Delete(selected.Id);
                MessageBox.Show("Eliminado");
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxInstrutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxInstrutores.SelectedItem is not Instrutor i) return;
            txtNome.Text = i.Nome;
            txtTelefone.Text = i.Telefone;
            txtEmail.Text = i.Email;
            txtEspecialidade.Text = i.Especialidade;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxInstrutores.SelectedItem is not Instrutor selected) return;
            try
            {
                selected.Nome = txtNome.Text.Trim();
                selected.Telefone = txtTelefone.Text.Trim();
                selected.Email = txtEmail.Text.Trim();
                selected.Especialidade = txtEspecialidade.Text.Trim();
                _service.Update(selected);
                MessageBox.Show("Actualizado");
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
