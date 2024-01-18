namespace data_protection_lab_1
{
    partial class MainMenu
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-1, 1);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 0;
            label1.Text = "Лабораторные работы";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(26, 51);
            button1.Name = "button1";
            button1.Size = new Size(159, 29);
            button1.TabIndex = 1;
            button1.Text = "Работа 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(26, 86);
            button2.Name = "button2";
            button2.Size = new Size(159, 29);
            button2.TabIndex = 2;
            button2.Text = "Работа 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(26, 121);
            button3.Name = "button3";
            button3.Size = new Size(159, 29);
            button3.TabIndex = 3;
            button3.Text = "Работа 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(26, 156);
            button4.Name = "button4";
            button4.Size = new Size(159, 29);
            button4.TabIndex = 4;
            button4.Text = "Работа 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(26, 191);
            button5.Name = "button5";
            button5.Size = new Size(159, 29);
            button5.TabIndex = 5;
            button5.Text = "Работа 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(26, 226);
            button6.Name = "button6";
            button6.Size = new Size(159, 29);
            button6.TabIndex = 6;
            button6.Text = "Работа 6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(26, 261);
            button7.Name = "button7";
            button7.Size = new Size(159, 29);
            button7.TabIndex = 7;
            button7.Text = "Работа 7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(26, 296);
            button8.Name = "button8";
            button8.Size = new Size(159, 29);
            button8.TabIndex = 8;
            button8.Text = "Работа 8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 45);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.Location = new Point(180, 0);
            label2.Name = "label2";
            label2.Size = new Size(30, 30);
            label2.TabIndex = 1;
            label2.Text = "❌";
            label2.Click += label2_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 341);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Panel panel1;
        private Label label2;
    }
}