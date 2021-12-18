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
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }

        private void PictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.SUADAÇÃO;
            label2.Text = Properties.Resources.SUADAÇÃO1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.SAUDAÇÃO2;
            label2.Text = Properties.Resources.SAUDAÇÃO3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.IMAGEN;
        }
    }
}
