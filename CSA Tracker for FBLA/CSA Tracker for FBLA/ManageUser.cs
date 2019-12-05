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
        AdminPage adminPage;

        DataGridViewRow row;
        bool saved = false;

        string type;

        string connectionString = "Data Source=data.db;Version=3;";
        SQLiteConnection con;

        public ManageUser(Login login, AdminPage adminPage)
        {
            // THIS CONSTRUCTOR IS FOR ADDING USERS

            this.login = login;
            this.adminPage = adminPage;
            type = "Add";

            con = new SQLiteConnection(connectionString);

            InitializeComponent();

            FirstNameBox.GotFocus += TextBox_GotFocus;
            LastNameBox.GotFocus += TextBox_GotFocus;
            StudentNumberBox.GotFocus += TextBox_GotFocus;
            GradeBox.GotFocus += TextBox_GotFocus;

            FirstNameBox.LostFocus += TextBox_LostFocus;
            LastNameBox.LostFocus += TextBox_LostFocus;
            StudentNumberBox.LostFocus += TextBox_LostFocus;
            GradeBox.LostFocus += TextBox_LostFocus;

            ChangeTheme();
        }

        public ManageUser(Login login, DataGridViewRow row, AdminPage adminPage)
        {
            // THIS CONSTRUCTOR IS FOR EDITING USERS
            
            this.login = login;
            this.adminPage = adminPage;
            this.row = row;
            type = "Edit";

            con = new SQLiteConnection(connectionString);

            InitializeComponent();

            
            FirstNameBox.GotFocus += TextBox_GotFocus;
            LastNameBox.GotFocus += TextBox_GotFocus;
            StudentNumberBox.GotFocus += TextBox_GotFocus;
            GradeBox.GotFocus += TextBox_GotFocus;

            FirstNameBox.LostFocus += TextBox_LostFocus;
            LastNameBox.LostFocus += TextBox_LostFocus;
            StudentNumberBox.LostFocus += TextBox_LostFocus;
            GradeBox.LostFocus += TextBox_LostFocus;

            //0 - 3
            try
            {
                FirstNameBox.Text = row.Cells["FirstName"].Value.ToString();
                LastNameBox.Text = row.Cells["LastName"].Value.ToString();
                StudentNumberBox.Text = row.Cells["StudentNumber"].Value.ToString();
                GradeBox.Text = row.Cells["Grade"].Value.ToString();
            }
            catch { this.Close(); }

            FirstNameBox.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Regular);
            FirstNameBox.ForeColor = Color.Black;

            LastNameBox.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Regular);
            LastNameBox.ForeColor = Color.Black;

            StudentNumberBox.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Regular);
            StudentNumberBox.ForeColor = Color.Black;

            GradeBox.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Regular);
            GradeBox.ForeColor = Color.Black;

            ChangeTheme();
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox) sender;

            if (textBox.Text == "First Name..." || textBox.Text == "Last Name..." || textBox.Text == "Student Number..." || textBox.Text == "Grade...")
            {
                textBox.Text = "";
                textBox.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Regular);
                textBox.ForeColor = Color.Black;
            }
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                switch (textBox.Name)
                {
                    case "FirstNameBox":
                        textBox.Text = "First Name...";
                        break;
                    case "LastNameBox":
                        textBox.Text = "Last Name...";
                        break;
                    case "StudentNumberBox":
                        textBox.Text = "Student Number...";
                        break;
                    case "GradeBox":
                        textBox.Text = "Grade...";
                        break;
                }
                textBox.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Italic);
                textBox.ForeColor = Color.FromName("ScrollBar");
            }
        }

        public void ChangeTheme()
        {
            if (login.settings.theme == "Dark")
            {
                BackColor = Color.FromArgb(41, 41, 41);
                
                // Submit Button
                SubmitButton.BackColor = Color.FromArgb(64, 64, 64);
                SubmitButton.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.FromName("Control");

                // Submit Button
                SubmitButton.BackColor = Color.FromName("Control");
                SubmitButton.ForeColor = Color.Black;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (type == "Add")
            {
                SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO Data (FirstName, LastName, StudentNumber, Grade, Hours) VALUES (@FirstName, @LastName, @StudentNumber, @Grade, @Hours)", con);

                //
                con.Open();
                insertCmd.Parameters.AddWithValue("@FirstName", FirstNameBox.Text);
                insertCmd.Parameters.AddWithValue("@LastName", LastNameBox.Text);
                insertCmd.Parameters.AddWithValue("@StudentNumber", StudentNumberBox.Text);
                insertCmd.Parameters.AddWithValue("@Grade", GradeBox.Text);
                insertCmd.Parameters.AddWithValue("@Hours", 0);
                insertCmd.ExecuteNonQuery();

                while (insertCmd.Parameters.Count != 0)
                    insertCmd.Parameters.RemoveAt(0);

                con.Close();

                MessageBox.Show("Data successfully added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //

                adminPage.FillDGV();
                saved = true;
                this.Close();
            }
            else if (type == "Edit")
            {
                string command = "UPDATE Data SET FirstName = @FirstName, LastName = @LastName, StudentNumber = @StudentNumber, Grade = @Grade WHERE Id = " + row.Cells["Id"].Value.ToString() + ";";

                SQLiteCommand replaceSettingsCmd = new SQLiteCommand(command, con);

                con.Open();
                replaceSettingsCmd.Parameters.AddWithValue("@FirstName", FirstNameBox.Text);
                replaceSettingsCmd.Parameters.AddWithValue("@LastName", LastNameBox.Text);
                replaceSettingsCmd.Parameters.AddWithValue("@StudentNumber", StudentNumberBox.Text);
                replaceSettingsCmd.Parameters.AddWithValue("@Grade", GradeBox.Text);
                replaceSettingsCmd.ExecuteNonQuery();

                while (replaceSettingsCmd.Parameters.Count != 0)
                    replaceSettingsCmd.Parameters.RemoveAt(0);

                con.Close();

                MessageBox.Show("Data successfully edited.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                adminPage.FillDGV();
                saved = true;
                this.Close();
            }
        }

        private void ManageUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saved == false)
                if ((FirstNameBox.Text != "First Name..." && !string.IsNullOrWhiteSpace(FirstNameBox.Text)) || (LastNameBox.Text != "Last Name..." && !string.IsNullOrWhiteSpace(LastNameBox.Text)) || (StudentNumberBox.Text != "Student Number..." && !string.IsNullOrWhiteSpace(StudentNumberBox.Text)) || (GradeBox.Text != "Grade..." && !string.IsNullOrWhiteSpace(GradeBox.Text)))
                    if (MessageBox.Show("You have data that has not yet been updated or added into the database. Are you sure you want to close?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        e.Cancel = true;
        }
    }
}
