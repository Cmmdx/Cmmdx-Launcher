using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Cmmdx_Launcher
{
    public partial class Launcher_Cmd : Form
    {
        public Launcher_Cmd()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            string text = TextBox.Text;
            Process process = new Process();
            process.StartInfo.FileName = text;
            process.Start();
            loadProcessList();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Launcher_Cmd_Load(object sender, EventArgs e)
        {
            loadProcessList();
            
        }

        private void loadProcessList()
        {
            listView1.Items.Clear();
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.Tag = process;
                listView1.Items.Add(item);
            }
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            Process process = (Process)item.Tag;
            process.Kill();
            loadProcessList();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            loadProcessList();
        }
    }
}
