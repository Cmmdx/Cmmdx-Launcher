using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Cmmdx_Launcher
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        public static string user;

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            user = user_name.Text;
            MainPage mp = new MainPage();
            mp.Show();

            Launcher_Cmd Lcmd = new Launcher_Cmd();
            Lcmd.Show();
            Hide();


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
