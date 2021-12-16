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
    public partial class MaskedTextBox : Form
    {
        public MaskedTextBox()
        {
            InitializeComponent();
            //O MASKEDTEXTBOX RECEBE O CARACTER DE FORMATO DE SENHA DO WINDOWS
            maskedTextBox1.UseSystemPasswordChar = true;
        }
        //TESTE ONDE VERIFICO O COMPORTAMENTO DO MASKEDTEXTBOX 
        //AO INSERIR UM NÚMERO MENOR DE ITENS DO QUE O OBRIGATÓRIO
        //NESTE TESTE QUANDO NÃO É INSERIDO O NÚMERO OBRIGATÓRIO 
        //DE ITENS COMO ESPECIFICADO(5 ITENS OBRIGATÓRIOS CARECTERIZADOS
        //PELO "0" NA PROPRIEDADE MASK DO MASKEDTEXTBOX) O TEXTBOX NÃO 
        //IMPRIME O VALOR QUE FOI INSERIDO.
        private void button1_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.MaskCompleted == true)
            {
                textBox1.Text = maskedTextBox1.Text;
            }
        }
        //LÓGICA QUE DEFINE SE A SENHA SERÁ VISÍVEL OU NÃO VISÍVEL 
        //CONFORME O CHECKBOX MARCADO == MARCADO: SENHA VISÍVEL 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
               maskedTextBox1.UseSystemPasswordChar = true;
            }
            else
            {
               maskedTextBox1.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(maskedTextBox2.MaskCompleted == true)
            {
                MessageBox.Show(maskedTextBox2.Text);
            }
        }
    }
}
