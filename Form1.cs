using System;
using System.Diagnostics;
using System.Windows.Forms;

// Build path C:\Users\gmtow\source\repos\PrintEye\PrintEye\bin\Debug
namespace PrintEye
{
    public partial class Form1 : Form
    {
        public readonly string filePath = "main.py";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\gmtow\\source\\repos\\PrintEye\\PrintEye\\bin\\Debug\\main.py");
        }
    }
}