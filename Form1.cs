using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PrintEye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(GetDir() + @"\main.py");
                Process.Start(GetDir() + @"\main.py");
            }
            catch
            {
                MessageBox.Show("Couldn't open PrintEye", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetDir()
        {
            string Dir = Directory.GetCurrentDirectory();
            return Dir;
        }
    }
}
