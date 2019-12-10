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

            if (type != "Add")
            {
                StartDateBox.Value = Convert.ToDateTime(refer.DGV.SelectedRows[0].Cells["StartDate"].Value.ToString());
                ActivityBox.Text = refer.DGV.SelectedRows[0].Cells["Activity"].Value.ToString();
                HoursBox.Value = Convert.ToDecimal(refer.DGV.SelectedRows[0].Cells["Hours"].Value.ToString());
                EndDateBox.Value = Convert.ToDateTime(refer.DGV.SelectedRows[0].Cells["EndDate"].Value.ToString());
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (StudentNumberBox.Text != "" && ActivityBox.Text != "" && HoursBox.Value > 0)
            {
                int studentNumber = Convert.ToInt32(StudentNumberBox.Text);

                string startDate = StartDateBox.Value.ToString("yyyy-MM-dd HH:mm");
                startDate += ":00";

                string activity = ActivityBox.Text;
                int hours = Convert.ToInt32(HoursBox.Value);

                string endDate = EndDateBox.Value.ToString("yyyy-MM-dd HH:mm");
                endDate += ":00";


                if (type == "Add")
                {
                    SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO Services (StudentNumber, StartDate, Activity, Hours, EndDate) VALUES (@StudentNumber, @StartDate, @Activity, @Hours, @EndDate)", con);

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
                }
                else
                {
                    string command = "UPDATE Services SET StudentNumber = @StudentNumber, StartDate = @StartDate, Activity = @Activity, Hours = @Hours, EndDate = @EndDate WHERE Id = " + type + ";";

                    SQLiteCommand replaceCmd = new SQLiteCommand(command, con);

                    con.Open();
                    replaceCmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    replaceCmd.Parameters.AddWithValue("@StartDate", startDate);
                    replaceCmd.Parameters.AddWithValue("@Activity", activity);
                    replaceCmd.Parameters.AddWithValue("@Hours", hours);
                    replaceCmd.Parameters.AddWithValue("@EndDate", endDate);
                    replaceCmd.ExecuteNonQuery();

                    while (replaceCmd.Parameters.Count != 0)
                        replaceCmd.Parameters.RemoveAt(0);

                    con.Close();
                }

                MessageBox.Show("Service operation successful.", "Service Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refer.FillDGV();
                this.Close();
            }
            else
            {
                if (StudentNumberBox.Text == "")
                    MessageBox.Show("Student number was not given.", "No Student Number Given", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ActivityBox.Text == "")
                    MessageBox.Show("You must give a brief description of the activity.", "No Activity Given", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (HoursBox.Value == 0)
                    MessageBox.Show("You cannot submit a service with 0 hours.", "No Hours Given", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void HoursBox_ValueChanged(object sender, EventArgs e)
        {
            EndDateBox.Value = StartDateBox.Value;
            EndDateBox.Value = EndDateBox.Value.AddHours(Convert.ToDouble(HoursBox.Value));
        }
    }
}
