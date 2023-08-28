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

        //botao que cadastra os funcionarios no banco de dados//
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtCpf.Text.Equals("") && !txtMatricula.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Nome = txtNome.Text;
                    cadFuncionarios.Cpf = txtCpf.Text;
                    cadFuncionarios.Matricula = txtMatricula.Text;

                    if (cadFuncionarios.cadastrarFuncionarios())
                    {
                        MessageBox.Show($"O funcion�rio {cadFuncionarios.Nome} foi cadastrado com sucesso!");
                        txtNome.Clear();
                        txtCpf.Clear();
                        txtMatricula.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("N�o foi poss�vel cadastrar funcion�rios!");
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
                MessageBox.Show("Erro ao cadastrar funcion�rio: " + ex.Message);
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
                            MessageBox.Show("Funcion�rio n�o encontrado");
                            txtCpf.Clear();
                            txtNome.Clear();
                            txtMatricula.Clear();
                            txtCpf.Focus();
                            lblId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcion�rio n�o encontrado");
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

                MessageBox.Show("Erro ao encontrar funcio�rio: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCpf.Clear();
            txtNome.Clear();
            txtMatricula.Clear();
            lblId.Text = "";
        }
    }
}