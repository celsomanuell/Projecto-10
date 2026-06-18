using System;
using System.Linq;
using System.Windows.Forms;
using ginastica.BLL;
using ginastica.Model;

namespace ginastica.UI
{
    public partial class AulaForm : Form
    {
        private readonly AulaService _service = new AulaService();

        public AulaForm()
        {
            InitializeComponent();
            LoadList();
        }

        private void LoadList()
        {
            var items = _service.GetAll().ToList();
            listBoxAulas.DataSource = items;
            listBoxAulas.DisplayMember = "Display";
        }

        private void btnInscrever_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // Inscrever sócio na aula selecionada
            //    if (listBoxAulas.SelectedItem is not AulaColectiva selected) throw new Exception("Selecione uma aula");
            //    var socioId = int.Parse(txtSocioId.Text.Trim());
            //    _service.InscreverSocio(selected.Id, socioId);
            //    MessageBox.Show("Inscrito com sucesso");
            //    LoadList();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnCreateAula_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new AulaColectiva
                {
                    Nome = txtAula.Text.Trim(),
                    InstrutorId = string.IsNullOrWhiteSpace(txtInstrutorId.Text) ? null : int.Parse(txtInstrutorId.Text.Trim()),
                    DataHora = dateTimePicker.Value,
                    Vagas = int.Parse(txtVagas.Text.Trim()),
                    Sala = txtSala.Text.Trim()
                };
                _service.Create(a);
                MessageBox.Show("Aula criada");
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
