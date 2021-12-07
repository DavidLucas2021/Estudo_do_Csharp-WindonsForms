
namespace Estudo_do_Csharp_Windons_Forms_
{
    partial class Check_bx
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
            this.cbx_1 = new System.Windows.Forms.CheckBox();
            this.cbx2 = new System.Windows.Forms.CheckBox();
            this.cbx3 = new System.Windows.Forms.CheckBox();
            this.cbx4 = new System.Windows.Forms.CheckBox();
            this.cbx5 = new System.Windows.Forms.CheckBox();
            this.btn_Checkbox = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbx_1
            // 
            this.cbx_1.AutoSize = true;
            this.cbx_1.Location = new System.Drawing.Point(28, 53);
            this.cbx_1.Name = "cbx_1";
            this.cbx_1.Size = new System.Drawing.Size(80, 17);
            this.cbx_1.TabIndex = 0;
            this.cbx_1.Text = "checkBox1";
            this.cbx_1.UseVisualStyleBackColor = true;
            // 
            // cbx2
            // 
            this.cbx2.AutoSize = true;
            this.cbx2.Location = new System.Drawing.Point(28, 76);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(80, 17);
            this.cbx2.TabIndex = 1;
            this.cbx2.Text = "checkBox2";
            this.cbx2.UseVisualStyleBackColor = true;
            // 
            // cbx3
            // 
            this.cbx3.AutoSize = true;
            this.cbx3.Location = new System.Drawing.Point(28, 99);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(80, 17);
            this.cbx3.TabIndex = 2;
            this.cbx3.Text = "checkBox3";
            this.cbx3.UseVisualStyleBackColor = true;
            // 
            // cbx4
            // 
            this.cbx4.AutoSize = true;
            this.cbx4.Location = new System.Drawing.Point(28, 122);
            this.cbx4.Name = "cbx4";
            this.cbx4.Size = new System.Drawing.Size(80, 17);
            this.cbx4.TabIndex = 3;
            this.cbx4.Text = "checkBox4";
            this.cbx4.UseVisualStyleBackColor = true;
            // 
            // cbx5
            // 
            this.cbx5.AutoSize = true;
            this.cbx5.Location = new System.Drawing.Point(28, 145);
            this.cbx5.Name = "cbx5";
            this.cbx5.Size = new System.Drawing.Size(80, 17);
            this.cbx5.TabIndex = 4;
            this.cbx5.Text = "checkBox5";
            this.cbx5.UseVisualStyleBackColor = true;
            // 
            // btn_Checkbox
            // 
            this.btn_Checkbox.Location = new System.Drawing.Point(159, 58);
            this.btn_Checkbox.Name = "btn_Checkbox";
            this.btn_Checkbox.Size = new System.Drawing.Size(112, 57);
            this.btn_Checkbox.TabIndex = 5;
            this.btn_Checkbox.Text = "Marcados";
            this.btn_Checkbox.UseVisualStyleBackColor = true;
            this.btn_Checkbox.Click += new System.EventHandler(this.btn_Checkbox_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 168);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 177);
            this.textBox1.TabIndex = 6;
            // 
            // Check_bx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 351);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Checkbox);
            this.Controls.Add(this.cbx5);
            this.Controls.Add(this.cbx4);
            this.Controls.Add(this.cbx3);
            this.Controls.Add(this.cbx2);
            this.Controls.Add(this.cbx_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Check_bx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbx_1;
        private System.Windows.Forms.CheckBox cbx2;
        private System.Windows.Forms.CheckBox cbx3;
        private System.Windows.Forms.CheckBox cbx4;
        private System.Windows.Forms.CheckBox cbx5;
        private System.Windows.Forms.Button btn_Checkbox;
        private System.Windows.Forms.TextBox textBox1;
    }
}