namespace PEIPEI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void qfile1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"\\192.168.100.250");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"\\NAS303F9E");
        }
    }
}
