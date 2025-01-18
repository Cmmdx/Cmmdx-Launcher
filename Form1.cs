using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;

namespace Cmmdx_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private DiscordRPC.EventHandlers handlers;
        private DiscordRPC.RichPresence presence;
        
        void RPC()
        {
            this.handlers = default(DiscordRPC.EventHandlers);
            DiscordRPC.Initialize("1220082869511131158", ref this.handlers, true, null);
            this.presence.details = "Cmmdx";
            this.presence.state = "Launcher";
            this.presence.largeImageKey = "01da4aa52ffbd12a2e50d80b8278851f";
            this.presence.largeImageText = "Cmmdx Logo";
            this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            DiscordRPC.UpdatePresence(ref this.presence);
        }

    private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;
            if (panel2.Width >= 350)
            {
                timer1.Stop();
                LoginScreen m = new LoginScreen();
                m.Show();
                Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RPC();
        }
    }
}
