namespace CSA_Tracker_for_FBLA
{
    partial class ManageUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUser));
            this.DGVContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.StudentNumberBox = new System.Windows.Forms.TextBox();
            this.GradeBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVContextMenu
            // 
            this.DGVContextMenu.Name = "DGVContextMenu";
            this.DGVContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(12, 6);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(94, 94);
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FirstNameBox.Location = new System.Drawing.Point(112, 6);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(278, 44);
            this.FirstNameBox.TabIndex = 19;
            this.FirstNameBox.Text = "First Name...";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LastNameBox.Location = new System.Drawing.Point(396, 6);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(278, 44);
            this.LastNameBox.TabIndex = 20;
            this.LastNameBox.Text = "Last Name...";
            // 
            // StudentNumberBox
            // 
            this.StudentNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNumberBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.StudentNumberBox.Location = new System.Drawing.Point(112, 56);
            this.StudentNumberBox.Name = "StudentNumberBox";
            this.StudentNumberBox.Size = new System.Drawing.Size(278, 44);
            this.StudentNumberBox.TabIndex = 21;
            this.StudentNumberBox.Text = "Student Number...";
            // 
            // GradeBox
            // 
            this.GradeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.GradeBox.Location = new System.Drawing.Point(396, 56);
            this.GradeBox.Name = "GradeBox";
            this.GradeBox.Size = new System.Drawing.Size(278, 44);
            this.GradeBox.TabIndex = 22;
            this.GradeBox.Text = "Grade...";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(290, 106);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(122, 32);
            this.SubmitButton.TabIndex = 23;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 150);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.GradeBox);
            this.Controls.Add(this.StudentNumberBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.PicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUser";
            this.Text = "Manage User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageUser_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.ContextMenuStrip DGVContextMenu;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox StudentNumberBox;
        private System.Windows.Forms.TextBox GradeBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}