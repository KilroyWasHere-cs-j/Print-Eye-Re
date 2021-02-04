using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

// Build path C:\Users\gmtow\source\repos\PrintEye\PrintEye\bin\Debug
namespace PrintEye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(GetDir() + @"\PY" + @"\PY\main.py");
                Process.Start(GetDir() + @"\PY" + @"\main.py");
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

        private void UpdateLog(string log)
        {
            StreamReader reader = new StreamReader(GetDir() + @"\PY\Log.txt");
            string fileContext = reader.ReadToEnd();
            reader.Close();
            StreamWriter writer = new StreamWriter(GetDir() + @"\PY\Log.txt");
            writer.WriteLine(fileContext);
            writer.WriteLine();
            writer.WriteLine(log);
            writer.Close();
        }
    }
}