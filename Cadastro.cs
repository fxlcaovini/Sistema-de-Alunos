using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Trabalho
{
    public partial class Cadastro : Form
    {
        private MySqlConnection conexao;
        private string stringConexao = "server=localhost;database=escola;uid=root;pwd=pass;";

        public Cadastro()
        {
            InitializeComponent();
            dataNasc.Value = DateTime.Now.Date;
            dataNasc.MaxDate = DateTime.Now.Date;

            conexao = new MySqlConnection(stringConexao);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Campo Nome é obrigatório", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(txtRU.Text))
            {
                MessageBox.Show("Campo Matricula é obrigatório", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (combEstado.SelectedItem == null)
            {
                MessageBox.Show("Selecione um município", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!radiobFeminino.Checked && !radiobMasculino.Checked && !radiobOutro.Checked)
            {
                MessageBox.Show("Selecione um gênero", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            string genero = "";
            if (radiobFeminino.Checked)
                genero = "Feminino";
            else if (radiobMasculino.Checked)
                genero = "Masculino";
            else if (radiobOutro.Checked)
                genero = "Outro";

            string dataNascimento = dataNasc.Value.ToString("yyyy-MM-dd");

            string estado = combEstado.SelectedItem.ToString();

            string query = "INSERT INTO tb_aluno (matricula, nome_aluno, estado_aluno, data_nasc_aluno, genero_aluno) " +
                           "VALUES (@matricula, @nome_aluno, @estado_aluno, @data_nasc_aluno, @genero_aluno)";

            MySqlCommand cmd = new MySqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@matricula", txtRU.Text);
            cmd.Parameters.AddWithValue("@nome_aluno", txtNome.Text);
            cmd.Parameters.AddWithValue("@estado_aluno", estado);
            cmd.Parameters.AddWithValue("@data_nasc_aluno", dataNascimento);
            cmd.Parameters.AddWithValue("@genero_aluno", genero);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar aluno: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtRU.Clear();
            combEstado.SelectedIndex = 2;
            radiobFeminino.Checked = false;
            radiobMasculino.Checked = false;
            radiobOutro.Checked = false;
            dataNasc.Value = DateTime.Today;
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            Consulta consultaForm = new Consulta();

            consultaForm.Show();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelGenero_Enter(object sender, EventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void labelEstado_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataNasc_ValueChanged(object sender, EventArgs e)
        { 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

