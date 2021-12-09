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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            textBox1.Clear();
            comboBox1.Items.Add("CAMARO");
            comboBox1.Items.Add("CORVETTE");
            comboBox1.Items.Add("BMW");
            comboBox1.Items.Add("JETTA");
            comboBox1.Items.Add("DOBLO");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                comboBox1.Items.Add(comboBox1.Text);
                comboBox1.Text = "";
            }
            else
            {
                comboBox1.Text = "";
                MessageBox.Show("Informe o veiculo para adicionar");
                comboBox1.Focus();
            }
        }
    }
}
