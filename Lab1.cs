using System.Text.RegularExpressions;

namespace data_protection_lab_1
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex keyReg = new Regex("^[0-9]+$");
            if (keyReg.IsMatch(textBox3.Text))
            {
                string key = textBox3.Text;
                string text = textBox1.Text;
                text = text.ToLower();
                string abc = "אבגדהו¸זחטיךכלםמןנסעףפץצקרשתûü‎‏ÿ", newKey = key, result = "";
                int offset, indexOf = 0, j = 0;
                while (newKey.Length < text.Length)
                {
                    newKey += key;
                }
                if (newKey.Length > text.Length)
                {
                    newKey = newKey.Substring(0, newKey.Length - (newKey.Length - text.Length));
                }

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ' ')
                    {
                        result += ' ';
                        continue;
                    }
                    indexOf = abc.IndexOf(text[i]);
                    if (indexOf != -1)
                    {
                        offset = abc.IndexOf(text[i]) + (Convert.ToInt32(newKey[j]) - 48);
                        if (offset >= abc.Length)
                            offset = offset - abc.Length;
                        else if (offset < 0)
                            offset = abc.Length + offset;
                        result += abc[offset];
                        j++;
                    }
                    else
                        result += text[i];
                }
                textBox2.Text = result;
            }
            else
            {
                textBox2.Text = "Âגוהום םוגונםûי ךכ‏ק";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}