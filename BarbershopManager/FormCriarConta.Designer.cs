namespace BarbershopManager
{
    partial class FormCriarConta
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNomeLogin = new TextBox();
            txtSenha = new TextBox();
            cmbTipo = new ComboBox();
            label4 = new Label();
            chkAtivo = new CheckBox();
            label5 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(272, 34);
            label1.Name = "label1";
            label1.Size = new Size(167, 22);
            label1.TabIndex = 0;
            label1.Text = "Criar Conta BarberShop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 109);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 171);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // txtNomeLogin
            // 
            txtNomeLogin.Location = new Point(220, 109);
            txtNomeLogin.Name = "txtNomeLogin";
            txtNomeLogin.Size = new Size(257, 27);
            txtNomeLogin.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(220, 171);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(257, 27);
            txtSenha.TabIndex = 4;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Barbeiro", "Cliente" });
            cmbTipo.Location = new Point(220, 227);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(154, 28);
            cmbTipo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 227);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 6;
            label4.Text = "Tipo:";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(220, 276);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(18, 17);
            chkAtivo.TabIndex = 7;
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 273);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 8;
            label5.Text = "Ativo:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(220, 332);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(383, 332);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCriarConta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(chkAtivo);
            Controls.Add(label4);
            Controls.Add(cmbTipo);
            Controls.Add(txtSenha);
            Controls.Add(txtNomeLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCriarConta";
            Text = "FormCriarConta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNomeLogin;
        private TextBox txtSenha;
        private ComboBox cmbTipo;
        private Label label4;
        private CheckBox chkAtivo;
        private Label label5;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}