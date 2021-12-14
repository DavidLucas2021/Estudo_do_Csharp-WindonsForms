
namespace Estudo_do_Csharp_Windons_Forms_
{
    partial class ListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "MOUSE",
            "200",
            "R$19,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "MONITOR 29\"",
            "150",
            "R$560"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "PC INTEL 7",
            "40",
            "R$939,90"}, -1);
            this.LV_tabela = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_quant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_prod = new System.Windows.Forms.TextBox();
            this.tb_quant = new System.Windows.Forms.TextBox();
            this.tb_prec = new System.Windows.Forms.TextBox();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LV_tabela
            // 
            this.LV_tabela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_produto,
            this.col_quant,
            this.col_preco});
            this.LV_tabela.FullRowSelect = true;
            this.LV_tabela.GridLines = true;
            this.LV_tabela.HideSelection = false;
            this.LV_tabela.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.LV_tabela.Location = new System.Drawing.Point(12, 12);
            this.LV_tabela.MultiSelect = false;
            this.LV_tabela.Name = "LV_tabela";
            this.LV_tabela.Size = new System.Drawing.Size(520, 191);
            this.LV_tabela.TabIndex = 0;
            this.LV_tabela.UseCompatibleStateImageBehavior = false;
            this.LV_tabela.View = System.Windows.Forms.View.Details;
            this.LV_tabela.SelectedIndexChanged += new System.EventHandler(this.LV_tabela_SelectedIndexChanged);
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 102;
            // 
            // col_produto
            // 
            this.col_produto.Text = "PRODUTO";
            this.col_produto.Width = 116;
            // 
            // col_quant
            // 
            this.col_quant.Text = "QUANTIDADE";
            this.col_quant.Width = 164;
            // 
            // col_preco
            // 
            this.col_preco.Text = "PREÇO";
            this.col_preco.Width = 133;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 209);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(97, 20);
            this.tb_id.TabIndex = 1;
            // 
            // tb_prod
            // 
            this.tb_prod.Location = new System.Drawing.Point(115, 209);
            this.tb_prod.Name = "tb_prod";
            this.tb_prod.Size = new System.Drawing.Size(114, 20);
            this.tb_prod.TabIndex = 2;
            // 
            // tb_quant
            // 
            this.tb_quant.Location = new System.Drawing.Point(235, 209);
            this.tb_quant.Name = "tb_quant";
            this.tb_quant.Size = new System.Drawing.Size(159, 20);
            this.tb_quant.TabIndex = 3;
            // 
            // tb_prec
            // 
            this.tb_prec.Location = new System.Drawing.Point(400, 209);
            this.tb_prec.Name = "tb_prec";
            this.tb_prec.Size = new System.Drawing.Size(132, 20);
            this.tb_prec.TabIndex = 4;
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(12, 235);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(84, 22);
            this.bt_adicionar.TabIndex = 5;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Location = new System.Drawing.Point(102, 235);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(84, 22);
            this.bt_remover.TabIndex = 6;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(192, 235);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(84, 22);
            this.bt_atualizar.TabIndex = 7;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(282, 235);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(84, 22);
            this.bt_limpar.TabIndex = 8;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 270);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.tb_prec);
            this.Controls.Add(this.tb_quant);
            this.Controls.Add(this.tb_prod);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.LV_tabela);
            this.Name = "ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_tabela;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_produto;
        private System.Windows.Forms.ColumnHeader col_quant;
        private System.Windows.Forms.ColumnHeader col_preco;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_prod;
        private System.Windows.Forms.TextBox tb_quant;
        private System.Windows.Forms.TextBox tb_prec;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_limpar;
    }
}