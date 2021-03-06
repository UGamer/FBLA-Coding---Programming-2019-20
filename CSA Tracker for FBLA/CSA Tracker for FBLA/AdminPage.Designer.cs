﻿namespace CSA_Tracker_for_FBLA
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.SettingsButton = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.DoubleClickLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.StudentNumberBox = new System.Windows.Forms.TextBox();
            this.StudentNumberLabel = new System.Windows.Forms.Label();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.GradeBox = new System.Windows.Forms.ComboBox();
            this.DGVContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SignOutButton = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.RowHeightLabel = new System.Windows.Forms.Label();
            this.RowHeightBox = new System.Windows.Forms.NumericUpDown();
            this.ReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowHeightBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(12, 456);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(39, 36);
            this.SettingsButton.TabIndex = 10;
            this.SettingsButton.Text = "⚙";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.Location = new System.Drawing.Point(12, 189);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 82;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.RowTemplate.Height = 50;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(993, 261);
            this.DGV.TabIndex = 11;
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            this.DGV.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.DGV_RowHeightChanged);
            // 
            // DoubleClickLabel
            // 
            this.DoubleClickLabel.AutoSize = true;
            this.DoubleClickLabel.Location = new System.Drawing.Point(12, 168);
            this.DoubleClickLabel.Name = "DoubleClickLabel";
            this.DoubleClickLabel.Size = new System.Drawing.Size(264, 13);
            this.DoubleClickLabel.TabIndex = 12;
            this.DoubleClickLabel.Text = "Double click a row to get a detailed view on a student.";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 125);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 36);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "+ Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(115, 125);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(97, 36);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "✎ Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(218, 125);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(97, 36);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "🗑️ Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 93);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.FirstNameLabel.TabIndex = 16;
            this.FirstNameLabel.Text = "First Name:";
            this.FirstNameLabel.Visible = false;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstNameBox.Location = new System.Drawing.Point(78, 91);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(198, 20);
            this.FirstNameBox.TabIndex = 17;
            this.FirstNameBox.Visible = false;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.SearchBoxes_TextChanged);
            // 
            // LastNameBox
            // 
            this.LastNameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LastNameBox.Location = new System.Drawing.Point(348, 91);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(198, 20);
            this.LastNameBox.TabIndex = 19;
            this.LastNameBox.Visible = false;
            this.LastNameBox.TextChanged += new System.EventHandler(this.SearchBoxes_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(282, 93);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.LastNameLabel.TabIndex = 18;
            this.LastNameLabel.Text = "Last Name:";
            this.LastNameLabel.Visible = false;
            // 
            // StudentNumberBox
            // 
            this.StudentNumberBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StudentNumberBox.Location = new System.Drawing.Point(618, 91);
            this.StudentNumberBox.Name = "StudentNumberBox";
            this.StudentNumberBox.Size = new System.Drawing.Size(198, 20);
            this.StudentNumberBox.TabIndex = 21;
            this.StudentNumberBox.Visible = false;
            this.StudentNumberBox.TextChanged += new System.EventHandler(this.SearchBoxes_TextChanged);
            // 
            // StudentNumberLabel
            // 
            this.StudentNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StudentNumberLabel.AutoSize = true;
            this.StudentNumberLabel.Location = new System.Drawing.Point(552, 93);
            this.StudentNumberLabel.Name = "StudentNumberLabel";
            this.StudentNumberLabel.Size = new System.Drawing.Size(57, 13);
            this.StudentNumberLabel.TabIndex = 20;
            this.StudentNumberLabel.Text = "Student #:";
            this.StudentNumberLabel.Visible = false;
            // 
            // GradeLabel
            // 
            this.GradeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Location = new System.Drawing.Point(822, 93);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(39, 13);
            this.GradeLabel.TabIndex = 22;
            this.GradeLabel.Text = "Grade:";
            this.GradeLabel.Visible = false;
            // 
            // GradeBox
            // 
            this.GradeBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GradeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GradeBox.FormattingEnabled = true;
            this.GradeBox.Items.AddRange(new object[] {
            "12",
            "11",
            "10",
            "9",
            "8",
            "7",
            "6"});
            this.GradeBox.Location = new System.Drawing.Point(868, 91);
            this.GradeBox.Name = "GradeBox";
            this.GradeBox.Size = new System.Drawing.Size(136, 21);
            this.GradeBox.TabIndex = 23;
            this.GradeBox.Visible = false;
            this.GradeBox.TextChanged += new System.EventHandler(this.SearchBoxes_TextChanged);
            // 
            // DGVContextMenu
            // 
            this.DGVContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.DGVContextMenu.Name = "DGVContextMenu";
            this.DGVContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // SignOutButton
            // 
            this.SignOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SignOutButton.Location = new System.Drawing.Point(57, 456);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(97, 36);
            this.SignOutButton.TabIndex = 26;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoBox.Image = global::CSA_Tracker_for_FBLA.Properties.Resources.black_logo;
            this.LogoBox.Location = new System.Drawing.Point(390, 11);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(253, 74);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 24;
            this.LogoBox.TabStop = false;
            // 
            // RowHeightLabel
            // 
            this.RowHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RowHeightLabel.AutoSize = true;
            this.RowHeightLabel.Location = new System.Drawing.Point(801, 168);
            this.RowHeightLabel.Name = "RowHeightLabel";
            this.RowHeightLabel.Size = new System.Drawing.Size(66, 13);
            this.RowHeightLabel.TabIndex = 27;
            this.RowHeightLabel.Text = "Row Height:";
            // 
            // RowHeightBox
            // 
            this.RowHeightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RowHeightBox.Location = new System.Drawing.Point(867, 166);
            this.RowHeightBox.Name = "RowHeightBox";
            this.RowHeightBox.Size = new System.Drawing.Size(137, 20);
            this.RowHeightBox.TabIndex = 29;
            this.RowHeightBox.ValueChanged += new System.EventHandler(this.RowHeightBox_ValueChanged);
            // 
            // ReportButton
            // 
            this.ReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportButton.Location = new System.Drawing.Point(908, 125);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(97, 36);
            this.ReportButton.TabIndex = 30;
            this.ReportButton.Text = "📄 Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 504);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.RowHeightBox);
            this.Controls.Add(this.RowHeightLabel);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.GradeBox);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.StudentNumberBox);
            this.Controls.Add(this.StudentNumberLabel);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DoubleClickLabel);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.SettingsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1033, 543);
            this.Name = "AdminPage";
            this.Text = "Administrator Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowHeightBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label DoubleClickLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox StudentNumberBox;
        private System.Windows.Forms.Label StudentNumberLabel;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.ComboBox GradeBox;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.ContextMenuStrip DGVContextMenu;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Label RowHeightLabel;
        private System.Windows.Forms.NumericUpDown RowHeightBox;
        private System.Windows.Forms.Button ReportButton;
        public System.Windows.Forms.DataGridView DGV;
    }
}