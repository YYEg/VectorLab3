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
            this.txtXFirst = new System.Windows.Forms.TextBox();
            this.txtYFirst = new System.Windows.Forms.TextBox();
            this.txtZFirst = new System.Windows.Forms.TextBox();
            this.txtXSecond = new System.Windows.Forms.TextBox();
            this.txtYSecond = new System.Windows.Forms.TextBox();
            this.txtZSecond = new System.Windows.Forms.TextBox();
            this.txtXResult = new System.Windows.Forms.TextBox();
            this.txtYResult = new System.Windows.Forms.TextBox();
            this.txtZResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMulti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLenghtFirst = new System.Windows.Forms.TextBox();
            this.textLenghtSecond = new System.Windows.Forms.TextBox();
            this.txtLengtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtXFirst
            // 
            this.txtXFirst.Location = new System.Drawing.Point(66, 68);
            this.txtXFirst.Name = "txtXFirst";
            this.txtXFirst.Size = new System.Drawing.Size(44, 22);
            this.txtXFirst.TabIndex = 0;
            this.txtXFirst.TextChanged += new System.EventHandler(this.txtXFirst_TextChanged);
            // 
            // txtYFirst
            // 
            this.txtYFirst.Location = new System.Drawing.Point(66, 126);
            this.txtYFirst.Name = "txtYFirst";
            this.txtYFirst.Size = new System.Drawing.Size(44, 22);
            this.txtYFirst.TabIndex = 1;
            this.txtYFirst.TextChanged += new System.EventHandler(this.txtYFirst_TextChanged);
            // 
            // txtZFirst
            // 
            this.txtZFirst.Location = new System.Drawing.Point(66, 187);
            this.txtZFirst.Name = "txtZFirst";
            this.txtZFirst.Size = new System.Drawing.Size(44, 22);
            this.txtZFirst.TabIndex = 2;
            this.txtZFirst.TextChanged += new System.EventHandler(this.txtZFirst_TextChanged);
            // 
            // txtXSecond
            // 
            this.txtXSecond.Location = new System.Drawing.Point(203, 68);
            this.txtXSecond.Name = "txtXSecond";
            this.txtXSecond.Size = new System.Drawing.Size(44, 22);
            this.txtXSecond.TabIndex = 3;
            this.txtXSecond.TextChanged += new System.EventHandler(this.txtXSecond_TextChanged);
            // 
            // txtYSecond
            // 
            this.txtYSecond.Location = new System.Drawing.Point(203, 126);
            this.txtYSecond.Name = "txtYSecond";
            this.txtYSecond.Size = new System.Drawing.Size(44, 22);
            this.txtYSecond.TabIndex = 4;
            this.txtYSecond.TextChanged += new System.EventHandler(this.txtYSecond_TextChanged);
            // 
            // txtZSecond
            // 
            this.txtZSecond.Location = new System.Drawing.Point(203, 187);
            this.txtZSecond.Name = "txtZSecond";
            this.txtZSecond.Size = new System.Drawing.Size(44, 22);
            this.txtZSecond.TabIndex = 5;
            this.txtZSecond.TextChanged += new System.EventHandler(this.txtZSecond_TextChanged);
            // 
            // txtXResult
            // 
            this.txtXResult.Location = new System.Drawing.Point(540, 68);
            this.txtXResult.Name = "txtXResult";
            this.txtXResult.Size = new System.Drawing.Size(44, 22);
            this.txtXResult.TabIndex = 6;
            // 
            // txtYResult
            // 
            this.txtYResult.Location = new System.Drawing.Point(540, 126);
            this.txtYResult.Name = "txtYResult";
            this.txtYResult.Size = new System.Drawing.Size(44, 22);
            this.txtYResult.TabIndex = 7;
            // 
            // txtZResult
            // 
            this.txtZResult.Location = new System.Drawing.Point(540, 187);
            this.txtZResult.Name = "txtZResult";
            this.txtZResult.Size = new System.Drawing.Size(44, 22);
            this.txtZResult.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "C";
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "Векторное произведение"});
            this.cmbOperation.Location = new System.Drawing.Point(302, 126);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(188, 24);
            this.cmbOperation.TabIndex = 12;
            this.cmbOperation.Text = "+";
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.cmbOperation_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Произведение:";
            // 
            // txtMulti
            // 
            this.txtMulti.Location = new System.Drawing.Point(400, 193);
            this.txtMulti.Name = "txtMulti";
            this.txtMulti.Size = new System.Drawing.Size(100, 22);
            this.txtMulti.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Длинна А";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Длинна В";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Длинна С";
            // 
            // txtLenghtFirst
            // 
            this.txtLenghtFirst.Location = new System.Drawing.Point(50, 287);
            this.txtLenghtFirst.Name = "txtLenghtFirst";
            this.txtLenghtFirst.Size = new System.Drawing.Size(100, 22);
            this.txtLenghtFirst.TabIndex = 18;
            // 
            // textLenghtSecond
            // 
            this.textLenghtSecond.Location = new System.Drawing.Point(189, 287);
            this.textLenghtSecond.Name = "textLenghtSecond";
            this.textLenghtSecond.Size = new System.Drawing.Size(100, 22);
            this.textLenghtSecond.TabIndex = 19;
            // 
            // txtLengtResult
            // 
            this.txtLengtResult.Location = new System.Drawing.Point(521, 287);
            this.txtLengtResult.Name = "txtLengtResult";
            this.txtLengtResult.Size = new System.Drawing.Size(100, 22);
            this.txtLengtResult.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 338);
            this.Controls.Add(this.txtLengtResult);
            this.Controls.Add(this.textLenghtSecond);
            this.Controls.Add(this.txtLenghtFirst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMulti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZResult);
            this.Controls.Add(this.txtYResult);
            this.Controls.Add(this.txtXResult);
            this.Controls.Add(this.txtZSecond);
            this.Controls.Add(this.txtYSecond);
            this.Controls.Add(this.txtXSecond);
            this.Controls.Add(this.txtZFirst);
            this.Controls.Add(this.txtYFirst);
            this.Controls.Add(this.txtXFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXFirst;
        private System.Windows.Forms.TextBox txtYFirst;
        private System.Windows.Forms.TextBox txtZFirst;
        private System.Windows.Forms.TextBox txtXSecond;
        private System.Windows.Forms.TextBox txtYSecond;
        private System.Windows.Forms.TextBox txtZSecond;
        private System.Windows.Forms.TextBox txtXResult;
        private System.Windows.Forms.TextBox txtYResult;
        private System.Windows.Forms.TextBox txtZResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMulti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLenghtFirst;
        private System.Windows.Forms.TextBox textLenghtSecond;
        private System.Windows.Forms.TextBox txtLengtResult;
    }
}

