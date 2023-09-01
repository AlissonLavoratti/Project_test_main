using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class FuncionarioTikets//Classe/objeto
    {
        //atribhutos do objeto - mesmos do banco de dados
        public string id;
        public string funcionario_nome;
        public string tikets_id;//eliminado
        public string tikets_versao;
        public string funcionario_id;
        public string tikets_quantidade;
        public string tikets_situacao = "A";
        public string tikets_data_entrega = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        public FuncionarioTikets()
        {
        }

        public FuncionarioTikets(string id, string nome)
        {
            this.funcionario_id = id;
            this.funcionario_nome = nome;
        }


        public string Tikets_versao//Maiúsculo
        {
            get { return tikets_versao; }
            set { tikets_versao = value; }
        }

        public string Id//Maiúsculo
        {
            get { return id; }
            set { id = value; }
        }

        public string Funcionario_nome//Maiúsculo
        {
            get { return funcionario_nome; }
            set { funcionario_nome = value; }
        }

        public string Funcionario_id//Maiúsculo
        {
            get { return funcionario_id; }
            set { funcionario_id = value; }
        }

        public string Quantidade
        {
            get { return tikets_quantidade; }
            set { tikets_quantidade = value; }
        }
        public string DataAlteracao
        {
            get { return tikets_data_entrega; }
            set { tikets_data_entrega = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); }
        }

        public static object Conn { get; }

        public bool cadastraFuncionarioTikets()
        {
            try
            {
                //comunicacao com banco de dados
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                Funcionarios funcNome = new Funcionarios();
                string nome = funcNome.nome;

                string insert = $"insert into funcionario_tiket (id_funcionario_tiket, funcionario_tikets_nome, funcionario_tikets_quantidade, funcionario_tikets_situacao, funcionario_tikets_data_entrega, funcionario_tiket_versao) values ('{funcionario_id}','{funcionario_nome}','{tikets_quantidade}','{tikets_situacao}','{tikets_data_entrega}','{tikets_versao}')";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //mensagem de erro do banco de dados quando não for possível cadastrar funcionáriosTiket no banco
                MessageBox.Show("Erro no banco de dados - método cadastraFuncionarioTikets: " + ex.Message);
                return false;
            }
        }


        public MySqlDataReader localizarFuncionarioTiket()
        {
            try
            {
                //comunicacao com banco de dados
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                //string (lista) com os dados que serão encaminhados para o banco - query
                string select = $"select funcionario_tikets_id, funcionario_tikets_nome, funcionario_tikets_quantidade, funcionario_tikets_situacao, funcionario_tikets_data_entrega from funcionario_tiket where funcionario_tikets_id = '{tikets_versao}';";// or funcionario_nome like '%{nome}%' or funcionario_matricula = '{matricula}';

                MySqlCommand comandSql = MysqlConexaoBanco.CreateCommand();
                comandSql.CommandText = select;

                MySqlDataReader reader = comandSql.ExecuteReader();
                
                //retorno de todos os dados pesquisados no banco
                return reader;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no banco de dados - método localizarFuncionario: " + ex.Message);
                return null;
            }
        }


        public bool atualizarFuncionarioTikets()
        {
            try
            {
                //comunicacao com banco de dados
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                Funcionarios funcNome = new Funcionarios();
                string nome = funcNome.nome;

                string update = $"update funcionario_tiket set funcionario_tikets_quantidade = '{tikets_quantidade}', funcionario_tikets_data_entrega = '{tikets_data_entrega}' where funcionario_tiket_versao = '{tikets_versao}';";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //mensagem de erro do banco de dados quando não for possível cadastrar funcionáriosTiket no banco
                MessageBox.Show("Erro no banco de dados - método atualizarFuncionarioTikets: " + ex.Message);
                return false;
            }
        }


        public MySqlDataReader getFuncionarniosTiket()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = $"SELECT funcionario_id, funcionario_nome, funcionario_cpf, funcionario_situacao, funcionario_data_alteracao, funcionario_matricula FROM FUNCIONARIO WHERE funcionario_nome = '{funcionario_nome}';";

                MySqlCommand comandSql = MysqlConexaoBanco.CreateCommand();
                comandSql.CommandText = select;

                MySqlDataReader reader = comandSql.ExecuteReader();

                // retorno dos dados
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método getFuncionarniosTiket: " + ex.Message);
                return null;
            }
        }
    }
}
