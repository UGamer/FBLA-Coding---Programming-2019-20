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
    public partial class Settings : Form
    {
        public Login login;

        string connectionString;
        SQLiteConnection con;
        DataTable table;

        public string theme;
        public string remember;
        public string rememberUser;
        public int adminRowHeight;
        public int userRowHeight;

        public Settings(Login login)
        {
            this.login = login;

            connectionString = "Data Source=data.db;Version=3;";
            con = new SQLiteConnection(connectionString);

            SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM Settings", con);

            con.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
            table = new DataTable();
            da.Fill(table);

            con.Close();

            theme = table.Rows[0][1].ToString();
            remember = table.Rows[1][1].ToString();
            rememberUser = table.Rows[2][1].ToString();
            adminRowHeight = Convert.ToInt32(table.Rows[3][1].ToString());
            userRowHeight = Convert.ToInt32(table.Rows[4][1].ToString());

            Console.WriteLine(theme);

            InitializeComponent();

            if (theme == "Dark")
            {
                BackColor = Color.FromArgb(41, 41, 41);
                ThemeButton.Text = "Dark";
                ThemeButton.ForeColor = Color.White;
                ThemeButton.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        public void ChangeTheme()
        {
            try { login.adminPage.ChangeTheme(); } catch { }
            try { login.detailedUser.ChangeTheme(); } catch { }
            login.ChangeTheme();
            try { login.detailedUser.manageService.ChangeTheme(); } catch { }
            try { login.adminPage.manageUser.ChangeTheme(); } catch { }

            try { login.adminPage.report.ChangeTheme(); } catch { }
            try { login.detailedUser.report.ChangeTheme(); } catch { }

            if (theme == "Dark")
            {
                BackColor = Color.FromArgb(41, 41, 41);
                ThemeButton.Text = "Dark";
                ThemeButton.ForeColor = Color.White;
                ThemeButton.BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                BackColor = Color.FromName("Control");
                ThemeButton.Text = "Light";
                ThemeButton.ForeColor = Color.Black;
                ThemeButton.BackColor = Color.FromName("Control");
            }

            try { login.signUp.ChangeTheme(); } catch { }

        }

        public void ChangeRememberValues()
        {

        }

        private void ThemeButton_Click(object sender, EventArgs e)
        {
            if (theme == "Dark")
            {
                theme = "Light";

                // Write to SQLite database here
            }
            else
            {
                theme = "Dark";

                // Write to SQLite database here
            }

            ChangeTheme();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }
    }
}
