using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CNotepad
{
    public partial class Form1 : Form
    {
        public string password = "";
        string file = "";
        int textLength = 0;
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Create a new text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            file = "";
            this.Text = "CNotepad";
            mainText.Text = "";
        }

        /// <summary>
        /// Open secure text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Secure Text Documents (*.stxt)|*.stxt";
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string mykey = Prompt.ShowDialog();
                mainText.Text = Crypto.DecryptFile(openFileDialog.FileName, mykey);
                if (mainText.Text.Length > 0)
                {
                    this.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName) + " - CNotepad";
                    file = openFileDialog.FileName;
                    textLength = mainText.Text.Length;
                }
                else
                {
                    this.Text = "CNotepad";
                }
            }
        }

        /// <summary>
        /// Save new text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file == "" && password == "")
            {
                saveText();
            }
            else
            {
                File.WriteAllText(file, mainText.Text);
                Crypto.EncryptFile(file, password);
                restoreTitle();
            }
            
        }

        /// <summary>
        /// Save as new text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveText();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.Undo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.Paste();
        }

        /// <summary>
        /// Font settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                mainText.Font = fontDialog.Font;
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        /// <summary>
        /// Trace changed text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainText_TextChanged(object sender, EventArgs e)
        {
            if (mainText.Text.Length != textLength)
            {
                this.Text = "*" + Path.GetFileNameWithoutExtension(file) + " - CNotepad";
            }
        }

        private void saveText()
        {
            string mykey = Prompt.ShowDialog("Set Password");

            if (String.IsNullOrEmpty(mykey))
                return;
            saveFileDialog.Filter = "Secure Text Documents (*.stxt)|*.stxt";
            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, mainText.Text);
                Crypto.EncryptFile(saveFileDialog.FileName, mykey);
                if (mainText.Text.Length > 0)
                {
                    this.Text = Path.GetFileNameWithoutExtension(saveFileDialog.FileName) + " - CNotepad";
                    file = saveFileDialog.FileName;
                    password = mykey;
                }
            }
        }

        /// <summary>
        /// Remove star from title
        /// </summary>
        private void restoreTitle()
        {
            if (this.Text[0] == '*')
            {
                this.Text = this.Text.Substring(1);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void steganographyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Stega().Show();
        }

        private void base64EncoderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Base64().Show();
        }

        private void passwordGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PasswordGenerator().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();


            if (args.Length > 1)
            {
                string mykey = Prompt.ShowDialog();
                mainText.Text = Crypto.DecryptFile(args[1], mykey);
                if (mainText.Text.Length > 0 && File.Exists(args[1]))
                {
                    this.Text = Path.GetFileNameWithoutExtension(args[1]) + " - CNotepad";
                    file = args[1];
                    textLength = mainText.Text.Length;
                }
            }
        }
    }
}
