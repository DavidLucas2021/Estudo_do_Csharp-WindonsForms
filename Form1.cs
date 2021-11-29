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
            textBox1.Focus();
        }
        //LÓGICA DO BOTÃO DE ADICIONAR CARRO
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                //JANELA DE ERRO INFORMANDO CAMPO VAZIO
                MessageBox.Show("Campo vazio. Informe o carro");
                //POSICIONA O CURSOR NA CAIXA DE TEXTO PARA ADICIONAR CARRO 
                textBox1.Focus();
            }
            else 
            if(textBox1.Text != "")
            {
                textBox2.Text += textBox1.Text +"\r\n";
                textBox1.Clear();
                textBox1.Focus();
            }
        }
        //LÓGICA DO BOTÃO DE LIMPAR CONTEÚDO     
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
