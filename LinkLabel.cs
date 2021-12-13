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
    public partial class LinkLabel : Form
    {
        public LinkLabel()
        {
            InitializeComponent();
        }
        //ABRINDO UM SITE EM ESPECÍFICO 
        private void ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCqHIWCQSq0yeE-1nbcRnt2w");
            //COR DE LINK VISITADO 
            //ll_canal.LinkColor = Color.Purple;
            //OU
            ll_canal.LinkVisited = true;
        }
        //ABRINDO UM PROGRAMA DO WINDOWS(CALCULADORA)
        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            //COR DE LINK VISITADO 
            //ll_calculadora.LinkColor = Color.Purple;
            //OU
            ll_calculadora.LinkVisited = true;

            //OU PODE SER USADO O DIRETÓRIO DO PROGRAMA TAMBÉM
            //TENHA ATENÇÃO A BARRA QUE SERA USADA,DARÁ ERRO COM A BARRA ERRADA
            //System.Diagnostics.Process.Start("C:Users/SMART AUTOMAÇÃO/Desktop/Aplicação Garagem/Estudo do Csharp(Windons Forms).exe");
        }

        private void ll_mutiplos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(textBox1.Text);
        }
    }
}
