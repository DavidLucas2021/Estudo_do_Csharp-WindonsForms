using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Estudo_do_Csharp_Windons_Forms_
{
    public partial class Progressbar_e_Sleep : Form
    {
        public Progressbar_e_Sleep()
        {
            InitializeComponent();
            progressBar1.Value = 0;
        }
        //DEFINE UM VALOR PARA O PROGRESSBAR QUE SEJA VALIDO 
        private void button2_Click(object sender, EventArgs e)
        {
            if((Int32.Parse(textBox1.Text)<progressBar1.Maximum)&&(Int32.Parse(textBox1.Text)>progressBar1.Minimum))
            {
                progressBar1.Value = int.Parse(textBox1.Text);
            }
            else
            {
                textBox1.Clear();
                textBox1.Text="Valor invalido";
            }
        }
        //DEFINE O VALOR DO PROGRESSBAR CONFORME O I DO FOR
        //O THREAD.SLEEP DA UMA PAUSA NO PROGRAMA 
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0; i<= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(250);
            }
        }
    }
}
