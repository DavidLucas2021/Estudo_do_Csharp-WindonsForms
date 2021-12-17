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
    public partial class MonthCalendar : Form
    {
        public MonthCalendar()
        {
            InitializeComponent();
            //DEFINE A DATA ATUAL NO TERCEIRO TEXTBOX
            textBox2.Text = monthCalendar1.TodayDate.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //DEFINE A DATA INICIAL SELECIONADA 
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            //DEFINE A DATA FINAL SELECIONADA 
            textBox1.Text += " - " +monthCalendar1.SelectionEnd.ToShortDateString();
        }
    }
}
