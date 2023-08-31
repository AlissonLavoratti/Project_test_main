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
    public partial class TiketsSistem : Form//class Form1 herda os membros (métodos, propriedades, eventos, etc.) da classe Form
    {
        //primeira form (janela) do programa
        public TiketsSistem()
        {
            InitializeComponent();
        }

        //fomr funcinarios 
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            Form1 tikets = new Form1();
            tikets.ShowDialog();
        }

        //fomr funcinarios tikets
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 tikets = new Form2();
            tikets.ShowDialog();
        }
    }
}
