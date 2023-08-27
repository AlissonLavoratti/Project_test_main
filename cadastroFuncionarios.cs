using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class cadastroFuncionarios
    {
        private int id;
        private string nome;
        private string cpf;
        private string situacao = "A";
        private string dataAlteracao = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        private string matricula;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Situacao
        {
            get { return situacao; }
            set { situacao = "A"; }
        }

        public string DataAlteracao
        {
            get { return dataAlteracao; }
            set { dataAlteracao = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        //metodo para cadastrar os funcionarios no banco de dados
        public bool cadastrarFuncionarios()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string insert = $"insert into funcionario (funcionario_nome, funcionario_cpf, funcionario_matricula, funcionario_situacao, funcionario_data_alteracao) values ('{nome}','{cpf}','{matricula}','{situacao}','{dataAlteracao}')";


                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert; 

                comandoSql.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {
                //mensagem de erro do banco de dados quando não for possível cadastrar funcionários no banco
                MessageBox.Show("Erro no banco de dados - método cadastrarFuncionarios: " + ex.Message);
                return false;
            }
        }


        public MySqlDataReader localizarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = $"select funcionario_id, funcionario_nome, funcionario_cpf, funcionario_matricula, funcionario_situacao from funcionario where funcionario_cpf = '{Cpf}';";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no banco de dados - método localizarFuncionario: " + ex.Message);
                return null;
            }

        }
    }
}
