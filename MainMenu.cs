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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            lab8 lab8 = new lab8();
            lab8.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            lab5 lab5 = new lab5();
            lab5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            lab4 lab4 = new lab4();
            lab4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lab3 lab3 = new lab3();
            lab3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            this.Hide();
            lab2 lab2 = new lab2();
            lab2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1 lab1 = new Lab1();
            lab1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
