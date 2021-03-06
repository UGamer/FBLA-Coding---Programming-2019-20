﻿using System;
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

        string connectionString = "Data Source=data.db;Version=3;";
        SQLiteConnection con;

        Question[] questions;

        List<int> avoidedIndexes;
        List<Question> actualQuestions;
        bool handled = false;

        public SignUp(Login login)
        {
            this.login = login;

            con = new SQLiteConnection(connectionString);

            InitializeComponent();
            ChangeTheme();

            int[] grades = { 6, 7, 8, 9, 10, 11, 12 };

            for (int index = 0; index < grades.Length; index++)
                GradeBox.Items.Add(grades[index]);

            questions = CreateSecurityQuestions();

            Question1Box.Items.AddRange(questions);
            Question2Box.Items.AddRange(questions);
            Question3Box.Items.AddRange(questions);

            actualQuestions = new List<Question>();
            for (int index = 0; index < questions.Length; index++)
                actualQuestions.Add(questions[index]);
        }

        private Question[] CreateSecurityQuestions()
        {
            questions = new Question[13];
            string[] texts = new string[13];

            texts[0] = "What was your address you lived at as a child?";
            texts[1] = "What were the last four digits of your childhood telephone number?";
            texts[2] = "What elementary school did you attend?";
            texts[3] = "What middle school did you attend?";
            texts[4] = "What high school did you attend?";
            texts[5] = "In what town or city did you meet your first partner?";
            texts[6] = "What are the last five digits of your driver's licence number?";
            texts[7] = "What is your grandmother's (on your mother's side) maiden name?";
            texts[8] = "What is your partner's mother's maiden name?";
            texts[9] = "In what town or city did your mother and father meet?";
            texts[10] = "What time of the day were you born? (hh:mm)";
            texts[11] = "What time of the day was your first child born? (hh:mm)";
            texts[12] = "What city was your first job in?";

            for (int index = 0; index < texts.Length; index++)
            {
                questions[index] = new Question();
                questions[index].Index = index;
                questions[index].Text = texts[index];
            }

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

                FirstNameLabel.ForeColor = Color.White;
                LastNameLabel.ForeColor = Color.White;
                StudentNumberLabel.ForeColor = Color.White;
                GradeLabel.ForeColor = Color.White;

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

                FirstNameLabel.ForeColor = Color.Black;
                LastNameLabel.ForeColor = Color.Black;
                StudentNumberLabel.ForeColor = Color.Black;
                GradeLabel.ForeColor = Color.Black;

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

                this.Close();
            }
        }

        private bool AttemptSignUp()
        {
            bool move = true;

            bool userBoxEmpty, userBoxShort, passBoxEmpty, passBoxShort, 
                passHasUpper, passHasLower, passHasNumber, passHasSpecial, 
                studentNumberEmpty, question1Empty, answer1Empty, question2Empty, 
                answer2Empty, question3Empty, answer3Empty;

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

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

        private void QuestionBox_TextChanged(object sender, EventArgs e)
        {
            if (!handled)
            {
                Console.WriteLine("NOT HANDLED");

                actualQuestions = new List<Question>();
                avoidedIndexes = new List<int>();

                try { avoidedIndexes.Add((Question1Box.SelectedItem as Question).Index); } catch { }
                try { avoidedIndexes.Add((Question2Box.SelectedItem as Question).Index); } catch { }
                try { avoidedIndexes.Add((Question3Box.SelectedItem as Question).Index); } catch { }

                for (int index = 0; index < questions.Length; index++)
                {
                    bool add = true;

                    for (int index2 = 0; index2 < avoidedIndexes.Count; index2++)
                        if (questions[index].Index == avoidedIndexes[index2])
                            add = false;

                    if (add)
                        actualQuestions.Add(questions[index]);
                }

                Question q1 = new Question();
                Question q2 = new Question();
                Question q3 = new Question();

                try { q1 = Question1Box.SelectedItem as Question; } catch { }
                try { q2 = Question2Box.SelectedItem as Question; } catch { }
                try { q3 = Question3Box.SelectedItem as Question; } catch { }

                Question1Box.Items.Clear();
                Question2Box.Items.Clear();
                Question3Box.Items.Clear();

                for (int index = 0; index < actualQuestions.Count; index++)
                {
                    Question1Box.Items.Add(actualQuestions[index]);
                    Question2Box.Items.Add(actualQuestions[index]);
                    Question3Box.Items.Add(actualQuestions[index]);
                }

                handled = true;

                Console.WriteLine("SET TO HANDLED");

                try { Question1Box.Items.Add(q1); } catch { }
                try { Question2Box.Items.Add(q2); } catch { }
                try { Question3Box.Items.Add(q3); } catch { }

                try { handled = true; Question1Box.SelectedItem = q1; } catch { }
                try { handled = true; Question2Box.SelectedItem = q2; } catch { }
                try { handled = true; Question3Box.SelectedItem = q3; } catch { }
            }

            handled = false;
            Console.WriteLine("SET TO NOT HANDLED");
        }
    }

    public class Question
    {
        public int Index { get; set; }
        public string Text { get; set; }

        public Question()
        {

        }

        public override string ToString()
        {
            return Text;
        }
    }
}
