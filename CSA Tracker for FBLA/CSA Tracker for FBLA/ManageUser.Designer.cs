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
            this.NameLabel = new System.Windows.Forms.Label();
            this.StudentGradeLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DGVContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PicBox = new System.Windows.Forms.PictureBox();
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
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(304, 141);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(97, 36);
            this.EditButton.TabIndex = 17;
            this.EditButton.Text = "✎ Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(201, 141);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 36);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "+ Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DGVContextMenu
            // 
            this.DGVContextMenu.Name = "DGVContextMenu";
            this.DGVContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(13, 13);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(172, 168);
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 196);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.StudentGradeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUser";
            this.Text = "ManageUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageUser_FormClosed);
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
    }
}