using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_protection_lab_1
{
    public partial class lab5 : Form
    {
        private Checker checker = new Checker(12);

        private string message;
        private string messageBinary;
        public lab5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message = textBox1.Text;

            if (message == "")
            {
                label4.Text = "Ошибка ввода";
                return;
            }

            messageBinary = checker.ConvertToBinary(message);
            textBox2.Text = messageBinary;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            messageBinary = textBox2.Text;

            if (messageBinary == "")
            {
                label4.Text = "Ошибка ввода";
                return;
            }

            if (checker.Check(messageBinary))
            {
                label4.Text = "Проверка пройдена";
            }

            else
            {
                label4.Text = "Проверка не пройдена";
            }
        }
    }
}
