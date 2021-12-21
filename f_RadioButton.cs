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
    public partial class f_RadioButton : Form
    {
        public f_RadioButton()
        {
            InitializeComponent();
        }
        //PRIMEIRA FORMA DE OBTER O CHECKED DO RADIOBUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            string txt;
            txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            textBox1.Text = txt;
        }
        //SEGUNDA FORMA DE OBTER CHECKED DO RADIOBUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            string txt="";
            foreach(RadioButton rb in groupBox1.Controls)
            {
                if(rb.Checked)
                {
                    txt = rb.Text;
                }
                textBox1.Text = txt;
            }
        }
    }
}
