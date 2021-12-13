
namespace Estudo_do_Csharp_Windons_Forms_
{
    partial class DateTimerPicker
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_obter = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.btn_setar = new System.Windows.Forms.Button();
            this.btn_resete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(276, 9);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(75, 23);
            this.btn_obter.TabIndex = 1;
            this.btn_obter.Text = "Obter data";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 44);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(258, 20);
            this.tb_data.TabIndex = 2;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(12, 70);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(81, 20);
            this.tb_dia.TabIndex = 3;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(187, 70);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(83, 20);
            this.tb_ano.TabIndex = 4;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(99, 70);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(82, 20);
            this.tb_mes.TabIndex = 5;
            // 
            // btn_setar
            // 
            this.btn_setar.Location = new System.Drawing.Point(277, 42);
            this.btn_setar.Name = "btn_setar";
            this.btn_setar.Size = new System.Drawing.Size(75, 23);
            this.btn_setar.TabIndex = 6;
            this.btn_setar.Text = "Definir data";
            this.btn_setar.UseVisualStyleBackColor = true;
            this.btn_setar.Click += new System.EventHandler(this.btn_setar_Click);
            // 
            // btn_resete
            // 
            this.btn_resete.Location = new System.Drawing.Point(277, 68);
            this.btn_resete.Name = "btn_resete";
            this.btn_resete.Size = new System.Drawing.Size(75, 23);
            this.btn_resete.TabIndex = 7;
            this.btn_resete.Text = "Resetar";
            this.btn_resete.UseVisualStyleBackColor = true;
            this.btn_resete.Click += new System.EventHandler(this.btn_resete_Click);
            // 
            // DateTimerPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 129);
            this.Controls.Add(this.btn_resete);
            this.Controls.Add(this.btn_setar);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DateTimerPicker";
            this.Text = "DateTimerPicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.Button btn_setar;
        private System.Windows.Forms.Button btn_resete;
    }
}