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
    public partial class NumericUpDown : Form
    {
        public NumericUpDown()
        {
            InitializeComponent();
        }
        //DEFININDO O VALOR DO NUMERICUPDOW PELO TEXTBOX
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                //CONFERE SE O VALOR INSERIDO NÃO É MAIOR QUE O VALOR MAXÍMO PERMITIDO
                if (decimal.Parse(textBox1.Text) <= numericUpDown1.Maximum)
                {
                    //PODE SER FEITO ESSA CONVERSÃO
                    //int x = Int32.Parse(textBox1.Text);
                    //numericUpDown1.Value = x;

                    //OU ESTA
                    numericUpDown1.Value = decimal.Parse(textBox1.Text);
                    textBox1.Clear();
                }
                else
                {
                    textBox1.Text = "Valor inválido";
                }
            }
            else
            {
                textBox1.Text = "INFORME O VALOR!!!";
            }
        }
    }
}
