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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // StudentNumberLabel
            // 
            this.StudentNumberLabel.AutoSize = true;
            this.StudentNumberLabel.Location = new System.Drawing.Point(12, 9);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // ManageService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.StudentNumberLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageService";
            this.Text = "ManageService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentNumberLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}