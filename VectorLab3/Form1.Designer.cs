namespace VectorLab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFirstX = new System.Windows.Forms.TextBox();
            this.txtFirstY = new System.Windows.Forms.TextBox();
            this.txtFirstZ = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFirstX
            // 
            this.txtFirstX.Location = new System.Drawing.Point(75, 45);
            this.txtFirstX.Name = "txtFirstX";
            this.txtFirstX.Size = new System.Drawing.Size(44, 22);
            this.txtFirstX.TabIndex = 0;
            this.txtFirstX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFirstY
            // 
            this.txtFirstY.Location = new System.Drawing.Point(75, 97);
            this.txtFirstY.Name = "txtFirstY";
            this.txtFirstY.Size = new System.Drawing.Size(44, 22);
            this.txtFirstY.TabIndex = 1;
            // 
            // txtFirstZ
            // 
            this.txtFirstZ.Location = new System.Drawing.Point(75, 152);
            this.txtFirstZ.Name = "txtFirstZ";
            this.txtFirstZ.Size = new System.Drawing.Size(44, 22);
            this.txtFirstZ.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(187, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(44, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(187, 97);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(44, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(187, 152);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(44, 22);
            this.textBox6.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(481, 45);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(44, 22);
            this.textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(481, 99);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(44, 22);
            this.textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(481, 152);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(44, 22);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(296, 318);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(106, 22);
            this.textBox10.TabIndex = 10;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(176, 248);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(71, 22);
            this.textBox11.TabIndex = 11;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(57, 248);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(71, 22);
            this.textBox12.TabIndex = 12;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(468, 248);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(71, 22);
            this.textBox13.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 382);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtFirstZ);
            this.Controls.Add(this.txtFirstY);
            this.Controls.Add(this.txtFirstX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstX;
        private System.Windows.Forms.TextBox txtFirstY;
        private System.Windows.Forms.TextBox txtFirstZ;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
    }
}

