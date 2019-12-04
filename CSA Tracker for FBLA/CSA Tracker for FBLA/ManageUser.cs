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
    public partial class ManageUser : Form
    {
        Login login;

        string user;
        string studentNumber;

        string connectionString = "Data Source=data.db;Version=3;";
        SQLiteConnection con;

        bool closeAll = true;
        public ManageUser(Login login, string user)
        {
            this.login = login;
            this.user = user;

            con = new SQLiteConnection(connectionString);

            SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM Users", con);

            con.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
            DataTable table = new DataTable();
            da.Fill(table);

            con.Close();

            for (int index = 0; index < table.Rows.Count; index++)
            {
                if (table.Rows[index][0].ToString() == user)
                    studentNumber = table.Rows[index][9].ToString();
            }

            InitializeComponent();
            ChangeTheme();
        }

        private void ManageUser_FormClosed(object sender, FormClosedEventArgs e)
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

        public void ChangeTheme()
        {
            if (login.settings.theme == "Dark")
            {
                BackColor = Color.FromArgb(41, 41, 41);

                // Field Labels
                NameLabel.ForeColor = Color.White;
                StudentGradeLabel.ForeColor = Color.White;
                HoursLabel.ForeColor = Color.White;

                // Add, Edit, Remove buttons
                AddButton.BackColor = Color.FromArgb(64, 64, 64);
                EditButton.BackColor = Color.FromArgb(64, 64, 64);
                DeleteButton.BackColor = Color.FromArgb(64, 64, 64);

                AddButton.ForeColor = Color.White;
                EditButton.ForeColor = Color.White;
                DeleteButton.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.FromName("Control");

                // Field Labels
                NameLabel.ForeColor = Color.Black;
                StudentGradeLabel.ForeColor = Color.Black;
                HoursLabel.ForeColor = Color.Black;

                // Add, Edit, Remove buttons
                AddButton.BackColor = Color.FromName("Control");
                EditButton.BackColor = Color.FromName("Control");
                DeleteButton.BackColor = Color.FromName("Control");

                AddButton.ForeColor = Color.Black;
                EditButton.ForeColor = Color.Black;
                DeleteButton.ForeColor = Color.Black;
            }
        }
    }
}
