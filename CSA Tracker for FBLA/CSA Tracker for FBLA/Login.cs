using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        public AdminPage adminPage;
        public DetailedUser detailedUser;

        Timer oneTimeTimer;
        bool signedIn = false;

        string connectionString = "Data Source=data.db;Version=3;";
        SQLiteConnection con;
        SQLiteCommand replaceSettingsCmd;

        public Login()
        {
            con = new SQLiteConnection(connectionString);

            InitializeComponent();
            settings = new Settings(this);
            ChangeTheme();
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            if (settings.remember == "True")
            {
                SignIn(settings.rememberUser);
                oneTimeTimer = new Timer { Interval = 100, Enabled = true };
                oneTimeTimer.Tick += OneTimeTimer_Tick;
            }
        }

        private void OneTimeTimer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            oneTimeTimer.Stop();
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

        private void SignInButton_Click(object sender, EventArgs e)
        {
            SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM Users", con);

            con.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
            DataTable table = new DataTable();
            da.Fill(table);

            con.Close();

            if (UserBox.Text == "Admin")
            {
                if (PassBox.Text == "CommunityServiceAwards")
                    SignIn("Admin");
            }
            else
            {
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    if (table.Rows[index][0].ToString() == UserBox.Text)
                    {
                        if (table.Rows[index][1].ToString() == PassBox.Text)
                        {
                            SignIn(UserBox.Text);
                        }
                    }

                }
            }

            if (signedIn)
            {
                string command = "UPDATE Settings SET Value = @Value WHERE Category = 'Remember';";

                replaceSettingsCmd = new SQLiteCommand(command, con);

                con.Open();
                replaceSettingsCmd.Parameters.AddWithValue("@Value", RememberBox.Checked.ToString());
                replaceSettingsCmd.ExecuteNonQuery();
                replaceSettingsCmd.Parameters.RemoveAt(0);

                if (RememberBox.Checked)
                {
                    command = "UPDATE Settings SET Value = @Value WHERE Category = 'RememberUser';";
                    replaceSettingsCmd = new SQLiteCommand(command, con);
                    replaceSettingsCmd.Parameters.AddWithValue("@Value", UserBox.Text);
                    replaceSettingsCmd.ExecuteNonQuery();
                    replaceSettingsCmd.Parameters.RemoveAt(0);
                }

                con.Close();
            }

            signedIn = false;
        }

        private void SignIn(string user)
        {
            if (user == "Admin")
            {
                adminPage = new AdminPage(this);
                adminPage.Show();
            }
            else
            {
                detailedUser = new DetailedUser(this);
                detailedUser.Show();
            }

            signedIn = true;
            this.Hide();
        }
    }
}
