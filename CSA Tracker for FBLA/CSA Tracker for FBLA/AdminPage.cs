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
    public partial class AdminPage : Form
    {
        public Login login;
        public ManageUser manageUser;
        public DetailedUser detailedUser;

        public Report report;

        string connectionString = "Data Source=data.db;Version=3;";
        SQLiteConnection con;

        bool closeAll = true;
        public AdminPage(Login login)
        {
            this.login = login;
            con = new SQLiteConnection(connectionString);

            InitializeComponent();
            ChangeTheme();
            FillDGV();
        }

        public void ChangeTheme()
        {
            if (login.settings.theme == "Dark")
            {
                BackColor = Color.FromArgb(41, 41, 41);

                // Logo Box
                LogoBox.Image = new Bitmap(Properties.Resources.white_logo);

                // Field Labels
                FirstNameLabel.ForeColor = Color.White;
                LastNameLabel.ForeColor = Color.White;
                StudentNumberLabel.ForeColor = Color.White;
                GradeLabel.ForeColor = Color.White;

                // Add, Edit, Remove buttons
                AddButton.BackColor = Color.FromArgb(64, 64, 64);
                EditButton.BackColor = Color.FromArgb(64, 64, 64);
                DeleteButton.BackColor = Color.FromArgb(64, 64, 64);

                AddButton.ForeColor = Color.White;
                EditButton.ForeColor = Color.White;
                DeleteButton.ForeColor = Color.White;

                // Double Click and Row Height label
                DoubleClickLabel.ForeColor = Color.White;
                RowHeightLabel.ForeColor = Color.White;

                // DGV
                DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35,35,35);
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

                // Logo Box
                LogoBox.Image = new Bitmap(Properties.Resources.black_logo);

                // Field Labels
                FirstNameLabel.ForeColor = Color.Black;
                LastNameLabel.ForeColor = Color.Black;
                StudentNumberLabel.ForeColor = Color.Black;
                GradeLabel.ForeColor = Color.Black;

                // Add, Edit, Remove buttons
                AddButton.BackColor = Color.FromName("Control");
                EditButton.BackColor = Color.FromName("Control");
                DeleteButton.BackColor = Color.FromName("Control");

                AddButton.ForeColor = Color.Black;
                EditButton.ForeColor = Color.Black;
                DeleteButton.ForeColor = Color.Black;

                // Double Click and Row Height label
                DoubleClickLabel.ForeColor = Color.Black;
                RowHeightLabel.ForeColor = Color.Black;

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

        public void FillDGV()
        {
            DGV.DataSource = null;

            SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM Data", con);
            con.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
            DataTable table = new DataTable();
            da.Fill(table);

            con.Close();

            DGV.RowTemplate.Height = login.settings.adminRowHeight;
            RowHeightBox.Value = login.settings.adminRowHeight;

            DGV.DataSource = table;

            DGV.Columns["FirstName"].HeaderText = "First Name";
            DGV.Columns["LastName"].HeaderText = "Last Name";
            DGV.Columns["StudentNumber"].HeaderText = "Student Number";

            DGV.Columns["Id"].Visible = false;
            DGV.Columns["Username"].Visible = false;
        }

        private void SearchBoxes_TextChanged(object sender, EventArgs e)
        {

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

        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closeAll)
                login.Close();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            login.settings.Show();
        }

        private void RowHeightBox_ValueChanged(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(RowHeightBox.Value);
            DGV.RowTemplate.Height = height;

            for (int index = 0; index < DGV.Rows.Count; index++)
                DGV.Rows[index].Height = height;

            string command = "UPDATE Settings SET Value = @Value WHERE Category = 'AdminRowHeight';";

            SQLiteCommand replaceSettingsCmd = new SQLiteCommand(command, con);

            con.Open();
            replaceSettingsCmd.Parameters.AddWithValue("@Value", height);
            replaceSettingsCmd.ExecuteNonQuery();
            replaceSettingsCmd.Parameters.RemoveAt(0);

            con.Close();
        }

        private void DGV_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            int height = e.Row.Height;

            RowHeightBox.Value = e.Row.Height;

            DGV.RowTemplate.Height = height;

            for (int index = 0; index < DGV.Rows.Count; index++)
                DGV.Rows[index].Height = height;

            string command = "UPDATE Settings SET Value = @Value WHERE Category = 'AdminRowHeight';";

            SQLiteCommand replaceSettingsCmd = new SQLiteCommand(command, con);

            con.Open();
            replaceSettingsCmd.Parameters.AddWithValue("@Value", height);
            replaceSettingsCmd.ExecuteNonQuery();
            replaceSettingsCmd.Parameters.RemoveAt(0);

            con.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            manageUser = new ManageUser(login, this);
            manageUser.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count == 1)
            {
                manageUser = new ManageUser(login, DGV.SelectedRows[0], this);
                try { manageUser.Show(); }
                catch (ObjectDisposedException) { MessageBox.Show("You cannot edit the final blank row.", "Attempted To Edit Final Row", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if (DGV.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one row to edit.", "More Than One Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "User Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SQLiteCommand deleteCmd;
            try
            {
                if (DGV.SelectedRows.Count == 1)
                {
                    string id = DGV.SelectedRows[0].Cells["Id"].Value.ToString();
                    deleteCmd = new SQLiteCommand("DELETE FROM Data WHERE Id = " + id + ";", con);

                    con.Open();
                    deleteCmd.ExecuteNonQuery();
                    con.Close();

                    FillDGV();
                    MessageBox.Show("User successfully deleted.", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (DGV.SelectedRows.Count > 1)
                {
                    string[] id = new string[DGV.SelectedRows.Count];

                    for (int index = 0; index < id.Length; index++)
                    {
                        id[index] = DGV.SelectedRows[index].Cells["Id"].Value.ToString();

                        deleteCmd = new SQLiteCommand("DELETE FROM Data WHERE Id = " + id[index] + ";", con);

                        con.Open();
                        deleteCmd.ExecuteNonQuery();
                        con.Close();
                    }

                    FillDGV();
                    MessageBox.Show("Users successfully deleted.", "Users Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "No Users Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("You cannot delete the final blank row.", "Final Row Delete Attempted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            detailedUser = new DetailedUser(login, DGV.Rows[e.RowIndex].Cells["Username"].Value.ToString(), true);
            detailedUser.Show();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            report = new Report(this);
            report.Show();
        }
    }
}
