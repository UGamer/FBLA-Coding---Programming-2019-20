namespace CSA_Tracker_for_FBLA
{
    partial class ManageService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageService));
            this.StudentNumberLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDateBox = new System.Windows.Forms.DateTimePicker();
            this.StudentNumberBox = new System.Windows.Forms.TextBox();
            this.ActivityBox = new System.Windows.Forms.TextBox();
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.HoursBox = new System.Windows.Forms.NumericUpDown();
            this.EndDateBox = new System.Windows.Forms.DateTimePicker();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HoursBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentNumberLabel
            // 
            this.StudentNumberLabel.AutoSize = true;
            this.StudentNumberLabel.Location = new System.Drawing.Point(12, 10);
            this.StudentNumberLabel.Name = "StudentNumberLabel";
            this.StudentNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.StudentNumberLabel.TabIndex = 0;
            this.StudentNumberLabel.Text = "Student Number:";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(12, 37);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(58, 13);
            this.StartDateLabel.TabIndex = 1;
            this.StartDateLabel.Text = "Start Date:";
            // 
            // StartDateBox
            // 
            this.StartDateBox.CustomFormat = "MMMM, dd, yyyy               hh:mm tt";
            this.StartDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateBox.Location = new System.Drawing.Point(104, 34);
            this.StartDateBox.Name = "StartDateBox";
            this.StartDateBox.Size = new System.Drawing.Size(248, 20);
            this.StartDateBox.TabIndex = 2;
            // 
            // StudentNumberBox
            // 
            this.StudentNumberBox.Enabled = false;
            this.StudentNumberBox.Location = new System.Drawing.Point(104, 7);
            this.StudentNumberBox.Name = "StudentNumberBox";
            this.StudentNumberBox.Size = new System.Drawing.Size(248, 20);
            this.StudentNumberBox.TabIndex = 3;
            // 
            // ActivityBox
            // 
            this.ActivityBox.Location = new System.Drawing.Point(104, 61);
            this.ActivityBox.Name = "ActivityBox";
            this.ActivityBox.Size = new System.Drawing.Size(248, 20);
            this.ActivityBox.TabIndex = 5;
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.Location = new System.Drawing.Point(12, 64);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(44, 13);
            this.ActivityLabel.TabIndex = 4;
            this.ActivityLabel.Text = "Activity:";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(12, 91);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(38, 13);
            this.HoursLabel.TabIndex = 6;
            this.HoursLabel.Text = "Hours:";
            // 
            // HoursBox
            // 
            this.HoursBox.Location = new System.Drawing.Point(104, 88);
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.Size = new System.Drawing.Size(248, 20);
            this.HoursBox.TabIndex = 8;
            this.HoursBox.ValueChanged += new System.EventHandler(this.HoursBox_ValueChanged);
            // 
            // EndDateBox
            // 
            this.EndDateBox.CustomFormat = "MMMM, dd, yyyy               hh:mm tt";
            this.EndDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateBox.Location = new System.Drawing.Point(104, 115);
            this.EndDateBox.Name = "EndDateBox";
            this.EndDateBox.Size = new System.Drawing.Size(248, 20);
            this.EndDateBox.TabIndex = 10;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(12, 118);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(55, 13);
            this.EndDateLabel.TabIndex = 9;
            this.EndDateLabel.Text = "End Date:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(12, 141);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(340, 35);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ManageService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 188);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.EndDateBox);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.HoursBox);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.ActivityBox);
            this.Controls.Add(this.ActivityLabel);
            this.Controls.Add(this.StudentNumberBox);
            this.Controls.Add(this.StartDateBox);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.StudentNumberLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageService";
            this.Text = "ManageService";
            ((System.ComponentModel.ISupportInitialize)(this.HoursBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentNumberLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDateBox;
        private System.Windows.Forms.TextBox StudentNumberBox;
        private System.Windows.Forms.TextBox ActivityBox;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.NumericUpDown HoursBox;
        private System.Windows.Forms.DateTimePicker EndDateBox;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Button SubmitButton;
    }
}