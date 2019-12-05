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

        string user;
        string studentNumber;

        string connectionString = "Data Source=data.db;Version=3;";
        SQLiteConnection con;

        bool closeAll = true;
        public DetailedUser(Login login, string user)
        {
            this.login = login;
            this.user = user;

            con = new SQLiteConnection(connectionString);

            SQLiteCommand selectUsersCmd = new SQLiteCommand("SELECT * FROM Users", con);
            SQLiteCommand selectDataCmd = new SQLiteCommand("SELECT * FROM Data", con);
            SQLiteCommand selectServicesCmd = new SQLiteCommand("SELECT * FROM Services", con);

            con.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectUsersCmd);
            DataTable table1 = new DataTable();
            da.Fill(table1);

            SQLiteDataAdapter da2 = new SQLiteDataAdapter(selectDataCmd);
            DataTable table2 = new DataTable();
            da.Fill(table2);

            SQLiteDataAdapter da3 = new SQLiteDataAdapter(selectServicesCmd);
            DataTable table3 = new DataTable();
            da.Fill(table3);

            con.Close();

            // This gets the student number from the username used to log in from the Users table
            for (int index = 0; index < table1.Rows.Count; index++)
            {
                if (table1.Rows[index][0].ToString() == user)
                    studentNumber = table1.Rows[index][9].ToString();
            }

            // This uses the student number to get details for labels.
            string firstName = "", lastName = "", grade = "";
            for (int index = 0; index < table2.Rows.Count; index++)
            {
                if (table2.Rows[index][3].ToString() == studentNumber)
                {
                    firstName = table2.Rows[index][1].ToString();
                    lastName = table2.Rows[index][2].ToString();
                    grade = table2.Rows[index][4].ToString();
                }
            }

            List<int> allHours = new List<int>();
            for (int index = 0; index < table3.Rows.Count; index++)
            {
                if (table3.Rows[index][0].ToString() == studentNumber)
                {
                    firstName = table3.Rows[index][1].ToString();
                    lastName = table3.Rows[index][2].ToString();
                    grade = table3.Rows[index][4].ToString();
                }
            }

            string totalHours = "";

            NameLabel.Text = firstName + " " + lastName;
            StudentGradeLabel.Text = "Student #" + studentNumber + ", Grade " + grade;
            // HoursLabel.Text = "Total Hours: " + totalHours;

            InitializeComponent();
            ChangeTheme();
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

                // Settings and SignOut buttons
                SettingsButton.BackColor = Color.FromArgb(64, 64, 64);
                SignOutButton.BackColor = Color.FromArgb(64, 64, 64);

                SettingsButton.ForeColor = Color.White;
                SignOutButton.ForeColor = Color.White;
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

                // Settings and SignOut buttons
                SettingsButton.BackColor = Color.FromName("Control");
                SignOutButton.BackColor = Color.FromName("Control");

                SettingsButton.ForeColor = Color.Black;
                SignOutButton.ForeColor = Color.Black;
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            login.settings.Show();
        }
    }
}
