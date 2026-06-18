using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace ginastica.UI
{
    partial class PlanoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxPlanos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescricao;

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
            listBoxPlanos = new ListBox();
            txtNome = new TextBox();
            comboTipo = new ComboBox();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            btnAdd = new Button();
            lblNome = new Label();
            lblTipo = new Label();
            lblPreco = new Label();
            lblDescricao = new Label();
            SuspendLayout();
            // 
            // listBoxPlanos
            // 
            listBoxPlanos.Location = new Point(12, 12);
            listBoxPlanos.Name = "listBoxPlanos";
            listBoxPlanos.Size = new Size(200, 274);
            listBoxPlanos.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(321, 36);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 29);
            txtNome.TabIndex = 2;
            // 
            // comboTipo
            // 
            comboTipo.Font = new Font("Segoe UI", 12F);
            comboTipo.Items.AddRange(new object[] { "Pula Pula", "Zumba" });
            comboTipo.Location = new Point(321, 76);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(200, 29);
            comboTipo.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 12F);
            txtPreco.Location = new Point(321, 116);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(200, 29);
            txtPreco.TabIndex = 6;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 12F);
            txtDescricao.Location = new Point(321, 156);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(200, 29);
            txtDescricao.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(321, 215);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 43);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Adicionar";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.Location = new Point(258, 42);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 23);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblTipo
            // 
            lblTipo.Font = new Font("Segoe UI", 10F);
            lblTipo.Location = new Point(258, 82);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(57, 23);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo:";
            // 
            // lblPreco
            // 
            lblPreco.Font = new Font("Segoe UI", 10F);
            lblPreco.Location = new Point(258, 122);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(57, 23);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço:";
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Segoe UI", 10F);
            lblDescricao.Location = new Point(238, 162);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(77, 23);
            lblDescricao.TabIndex = 7;
            lblDescricao.Text = "Descrição:";
            // 
            // PlanoForm
            // 
            ClientSize = new Size(640, 312);
            Controls.Add(listBoxPlanos);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblTipo);
            Controls.Add(comboTipo);
            Controls.Add(lblPreco);
            Controls.Add(txtPreco);
            Controls.Add(lblDescricao);
            Controls.Add(txtDescricao);
            Controls.Add(btnAdd);
            Name = "PlanoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Planos";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
