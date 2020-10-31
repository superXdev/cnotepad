using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CNotepad
{
    public partial class Base64 : Form
    {
        public Base64()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOutput.Text = Base64Encode(txtInput.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOutput.Text = Base64Decode(txtInput.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtInput.Text = String.Empty;
            txtOutput.Text = String.Empty;
        }

        string Base64Encode(string plaintext)
        {
            var plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
            return Convert.ToBase64String(plaintextBytes);
        }

        string Base64Decode(string encoded)
        {
            var encodedBytes = Convert.FromBase64String(encoded);
            return Encoding.UTF8.GetString(encodedBytes);
        }
    }
}
