using Lab4Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace data_protection_lab_1
{
    public partial class lab4 : Form
    {

        public Lab4Main.BinaryReader reader = new Lab4Main.BinaryReader();
        public BinaryPrinter printer = new BinaryPrinter();

        public Encryptor encryptor = new Encryptor();

        private string decryptedPath = "";
        private string encryptedPath = "";

        private string decryptedText = "";
        private string encryptedText = "";

        public string key = "";
        public lab4()
        {
            InitializeComponent();
        }

        private void lab4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            key = encryptor.GenerateKey();
            textBox7.Text = key;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            encryptedText = reader.Read(encryptedPath);
            //string txt = encryptor.Decrypt(encryptedText, key);
           // printer.Print(decryptedPath, txt);
            //textBox4.Text = txt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
//            decryptedText = reader.Read(decryptedPath);
            string txt = Encryptor.Encrypt(textBox2.Text);
            Console.WriteLine(txt);
            //          printer.Print(encryptedPath, txt);
            var sha = SHA256.Create();
            var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(txt));
            textBox3.Text = Convert.ToBase64String(hash);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text files (*.bin)|*.bin";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                decryptedPath = openFileDialog.FileName;
            };
            textBox5.Text = decryptedPath;
            textBox2.Text = System.IO.File.ReadAllText(decryptedPath);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text files (*.bin)|*.bin";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                encryptedPath = openFileDialog.FileName;
            };
            textBox6.Text = encryptedPath;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
