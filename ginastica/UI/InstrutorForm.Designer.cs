using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace ginastica.UI
{
    partial class InstrutorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxInstrutores;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEspecialidade;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEspecialidade;

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
            listBoxInstrutores = new ListBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtEspecialidade = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblNome = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblEspecialidade = new Label();
            SuspendLayout();
            // 
            // listBoxInstrutores
            // 
            listBoxInstrutores.Location = new Point(12, 12);
            listBoxInstrutores.Name = "listBoxInstrutores";
            listBoxInstrutores.Size = new Size(200, 244);
            listBoxInstrutores.TabIndex = 0;
            listBoxInstrutores.SelectedIndexChanged += listBoxInstrutores_SelectedIndexChanged;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(347, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 29);
            txtNome.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F);
            txtTelefone.Location = new Point(347, 60);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(200, 29);
            txtTelefone.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(347, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 29);
            txtEmail.TabIndex = 3;
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.Font = new Font("Segoe UI", 12F);
            txtEspecialidade.Location = new Point(347, 140);
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.Size = new Size(200, 29);
            txtEspecialidade.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(243, 246);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 38);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Adicionar";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(370, 246);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 38);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Actualizar";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(492, 246);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 38);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Eliminar";
            btnDelete.Click += btnDelete_Click;
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.Location = new Point(287, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(54, 23);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            lblTelefone.Font = new Font("Segoe UI", 10F);
            lblTelefone.Location = new Point(267, 60);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(74, 23);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(287, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblEspecialidade
            // 
            lblEspecialidade.Font = new Font("Segoe UI", 10F);
            lblEspecialidade.Location = new Point(227, 140);
            lblEspecialidade.Name = "lblEspecialidade";
            lblEspecialidade.Size = new Size(114, 23);
            lblEspecialidade.TabIndex = 4;
            lblEspecialidade.Text = "Especialidade:";
            // 
            // InstrutorForm
            // 
            ClientSize = new Size(640, 314);
            Controls.Add(listBoxInstrutores);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblTelefone);
            Controls.Add(txtTelefone);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblEspecialidade);
            Controls.Add(txtEspecialidade);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "InstrutorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Instrutores";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
