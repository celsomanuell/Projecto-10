namespace ginastica.UI
{
    partial class InscricaoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxSocios = new ListBox();
            lblPlano = new Label();
            lblEstado = new Label();
            btnAdd = new Button();
            txtSocioId = new TextBox();
            txtAulaId = new TextBox();
            SuspendLayout();
            // 
            // listBoxSocios
            // 
            listBoxSocios.Location = new Point(24, 31);
            listBoxSocios.Name = "listBoxSocios";
            listBoxSocios.Size = new Size(200, 184);
            listBoxSocios.TabIndex = 16;
            // 
            // lblPlano
            // 
            lblPlano.Font = new Font("Segoe UI", 10F);
            lblPlano.Location = new Point(239, 35);
            lblPlano.Name = "lblPlano";
            lblPlano.Size = new Size(59, 23);
            lblPlano.TabIndex = 25;
            lblPlano.Text = "SocioId:";
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI", 10F);
            lblEstado.Location = new Point(239, 84);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(59, 23);
            lblEstado.TabIndex = 27;
            lblEstado.Text = "AulaId:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(302, 150);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 43);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Inscrever";
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSocioId
            // 
            txtSocioId.Font = new Font("Segoe UI", 12F);
            txtSocioId.Location = new Point(302, 31);
            txtSocioId.Name = "txtSocioId";
            txtSocioId.Size = new Size(171, 29);
            txtSocioId.TabIndex = 30;
            // 
            // txtAulaId
            // 
            txtAulaId.Font = new Font("Segoe UI", 12F);
            txtAulaId.Location = new Point(302, 84);
            txtAulaId.Name = "txtAulaId";
            txtAulaId.Size = new Size(171, 29);
            txtAulaId.TabIndex = 31;
            // 
            // InscricaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 252);
            Controls.Add(txtAulaId);
            Controls.Add(txtSocioId);
            Controls.Add(listBoxSocios);
            Controls.Add(lblPlano);
            Controls.Add(lblEstado);
            Controls.Add(btnAdd);
            Name = "InscricaoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscricao das aulas coletivas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSocios;
        private Label lblPlano;
        private Label lblEstado;
        private Button btnAdd;
        private TextBox txtSocioId;
        private TextBox txtAulaId;
    }
}