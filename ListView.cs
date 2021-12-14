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
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }
        private void atualizar()
        {
            //IF PARA GARANTIR QUE SOMENTE QUANDO UM ITEM ESTIVER SELECIONADO 
            //ESSE TRECHO DE CÓDIGO SERÁ VERDADEIRO, ASSIM EVITA-SE EXCEÇÃO
            if (LV_tabela.SelectedItems.Count > 0)
            {
                tb_id.Text = LV_tabela.SelectedItems[0].SubItems[0].Text;
                tb_prod.Text = LV_tabela.SelectedItems[0].SubItems[1].Text;
                tb_quant.Text = LV_tabela.SelectedItems[0].SubItems[2].Text;
                tb_prec.Text = LV_tabela.SelectedItems[0].SubItems[3].Text;
            }
        }        
        //LÓGICA PARA LIMPAR TEXTBOX DEPOIS DE UMA OPERAÇÃO
        private void limpar()
        {
            tb_id.Clear();
            tb_prod.Clear();
            tb_quant.Clear();
            tb_prec.Clear();
            tb_id.Focus();
        }
        //LÓGICA DE ADICIONAR ELEMENTOS NA LISTA
        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            string[] itens_list = new string[4];
            itens_list[0] = tb_id.Text;
            itens_list[1] = tb_prod.Text;
            itens_list[2] = tb_quant.Text;
            itens_list[3] = tb_prec.Text;

            ListViewItem list = new ListViewItem(itens_list);
            LV_tabela.Items.Add(list);
            limpar();
        }
        //LÓGICA PARA REMOVER ELEMENTOS DA LISTA
        private void bt_remover_Click(object sender, EventArgs e)
        {
            if (tb_id.Text != "")
            {
                //REMOVENDO PELO ID INSERIDO NO TEXTBOX
                int pos = Int32.Parse(tb_id.Text);
                LV_tabela.Items.RemoveAt(pos);
                limpar();
            }
            else
            {
                //IF PARA GARANTIR QUE SOMENTE QUANDO UM ITEM ESTIVER SELECIONADO 
                //ESSE TRECHO DE CÓDIGO SERÁ VERDADEIRO, ASSIM EVITA-SE EXCEÇÃO
                if (LV_tabela.SelectedItems.Count > 0)
                {
                    //REMOVENDO PELO PRODUTO SELECIONADO
                    LV_tabela.Items.RemoveAt(LV_tabela.SelectedIndices[0]);
                }    
            }
        }
        //LÓGICA PARA CARREGAR ELEMENTO SELECIONADO NO TEXTBOX 
        //COM O BOTÃO DE ATUALIZAR 
        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            atualizar();
        }
        //LÓGICA PARA SEMPRE CARREGAR O ITEM SELECIONADO NO TEXTBOX 
        private void LV_tabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizar();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            LV_tabela.Clear();
        }
    }
}
