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
    public partial class ForgotLogin : Form
    {
        DataTable table;
        public ForgotLogin()
        {
            string connectionString = "Data Source=data.db;Version=3;";
            SQLiteConnection con = new SQLiteConnection(connectionString);
            SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM Users", con);

            con.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
            table = new DataTable();
            da.Fill(table);

            con.Close();

            InitializeComponent();
        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {
            bool userFound = false;

            for (int index = 0; index < table.Rows.Count; index++)
            {
                if (table.Rows[index]["Username"].ToString() == UserBox.Text)
                {
                    QuestionLabel1.Text = table.Rows[index]["Question1"].ToString();
                    QuestionLabel2.Text = table.Rows[index]["Question2"].ToString();
                    QuestionLabel3.Text = table.Rows[index]["Question3"].ToString();

                    userFound = true;
                    HideShow(true);

                    break;
                }
            }

            if (!userFound)
            {
                HideShow(false);
            }
        }

        private void HideShow(bool visibility)
        {
            QuestionLabel1.Visible = visibility;
            AnswerLabel1.Visible = visibility;
            AnswerBox1.Visible = visibility;

            QuestionLabel2.Visible = visibility;
            AnswerLabel2.Visible = visibility;
            AnswerBox2.Visible = visibility;

            QuestionLabel3.Visible = visibility;
            AnswerLabel3.Visible = visibility;
            AnswerBox3.Visible = visibility;

            PasswordLabel.Visible = visibility;
            PassBox.Visible = visibility;

            ConfirmLabel.Visible = visibility;
            ConfirmBox.Visible = visibility;

            SubmitButton.Visible = visibility;

            if (visibility)
                this.Size = new Size(564, 640);
            else
                this.Size = new Size(564, 198);
        }
    }
}
