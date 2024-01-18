namespace data_protection_lab_1
{
    partial class lab4
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
            textBox1 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(-1, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(652, 96);
            textBox1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(451, 12);
            button4.Name = "button4";
            button4.Size = new Size(81, 29);
            button4.TabIndex = 5;
            button4.Text = "Назад";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.OrangeRed;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(538, 12);
            button5.Name = "button5";
            button5.Size = new Size(81, 29);
            button5.TabIndex = 6;
            button5.Text = "Выход";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(183, 29);
            button2.TabIndex = 7;
            button2.Text = "Сгенерировать ключи";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(201, 12);
            button3.Name = "button3";
            button3.Size = new Size(120, 29);
            button3.TabIndex = 8;
            button3.Text = "Шифровать";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DeepSkyBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(327, 12);
            button6.Name = "button6";
            button6.Size = new Size(118, 29);
            button6.TabIndex = 9;
            button6.Text = "Дешифровать";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DeepSkyBlue;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(327, 47);
            button7.Name = "button7";
            button7.Size = new Size(292, 29);
            button7.TabIndex = 10;
            button7.Text = "Указать путь к зашифрованному файлу";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DeepSkyBlue;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(12, 47);
            button8.Name = "button8";
            button8.Size = new Size(309, 29);
            button8.TabIndex = 11;
            button8.Text = "Указать путь к иходному файлу";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(330, 207);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 95);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(330, 181);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 16;
            label1.Text = "Исходный текст";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(329, 343);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(291, 95);
            textBox3.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(329, 317);
            label2.Name = "label2";
            label2.Size = new Size(188, 23);
            label2.TabIndex = 18;
            label2.Text = "Зашифрованный текст";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 343);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(309, 95);
            textBox4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 317);
            label3.Name = "label3";
            label3.Size = new Size(191, 23);
            label3.TabIndex = 19;
            label3.Text = "Дешифрованный текст";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(96, 102);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(522, 27);
            textBox5.TabIndex = 20;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(96, 135);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(522, 27);
            textBox6.TabIndex = 21;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Control;
            textBox7.Location = new Point(12, 207);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(309, 95);
            textBox7.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 135);
            label5.Name = "label5";
            label5.Size = new Size(60, 23);
            label5.TabIndex = 23;
            label5.Text = "Путь 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 24;
            label4.Text = "Путь 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 181);
            label6.Name = "label6";
            label6.Size = new Size(53, 23);
            label6.TabIndex = 25;
            label6.Text = "Ключ";
            // 
            // lab4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(630, 450);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "lab4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "lab4";
            Load += lab4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label5;
        private Label label4;
        private Label label6;
    }
}