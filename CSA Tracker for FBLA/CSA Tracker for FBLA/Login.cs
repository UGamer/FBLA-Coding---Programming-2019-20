using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSA_Tracker_for_FBLA
{
    public partial class Login : Form
    {
        public Settings settings;

        public Login()
        {
            InitializeComponent();
            settings = new Settings(this);
            // ChangeTheme();
        }

        public void ChangeTheme()
        {
            if (settings.theme == "Dark")
            {
                BackColor = Color.FromArgb(41, 41, 41);

                label1.ForeColor = Color.White;

                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;

                RememberBox.ForeColor = Color.White;

                SignUpButton.BackColor = Color.FromArgb(64, 64, 64);
                SignInButton.BackColor = Color.FromArgb(64, 64, 64);
                SettingsButton.BackColor = Color.FromArgb(64, 64, 64);

                SignUpButton.ForeColor = Color.White;
                SignInButton.ForeColor = Color.White;
                SettingsButton.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.FromName("Control");

                label1.ForeColor = Color.Black;

                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;

                RememberBox.ForeColor = Color.Black;

                SignUpButton.BackColor = Color.FromName("Control");
                SignInButton.BackColor = Color.FromName("Control");
                SettingsButton.BackColor = Color.FromName("Control");

                SignUpButton.ForeColor = Color.Black;
                SignInButton.ForeColor = Color.Black;
                SettingsButton.ForeColor = Color.Black;
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            settings.Show();
        }
    }
}
