using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BarbershopManager
{
    public partial class FormCriarConta : Form
    {
        public FormCriarConta()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string nomeLogin = txtNomeLogin.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um tipo de usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tipo = cmbTipo.SelectedItem.ToString();
            bool ativo = chkAtivo.Checked;

            if (string.IsNullOrEmpty(nomeLogin) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Nome de login e senha são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Código para salvar no banco deve ser implementado aqui

            string connectionString = @"Server=VINICIUS\SQLEXPRESS;
            Database=BarbershopDb;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "INSERT INTO Usuarios (NomeLogin, Senha, Tipo, Ativo) VALUES (@NomeLogin, @Senha, @Tipo, @Ativo)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NomeLogin", nomeLogin);
                        cmd.Parameters.AddWithValue("@Senha", senha);
                        cmd.Parameters.AddWithValue("@Tipo", tipo);
                        cmd.Parameters.AddWithValue("@Ativo", ativo);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                MessageBox.Show("Usuário criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
