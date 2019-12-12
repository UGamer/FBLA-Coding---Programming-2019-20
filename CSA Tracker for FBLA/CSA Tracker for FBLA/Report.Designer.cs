namespace CSA_Tracker_for_FBLA
{
    partial class Report
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.WeekMonthButton = new System.Windows.Forms.Button();
            this.CurrentDisplayLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.Location = new System.Drawing.Point(0, 100);
            this.DGV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 82;
            this.DGV.Size = new System.Drawing.Size(1600, 765);
            this.DGV.TabIndex = 0;
            // 
            // WeekMonthButton
            // 
            this.WeekMonthButton.Location = new System.Drawing.Point(24, 23);
            this.WeekMonthButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.WeekMonthButton.Name = "WeekMonthButton";
            this.WeekMonthButton.Size = new System.Drawing.Size(150, 65);
            this.WeekMonthButton.TabIndex = 1;
            this.WeekMonthButton.Text = "Monthly";
            this.WeekMonthButton.UseVisualStyleBackColor = true;
            this.WeekMonthButton.Click += new System.EventHandler(this.WeekMonthButton_Click);
            // 
            // CurrentDisplayLabel
            // 
            this.CurrentDisplayLabel.AutoSize = true;
            this.CurrentDisplayLabel.Location = new System.Drawing.Point(186, 44);
            this.CurrentDisplayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CurrentDisplayLabel.Name = "CurrentDisplayLabel";
            this.CurrentDisplayLabel.Size = new System.Drawing.Size(353, 25);
            this.CurrentDisplayLabel.TabIndex = 2;
            this.CurrentDisplayLabel.Text = "Currently displaying weekly reports.";
            // 
            // NumberLabel
            // 
            this.NumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(668, 41);
            this.NumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(173, 25);
            this.NumberLabel.TabIndex = 3;
            this.NumberLabel.Text = "Student Number:";
            // 
            // NumberBox
            // 
            this.NumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberBox.Location = new System.Drawing.Point(854, 38);
            this.NumberBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(174, 31);
            this.NumberBox.TabIndex = 4;
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.Location = new System.Drawing.Point(1212, 38);
            this.NameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(360, 31);
            this.NameBox.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(1044, 41);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(154, 25);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Student Name:";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.CurrentDisplayLabel);
            this.Controls.Add(this.WeekMonthButton);
            this.Controls.Add(this.DGV);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button WeekMonthButton;
        private System.Windows.Forms.Label CurrentDisplayLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
    }
}