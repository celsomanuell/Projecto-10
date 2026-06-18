using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace ginastica.UI
{
    partial class PagamentoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSocioId;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtMetodo;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblSocioId;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Label lblObservacoes;

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
            txtSocioId = new TextBox();
            dateTimePicker = new DateTimePicker();
            txtValor = new TextBox();
            txtMetodo = new TextBox();
            txtObservacoes = new TextBox();
            btnRegistrar = new Button();
            lblSocioId = new Label();
            lblDataPagamento = new Label();
            lblValor = new Label();
            lblMetodo = new Label();
            lblObservacoes = new Label();
            listBoxInstrutores = new ListBox();
            SuspendLayout();
            // 
            // txtSocioId
            // 
            txtSocioId.Font = new Font("Segoe UI", 12F);
            txtSocioId.Location = new Point(526, 21);
            txtSocioId.Name = "txtSocioId";
            txtSocioId.Size = new Size(100, 29);
            txtSocioId.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 12F);
            dateTimePicker.Location = new Point(526, 59);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 29);
            dateTimePicker.TabIndex = 3;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 12F);
            txtValor.Location = new Point(526, 99);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 29);
            txtValor.TabIndex = 5;
            // 
            // txtMetodo
            // 
            txtMetodo.Font = new Font("Segoe UI", 12F);
            txtMetodo.Location = new Point(526, 139);
            txtMetodo.Name = "txtMetodo";
            txtMetodo.Size = new Size(200, 29);
            txtMetodo.TabIndex = 7;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Font = new Font("Segoe UI", 12F);
            txtObservacoes.Location = new Point(526, 179);
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(200, 29);
            txtObservacoes.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 12F);
            btnRegistrar.Location = new Point(526, 234);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(135, 44);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registar";
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblSocioId
            // 
            lblSocioId.Font = new Font("Segoe UI", 10F);
            lblSocioId.Location = new Point(402, 27);
            lblSocioId.Name = "lblSocioId";
            lblSocioId.Size = new Size(118, 23);
            lblSocioId.TabIndex = 0;
            lblSocioId.Text = "Sócio Id:";
            // 
            // lblDataPagamento
            // 
            lblDataPagamento.Font = new Font("Segoe UI", 10F);
            lblDataPagamento.Location = new Point(402, 65);
            lblDataPagamento.Name = "lblDataPagamento";
            lblDataPagamento.Size = new Size(118, 23);
            lblDataPagamento.TabIndex = 2;
            lblDataPagamento.Text = "Data Pagamento:";
            // 
            // lblValor
            // 
            lblValor.Font = new Font("Segoe UI", 10F);
            lblValor.Location = new Point(402, 105);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(118, 23);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor:";
            // 
            // lblMetodo
            // 
            lblMetodo.Font = new Font("Segoe UI", 10F);
            lblMetodo.Location = new Point(402, 145);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(118, 23);
            lblMetodo.TabIndex = 6;
            lblMetodo.Text = "Método:";
            // 
            // lblObservacoes
            // 
            lblObservacoes.Font = new Font("Segoe UI", 10F);
            lblObservacoes.Location = new Point(402, 185);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(118, 23);
            lblObservacoes.TabIndex = 8;
            lblObservacoes.Text = "Observações:";
            // 
            // listBoxInstrutores
            // 
            listBoxInstrutores.Location = new Point(12, 12);
            listBoxInstrutores.Name = "listBoxInstrutores";
            listBoxInstrutores.Size = new Size(365, 274);
            listBoxInstrutores.TabIndex = 11;
            // 
            // PagamentoForm
            // 
            ClientSize = new Size(838, 299);
            Controls.Add(listBoxInstrutores);
            Controls.Add(lblSocioId);
            Controls.Add(txtSocioId);
            Controls.Add(lblDataPagamento);
            Controls.Add(dateTimePicker);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(lblMetodo);
            Controls.Add(txtMetodo);
            Controls.Add(lblObservacoes);
            Controls.Add(txtObservacoes);
            Controls.Add(btnRegistrar);
            Name = "PagamentoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registo de Pagamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox listBoxInstrutores;
    }
}
