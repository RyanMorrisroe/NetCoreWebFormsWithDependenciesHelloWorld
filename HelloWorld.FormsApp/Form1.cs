using System;
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
    }
}
