namespace CSA_Tracker_for_FBLA
{
    partial class DetailedUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedUser));
            this.NameLabel = new System.Windows.Forms.Label();
            this.StudentGradeLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.DGVContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SignOutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(191, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(220, 55);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "First Last";
            // 
            // StudentGradeLabel
            // 
            this.StudentGradeLabel.AutoSize = true;
            this.StudentGradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentGradeLabel.Location = new System.Drawing.Point(194, 64);
            this.StudentGradeLabel.Name = "StudentGradeLabel";
            this.StudentGradeLabel.Size = new System.Drawing.Size(261, 37);
            this.StudentGradeLabel.TabIndex = 2;
            this.StudentGradeLabel.Text = "Student #, Grade";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLabel.Location = new System.Drawing.Point(194, 101);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(283, 37);
            this.HoursLabel.TabIndex = 3;
            this.HoursLabel.Text = "Total Hours: hours";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(407, 141);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(97, 36);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "🗑️ Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(304, 141);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(97, 36);
            this.EditButton.TabIndex = 17;
            this.EditButton.Text = "✎ Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(201, 141);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 36);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "+ Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.Location = new System.Drawing.Point(13, 188);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(775, 250);
            this.DGV.TabIndex = 19;
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(13, 13);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(172, 168);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            // 
            // DGVContextMenu
            // 
            this.DGVContextMenu.Name = "DGVContextMenu";
            this.DGVContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // SignOutButton
            // 
            this.SignOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SignOutButton.Location = new System.Drawing.Point(57, 443);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(97, 36);
            this.SignOutButton.TabIndex = 28;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(12, 443);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(39, 36);
            this.SettingsButton.TabIndex = 27;
            this.SettingsButton.Text = "⚙";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // DetailedUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.StudentGradeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(533, 308);
            this.Name = "DetailedUser";
            this.Text = "First Last\'s Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DetailedUser_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label StudentGradeLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ContextMenuStrip DGVContextMenu;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Button SettingsButton;
        public System.Windows.Forms.DataGridView DGV;
    }
}