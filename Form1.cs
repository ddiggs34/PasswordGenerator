using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace passworgenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordGenerator(6);
            }
            else if (checkBox2.Checked)
            {
                PasswordGenerator(10);
            }
            else if (checkBox3.Checked)
            {
                PasswordGenerator(12);
            }
            else
            {
                PasswordGenerator(8);
            }


            
        }
        public void PasswordGenerator(int length)
        {
            const string ValidChar = "abcdefhijklmnopqrstuvwxyzABCDEFGHIJKJLMNOPQRSTUVWXYZ0123456789";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();

            while (0 < length--)
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);

            }
            textBox1.Text = result.ToString();
        }
    }
}