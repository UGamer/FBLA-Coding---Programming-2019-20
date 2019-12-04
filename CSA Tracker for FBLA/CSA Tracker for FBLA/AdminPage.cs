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

                // Settings and SignOut buttons
                SettingsButton.BackColor = Color.FromName("Control");
                SignOutButton.BackColor = Color.FromName("Control");

                SettingsButton.ForeColor = Color.Black;
                SignOutButton.ForeColor = Color.Black;
            }
        }

        private void FillDGV()
        {
            SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM Data", con);
            con.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
            DataTable table = new DataTable();
            da.Fill(table);

            con.Close();

            DGV.RowTemplate.Height = login.settings.adminRowHeight;
            RowHeightBox.Value = login.settings.adminRowHeight;

            DGV.DataSource = table;
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

        }
    }
}
