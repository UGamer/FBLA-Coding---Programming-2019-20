using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSA_Tracker_for_FBLA
{
    public partial class Report : Form
    {
        string type;

        DetailedUser detailedUser;
        AdminPage adminPage;

        DataTable dataTable;

        public Report(DetailedUser user)
        {
            // Program starts on displaying weekly.

            detailedUser = user;
            type = detailedUser.studentNumber;

            InitializeComponent();
            ChangeTheme();
            FillDGV();
        }

        private void FillDGV()
        {
            dataTable = new DataTable();
            dataTable = detailedUser.DGV.DataSource as DataTable;

            DataTable newTable = new DataTable();

            newTable.Columns.Add("Start of Week", typeof(DateTime));
            newTable.Columns.Add("Hours");
            newTable.Columns.Add("CSA Category");
            newTable.Columns.Add("End of Week", typeof(DateTime));

            DataRow newRow;

            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                DateTime currentDate = Convert.ToDateTime(dataTable.Rows[index]["StartDate"].ToString());
                if (currentDate.DayOfWeek.ToString() != "Monday")
                    currentDate.AddDays(-1);

                bool weekStarted = false;
                int savedIndex = -1;
                for (int index2 = 0; index2 < newTable.Rows.Count; index2++)
                {
                    if (newTable.Rows[index2]["Start of Week"].ToString() == currentDate.ToString())
                    {
                        weekStarted = true;
                        savedIndex = index2;
                    }
                }

                if (weekStarted)
                {
                    int hours = Convert.ToInt32(newTable.Rows[savedIndex]["Hours"]);

                    newTable.Rows[savedIndex]["Hours"] = hours + Convert.ToInt32(dataTable.Rows[index]);

                    if (hours >= 0 && hours < 50)
                        newTable.Rows[savedIndex]["CSA Category"] = "CSA Community";
                    else if (hours >= 50 && hours < 200)
                        newTable.Rows[savedIndex]["CSA Category"] = "CSA Service";
                    else if (hours >= 201)
                        newTable.Rows[savedIndex]["CSA Category"] = "CSA Achievement";
                }
                else
                {
                    newRow = newTable.NewRow();

                    newRow["Start of Week"] = currentDate;
                    newRow["Hours"] = Convert.ToInt32(dataTable.Rows[index]);

                    int hours = Convert.ToInt32(dataTable.Rows[index]);

                    if (hours >= 0 && hours < 50)
                        newRow["CSA Category"] = "CSA Community";
                    else if (hours >= 50 && hours < 200)
                        newRow["CSA Category"] = "CSA Service";
                    else if (hours >= 201)
                        newRow["CSA Category"] = "CSA Achievement";

                    newRow["End of Week"] = currentDate.AddDays(6);

                    newTable.Rows.Add(newRow);
                }

            }

            DGV.DataSource = newTable;

            DGV.Columns["Id"].Visible = false;
            DGV.Columns["StudentNumber"].Visible = false;
            DGV.Columns["StartDate"].HeaderText = "Start Date";
            DGV.Columns["EndDate"].HeaderText = "End Date";
        }

        private void WeekMonthButton_Click(object sender, EventArgs e)
        {
            if (WeekMonthButton.Text == "Weekly")
            {
                // THIS IS CHANGING FROM MONTHLY TO WEEKLY
                WeekMonthButton.Text = "Monthly";
                CurrentDisplayLabel.Text = "Currently displaying weekly reports.";
                if (type == "Admin")
                {
                    
                }
                else
                {

                }
            }
            else
            {
                // THIS IS CHANGING FROM WEEKLY TO MONTHLY
                WeekMonthButton.Text = "Weekly";
                CurrentDisplayLabel.Text = "Currently displaying monthly reports.";
                if (type == "Admin")
                {

                }
                else
                {

                }
            }
        }

        public void ChangeTheme()
        {
            string theme = "Dark";
            try { theme = detailedUser.login.settings.theme; } catch { theme = adminPage.login.settings.theme; }

            if (theme == "Dark")
            {
                BackColor = Color.FromArgb(41, 41, 41);

                // Settings and SignOut buttons
                WeekMonthButton.BackColor = Color.FromArgb(64, 64, 64);

                WeekMonthButton.ForeColor = Color.White;

                // Field Labels
                CurrentDisplayLabel.ForeColor = Color.White;
                NumberLabel.ForeColor = Color.White;
                NameLabel.ForeColor = Color.White;

                // DGV
                DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
                DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                DGV.RowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                DGV.RowsDefaultCellStyle.ForeColor = Color.White;

                DGV.BackgroundColor = Color.FromArgb(35, 35, 35);
            }
            else
            {
                BackColor = Color.FromName("Control");

                // Settings and SignOut buttons
                WeekMonthButton.BackColor = Color.FromName("Control");

                WeekMonthButton.ForeColor = Color.Black;

                // Field Labels
                CurrentDisplayLabel.ForeColor = Color.Black;
                NumberLabel.ForeColor = Color.Black;
                NameLabel.ForeColor = Color.Black;

                // DGV
                DGV.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
                DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
                DGV.BackgroundColor = Color.FromName("Silver");

                DGV.RowsDefaultCellStyle = new DataGridViewCellStyle();

                DGV.BackgroundColor = Color.FromName("AppWorkspace");
            }
        }
    }
}
