using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private object dataGridView1;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*
            FuncionarioTikets funcTikets = new FuncionarioTikets();
            funcTikets.id;
            funcTikets.tiket_situacao = "A";*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se a célula clicada é a célula do cabeçalho e não uma célula de dados.
            if (e.RowIndex >= 0)
            {
                // Obtenha o DataGridView atualmente em foco.
                DataGridView dgv = (DataGridView)sender;

                // Verifique se a célula clicada está na coluna correta (por exemplo, a coluna de funcionário_nome).
                if (dgv.Columns[e.ColumnIndex].Name == "funcionario_nome") // Substitua "funcionario_nome" pelo nome correto da coluna.
                {
                    // Obtenha o valor da célula clicada.
                    string valorClicado = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    // Use o valor conforme necessário, por exemplo, exibindo-o em um MessageBox.
                    MessageBox.Show($"Você clicou no funcionário com o nome: {valorClicado}");
                }
            }
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click1(object sender, EventArgs e)
        {
            try
            {
                // Chame a função getFuncionarniosTiket para obter o MySqlDataReader com os resultados.
                MySqlDataReader reader = getFuncionarniosTiket();

                if (reader != null)
                {
                    
                    // Preencha o DataGridView com os dados do leitor.
                    while (reader.Read())
                    {

                        // Adicione uma nova linha ao DataGridView para cada registro no leitor.
                        dgvFuncTikets.Rows.Add(
                            reader["funcionario_id"].ToString(),
                            reader["funcionario_nome"].ToString(),
                            reader["funcionario_cpf"].ToString(),
                            reader["funcionario_situacao"].ToString(),
                            reader["funcionario_data_alteracao"].ToString(),
                            reader["funcionario_matricula"].ToString()
                        );
                    }

                    // Feche o leitor após preencher o DataGridView.
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados: " + ex.Message);
            }
        }

        private MySqlDataReader getFuncionarniosTiket()
        {
            throw new NotImplementedException();
        }
    }
}
