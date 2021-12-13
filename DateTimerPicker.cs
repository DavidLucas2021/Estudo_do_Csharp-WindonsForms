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
    public partial class DateTimerPicker : Form
    {
        public DateTimerPicker()
        {
            InitializeComponent();
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_data.Text = dateTimePicker1.Text;
            tb_dia.Text = dateTimePicker1.Value.Day.ToString();
            tb_mes.Text = dateTimePicker1.Value.Month.ToString();
            tb_ano.Text = dateTimePicker1.Value.Year.ToString();
        }

        private void btn_setar_Click(object sender, EventArgs e)
        {
            int d, m, a;
            d = Int32.Parse(tb_dia.Text);
            m = Int32.Parse(tb_mes.Text);
            a = Int32.Parse(tb_ano.Text);

            DateTime dateTime = new DateTime(a,m,d);

            dateTimePicker1.Value = dateTime;
        }

        private void btn_resete_Click(object sender, EventArgs e)
        {
            dateTimePicker1.ResetText();
            //OU TAMBÉM PODERIA SER O SEGUINTE TRECHO DO CÓDIGO 
            //dateTimePicker1.Value = DateTime.Now;
            //dateTimePicker1.Value = DateTime.Today;
        }
    }
}
