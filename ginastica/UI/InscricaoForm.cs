using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ginastica.BLL;
using ginastica.Model;

namespace ginastica.UI
{
    public partial class InscricaoForm : Form
    {
        private readonly InscricaoService _service = new InscricaoService();
        public InscricaoForm()
        {
            InitializeComponent();
            LoadList();
        }

        private void LoadList()
        {
            var items = _service.GetAll().ToList();
            listBoxSocios.DataSource = items;
            // mostra "Sócio - Aula" no ListBox usando a propriedade Display
            listBoxSocios.DisplayMember = "Display";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var s = new Inscricao
                {
                    SocioId = int.Parse(txtSocioId.Text),
                    AulaId = int.Parse(txtAulaId.Text),
                    DataInscricao= DateTime.Now,
                };
                _service.Create(s);
                MessageBox.Show($"Inscrição criado");
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
