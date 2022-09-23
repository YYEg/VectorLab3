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
            this.SuspendLayout();
            // 
            // txtXFirst
            // 
            this.txtXFirst.Location = new System.Drawing.Point(82, 64);
            this.txtXFirst.Name = "txtXFirst";
            this.txtXFirst.Size = new System.Drawing.Size(44, 22);
            this.txtXFirst.TabIndex = 0;
            this.txtXFirst.TextChanged += new System.EventHandler(this.txtXFirst_TextChanged);
            // 
            // txtYFirst
            // 
            this.txtYFirst.Location = new System.Drawing.Point(82, 122);
            this.txtYFirst.Name = "txtYFirst";
            this.txtYFirst.Size = new System.Drawing.Size(44, 22);
            this.txtYFirst.TabIndex = 1;
            this.txtYFirst.TextChanged += new System.EventHandler(this.txtYFirst_TextChanged);
            // 
            // txtZFirst
            // 
            this.txtZFirst.Location = new System.Drawing.Point(82, 183);
            this.txtZFirst.Name = "txtZFirst";
            this.txtZFirst.Size = new System.Drawing.Size(44, 22);
            this.txtZFirst.TabIndex = 2;
            this.txtZFirst.TextChanged += new System.EventHandler(this.txtZFirst_TextChanged);
            // 
            // txtXSecond
            // 
            this.txtXSecond.Location = new System.Drawing.Point(219, 64);
            this.txtXSecond.Name = "txtXSecond";
            this.txtXSecond.Size = new System.Drawing.Size(44, 22);
            this.txtXSecond.TabIndex = 3;
            this.txtXSecond.TextChanged += new System.EventHandler(this.txtXSecond_TextChanged);
            // 
            // txtYSecond
            // 
            this.txtYSecond.Location = new System.Drawing.Point(219, 122);
            this.txtYSecond.Name = "txtYSecond";
            this.txtYSecond.Size = new System.Drawing.Size(44, 22);
            this.txtYSecond.TabIndex = 4;
            this.txtYSecond.TextChanged += new System.EventHandler(this.txtYSecond_TextChanged);
            // 
            // txtZSecond
            // 
            this.txtZSecond.Location = new System.Drawing.Point(219, 183);
            this.txtZSecond.Name = "txtZSecond";
            this.txtZSecond.Size = new System.Drawing.Size(44, 22);
            this.txtZSecond.TabIndex = 5;
            this.txtZSecond.TextChanged += new System.EventHandler(this.txtZSecond_TextChanged);
            // 
            // txtXResult
            // 
            this.txtXResult.Location = new System.Drawing.Point(441, 64);
            this.txtXResult.Name = "txtXResult";
            this.txtXResult.Size = new System.Drawing.Size(44, 22);
            this.txtXResult.TabIndex = 6;
            // 
            // txtYResult
            // 
            this.txtYResult.Location = new System.Drawing.Point(441, 122);
            this.txtYResult.Name = "txtYResult";
            this.txtYResult.Size = new System.Drawing.Size(44, 22);
            this.txtYResult.TabIndex = 7;
            // 
            // txtZResult
            // 
            this.txtZResult.Location = new System.Drawing.Point(441, 183);
            this.txtZResult.Name = "txtZResult";
            this.txtZResult.Size = new System.Drawing.Size(44, 22);
            this.txtZResult.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 13);
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
            "-"});
            this.cmbOperation.Location = new System.Drawing.Point(320, 120);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(75, 24);
            this.cmbOperation.TabIndex = 12;
            this.cmbOperation.Text = "+";
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.cmbOperation_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 296);
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
    }
}

