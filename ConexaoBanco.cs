using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    static  class ConexaoBanco
    {
        /* quatro variaveis declaradas informando os dados do banco de dados */
        private const string servidor = "localhost";
        private const string bancoDados = "dbCompany";
        private const string usuario = "root";
        private const string senha = "12345";

        /* declarando varivel conexaoBanco para fazer a conecao com banco mysql */
        static public string bancoServidor = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha}";/*$ para juntar textos com variaveis evitando usar + + + */
    }
}
