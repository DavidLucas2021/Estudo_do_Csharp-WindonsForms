
namespace Estudo_do_Csharp_Windons_Forms_
{
    partial class LinkLabel
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
            this.ll_calculadora = new System.Windows.Forms.LinkLabel();
            this.ll_canal = new System.Windows.Forms.LinkLabel();
            this.ll_mutiplos = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ll_calculadora
            // 
            this.ll_calculadora.AutoSize = true;
            this.ll_calculadora.Location = new System.Drawing.Point(23, 101);
            this.ll_calculadora.Name = "ll_calculadora";
            this.ll_calculadora.Size = new System.Drawing.Size(62, 13);
            this.ll_calculadora.TabIndex = 0;
            this.ll_calculadora.TabStop = true;
            this.ll_calculadora.Text = "calculadora";
            this.ll_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calculadora_LinkClicked);
            // 
            // ll_canal
            // 
            this.ll_canal.AutoSize = true;
            this.ll_canal.Location = new System.Drawing.Point(23, 48);
            this.ll_canal.Name = "ll_canal";
            this.ll_canal.Size = new System.Drawing.Size(78, 13);
            this.ll_canal.TabIndex = 2;
            this.ll_canal.TabStop = true;
            this.ll_canal.Text = "Canal do curso";
            this.ll_canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_canal_LinkClicked);
            // 
            // ll_mutiplos
            // 
            this.ll_mutiplos.AutoSize = true;
            this.ll_mutiplos.Location = new System.Drawing.Point(23, 145);
            this.ll_mutiplos.Name = "ll_mutiplos";
            this.ll_mutiplos.Size = new System.Drawing.Size(45, 13);
            this.ll_mutiplos.TabIndex = 3;
            this.ll_mutiplos.TabStop = true;
            this.ll_mutiplos.Text = "mutiplos";
            this.ll_mutiplos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_mutiplos_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 193);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ll_mutiplos);
            this.Controls.Add(this.ll_canal);
            this.Controls.Add(this.ll_calculadora);
            this.Name = "LinkLabel";
            this.Text = "LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_calculadora;
        private System.Windows.Forms.LinkLabel ll_canal;
        private System.Windows.Forms.LinkLabel ll_mutiplos;
        private System.Windows.Forms.TextBox textBox1;
    }
}