using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace OptimalizationTool
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

        private void button1_Click(object sender, EventArgs e)

        {         
            Process.Start("cleanmgr.exe");
            button1.BackColor = Color.LightGreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("SystemPropertiesPerformance.exe");
            button2.BackColor = Color.LightGreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL desk.cpl,,0");
            button3.BackColor = Color.LightGreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("services.msc");
            button4.BackColor = Color.LightGreen;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("dfrgui.exe");
            button5.BackColor = Color.LightGreen;
        }
    }
}
