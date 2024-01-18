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
    public partial class lab8 : Form
    {
        Gamma gm = new Gamma();
        public lab8()
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = gm.Decode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = gm.Update(textBox1.Text);
            textBox3.Text = gm.key;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void lab8_Load(object sender, EventArgs e)
        {

        }
    }
}
