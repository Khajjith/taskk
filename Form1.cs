using System.Diagnostics;
namespace taskk_2_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] procCHEK = Process.GetProcessesByName("explorer");
            if (procCHEK.Length > 0) {
            foreach (Process proc in procCHEK) {
                    proc.Kill();
                    MessageBox.Show("Kész!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("OUTLOOK");
            foreach (Process proc in processes) { proc.Kill(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("SPOOL");
            foreach (Process proc in processes) { proc.Kill(); }

        }
    }
}