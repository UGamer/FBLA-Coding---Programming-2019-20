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
        public SignUp signUp;
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

                PleaseSignInLabel.ForeColor = Color.White;

                UserLabel.ForeColor = Color.White;
                PassLabel.ForeColor = Color.White;

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

                PleaseSignInLabel.ForeColor = Color.Black;

                UserLabel.ForeColor = Color.Black;
                PassLabel.ForeColor = Color.Black;

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

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            signUp = new SignUp(this);
            signUp.Show();
            this.Hide();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            AttemptSignIn();
        }

        private void AttemptSignIn()
        {
            SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM Users", con);

            con.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
            DataTable table = new DataTable();
            da.Fill(table);

            con.Close();

            if (UserBox.Text == "Admin")
            {
                if (PassBox.Text == "CSA")
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
                detailedUser = new DetailedUser(this, user);
                detailedUser.Show();
            }

            signedIn = true;
            this.Hide();
        }
        private void UserBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                PassBox.Focus();
            if (e.KeyData == Keys.Down)
                PassBox.Focus();
        }
        private void PassBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                AttemptSignIn();
            if (e.KeyData == Keys.Up)
                UserBox.Focus();
        }
    }
}
