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

            // Fills a DataTable out with the contents of the SQL table "Users"
            SQLiteDataAdapter da = new SQLiteDataAdapter(selectUsersCmd);
            DataTable table1 = new DataTable();
            da.Fill(table1);

            // Fills a DataTable out with the contents of the SQL table "Data"
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(selectDataCmd);
            DataTable table2 = new DataTable();
            da2.Fill(table2);

            // Fills a DataTable out with the contents of the SQL table "Services"
            SQLiteDataAdapter da3 = new SQLiteDataAdapter(selectServicesCmd);
            DataTable table3 = new DataTable();
            da3.Fill(table3);
            
            con.Close();

            // This gets the student number from the username used to log in from the Users table
            for (int index = 0; index < table1.Rows.Count; index++)
            {
                if (table1.Rows[index]["Username"].ToString() == user)
                    studentNumber = table1.Rows[index]["StudentNumber"].ToString();
            }

            // This uses the student number to get details for labels.
            string firstName = "", lastName = "", grade = "";
            for (int index = 0; index < table2.Rows.Count; index++)
            {
                if (table2.Rows[index]["StudentNumber"].ToString() == studentNumber)
                {
                    firstName = table2.Rows[index]["FirstName"].ToString();
                    lastName = table2.Rows[index]["LastName"].ToString();
                    grade = table2.Rows[index]["Grade"].ToString();
                }
            }

            // This uses the student number to get a total amount of hours the student has completed from services.
            int hours = 0;
            for (int index = 0; index < table3.Rows.Count; index++)
            {
                if (table3.Rows[index][0].ToString() == studentNumber)
                {
                    hours += Convert.ToInt32(table3.Rows[index]["Hours"].ToString());
                }
            }

            InitializeComponent();

            this.Text = firstName + " " + lastName + "'s Page";

            NameLabel.Text = firstName + " " + lastName;
            StudentGradeLabel.Text = "Student #" + studentNumber + ", "  + grade + "th Grade";
            HoursLabel.Text = "Total Hours: " + hours;

            DGV.DataSource = table3;

            DGV.Columns["StudentNumber"].Visible = false;
            DGV.Columns["StartDate"].HeaderText = "Start Date";
            DGV.Columns["EndDate"].HeaderText = "End Date";

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

                // DGV
                DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
                DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                DGV.RowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                DGV.RowsDefaultCellStyle.ForeColor = Color.White;

                DGV.BackgroundColor = Color.FromArgb(35, 35, 35);

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

                // DGV
                DGV.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
                DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
                DGV.BackgroundColor = Color.FromName("Silver");

                DGV.RowsDefaultCellStyle = new DataGridViewCellStyle();

                DGV.BackgroundColor = Color.FromName("AppWorkspace");

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
