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
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(string[] lst,Form1 formone)
        {
            InitializeComponent();
            tb_list.Text = string.Join(Environment.NewLine,lst);
            formone.num = 10;
            form1 = formone;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.listBox1.Items.Add(string.Join(Environment.NewLine,tb_list.Text));
        }
    }

}
