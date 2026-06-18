using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace ginastica.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Button btnPlanos;
        private System.Windows.Forms.Button btnInstrutores;
        private System.Windows.Forms.Button btnAulas;
        private System.Windows.Forms.Button btnPagamentos;

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
            btnSocios = new Button();
            btnPlanos = new Button();
            btnInstrutores = new Button();
            btnAulas = new Button();
            btnPagamentos = new Button();
            btnInscrever = new Button();
            SuspendLayout();
            // 
            // btnSocios
            // 
            btnSocios.Location = new Point(155, 257);
            btnSocios.Name = "btnSocios";
            btnSocios.Size = new Size(120, 77);
            btnSocios.TabIndex = 0;
            btnSocios.Text = "Sócios";
            btnSocios.Click += btnSocios_Click;
            // 
            // btnPlanos
            // 
            btnPlanos.Location = new Point(155, 140);
            btnPlanos.Name = "btnPlanos";
            btnPlanos.Size = new Size(120, 77);
            btnPlanos.TabIndex = 1;
            btnPlanos.Text = "Planos";
            btnPlanos.Click += btnPlanos_Click;
            // 
            // btnInstrutores
            // 
            btnInstrutores.Location = new Point(290, 140);
            btnInstrutores.Name = "btnInstrutores";
            btnInstrutores.Size = new Size(120, 77);
            btnInstrutores.TabIndex = 2;
            btnInstrutores.Text = "Instrutores";
            btnInstrutores.Click += btnInstrutores_Click;
            // 
            // btnAulas
            // 
            btnAulas.Location = new Point(427, 140);
            btnAulas.Name = "btnAulas";
            btnAulas.Size = new Size(120, 77);
            btnAulas.TabIndex = 3;
            btnAulas.Text = "Aulas";
            btnAulas.Click += btnAulas_Click;
            // 
            // btnPagamentos
            // 
            btnPagamentos.Location = new Point(427, 257);
            btnPagamentos.Name = "btnPagamentos";
            btnPagamentos.Size = new Size(120, 77);
            btnPagamentos.TabIndex = 4;
            btnPagamentos.Text = "Pagamentos";
            btnPagamentos.Click += btnPagamentos_Click;
            // 
            // btnInscrever
            // 
            btnInscrever.Location = new Point(290, 257);
            btnInscrever.Name = "btnInscrever";
            btnInscrever.Size = new Size(120, 77);
            btnInscrever.TabIndex = 5;
            btnInscrever.Text = "Inscrição Aula Coletiva";
            btnInscrever.Click += btnInscrever_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(720, 480);
            Controls.Add(btnInscrever);
            Controls.Add(btnSocios);
            Controls.Add(btnPlanos);
            Controls.Add(btnInstrutores);
            Controls.Add(btnAulas);
            Controls.Add(btnPagamentos);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão Academia";
            ResumeLayout(false);
        }

        private Button btnInscrever;
    }
}
