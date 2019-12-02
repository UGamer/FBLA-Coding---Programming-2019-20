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

        public string theme;

        public Settings(Login login)
        {
            this.login = login;

            connectionString = "Data Source=data.db;Version=3;";
            con = new SQLiteConnection(connectionString);

            SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM Settings", con);

            con.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
            DataTable table = new DataTable();
            da.Fill(table);

            con.Close();

            theme = table.Rows[0][1].ToString();
            Console.WriteLine(theme);

            InitializeComponent();

            ChangeTheme();
        }

        public void ChangeTheme()
        {
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
                ThemeButton.BackColor = Color.Transparent;
                
            }

            login.ChangeTheme();
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
