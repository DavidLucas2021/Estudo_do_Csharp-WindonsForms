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
        public Form2(string[] lst)
        {
            InitializeComponent();
            tb_list.Text = string.Join(Environment.NewLine,lst);
        }
    }

}
