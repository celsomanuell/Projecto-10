using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace ginastica.UI
{
    partial class AulaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxAulas;
        private System.Windows.Forms.TextBox txtInstrutorId;
        private System.Windows.Forms.Label lblSocioId;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listBoxAulas = new ListBox();
            txtInstrutorId = new TextBox();
            lblSocioId = new Label();
            label1 = new Label();
            txtAula = new TextBox();
            label2 = new Label();
            txtVagas = new TextBox();
            label3 = new Label();
            txtSala = new TextBox();
            dateTimePicker = new DateTimePicker();
            label4 = new Label();
            btnCreateAula = new Button();
            SuspendLayout();
            // 
            // listBoxAulas
            // 
            listBoxAulas.Location = new Point(12, 12);
            listBoxAulas.Name = "listBoxAulas";
            listBoxAulas.Size = new Size(368, 304);
            listBoxAulas.TabIndex = 0;
            // 
            // txtInstrutorId
            // 
            txtInstrutorId.Font = new Font("Segoe UI", 12F);
            txtInstrutorId.Location = new Point(493, 31);
            txtInstrutorId.Name = "txtInstrutorId";
            txtInstrutorId.Size = new Size(186, 29);
            txtInstrutorId.TabIndex = 1;
            // 
            // lblSocioId
            // 
            lblSocioId.Font = new Font("Segoe UI", 10F);
            lblSocioId.Location = new Point(411, 37);
            lblSocioId.Name = "lblSocioId";
            lblSocioId.Size = new Size(76, 23);
            lblSocioId.TabIndex = 1;
            lblSocioId.Text = "IntrutorId:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(386, 90);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 3;
            label1.Text = "Nome da aula:";
            // 
            // txtAula
            // 
            txtAula.Font = new Font("Segoe UI", 12F);
            txtAula.Location = new Point(493, 84);
            txtAula.Name = "txtAula";
            txtAula.Size = new Size(186, 29);
            txtAula.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(428, 194);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 5;
            label2.Text = "Vagas:";
            // 
            // txtVagas
            // 
            txtVagas.Font = new Font("Segoe UI", 12F);
            txtVagas.Location = new Point(493, 188);
            txtVagas.Name = "txtVagas";
            txtVagas.Size = new Size(186, 29);
            txtVagas.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(442, 140);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 7;
            label3.Text = "Sala:";
            // 
            // txtSala
            // 
            txtSala.Font = new Font("Segoe UI", 12F);
            txtSala.Location = new Point(493, 134);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(186, 29);
            txtSala.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker.Font = new Font("Segoe UI", 12F);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(493, 241);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.Size = new Size(186, 29);
            dateTimePicker.TabIndex = 9;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(386, 247);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 10;
            label4.Text = "Data e Hora:";
            // 
            // btnCreateAula
            // 
            btnCreateAula.Location = new Point(493, 292);
            btnCreateAula.Name = "btnCreateAula";
            btnCreateAula.Size = new Size(110, 39);
            btnCreateAula.TabIndex = 11;
            btnCreateAula.Text = "Criar Aula";
            btnCreateAula.Click += btnCreateAula_Click;
            // 
            // AulaForm
            // 
            ClientSize = new Size(702, 366);
            Controls.Add(label4);
            Controls.Add(dateTimePicker);
            Controls.Add(label3);
            Controls.Add(txtSala);
            Controls.Add(label2);
            Controls.Add(txtVagas);
            Controls.Add(label1);
            Controls.Add(txtAula);
            Controls.Add(listBoxAulas);
            Controls.Add(lblSocioId);
            Controls.Add(txtInstrutorId);
            Controls.Add(btnCreateAula);
            Name = "AulaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Aulas Colectivas";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox txtAula;
        private Label label2;
        private TextBox txtVagas;
        private Label label3;
        private TextBox txtSala;
        private DateTimePicker dateTimePicker;
        private Label label4;
        private Button btnCreateAula;
    }
}
