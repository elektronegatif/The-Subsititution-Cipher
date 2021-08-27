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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            encryption en = new encryption();
            en.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decipher de = new decipher();
            de.Show();
        }
    }
}