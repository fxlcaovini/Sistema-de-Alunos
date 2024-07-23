using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Trabalho
{
    public partial class Alterar : Form
    {
        private MySqlConnection conexao;
        private string stringConexao = "server=localhost;database=escola;uid=root;pwd=pass;";
        private string matriculaOriginal;

        public Alterar(string matricula, string nome, string estado, DateTime dataNasc, string genero)
        {
            InitializeComponent();
            conexao = new MySqlConnection(stringConexao);
            matriculaOriginal = matricula;
            txtMatricula.Text = matricula;
            txtNome.Text = nome;
            combEstado.SelectedItem = estado;
            this.dataNasc.Value = dataNasc;
            if (genero == "Feminino")
                radiobFeminino.Checked = true;
            else if (genero == "Masculino")
                radiobMasculino.Checked = true;
            else
                radiobOutro.Checked = true;

            txtMatricula.KeyPress += TxtMatricula_KeyPress;
        }

        private void TxtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("O campo matrícula deve conter apenas números.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) || string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE tb_aluno SET matricula = @novaMatricula, nome_aluno = @nome, estado_aluno = @estado, data_nasc_aluno = @data_nasc, genero_aluno = @genero WHERE matricula = @matriculaOriginal";

            MySqlCommand cmd = new MySqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@novaMatricula", txtMatricula.Text); 
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@estado", combEstado.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@data_nasc", this.dataNasc.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@genero", radiobFeminino.Checked ? "Feminino" : radiobMasculino.Checked ? "Masculino" : "Outro");
            cmd.Parameters.AddWithValue("@matriculaOriginal", matriculaOriginal); 

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alterar_Load(object sender, EventArgs e)
        {
            combEstado.Items.AddRange(new object[]
            {
                "Acre",
                "Alagoas",
                "Amapá",
                "Amazonas",
                "Bahia",
                "Ceará",
                "Distrito Federal",
                "Espírito Santo",
                "Goiás",
                "Maranhão",
                "Mato Grosso",
                "Mato Grosso do Sul",
                "Minas Gerais",
                "Pará",
                "Paraíba",
                "Paraná",
                "Pernambuco",
                "Piauí",
                "Rio de Janeiro",
                "Rio Grande do Norte",
                "Rio Grande do Sul",
                "Rondônia",
                "Roraima",
                "Santa Catarina",
                "São Paulo",
                "Sergipe",
                "Tocantins"
            });

            combEstado.SelectedIndex = 0;
        }

     
    }
}
