using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using HelloWorld.Library2;

namespace HelloWorld.FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Class2.SubtractThenAdd(1, 2, 3).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string executablePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HelloWorld.ConsoleApp.exe");
            if(!File.Exists(executablePath))
            {
                MessageBox.Show("Can't find the console app. Path checked: " + executablePath);
            }
            else
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = executablePath;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();
                    StringBuilder sb = new StringBuilder();
                    while (!process.HasExited)
                    {
                        sb.Append(process.StandardOutput.ReadToEnd());
                    }
                    label1.Text = sb.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFile1.txt");
            if (!File.Exists(textFilePath))
            {
                MessageBox.Show("Can't find the console app. Path checked: " + textFilePath);
            }
            else
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = textFilePath;
                    process.StartInfo.UseShellExecute = true;
                    process.Start();
                }
            }
        }
    }
}
