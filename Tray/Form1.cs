using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tray
{
    public partial class Form1 : Form
    {
        private int minResizeCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Visible = false;
                notifyIcon1.Visible = true;
                minResizeCount++;
                notifyIcon1.Text = minResizeCount.ToString();
                notifyIcon1.BalloonTipText = minResizeCount.ToString();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Maximized;
                notifyIcon1.Visible = false;
                Visible = true;
            }
        }
    }
}
