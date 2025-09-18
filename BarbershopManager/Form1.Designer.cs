namespace BarbershopManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNomeLogin = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnCriarConta = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(356, 48);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 0;
            label1.Text = "Login BarberShop";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 108);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(198, 207);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNomeLogin
            // 
            txtNomeLogin.Location = new Point(263, 108);
            txtNomeLogin.Name = "txtNomeLogin";
            txtNomeLogin.Size = new Size(288, 27);
            txtNomeLogin.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(263, 207);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(288, 27);
            txtSenha.TabIndex = 4;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(356, 265);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(94, 29);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnCriarConta
            // 
            btnCriarConta.Location = new Point(706, 149);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(130, 29);
            btnCriarConta.TabIndex = 6;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = true;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(676, 112);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 7;
            label4.Text = "Não tem conta? Crie uma ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(941, 522);
            Controls.Add(label4);
            Controls.Add(btnCriarConta);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtNomeLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNomeLogin;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnCriarConta;
        private Label label4;
    }
}
