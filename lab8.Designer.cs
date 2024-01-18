namespace data_protection_lab_1
{
    partial class lab8
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
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label3 = new Label();
            textBox10 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(252, 29);
            button1.TabIndex = 30;
            button1.Text = "Шифровать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(368, 189);
            button3.Name = "button3";
            button3.Size = new Size(88, 29);
            button3.TabIndex = 32;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.OrangeRed;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(462, 189);
            button4.Name = "button4";
            button4.Size = new Size(88, 29);
            button4.TabIndex = 33;
            button4.Text = "Выход";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 85);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 98);
            textBox1.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(298, 85);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(252, 98);
            textBox2.TabIndex = 34;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(298, 12);
            button2.Name = "button2";
            button2.Size = new Size(252, 29);
            button2.TabIndex = 40;
            button2.Text = "Расшифровать";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 41;
            label1.Text = "Исходный текст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(298, 55);
            label3.Name = "label3";
            label3.Size = new Size(189, 23);
            label3.TabIndex = 42;
            label3.Text = "Закодированный текст";
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.ActiveCaption;
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Enabled = false;
            textBox10.Location = new Point(-1, 0);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(668, 79);
            textBox10.TabIndex = 43;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 224);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(538, 27);
            textBox3.TabIndex = 44;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 197);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 45;
            label2.Text = "Ключ";
            // 
            // lab8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(562, 264);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "lab8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "lab8";
            Load += lab8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private Label label3;
        private TextBox textBox10;
        private TextBox textBox3;
        private Label label2;
    }
}