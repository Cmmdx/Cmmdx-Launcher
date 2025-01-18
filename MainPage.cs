using CmlLib.Core.Auth;
using CmlLib.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using MCServerStatus;
using MCServerStatus.Models;
using System;

namespace Cmmdx_Launcher
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            var session = MSession.CreateOfflineSession(LoginScreen.user);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public static string version;

        MSession session;

        private void path()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);
            launcher.FileChanged += (e) =>
            {
                listBox1.Items.Add(string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount, e.FileType, e.Source, e.FileKind));
            };
            launcher.ProgressChanged += (s, e) =>
            {
                //Console.WriteLine("{0}%", e.ProgressPercentage);
            };

            foreach (var item in launcher.GetAllVersions())
            {
                versioncombobox.Items.Add(item.Name);
            }
        }

        private void launch()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);
            launcher.FileChanged += (e) =>
            {
                listBox1.Items.Add(string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount, e.FileKind, e.FileType, e.Source));
            };
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = 3024,
                Session = MSession.CreateOfflineSession(LoginScreen.user)
            };

            version = versioncombobox.SelectedItem.ToString();
            var process = launcher.CreateProcess(version, launchOption);
            process.Start();
            Hide();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            user_name.Text = LoginScreen.user;
            path();

            ServerStatus();

            var request = WebRequest.Create("https://minotar.net/avatar/"+ user_name.Text +"/100.png");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox2.Image = Bitmap.FromStream(stream);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Thread thread = new Thread(() => launch());
            thread.IsBackground = true;
            thread.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async Task ServerStatus()
        {
            IMinecraftPinger pinger = new MinecraftPinger("hypixel.net", 25565);
            var status = await pinger.RequestAsync();
            String server = status.Players.Online + " Users in server";
            Ionlineshow.Text = server;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
