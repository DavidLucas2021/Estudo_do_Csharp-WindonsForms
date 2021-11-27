using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo_do_Csharp_Windons_Forms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //BOTÃO DE "OK" FAZ A LABEL RECEBER VALOR DA CAIXA DE TEXTO
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Informe a mensagem a ser carregado:";
            }
            else
            {
                label1.Text = textBox1.Text;
                textBox1.Clear();
            }
        }

        //BOTÃO DE LIMPAR RESETA O VALOR DA LABEL 
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Informe a mensagem a ser carregado:";
            textBox1.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
