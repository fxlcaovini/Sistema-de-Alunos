using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Consulta : Form
    {
        private MySqlConnection conexao;
        private string stringConexao = "server=localhost;database=escola;uid=root;pwd=pass;";

        public Consulta()
        {
            InitializeComponent();

            conexao = new MySqlConnection(stringConexao);
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            CarregarAlunos();
        }

        private void CarregarAlunos()
        {
            string query = "SELECT matricula, nome_aluno, estado_aluno, data_nasc_aluno, genero_aluno FROM tb_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conexao);

            try
            {
                conexao.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridViewAlunos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar alunos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text.Trim();

            string query = "SELECT matricula, nome_aluno, estado_aluno, data_nasc_aluno, genero_aluno FROM tb_aluno WHERE nome_aluno LIKE @nome OR matricula = @matricula";

            MySqlCommand cmd = new MySqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@nome", $"%{buscar}%");
            cmd.Parameters.AddWithValue("@matricula", buscar);

            try
            {
                conexao.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridViewAlunos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar alunos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlunos.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridViewAlunos.SelectedRows[0];
                string matricula = linhaSelecionada.Cells["matricula"].Value.ToString();
                string nome = linhaSelecionada.Cells["nome_aluno"].Value.ToString();
                string estado = linhaSelecionada.Cells["estado_aluno"].Value.ToString();
                DateTime dataNasc = Convert.ToDateTime(linhaSelecionada.Cells["data_nasc_aluno"].Value);
                string genero = linhaSelecionada.Cells["genero_aluno"].Value.ToString();

                Alterar alterarForm = new Alterar(matricula, nome, estado, dataNasc, genero);
                alterarForm.ShowDialog();

    
                CarregarAlunos();
            }
            else
            {
                MessageBox.Show("Selecione um aluno para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

            private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlunos.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridViewAlunos.SelectedRows[0];
                string matricula = linhaSelecionada.Cells["matricula"].Value.ToString();
                string nome = linhaSelecionada.Cells["nome_aluno"].Value.ToString();

                DialogResult result = MessageBox.Show($"Tem certeza que deseja excluir o aluno {nome}?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ExcluirAluno(matricula, true); 
                }
            }
            else
            {
                MessageBox.Show("Selecione um aluno para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExcluirAluno(string parametro, bool porMatricula)
        {
            string campo = porMatricula ? "matricula" : "nome_aluno";
            string query = $"DELETE FROM tb_aluno WHERE {campo} = @parametro";

            using (MySqlConnection conexaoExclusao = new MySqlConnection(stringConexao))
            {
                MySqlCommand cmd = new MySqlCommand(query, conexaoExclusao);
                cmd.Parameters.AddWithValue("@parametro", parametro);

                try
                {
                    conexaoExclusao.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("O Aluno foi excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarAlunos(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir aluno(s): " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear(); 
            CarregarAlunos();
        }
    



        private void dataGridViewAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
