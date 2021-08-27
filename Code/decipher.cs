using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Substitution_Cipher_YT
{
    public partial class decipher : Form
    {
        public decipher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                String text = this.textBox1.Text;
                String cipherText = "";
                for (int x = 0; x <= text.Length - 1; x++)
                {
                    char c = text[x];
                    if (((int)c >= 65 && (int)c < 65 + 26))
                    {
                        int i = ((int)c) - 65;
                        cipherText += ((char)(97 + ((26 + i - (int)numericUpDown1.Value) % 26))).ToString();
                    }
                    else
                    {
                        cipherText += c.ToString();
                    }
                }
                this.textBox2.Text = cipherText;
            }
            catch (Exception)
            {
                MessageBox.Show("Error: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
