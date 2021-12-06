
namespace Estudo_do_Csharp_Windons_Forms_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Add_Car = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_historico = new System.Windows.Forms.Button();
            this.bt_mostrarnum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Car
            // 
            this.Add_Car.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_Car.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Car.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Car.Location = new System.Drawing.Point(254, 59);
            this.Add_Car.Name = "Add_Car";
            this.Add_Car.Size = new System.Drawing.Size(72, 26);
            this.Add_Car.TabIndex = 0;
            this.Add_Car.Text = "Adicionar ";
            this.Add_Car.UseVisualStyleBackColor = false;
            this.Add_Car.Click += new System.EventHandler(this.Add_Car_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adicione um carro:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "00:00:00 - 00/00/0000";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(236, 20);
            this.textBox3.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(254, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 26);
            this.button3.TabIndex = 8;
            this.button3.Text = "Retirar ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 173);
            this.listBox1.TabIndex = 9;
            // 
            // bt_historico
            // 
            this.bt_historico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_historico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_historico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_historico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_historico.Location = new System.Drawing.Point(12, 341);
            this.bt_historico.Name = "bt_historico";
            this.bt_historico.Size = new System.Drawing.Size(314, 26);
            this.bt_historico.TabIndex = 10;
            this.bt_historico.Text = "Histórico ";
            this.bt_historico.UseVisualStyleBackColor = false;
            this.bt_historico.Click += new System.EventHandler(this.bt_historico_Click);
            // 
            // bt_mostrarnum
            // 
            this.bt_mostrarnum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_mostrarnum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mostrarnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mostrarnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mostrarnum.Location = new System.Drawing.Point(12, 373);
            this.bt_mostrarnum.Name = "bt_mostrarnum";
            this.bt_mostrarnum.Size = new System.Drawing.Size(314, 26);
            this.bt_mostrarnum.TabIndex = 11;
            this.bt_mostrarnum.Text = "Valor_Num";
            this.bt_mostrarnum.UseVisualStyleBackColor = false;
            this.bt_mostrarnum.Click += new System.EventHandler(this.bt_mostrarnum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(336, 404);
            this.Controls.Add(this.bt_mostrarnum);
            this.Controls.Add(this.bt_historico);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_Car);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GARAGEM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Car;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_historico;
        private System.Windows.Forms.Button bt_mostrarnum;
        public System.Windows.Forms.ListBox listBox1;
    }
}

