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
        private string nome; // Declare a variável aqui para que ela seja acessível em toda a classe

        public Form3(string nome) // Construtor que recebe o nome como parâmetro
        {
            InitializeComponent();
            this.nome = nome;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            Nome_Func.Text = $"{nome}";
        }

        private void btnCancelarTiket_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}







