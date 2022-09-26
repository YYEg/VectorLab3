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
            this.txtSecondX = new System.Windows.Forms.TextBox();
            this.txtSecondY = new System.Windows.Forms.TextBox();
            this.txtSecondZ = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.txtResultX = new System.Windows.Forms.TextBox();
            this.txtResultY = new System.Windows.Forms.TextBox();
            this.txtResultZ = new System.Windows.Forms.TextBox();
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
            this.txtFirstY.TextChanged += new System.EventHandler(this.txtFirstY_TextChanged);
            // 
            // txtFirstZ
            // 
            this.txtFirstZ.Location = new System.Drawing.Point(75, 152);
            this.txtFirstZ.Name = "txtFirstZ";
            this.txtFirstZ.Size = new System.Drawing.Size(44, 22);
            this.txtFirstZ.TabIndex = 2;
            this.txtFirstZ.TextChanged += new System.EventHandler(this.txtFirstZ_TextChanged);
            // 
            // txtSecondX
            // 
            this.txtSecondX.Location = new System.Drawing.Point(187, 45);
            this.txtSecondX.Name = "txtSecondX";
            this.txtSecondX.Size = new System.Drawing.Size(44, 22);
            this.txtSecondX.TabIndex = 3;
            this.txtSecondX.TextChanged += new System.EventHandler(this.txtSecondX_TextChanged);
            // 
            // txtSecondY
            // 
            this.txtSecondY.Location = new System.Drawing.Point(187, 97);
            this.txtSecondY.Name = "txtSecondY";
            this.txtSecondY.Size = new System.Drawing.Size(44, 22);
            this.txtSecondY.TabIndex = 4;
            this.txtSecondY.TextChanged += new System.EventHandler(this.txtSecondY_TextChanged);
            // 
            // txtSecondZ
            // 
            this.txtSecondZ.Location = new System.Drawing.Point(187, 152);
            this.txtSecondZ.Name = "txtSecondZ";
            this.txtSecondZ.Size = new System.Drawing.Size(44, 22);
            this.txtSecondZ.TabIndex = 5;
            this.txtSecondZ.TextChanged += new System.EventHandler(this.txtSecondZ_TextChanged);
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "Векторное произведение"});
            this.cmbOperation.Location = new System.Drawing.Point(296, 97);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(121, 24);
            this.cmbOperation.TabIndex = 6;
            this.cmbOperation.Text = "+";
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.cmbOperation_SelectedIndexChanged);
            // 
            // txtResultX
            // 
            this.txtResultX.Location = new System.Drawing.Point(481, 45);
            this.txtResultX.Name = "txtResultX";
            this.txtResultX.Size = new System.Drawing.Size(44, 22);
            this.txtResultX.TabIndex = 7;
            // 
            // txtResultY
            // 
            this.txtResultY.Location = new System.Drawing.Point(481, 99);
            this.txtResultY.Name = "txtResultY";
            this.txtResultY.Size = new System.Drawing.Size(44, 22);
            this.txtResultY.TabIndex = 8;
            // 
            // txtResultZ
            // 
            this.txtResultZ.Location = new System.Drawing.Point(481, 152);
            this.txtResultZ.Name = "txtResultZ";
            this.txtResultZ.Size = new System.Drawing.Size(44, 22);
            this.txtResultZ.TabIndex = 9;
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
            this.Controls.Add(this.txtResultZ);
            this.Controls.Add(this.txtResultY);
            this.Controls.Add(this.txtResultX);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.txtSecondZ);
            this.Controls.Add(this.txtSecondY);
            this.Controls.Add(this.txtSecondX);
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
        private System.Windows.Forms.TextBox txtSecondX;
        private System.Windows.Forms.TextBox txtSecondY;
        private System.Windows.Forms.TextBox txtSecondZ;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.TextBox txtResultX;
        private System.Windows.Forms.TextBox txtResultY;
        private System.Windows.Forms.TextBox txtResultZ;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
    }
}

