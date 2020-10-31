using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;
using System.Diagnostics;
using System.IO;

namespace CNotepad
{
    public partial class Stega : Form
    {
        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string thisPath = Path.GetDirectoryName(Application.ExecutablePath);
        public Stega()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPEG (*.jpg)|*.jpg";
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtImage.Text = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "JPEG (*.jpg)|*.jpg";
            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtOutput.Text = saveFileDialog.FileName;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string zipTemp = @"\cnotepad-temp.zip";
            string imgTemp = @"\cnotepad-temp.jpg";

            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "All Files (.*)|*.*";
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                using (ZipFile zip = new ZipFile())
                {
                    if (usePassword.Checked && !String.IsNullOrEmpty(txtPassword.Text))
                    {
                        zip.Password = txtPassword.Text;
                    }
                    foreach (var file in openFileDialog.FileNames)
                    {
                        zip.AddFile(file, @"\");
                    }
                    zip.Save(appdata + zipTemp);
                }
                var cmd = "copy /b " + appdata + imgTemp + " + " + appdata + zipTemp;
                File.Copy(txtImage.Text, appdata + imgTemp, true);
                ExecuteCommand(cmd);

                System.Threading.Thread.Sleep(3000);
                File.Copy(thisPath + imgTemp, txtOutput.Text, true);

                MessageBox.Show("Completed", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Shell Command
        void ExecuteCommand(string Command)
        {
            ProcessStartInfo ProcessInfo;
            Process Process;

            ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + Command);
            ProcessInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            ProcessInfo.CreateNoWindow = false;
            ProcessInfo.UseShellExecute = true;

            Process = Process.Start(ProcessInfo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPEG (*.jpg)|*.jpg";
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.Copy(openFileDialog.FileName, appdata + @"\cnotepad-img.zip", true);
                Process.Start(appdata + @"\cnotepad-img.zip");
            }
        }

        private void usePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (usePassword.Checked)
            {
                txtPassword.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = false;
            }
        }
    }

}
