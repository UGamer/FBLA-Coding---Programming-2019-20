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

            NumberLabel.Visible = false;
            NumberBox.Visible = false;
            NameLabel.Visible = false;
            NameBox.Visible = false;

            ChangeTheme();
            FillDGV();
        }

        public Report(AdminPage adminPage)
        {
            // Program starts on displaying weekly.

            this.adminPage = adminPage;
            type = "Admin";

            InitializeComponent();
            ChangeTheme();
            FillDGV();
        }

        private void FillDGV()
        {
            dataTable = new DataTable();
            DataTable newTable = new DataTable();
            DataRow newRow;

            // User & Weekly
            if (type != "Admin" && WeekMonthButton.Text == "Monthly")
            {
                dataTable = detailedUser.DGV.DataSource as DataTable;

                newTable.Columns.Add("Start of Week", typeof(DateTime));
                newTable.Columns.Add("Hours");
                newTable.Columns.Add("Total Hours");
                newTable.Columns.Add("CSA Category");
                newTable.Columns.Add("End of Week", typeof(DateTime));

                for (int index = 0; index < dataTable.Rows.Count; index++)
                {
                    DateTime currentDate = Convert.ToDateTime(dataTable.Rows[index]["StartDate"].ToString());
                    currentDate = currentDate.AddHours(currentDate.Hour * -1);
                    currentDate = currentDate.AddMinutes(currentDate.Minute * -1);
                    currentDate = currentDate.AddSeconds(currentDate.Second * -1);

                    while (currentDate.DayOfWeek != DayOfWeek.Monday)
                        currentDate = currentDate.AddDays(-1);

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

                        newTable.Rows[savedIndex]["Hours"] = hours + Convert.ToInt32(dataTable.Rows[index]["Hours"]);
                    }
                    else
                    {
                        newRow = newTable.NewRow();

                        newRow["Start of Week"] = currentDate;

                        int hours = Convert.ToInt32(dataTable.Rows[index]["Hours"]);

                        newRow["Hours"] = hours;

                        newRow["End of Week"] = currentDate.AddDays(6);

                        newTable.Rows.Add(newRow);
                    }

                }

                int totalHours = 0;
                for (int index = 0; index < newTable.Rows.Count; index++)
                {
                    totalHours += Convert.ToInt32(newTable.Rows[index]["Hours"]);
                    newTable.Rows[index]["Total Hours"] = totalHours;
                }

                for (int index = 0; index < newTable.Rows.Count; index++)
                {
                    int hours = Convert.ToInt32(newTable.Rows[index]["Total Hours"]);

                    if (hours >= 0 && hours < 50)
                        newTable.Rows[index]["CSA Category"] = "CSA Community";
                    else if (hours >= 50 && hours < 200)
                        newTable.Rows[index]["CSA Category"] = "CSA Service";
                    else if (hours >= 201)
                        newTable.Rows[index]["CSA Category"] = "CSA Achievement";
                }
            }
            // User & Monthly
            if (type != "Admin" && WeekMonthButton.Text == "Weekly")
            {
                dataTable = detailedUser.DGV.DataSource as DataTable;

                newTable.Columns.Add("Month & Year");
                newTable.Columns.Add("Hours");
                newTable.Columns.Add("Total Hours");
                newTable.Columns.Add("CSA Category");

                for (int index = 0; index < dataTable.Rows.Count; index++)
                {
                    DateTime currentDate = Convert.ToDateTime(dataTable.Rows[index]["StartDate"].ToString());
                    string dateString = currentDate.ToString("MM-yyyy");

                    bool monthStarted = false;
                    int savedIndex = -1;
                    for (int index2 = 0; index2 < newTable.Rows.Count; index2++)
                    {
                        if (newTable.Rows[index2]["Month & Year"].ToString() == dateString)
                        {
                            monthStarted = true;
                            savedIndex = index2;
                        }
                    }

                    if (monthStarted)
                    {
                        int hours = Convert.ToInt32(newTable.Rows[savedIndex]["Hours"]);

                        newTable.Rows[savedIndex]["Hours"] = hours + Convert.ToInt32(dataTable.Rows[index]["Hours"]);
                    }
                    else
                    {
                        newRow = newTable.NewRow();

                        newRow["Month & Year"] = dateString;

                        int hours = Convert.ToInt32(dataTable.Rows[index]["Hours"]);

                        newRow["Hours"] = hours;

                        newTable.Rows.Add(newRow);
                    }

                }

                int totalHours = 0;
                for (int index = 0; index < newTable.Rows.Count; index++)
                {
                    totalHours += Convert.ToInt32(newTable.Rows[index]["Hours"]);
                    newTable.Rows[index]["Total Hours"] = totalHours;
                }

                for (int index = 0; index < newTable.Rows.Count; index++)
                {
                    int hours = Convert.ToInt32(newTable.Rows[index]["Total Hours"]);

                    if (hours >= 0 && hours < 50)
                        newTable.Rows[index]["CSA Category"] = "CSA Community";
                    else if (hours >= 50 && hours < 200)
                        newTable.Rows[index]["CSA Category"] = "CSA Service";
                    else if (hours >= 201)
                        newTable.Rows[index]["CSA Category"] = "CSA Achievement";
                }
            }

            DataTable serviceTable = new DataTable();
            if (type == "Admin")
            {
                // Admin reports need the Services table.
                string connectionString = "Data Source=data.db;Version=3;";
                SQLiteConnection con = new SQLiteConnection(connectionString);
                SQLiteCommand selectServicesCmd = new SQLiteCommand("SELECT * FROM Services", con);

                con.Open();
                // Fills a DataTable out with the contents of the SQL table "Services"
                SQLiteDataAdapter da = new SQLiteDataAdapter(selectServicesCmd);
                da.Fill(serviceTable);
                con.Close();
            }

            // Admin & Weekly
            if (type == "Admin" && WeekMonthButton.Text == "Monthly")
            {
                dataTable = adminPage.DGV.DataSource as DataTable;

                newTable.Columns.Add("Start of Week", typeof(DateTime));
                newTable.Columns.Add("Student Number");
                newTable.Columns.Add("Full Name");
                newTable.Columns.Add("Hours");
                newTable.Columns.Add("Total Hours");
                newTable.Columns.Add("CSA Category");
                newTable.Columns.Add("End of Week", typeof(DateTime));

                for (int index = 0; index < dataTable.Rows.Count; index++)
                {
                    string currentNumber = dataTable.Rows[index]["StudentNumber"].ToString();

                    for (int index2 = 0; index2 < serviceTable.Rows.Count; index2++)
                    {
                        if (serviceTable.Rows[index2]["StudentNumber"].ToString() == currentNumber)
                        {
                            DateTime currentDate = Convert.ToDateTime(serviceTable.Rows[index2]["StartDate"].ToString());
                            currentDate = currentDate.AddHours(currentDate.Hour * -1);
                            currentDate = currentDate.AddMinutes(currentDate.Minute * -1);
                            currentDate = currentDate.AddSeconds(currentDate.Second * -1);

                            while (currentDate.DayOfWeek != DayOfWeek.Monday)
                                currentDate = currentDate.AddDays(-1);

                            bool weekStarted = false;
                            int savedIndex = -1;
                            for (int index3 = 0; index3 < newTable.Rows.Count; index3++)
                            {
                                if (newTable.Rows[index3]["Start of Week"].ToString() == currentDate.ToString() && newTable.Rows[index3]["Student Number"].ToString() == currentNumber)
                                {
                                    weekStarted = true;
                                    savedIndex = index3;
                                }
                            }

                            if (weekStarted)
                            {
                                int hours = Convert.ToInt32(newTable.Rows[savedIndex]["Hours"]);

                                newTable.Rows[savedIndex]["Hours"] = hours + Convert.ToInt32(serviceTable.Rows[index2]["Hours"]);
                            }
                            else
                            {
                                newRow = newTable.NewRow();

                                newRow["Start of Week"] = currentDate;
                                newRow["Student Number"] = currentNumber;
                                newRow["Full Name"] = dataTable.Rows[index]["FirstName"].ToString() + " " + dataTable.Rows[index]["LastName"].ToString();

                                int hours = Convert.ToInt32(serviceTable.Rows[index2]["Hours"]);

                                newRow["Hours"] = hours;

                                newRow["End of Week"] = currentDate.AddDays(6);

                                newTable.Rows.Add(newRow);
                            }
                        }
                    }
                }

                int totalHours = 0;
                for (int index = 0; index < newTable.Rows.Count; index++)
                {
                    totalHours += Convert.ToInt32(newTable.Rows[index]["Hours"]);
                    newTable.Rows[index]["Total Hours"] = totalHours;
                }

                for (int index = 0; index < newTable.Rows.Count; index++)
                {
                    int hours = Convert.ToInt32(newTable.Rows[index]["Total Hours"]);

                    if (hours >= 0 && hours < 50)
                        newTable.Rows[index]["CSA Category"] = "CSA Community";
                    else if (hours >= 50 && hours < 200)
                        newTable.Rows[index]["CSA Category"] = "CSA Service";
                    else if (hours >= 201)
                        newTable.Rows[index]["CSA Category"] = "CSA Achievement";
                }
            }
            // Admin & Monthly
            if (type == "Admin" && WeekMonthButton.Text == "Weekly")
            {
                dataTable = adminPage.DGV.DataSource as DataTable;

                newTable.Columns.Add("Month & Year");
                newTable.Columns.Add("Student Number");
                newTable.Columns.Add("Full Name");
                newTable.Columns.Add("Hours");
                newTable.Columns.Add("Total Hours");
                newTable.Columns.Add("CSA Category");

                for (int index = 0; index < dataTable.Rows.Count; index++)
                {
                    string currentNumber = dataTable.Rows[index]["StudentNumber"].ToString();

                    for (int index2 = 0; index2 < serviceTable.Rows.Count; index2++)
                    {
                        if (serviceTable.Rows[index2]["StudentNumber"].ToString() == currentNumber)
                        {
                            DateTime currentDate = Convert.ToDateTime(serviceTable.Rows[index2]["StartDate"].ToString());
                            string dateString = currentDate.ToString("MM-yyyy");

                            while (currentDate.DayOfWeek != DayOfWeek.Monday)
                                currentDate = currentDate.AddDays(-1);

                            bool monthStarted = false;
                            int savedIndex = -1;
                            for (int index3 = 0; index3 < newTable.Rows.Count; index3++)
                            {
                                if (newTable.Rows[index3]["Month & Year"].ToString() == dateString && newTable.Rows[index3]["Student Number"].ToString() == currentNumber)
                                {
                                    monthStarted = true;
                                    savedIndex = index3;
                                }
                            }

                            if (monthStarted)
                            {
                                int hours = Convert.ToInt32(newTable.Rows[savedIndex]["Hours"]);

                                newTable.Rows[savedIndex]["Hours"] = hours + Convert.ToInt32(serviceTable.Rows[index2]["Hours"]);
                            }
                            else
                            {
                                newRow = newTable.NewRow();

                                newRow["Month & Year"] = dateString;
                                newRow["Student Number"] = currentNumber;
                                newRow["Full Name"] = dataTable.Rows[index]["FirstName"].ToString() + " " + dataTable.Rows[index]["LastName"].ToString();

                                int hours = Convert.ToInt32(serviceTable.Rows[index2]["Hours"]);

                                newRow["Hours"] = hours;

                                newTable.Rows.Add(newRow);
                            }
                        }
                    }
                }

                int totalHours = 0;
                for (int index = 0; index < newTable.Rows.Count; index++)
                {
                    totalHours += Convert.ToInt32(newTable.Rows[index]["Hours"]);
                    newTable.Rows[index]["Total Hours"] = totalHours;
                }

                for (int index = 0; index < newTable.Rows.Count; index++)
                {
                    int hours = Convert.ToInt32(newTable.Rows[index]["Total Hours"]);

                    if (hours >= 0 && hours < 50)
                        newTable.Rows[index]["CSA Category"] = "CSA Community";
                    else if (hours >= 50 && hours < 200)
                        newTable.Rows[index]["CSA Category"] = "CSA Service";
                    else if (hours >= 201)
                        newTable.Rows[index]["CSA Category"] = "CSA Achievement";
                }
            }

            DGV.DataSource = newTable;
            DGV.Sort(DGV.Columns[0], ListSortDirection.Ascending);
        }

        private void WeekMonthButton_Click(object sender, EventArgs e)
        {
            if (WeekMonthButton.Text == "Weekly")
            {
                // THIS IS CHANGING FROM MONTHLY TO WEEKLY
                WeekMonthButton.Text = "Monthly";
                CurrentDisplayLabel.Text = "Currently displaying weekly reports.";
                FillDGV();
            }
            else
            {
                // THIS IS CHANGING FROM WEEKLY TO MONTHLY
                WeekMonthButton.Text = "Weekly";
                CurrentDisplayLabel.Text = "Currently displaying monthly reports.";
                FillDGV();
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

        private void NumberBox_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(DGV.DataSource as DataTable);

            DV.RowFilter = "Student_Number LIKE '%" + NumberBox.Text + "%'";
            // DV.RowFilter = "'Student Number' LIKE '%" + NumberBox.Text + "%' AND 'Full Name' LIKE '%" + NameBox.Text + "%'";
            DGV.DataSource = DV;
        }
    }
}
