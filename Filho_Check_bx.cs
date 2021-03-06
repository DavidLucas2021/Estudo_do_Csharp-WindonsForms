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
    public partial class Filho_Check_bx : Form
    {
        public Check_bx check_Bx;
        public Filho_Check_bx()
        {
            InitializeComponent();
            //LÓGICA DE ALTERAÇÃO DE FORMS POR OUTRO FORMS USANDO OPENFORMS
            //OPENFORMS SOMENTE FUNCIONA SE O FORMULÁRIO DESEJADO ESTIVER 
            //ABERTO 
            check_Bx = Application.OpenForms["Check_bx"] as Check_bx;
            //LÓGICA QUE PERMITE QUE TODO CHECKBOX ALTERADO EM "CHECK_BX"
            //SEJA ALTERADO TAMBEM EM "FILHO_CHECK_BX"
            cbx_1.Checked = check_Bx.cbx_1.Checked;
            cbx2.Checked = check_Bx.cbx2.Checked;
            cbx3.Checked = check_Bx.cbx3.Checked;
            cbx4.Checked = check_Bx.cbx4.Checked;
            cbx5.Checked = check_Bx.cbx5.Checked;
        }

        //LÓGICA DE EVENTOS QUE PERMITE QUE CADA CHECKBOX ALTERADO EM "FILHO_CHECK_BX"
        //SEJA TAMBEM ALTERADO EM "CHECK_BX"
        //EVENTO CHECKEDCHANGED É ACIONADO TODO VEZ QUE O CHECKBOX MUDA DE ESTADO
        private void cbx_1_CheckedChanged(object sender, EventArgs e)
        {
            check_Bx.cbx_1.Checked = cbx_1.Checked;
        }

        private void cbx2_CheckedChanged(object sender, EventArgs e)
        {
            check_Bx.cbx2.Checked = cbx2.Checked;
        }

        private void cbx3_CheckedChanged(object sender, EventArgs e)
        {
            check_Bx.cbx3.Checked = cbx3.Checked;
        }

        private void cbx4_CheckedChanged(object sender, EventArgs e)
        {
            check_Bx.cbx4.Checked = cbx4.Checked;
        }

        private void cbx5_CheckedChanged(object sender, EventArgs e)
        {
            check_Bx.cbx5.Checked = cbx5.Checked;
        }
    }
}
