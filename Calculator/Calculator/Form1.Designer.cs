namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.devision = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.resultt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 2;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(12, 38);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(43, 41);
            this.plus.TabIndex = 24;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.button14_Click);
            // 
            // devision
            // 
            this.devision.Location = new System.Drawing.Point(110, 38);
            this.devision.Name = "devision";
            this.devision.Size = new System.Drawing.Size(43, 41);
            this.devision.TabIndex = 25;
            this.devision.Text = "/";
            this.devision.UseVisualStyleBackColor = true;
            this.devision.Click += new System.EventHandler(this.button14_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(159, 38);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(43, 41);
            this.multiply.TabIndex = 26;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.button14_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(61, 38);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(43, 41);
            this.minus.TabIndex = 27;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button14_Click);
            // 
            // resultt
            // 
            this.resultt.AutoSize = true;
            this.resultt.Location = new System.Drawing.Point(267, 15);
            this.resultt.Name = "resultt";
            this.resultt.Size = new System.Drawing.Size(0, 13);
            this.resultt.TabIndex = 29;
            this.resultt.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(331, 93);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultt);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.devision);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Кукареку";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button devision;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Label resultt;
        private System.Windows.Forms.Label label2;

    }
}

