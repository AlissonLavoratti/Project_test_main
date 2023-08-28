using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /**/
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)/*botao que cadastra os funcionarios no banco de dados */
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtCpf.Text.Equals("") && !txtMatricula.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Nome = txtNome.Text;//recebe os dados inseridos pelo usuário e atribui aos atributos do ojeto cadFuncionarios
                    cadFuncionarios.Cpf = txtCpf.Text;
                    cadFuncionarios.Matricula = txtMatricula.Text;

                    if (cadFuncionarios.cadastrarFuncionarios())
                    {
                        MessageBox.Show($"O funcionário {cadFuncionarios.Nome} foi cadastrado com sucesso!");
                        txtNome.Clear();
                        txtCpf.Clear();
                        txtMatricula.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar funcionários!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                    txtNome.Clear();
                    txtCpf.Clear();
                    txtMatricula.Clear();
                    txtNome.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);
            }
        }

        //botao que pesquisa os funcionarios no banco de dados//
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Cpf = txtCpf.Text;

                    MySqlDataReader reader = cadFuncionarios.localizarFuncionario();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            lblId.Text = reader["funcionario_id"].ToString();
                            txtNome.Text = reader["funcionario_nome"].ToString();
                            txtMatricula.Text = reader["funcionario_matricula"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado");
                            txtCpf.Clear();
                            txtNome.Clear();
                            txtMatricula.Clear();
                            txtCpf.Focus();
                            lblId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado");
                        txtCpf.Clear();
                        txtNome.Clear();
                        txtMatricula.Clear();
                        txtCpf.Focus();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo CPF para realizar a pesquisa!");
                    txtCpf.Clear();
                    txtNome.Clear();
                    txtMatricula.Clear();
                    txtCpf.Focus();
                    lblId.Text = "";


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao encontrar funcioário: " + ex.Message);
            }
        }
        //botao que limpa os dados inseridos pelo usuario
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //nao possui métodos
            txtCpf.Clear();
            txtNome.Clear();
            txtMatricula.Clear();
            lblId.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals("") && !txtNome.Text.Equals("") && !txtMatricula.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Id = int.Parse(lblId.Text);
                    cadFuncionarios.Nome = txtNome.Text;
                    cadFuncionarios.Cpf = txtMatricula.Text;
                    cadFuncionarios.Matricula = txtMatricula.Text;
                    cadFuncionarios.Situacao = txtNome.Text;
                    cadFuncionarios.DataAlteracao = txtMatricula.Text;

                    if (cadFuncionarios.atualizarFuncionario())
                    {
                        MessageBox.Show("Os dados do funcionário foram atualizados com sucesso!");
                        txtCpf.Clear();
                        txtNome.Clear();
                        txtMatricula.Clear();
                        txtCpf.Focus();
                        lblId.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações do funcionário");
                        txtCpf.Clear();
                        txtNome.Clear();
                        txtMatricula.Clear();
                        txtCpf.Focus();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar o funcioário que deseja atualizar as informações");
                    txtCpf.Clear();
                    txtNome.Clear();
                    txtMatricula.Clear();
                    txtCpf.Focus();
                    lblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do funcionário: " + ex.Message);
            }
        }
    }
}