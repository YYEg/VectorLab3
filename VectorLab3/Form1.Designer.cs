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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.txtLengthSecond = new System.Windows.Forms.TextBox();
            this.txtLengthFirst = new System.Windows.Forms.TextBox();
            this.txtLengthResult = new System.Windows.Forms.TextBox();
            this.txtDotMulti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            // txtLengthSecond
            // 
            this.txtLengthSecond.Location = new System.Drawing.Point(176, 248);
            this.txtLengthSecond.Name = "txtLengthSecond";
            this.txtLengthSecond.Size = new System.Drawing.Size(71, 22);
            this.txtLengthSecond.TabIndex = 11;
            // 
            // txtLengthFirst
            // 
            this.txtLengthFirst.Location = new System.Drawing.Point(57, 248);
            this.txtLengthFirst.Name = "txtLengthFirst";
            this.txtLengthFirst.Size = new System.Drawing.Size(71, 22);
            this.txtLengthFirst.TabIndex = 12;
            // 
            // txtLengthResult
            // 
            this.txtLengthResult.Location = new System.Drawing.Point(468, 248);
            this.txtLengthResult.Name = "txtLengthResult";
            this.txtLengthResult.Size = new System.Drawing.Size(71, 22);
            this.txtLengthResult.TabIndex = 13;
            // 
            // txtDotMulti
            // 
            this.txtDotMulti.Location = new System.Drawing.Point(406, 306);
            this.txtDotMulti.Name = "txtDotMulti";
            this.txtDotMulti.Size = new System.Drawing.Size(106, 22);
            this.txtDotMulti.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Длинна А";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Длинна В";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Длинна С";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Скалярное произведение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 382);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDotMulti);
            this.Controls.Add(this.txtLengthResult);
            this.Controls.Add(this.txtLengthFirst);
            this.Controls.Add(this.txtLengthSecond);
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
        private System.Windows.Forms.TextBox txtLengthSecond;
        private System.Windows.Forms.TextBox txtLengthFirst;
        private System.Windows.Forms.TextBox txtLengthResult;
        private System.Windows.Forms.TextBox txtDotMulti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

