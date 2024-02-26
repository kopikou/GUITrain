namespace Train
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
            this.arrivalHour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arrivalMinute = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.commingHour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.commingMinute = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.departHour = new System.Windows.Forms.TextBox();
            this.departMinute = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrivalHour
            // 
            this.arrivalHour.Location = new System.Drawing.Point(180, 30);
            this.arrivalHour.Name = "arrivalHour";
            this.arrivalHour.Size = new System.Drawing.Size(100, 22);
            this.arrivalHour.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поезд прибывает в";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "часов";
            // 
            // arrivalMinute
            // 
            this.arrivalMinute.Location = new System.Drawing.Point(367, 33);
            this.arrivalMinute.Name = "arrivalMinute";
            this.arrivalMinute.Size = new System.Drawing.Size(100, 22);
            this.arrivalMinute.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "минут";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пассажир пришел в";
            // 
            // commingHour
            // 
            this.commingHour.Location = new System.Drawing.Point(180, 150);
            this.commingHour.Name = "commingHour";
            this.commingHour.Size = new System.Drawing.Size(100, 22);
            this.commingHour.TabIndex = 6;
            this.commingHour.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "часов";
            // 
            // commingMinute
            // 
            this.commingMinute.Location = new System.Drawing.Point(367, 150);
            this.commingMinute.Name = "commingMinute";
            this.commingMinute.Size = new System.Drawing.Size(100, 22);
            this.commingMinute.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "минут";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Поезд отправляется в";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "часов";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "минут";
            // 
            // departHour
            // 
            this.departHour.Location = new System.Drawing.Point(180, 96);
            this.departHour.Name = "departHour";
            this.departHour.Size = new System.Drawing.Size(100, 22);
            this.departHour.TabIndex = 13;
            // 
            // departMinute
            // 
            this.departMinute.Location = new System.Drawing.Point(367, 96);
            this.departMinute.Name = "departMinute";
            this.departMinute.Size = new System.Drawing.Size(100, 22);
            this.departMinute.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(529, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Будет ли поезд стоять на платформе?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.departMinute);
            this.Controls.Add(this.departHour);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.commingMinute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.commingHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrivalMinute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrivalHour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arrivalHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arrivalMinute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox commingHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox commingMinute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox departHour;
        private System.Windows.Forms.TextBox departMinute;
        private System.Windows.Forms.Button button1;
    }
}

