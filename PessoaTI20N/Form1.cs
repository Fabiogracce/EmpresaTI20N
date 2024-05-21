using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PessoaTI20N
{
    public partial class Form1 : Form
    { 
        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir exc;

    
        public Form1()
        {
            InitializeComponent();
            cad = new Cadastrar();
            con = new Consultar();
            atu = new Atualizar();
            exc = new Excluir();
        }//contrutor de tela

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();

        }// fim do cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            con = new Consultar();
            con.ShowDialog();
        }//fim do consultar

        private void button3_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
        }//fim do atualizar

        private void button4_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();
        }// fim do excluir
    }
}
