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
    public partial class Form1 : Form
    {
        List<string> Car= new List<string>();
        public int num;
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
            num = 0;
        }
        //LÓGICA DO BOTÃO DE ADICIONAR CARRO
        private void Add_Car_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                //JANELA DE ERRO INFORMANDO CAMPO VAZIO
                MessageBox.Show("Campo vazio. Informe o carro a ser adicionado");
                //POSICIONA O CURSOR NA CAIXA DE TEXTO PARA ADICIONAR CARRO 
                textBox1.Focus();
            }
            else 
            //VERIFICA SE O VALOR NA TEXTBOX NÃO É NULO
            if(textBox1.Text != "")
            {
                //VERIFICA SE A GARAGEM PASSOU DO LIMITE DE CARROS 
                if (listBox1.Items.Count <= 4/*Car.Count <= 4*/)
                {
                    //TRECHO QUE ADICIONA NA LISTA LÓGICA UM CARRO 
                    //PELO VALOR QUE É INFORMADO NO TEXTBOX1
                    string Valor_Car = textBox1.Text;
                    Car.Add(Valor_Car);
                    //TRECHO QUE ADICIONA NA LISTA DO TEXTBOX2(LISTA VISUAL)
                    //USANDO O MÉTODO JOIN QUE PEDE UM SEPARADOR(QUEBRA DE LINHA)
                    //É A VARIÁVEL A SER CONCATENADA
                    listBox1.Items.Add(Valor_Car);
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Garagem cheia. Retire um carro");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }
        //LÓGICA DO BOTÃO DE LIMPAR CONTEÚDO     
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            textBox3.Clear();
            Car.Clear();
            textBox1.Focus();
        }
        //TRECHO DA LÓGICA DE DATA E HORA 
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        //LOGICA DO BOTÃO DE REMOVER 
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >=1/*Car.Count >= 1*/)
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Campo vazio. Informe o carro a ser retirado");
                    textBox3.Focus();
                }
                else
                if(textBox3.Text != "")
                {
                    string Car_remove = textBox3.Text;
                    if(listBox1.Items.Contains(Car_remove) == true)
                    {
                       Car.Remove(Car_remove);
                       listBox1.Items.Remove(Car_remove);
                       textBox3.Clear();
                       textBox3.Focus();
                    }else
                    {
                       MessageBox.Show("O Carro informado não se encontra na garagem.");
                       textBox3.Clear();
                       textBox3.Focus(); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Garagem vazia. Não é possivel remover carros");
                textBox3.Clear();
                textBox1.Focus();
            }
        }
        //LÓGICA D QUE ABRE A JANELA(FORMS 2) DE HISTÓRICO E CARREGA 
        //A LISTA QUE SE ENCOONTRA NA PRIMEIRA JANELA(FORM 1)
        private void bt_historico_Click(object sender, EventArgs e)
        {
            string[] list = new string[5];
            Car.CopyTo(list);
            //ENTRANDO COM LIST(ARRAY) E UM OBJETO DA CLASSE FORM1(THIS)
            Form2 form2 = new Form2(list,this);
            form2.ShowDialog();
        }
        //LÓGICA DO BOTÃO QUE MOSTRA O VALOR DA VARIÁVEL NUM 
        private void bt_mostrarnum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }
        //LÓGICA DE MENU QUE ABRE O FORM CHECK_BX
        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_bx form_Check_bx = new Check_bx();
            form_Check_bx.ShowDialog(); 
        }

        private void checkledListboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checkled_listbox checkled_Listbox = new Checkled_listbox();
            checkled_Listbox.ShowDialog();
        }

        private void comboboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.ShowDialog();
        }

        private void dateTimerPickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimerPicker dateTimerPicker = new DateTimerPicker();
            dateTimerPicker.ShowDialog();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkLabel linkLabel = new LinkLabel();
            linkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox listBox = new ListBox();
            listBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView listView = new ListView();
            listView.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = new MaskedTextBox();
            maskedTextBox.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthCalendar monthCalendar = new MonthCalendar();
            monthCalendar.ShowDialog();
        }
        //EVENTO ONDE O ToolStripItemClickedEventArgs "e" OBTEM O ELEMENTO QUE FOI 
        //CLICADO E SOMENTE É NECESSÁRIO FAZER UMA CONDIÇÃO DE VERIFICAÇÃO DO TEXTO DO
        //ELEMENTO PARA PODER DEFINIR QUAL COMANDO REALIZAR 
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name.ToString() == "toolStripMenuItem3")
            {
                this.Close();
            }
            else if(e.ClickedItem.Name.ToString() == "toolStripMenuItem1")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if(e.ClickedItem.Name.ToString() == "toolStripMenuItem2")
            {
                MessageBox.Show("BOM DIA");
            }

        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            //CENTRALIZANDO O FORMS POR MEIO DO CÓDIGO;
            pictureBox.StartPosition = FormStartPosition.CenterScreen;
            pictureBox.ShowDialog();
        }

        private void progressbarESleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Progressbar_e_Sleep progressbar_E_Sleep = new Progressbar_e_Sleep();
            progressbar_E_Sleep.StartPosition = FormStartPosition.CenterScreen;
            progressbar_E_Sleep.ShowDialog();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_RadioButton f_Radio = new f_RadioButton();
            f_Radio.StartPosition = FormStartPosition.CenterScreen;
            f_Radio.ShowDialog();
        }
    }
}
