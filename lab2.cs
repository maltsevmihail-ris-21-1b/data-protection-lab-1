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
    public partial class lab2 : Form
    {
        public static RSA rSA;
        public lab2()
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = rSA.Encrypt(textBox1.Text).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isDone = true;
            rSA = new RSA();
            isDone = rSA.GenerateKeys(/*long.Parse(textBox3.Text), long.Parse(textBox4.Text)*/);
            if (!isDone)
            {
                textBox2.Text = "Ошибка ввода ключей";
            }
            else
            {
                textBox3.Text = rSA.P.ToString();
                textBox4.Text = rSA.Q.ToString();
                textBox5.Text = rSA.T.ToString();
                textBox6.Text = rSA.N.ToString();
                textBox7.Text = rSA.E.ToString();
                textBox8.Text = rSA.D.ToString();
                textBox9.Text = "-1";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox11.Text = rSA.Decrypt();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void lab2_Load(object sender, EventArgs e)
        {

        }
    }
}
