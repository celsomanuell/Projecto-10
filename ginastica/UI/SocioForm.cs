using System;
using System.Linq;
using System.Windows.Forms;
using ginastica.BLL;
using ginastica.Model;

namespace ginastica.UI
{
    public partial class SocioForm : Form
    {
        private readonly SocioService _service = new SocioService();

        public SocioForm()
        {
            InitializeComponent();
            ComboPlano.Items.AddRange(Enum.GetNames(typeof(TipoPlano)));
            ComboEstado.Items.AddRange(Enum.GetNames(typeof(EstadoPagamento)));
            LoadList();
        }

        private void LoadList()
        {
            var items = _service.GetAll().ToList();
            listBoxSocios.DataSource = items;
            listBoxSocios.DisplayMember = "Nome";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var s = new Socio
                {
                    Nome = txtNome.Text.Trim(),
                    DataNascimento = DateOnly.Parse(dateTimePicker.Value.ToShortDateString()),
                    Telefone = txtTelefone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Plano = Enum.Parse<TipoPlano>(ComboPlano.SelectedItem?.ToString() ?? "Misto"),
                    EstadoPagamento = Enum.Parse<EstadoPagamento>(ComboEstado.SelectedItem?.ToString() ?? "EmDia")
                };
                var id = _service.Create(s);
                MessageBox.Show($"Sócio criado com Id {id}");
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxSocios.SelectedItem is not Socio selected) return;
            try
            {
                selected.Nome = txtNome.Text.Trim();
                selected.DataNascimento = DateOnly.Parse(dateTimePicker.Value.ToShortDateString());
                selected.Telefone = txtTelefone.Text.Trim();
                selected.Email = txtEmail.Text.Trim();
                selected.Plano = Enum.Parse<TipoPlano>(ComboPlano.SelectedItem?.ToString() ?? "Misto");
                selected.EstadoPagamento = Enum.Parse<EstadoPagamento>(ComboEstado.SelectedItem?.ToString() ?? "EmDia");
                _service.Update(selected);
                MessageBox.Show("Actualizado");
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxSocios.SelectedItem is not Socio selected) return;
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

        private void listBoxSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSocios.SelectedItem is not Socio s) return;
            txtNome.Text = s.Nome;
            dateTimePicker.Value = s.DataNascimento.ToDateTime(new TimeOnly(0));
            txtTelefone.Text = s.Telefone;
            txtEmail.Text = s.Email;
            ComboPlano.SelectedItem = s.Plano.ToString();
            ComboEstado.SelectedItem = s.EstadoPagamento.ToString();
        }
    }
}
