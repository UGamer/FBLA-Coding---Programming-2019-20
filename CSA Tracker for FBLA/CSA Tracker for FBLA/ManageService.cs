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
    public partial class ManageService : Form
    {
        Login login;
        DetailedUser refer;
        string type;

        string connectionString = "Data Source=data.db;Version=3;";
        SQLiteConnection con;

        public ManageService(Login login, DetailedUser refer, string studentNumber, string type)
        {
            this.login = login;
            this.refer = refer;
            this.type = type;

            con = new SQLiteConnection(connectionString);

            InitializeComponent();
            ChangeTheme();

            StudentNumberBox.Text = studentNumber;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (StudentNumberBox.Text != "" && ActivityBox.Text != "" && HoursBox.Value > 0)
            {
                int studentNumber = Convert.ToInt32(StudentNumberBox.Text);
                string startDate = StartDateBox.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string activity = ActivityBox.Text;
                int hours = Convert.ToInt32(HoursBox.Value);
                string endDate = EndDateBox.Value.ToString("yyyy-MM-dd HH:mm:ss");

                SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO Services (StudentNumber, StartDate, Activity, Hours, EndDate) VALUES (@StudentNumber, @StartDate, @Activity, @Hours, @EndDate)", con);

                //
                con.Open();
                insertCmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                insertCmd.Parameters.AddWithValue("@StartDate", startDate);
                insertCmd.Parameters.AddWithValue("@Activity", activity);
                insertCmd.Parameters.AddWithValue("@Hours", hours);
                insertCmd.Parameters.AddWithValue("@EndDate", endDate);
                insertCmd.ExecuteNonQuery();

                while (insertCmd.Parameters.Count != 0)
                    insertCmd.Parameters.RemoveAt(0);

                con.Close();

                MessageBox.Show("Service successfully added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refer.FillDGV();
                this.Close();
            }
            else
            {

            }
        }

        public void ChangeTheme()
        {
            if (login.settings.theme == "Dark")
            {
                BackColor = Color.FromArgb(41, 41, 41);

                // Field Labels
                StudentNumberLabel.ForeColor = Color.White;
                StartDateLabel.ForeColor = Color.White;
                ActivityLabel.ForeColor = Color.White;
                HoursLabel.ForeColor = Color.White;
                EndDateLabel.ForeColor = Color.White;

                // Add, Edit, Remove buttons
                SubmitButton.BackColor = Color.FromArgb(64, 64, 64);

                SubmitButton.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.FromName("Control");

                // Field Labels
                StudentNumberLabel.ForeColor = Color.Black;
                StartDateLabel.ForeColor = Color.Black;
                ActivityLabel.ForeColor = Color.Black;
                HoursLabel.ForeColor = Color.Black;
                EndDateLabel.ForeColor = Color.Black;

                // Add, Edit, Remove buttons
                SubmitButton.BackColor = Color.FromName("Control");

                SubmitButton.ForeColor = Color.Black;
            }
        }

        
    }
}
