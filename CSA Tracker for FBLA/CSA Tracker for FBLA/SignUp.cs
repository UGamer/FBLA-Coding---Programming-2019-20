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
    public partial class SignUp : Form
    {
        Login login;

        bool signedIn = false;

        string connectionString = "Data Source=data.db;Version=3;";
        SQLiteConnection con;

        public SignUp(Login login)
        {
            this.login = login;

            con = new SQLiteConnection(connectionString);

            InitializeComponent();
            ChangeTheme();

            int[] grades = { 6, 7, 8, 9, 10, 11, 12 };
            GradeBox.Items.Add(grades);

            string[] questions = CreateSecurityQuestions();

            Question1Box.Items.AddRange(questions);
            Question2Box.Items.AddRange(questions);
            Question3Box.Items.AddRange(questions);
        }

        private string[] CreateSecurityQuestions()
        {
            string[] questions = new string[13];

            questions[0] = "What was your address you lived at as a child?";
            questions[1] = "What were the last four digits of your childhood telephone number?";
            questions[2] = "What elementary school did you attend?";
            questions[3] = "What middle school did you attend?";
            questions[4] = "What high school did you attend?";
            questions[5] = "In what town or city did you meet your first partner?";
            questions[6] = "What are the last five digits of your driver's licence number?";
            questions[7] = "What is your grandmother's (on your mother's side) maiden name?";
            questions[8] = "What is your partner's mother's maiden name?";
            questions[9] = "In what town or city did your mother and father meet?";
            questions[10] = "What time of the day were you born? (hh:mm)";
            questions[11] = "What time of the day was your first child born? (hh:mm)";
            questions[12] = "What city was your first job in?";

            return questions;
        }

        public void ChangeTheme()
        {
            if (login.settings.theme == "Dark")
            {
                BackColor = Color.FromArgb(41, 41, 41);

                FillOutFieldsLabel.ForeColor = Color.White;

                UserLabel.ForeColor = Color.White;
                PassLabel.ForeColor = Color.White;
                StudentNumberLabel.ForeColor = Color.White;

                Question1Label.ForeColor = Color.White;
                Question2Label.ForeColor = Color.White;
                Question3Label.ForeColor = Color.White;
                Answer1Label.ForeColor = Color.White;
                Answer2Label.ForeColor = Color.White;
                Answer3Label.ForeColor = Color.White;

                SignUpButton.BackColor = Color.FromArgb(64, 64, 64);
                SettingsButton.BackColor = Color.FromArgb(64, 64, 64);

                SignUpButton.ForeColor = Color.White;
                SettingsButton.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.FromName("Control");

                FillOutFieldsLabel.ForeColor = Color.Black;

                UserLabel.ForeColor = Color.Black;
                PassLabel.ForeColor = Color.Black;
                StudentNumberLabel.ForeColor = Color.Black;

                Question1Label.ForeColor = Color.Black;
                Question2Label.ForeColor = Color.Black;
                Question3Label.ForeColor = Color.Black;
                Answer1Label.ForeColor = Color.Black;
                Answer2Label.ForeColor = Color.Black;
                Answer3Label.ForeColor = Color.Black;

                SignUpButton.BackColor = Color.FromName("Control");
                SettingsButton.BackColor = Color.FromName("Control");

                SignUpButton.ForeColor = Color.Black;
                SettingsButton.ForeColor = Color.Black;
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            login.settings.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // if (AttemptSignUp)
            {
                string command = "INSERT INTO Users (Username, Password, Question1, Question2, Question3, Answer1, Answer2, Answer3, Type, StudentNumber) VALUES (@Username, @Password, @Question1, @Question2, @Question3, @Answer1, @Answer2, @Answer3, @Type, @StudentNumber)";
                SQLiteCommand insertCmd = new SQLiteCommand(command, con);

                con.Open();
                insertCmd.Parameters.AddWithValue("@Username", UserBox.Text);
                insertCmd.Parameters.AddWithValue("@Password", PassBox.Text);
                insertCmd.Parameters.AddWithValue("@Question1", Question1Box.Text);
                insertCmd.Parameters.AddWithValue("@Question2", Question2Box.Text);
                insertCmd.Parameters.AddWithValue("@Question3", Question3Box.Text);
                insertCmd.Parameters.AddWithValue("@Answer1", Answer1Box.Text);
                insertCmd.Parameters.AddWithValue("@Answer2", Answer2Box.Text);
                insertCmd.Parameters.AddWithValue("@Answer3", Answer3Box.Text);
                insertCmd.Parameters.AddWithValue("@Type", "Student");
                insertCmd.Parameters.AddWithValue("@StudentNumber", StudentNumberBox.Text);
                insertCmd.ExecuteNonQuery();

                while (insertCmd.Parameters.Count != 0)
                    insertCmd.Parameters.RemoveAt(0);

                command = "INSERT INTO Data (FirstName, LastName, StudentNumber, Grade, Hours, Username) VALUES (@FirstName, @LastName, @StudentNumber, @Grade, @Hours, @Username)";
                insertCmd = new SQLiteCommand(command, con);

                insertCmd.Parameters.AddWithValue("@FirstName", FirstNameBox.Text);
                insertCmd.Parameters.AddWithValue("@LastName", LastNameBox.Text);
                insertCmd.Parameters.AddWithValue("@StudentNumber", StudentNumberBox.Text);
                insertCmd.Parameters.AddWithValue("@Grade", GradeBox.Text);
                insertCmd.Parameters.AddWithValue("@Hours", 0);
                insertCmd.Parameters.AddWithValue("@Username", UserBox.Text);
                insertCmd.ExecuteNonQuery();

                while (insertCmd.Parameters.Count != 0)
                    insertCmd.Parameters.RemoveAt(0);

                con.Close();

                MessageBox.Show("Sign up successful.", "Signed Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool AttemptSignUp()
        {
            bool move = true;

            bool userBoxEmpty, userBoxShort, passBoxEmpty, passBoxShort, passHasUpper, passHasLower, passHasNumber, passHasSpecial, studentNumberEmpty, question1Empty, answer1Empty, question2Empty, answer2Empty, question3Empty, answer3Empty;

            userBoxEmpty = false;
            

            if (UserBox.Text == "")
            {
                move = false;
                userBoxEmpty = false;
            }
            else if (UserBox.Text.Length < 8)
            {
                move = false;
                userBoxShort = true;
            }
            else if (PassBox.Text == "")
            {
                move = false;
                passBoxEmpty = true;
            }
            else if (PassBox.Text.Length < 8)
            {
                move = false;
                passBoxShort = true;
            }
            // Put passHasUpper, passHasLower, passHasNumber, passHasSpecial

            return move;
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
                StudentNumberBox.Focus();
            if (e.KeyData == Keys.Up)
                StudentNumberBox.Focus();
        }
    }
}
