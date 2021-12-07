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
    public partial class Check_bx : Form
    {
        List<CheckBox> list = new List<CheckBox>();
        public Check_bx()
        {
            InitializeComponent();
            list.Add(cbx_1);
            list.Add(cbx2);
            list.Add(cbx3);
            list.Add(cbx4);
            list.Add(cbx5);
        }

        private void btn_Checkbox_Click(object sender, EventArgs e)
        {
            string txt = "";
            //LÓGICA DE CHECAGEM QUE DE CHECKBOX FEITO ELEMENTO POR ELEMENTO 
            //if(cbx_1.checked)
            //{
            //    txt += cbx_1.text + environment.newline;
            //}
            //if (cbx2.checked)
            //{
            //    txt += cbx2.text + environment.newline;
            //}
            //if (cbx3.checked)
            //{
            //    txt += cbx3.text + environment.newline;
            //}
            //if (cbx4.checked)
            //{
            //    txt += cbx4.text + environment.newline;
            //}
            //if (cbx5.checked)
            //{
            //    txt += cbx5.text + environment.newline;
            //}
            //LÓGICA DE CHECAGEM FEITO COM FOREACH(MESMO EFEITO)
            foreach(CheckBox lst in list)
            {
                if(lst.Checked)
                {
                    txt += lst.Text + Environment.NewLine;
                }
            }
            textBox1.Text = txt;
        }
    }
}
