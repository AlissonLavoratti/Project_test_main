using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class Form3 : Form
    {
        private string id;
        private string nome; // Declare a variável aqui para que ela seja acessível em toda a classe


        // Construtor que recebe o nome como parâmetro
        public Form3(string id, string nome)
        {
            InitializeComponent();
            this.nome = nome;
            this.id = id;
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            Id_Func.Text = $"{id}";
            Nome_Func.Text = $"{nome}";
        }

        //botao cancelar para fechar janela
        private void btnCancelarTiket_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //botao salvar - envia os dados para o banco mysql
        private void btnSalvarTiket_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textBox1.Text.Equals(""))
                {
                    FuncionarioTikets cadFuncionarioTikets = new FuncionarioTikets();//OBJETO
                    cadFuncionarioTikets.Quantidade = textBox1.Text;
                    cadFuncionarioTikets.Funcionario_id = Id_Func.Text;
                    cadFuncionarioTikets.funcionario_nome = Nome_Func.Text;
                    cadFuncionarioTikets.Id = numTiket.Text;
                    cadFuncionarioTikets.Tikets_versao = numTiketVer.Text;



                    cadFuncionarioTikets.cadastraFuncionarioTikets();

                    MessageBox.Show($"{cadFuncionarioTikets.Quantidade} tikets foram cadastrados com sucesso!");

                    MySqlDataReader reader = cadFuncionarioTikets.localizarFuncionarioTiket();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            //Retorno dos dados do banco
                            numTiket.Text = reader["funcionario_tikets_id"].ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Digite a quantidade de Tikets");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método cadastraFuncionarioTikets: " + ex.Message);
                /*return false;*/
            }
        }

        private void btnAtualizarTiket_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textBox1.Text.Equals(""))
                {
                    FuncionarioTikets cadFuncionarioTikets = new FuncionarioTikets();//OBJETO
                    cadFuncionarioTikets.Quantidade = textBox1.Text;
                    cadFuncionarioTikets.Funcionario_id = Id_Func.Text;
                    cadFuncionarioTikets.funcionario_nome = Nome_Func.Text;



                    cadFuncionarioTikets.atualizarFuncionarioTikets();
                    MessageBox.Show($"{cadFuncionarioTikets.Quantidade} tikets foram atualizados com sucesso!");
                }
                else
                {
                    MessageBox.Show("Digite a quantidade de Tikets recebidas pelo funcionário");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método btnAtualizarTiket_Click: " + ex.Message);
                /*return false;*/
            }
        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }
    }
}







