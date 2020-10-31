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
    public partial class PasswordGenerator : Form
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = CreatePassword(Convert.ToInt32(lengthNum.Value), alphaBox.Checked, alphaCapitalBox.Checked, numBox.Checked, symbolsBox.Checked);
        }

        string CreatePassword(int length, bool alpha, bool alphaCapital, bool num, bool symbol)
        {
            string alphaChar = "abcdefghijknopqrstuvxyz";
            string alphaCapitalChar = "ABCEFGHIJKLMNOPQRSUVWXYZ";
            string numChar = "1234567890";
            string symbolChar = "*!=&?&/()-+|$#^~";

            string valid = "";
            valid += (alpha) ? alphaChar : "";
            valid += (alphaCapital) ? alphaCapitalChar : "";
            valid += (num) ? numChar : "";
            valid += (symbol) ? symbolChar : "";

            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("Copied!");
        }

    }
}
