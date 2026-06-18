using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace ginastica.UI
{
    partial class SocioForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxSocios;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox ComboPlano;
        private System.Windows.Forms.ComboBox ComboEstado;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.Label lblEstado;

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
            listBoxSocios = new ListBox();
            txtNome = new TextBox();
            dateTimePicker = new DateTimePicker();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            ComboPlano = new ComboBox();
            ComboEstado = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblNome = new Label();
            lblDataNascimento = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblPlano = new Label();
            lblEstado = new Label();
            SuspendLayout();
            // 
            // listBoxSocios
            // 
            listBoxSocios.Location = new Point(12, 12);
            listBoxSocios.Name = "listBoxSocios";
            listBoxSocios.Size = new Size(200, 304);
            listBoxSocios.TabIndex = 0;
            listBoxSocios.SelectedIndexChanged += listBoxSocios_SelectedIndexChanged;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(311, 19);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 29);
            txtNome.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 12F);
            dateTimePicker.Location = new Point(311, 59);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 29);
            dateTimePicker.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F);
            txtTelefone.Location = new Point(311, 99);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(200, 29);
            txtTelefone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(311, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 29);
            txtEmail.TabIndex = 8;
            // 
            // ComboPlano
            // 
            ComboPlano.Font = new Font("Segoe UI", 12F);
            ComboPlano.Location = new Point(311, 179);
            ComboPlano.Name = "ComboPlano";
            ComboPlano.Size = new Size(200, 29);
            ComboPlano.TabIndex = 10;
            // 
            // ComboEstado
            // 
            ComboEstado.Font = new Font("Segoe UI", 12F);
            ComboEstado.Location = new Point(311, 219);
            ComboEstado.Name = "ComboEstado";
            ComboEstado.Size = new Size(200, 29);
            ComboEstado.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(220, 279);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 43);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Adicionar";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(358, 279);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 43);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Actualizar";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(498, 279);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 43);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Eliminar";
            btnDelete.Click += btnDelete_Click;
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.Location = new Point(258, 23);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(49, 23);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.Font = new Font("Segoe UI", 10F);
            lblDataNascimento.Location = new Point(218, 63);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(89, 23);
            lblDataNascimento.TabIndex = 3;
            lblDataNascimento.Text = "Data Nasc:";
            // 
            // lblTelefone
            // 
            lblTelefone.Font = new Font("Segoe UI", 10F);
            lblTelefone.Location = new Point(238, 103);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(69, 23);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(258, 143);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 23);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblPlano
            // 
            lblPlano.Font = new Font("Segoe UI", 10F);
            lblPlano.Location = new Point(258, 183);
            lblPlano.Name = "lblPlano";
            lblPlano.Size = new Size(49, 23);
            lblPlano.TabIndex = 9;
            lblPlano.Text = "Plano:";
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI", 10F);
            lblEstado.Location = new Point(248, 223);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(59, 23);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado:";
            // 
            // SocioForm
            // 
            ClientSize = new Size(640, 341);
            Controls.Add(listBoxSocios);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblDataNascimento);
            Controls.Add(dateTimePicker);
            Controls.Add(lblTelefone);
            Controls.Add(txtTelefone);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPlano);
            Controls.Add(ComboPlano);
            Controls.Add(lblEstado);
            Controls.Add(ComboEstado);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "SocioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Sócios";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
