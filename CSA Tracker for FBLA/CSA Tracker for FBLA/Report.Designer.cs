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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV.Location = new System.Drawing.Point(0, 52);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(800, 398);
            this.DGV.TabIndex = 0;
            // 
            // WeekMonthButton
            // 
            this.WeekMonthButton.Location = new System.Drawing.Point(12, 12);
            this.WeekMonthButton.Name = "WeekMonthButton";
            this.WeekMonthButton.Size = new System.Drawing.Size(75, 34);
            this.WeekMonthButton.TabIndex = 1;
            this.WeekMonthButton.Text = "Monthly";
            this.WeekMonthButton.UseVisualStyleBackColor = true;
            this.WeekMonthButton.Click += new System.EventHandler(this.WeekMonthButton_Click);
            // 
            // CurrentDisplayLabel
            // 
            this.CurrentDisplayLabel.AutoSize = true;
            this.CurrentDisplayLabel.Location = new System.Drawing.Point(93, 23);
            this.CurrentDisplayLabel.Name = "CurrentDisplayLabel";
            this.CurrentDisplayLabel.Size = new System.Drawing.Size(171, 13);
            this.CurrentDisplayLabel.TabIndex = 2;
            this.CurrentDisplayLabel.Text = "Currently displaying weekly reports.";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(334, 23);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(87, 13);
            this.NumberLabel.TabIndex = 3;
            this.NumberLabel.Text = "Student Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 4;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(606, 20);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(182, 20);
            this.NameBox.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(522, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(78, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Student Name:";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.CurrentDisplayLabel);
            this.Controls.Add(this.WeekMonthButton);
            this.Controls.Add(this.DGV);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
    }
}