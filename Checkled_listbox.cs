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
    public partial class Checkled_listbox : Form
    {
        public Checkled_listbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach(string car in CLBx1.CheckedItems)
            {
                txt += car + Environment.NewLine;
                textBox1.Text = txt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLBx1.Items.Clear();
        }
        //PRECISA MELHORAR/IMPREMENTAR USANDO LISTA 
        private void button3_Click(object sender, EventArgs e)
        {
            CLBx1.Items.Clear();
            CLBx1.Items.Add("CAMARO", false);
            CLBx1.Items.Add("SIENA", false);
            CLBx1.Items.Add("UNO", false);
            CLBx1.Items.Add("CORVETTE", false);
            CLBx1.Items.Add("DOBLO", false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CLBx1.Items.Add(textBox2.Text, false);
            textBox2.Clear();
            textBox2.Focus();            
        }
    }
}
