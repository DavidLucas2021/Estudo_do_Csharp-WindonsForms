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
    public partial class ListBox : Form
    {
        List<string> Car = new List<string>();
        public ListBox()
        {
            InitializeComponent();
            Car.Add("Camaro");
            Car.Add("Civic");
            Car.Add("Hb20");
        }
        //BOTÃO DE CARREGAR A LISTA DE ELEMENTOS 
        private void btn_carregar_Click(object sender, EventArgs e)
        {
            lb_carros.DataSource = Car;
        }
        //BOTÃO DE ADICIONAR ELEMENTO 
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Campo vazio. Informe o carro a ser adicionado.");
            }else
            {
                Car.Add(textBox1.Text);
                DataSource();
                textBox1.Clear();
                textBox1.Focus();
            }
        }
        //BOTÃO DE REMOVER ELEMENTO 
        private void btn_remove_Click(object sender, EventArgs e)
        {
            //REMOVE O ITEM SELECIONADO NO LISTBOX
            //Car.RemoveAt(lb_carros.SelectedIndex);
            if (textBox1.Text != "")
            {
                //REMOVE O ITEM INFORMADO NO TEXTBOX
                int pos = Car.IndexOf(textBox1.Text);
                Car.RemoveAt(pos);
                //ATUALIZA O BANCO DE DADOS(LIST CAR)
                DataSource();
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Campo vazio. Informe o carro a ser removido.");
                textBox1.Focus();
            }
        }
        public void DataSource()
        {
            //FUNÇÃO QUE ATUALIZA O BANCO DE DADOS(LIST)
            //É NECESSÁRIO QUE O DATASOURCE RECEBA NULL E DEPOIS OS VALORES 
            //PARA PODER SER ALTERADO DESTE MODO 
            lb_carros.DataSource = null;
            lb_carros.DataSource = Car;
        }
    }
}
