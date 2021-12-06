﻿using System;
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
            Form2 form2 = new Form2(list,this);
            form2.ShowDialog();
        }

        private void bt_mostrarnum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }
    }
}