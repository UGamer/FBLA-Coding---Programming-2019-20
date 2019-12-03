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
    public partial class DetailedUser : Form
    {
        Login login;

        string connectionString = "Data Source=data.db;Version=3;";
        SQLiteConnection con;

        bool closeAll = true;
        public DetailedUser(Login login)
        {
            this.login = login;
            con = new SQLiteConnection(connectionString);

            InitializeComponent();
        }

        private void DetailedUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closeAll)
                login.Close();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            string command = "UPDATE Settings SET Value = @Value WHERE Category = 'Remember';";

            SQLiteCommand replaceSettingsCmd = new SQLiteCommand(command, con);

            con.Open();
            replaceSettingsCmd.Parameters.AddWithValue("@Value", "False");
            replaceSettingsCmd.ExecuteNonQuery();
            replaceSettingsCmd.Parameters.RemoveAt(0);

            command = "UPDATE Settings SET Value = @Value WHERE Category = 'RememberUser';";
            replaceSettingsCmd = new SQLiteCommand(command, con);
            replaceSettingsCmd.Parameters.AddWithValue("@Value", "");
            replaceSettingsCmd.ExecuteNonQuery();
            replaceSettingsCmd.Parameters.RemoveAt(0);

            con.Close();

            login.UserBox.Text = "";
            login.PassBox.Text = "";
            login.RememberBox.Checked = false;
            login.Show();
            closeAll = false;
            this.Close();
        }
    }
}
