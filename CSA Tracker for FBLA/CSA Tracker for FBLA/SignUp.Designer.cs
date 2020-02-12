namespace CSA_Tracker_for_FBLA
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.FillOutFieldsLabel = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.StudentNumberLabel = new System.Windows.Forms.Label();
            this.StudentNumberBox = new System.Windows.Forms.TextBox();
            this.Question1Label = new System.Windows.Forms.Label();
            this.Answer1Box = new System.Windows.Forms.TextBox();
            this.Question1Box = new System.Windows.Forms.ComboBox();
            this.Answer1Label = new System.Windows.Forms.Label();
            this.Answer2Label = new System.Windows.Forms.Label();
            this.Question2Box = new System.Windows.Forms.ComboBox();
            this.Question2Label = new System.Windows.Forms.Label();
            this.Answer2Box = new System.Windows.Forms.TextBox();
            this.Answer3Label = new System.Windows.Forms.Label();
            this.Question3Box = new System.Windows.Forms.ComboBox();
            this.Question3Label = new System.Windows.Forms.Label();
            this.Answer3Box = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.GradeBox = new System.Windows.Forms.ComboBox();
            this.GradeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FillOutFieldsLabel
            // 
            this.FillOutFieldsLabel.AutoSize = true;
            this.FillOutFieldsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillOutFieldsLabel.Location = new System.Drawing.Point(122, 170);
            this.FillOutFieldsLabel.Name = "FillOutFieldsLabel";
            this.FillOutFieldsLabel.Size = new System.Drawing.Size(253, 24);
            this.FillOutFieldsLabel.TabIndex = 1;
            this.FillOutFieldsLabel.Text = "Fill out the fields and sign up.";
            this.FillOutFieldsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(112, 199);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(371, 20);
            this.UserBox.TabIndex = 1;
            this.UserBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserBox_KeyDown);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(19, 202);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(32, 13);
            this.UserLabel.TabIndex = 3;
            this.UserLabel.Text = "User:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(19, 228);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(56, 13);
            this.PassLabel.TabIndex = 5;
            this.PassLabel.Text = "Password:";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(112, 225);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(371, 20);
            this.PassBox.TabIndex = 2;
            this.PassBox.UseSystemPasswordChar = true;
            this.PassBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassBox_KeyDown);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(12, 523);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(471, 36);
            this.SignUpButton.TabIndex = 13;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(12, 565);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(39, 37);
            this.SettingsButton.TabIndex = 14;
            this.SettingsButton.Text = "⚙";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::CSA_Tracker_for_FBLA.Properties.Resources.logo;
            this.LogoBox.Location = new System.Drawing.Point(126, 12);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(243, 155);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // StudentNumberLabel
            // 
            this.StudentNumberLabel.AutoSize = true;
            this.StudentNumberLabel.Location = new System.Drawing.Point(19, 317);
            this.StudentNumberLabel.Name = "StudentNumberLabel";
            this.StudentNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.StudentNumberLabel.TabIndex = 11;
            this.StudentNumberLabel.Text = "Student Number:";
            // 
            // StudentNumberBox
            // 
            this.StudentNumberBox.Location = new System.Drawing.Point(112, 314);
            this.StudentNumberBox.Name = "StudentNumberBox";
            this.StudentNumberBox.Size = new System.Drawing.Size(371, 20);
            this.StudentNumberBox.TabIndex = 5;
            // 
            // Question1Label
            // 
            this.Question1Label.AutoSize = true;
            this.Question1Label.Location = new System.Drawing.Point(19, 369);
            this.Question1Label.Name = "Question1Label";
            this.Question1Label.Size = new System.Drawing.Size(61, 13);
            this.Question1Label.TabIndex = 13;
            this.Question1Label.Text = "Question 1:";
            // 
            // Answer1Box
            // 
            this.Answer1Box.Location = new System.Drawing.Point(112, 392);
            this.Answer1Box.Name = "Answer1Box";
            this.Answer1Box.Size = new System.Drawing.Size(370, 20);
            this.Answer1Box.TabIndex = 8;
            // 
            // Question1Box
            // 
            this.Question1Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Question1Box.FormattingEnabled = true;
            this.Question1Box.Location = new System.Drawing.Point(112, 366);
            this.Question1Box.Name = "Question1Box";
            this.Question1Box.Size = new System.Drawing.Size(370, 21);
            this.Question1Box.TabIndex = 7;
            this.Question1Box.TextChanged += new System.EventHandler(this.QuestionBox_TextChanged);
            // 
            // Answer1Label
            // 
            this.Answer1Label.AutoSize = true;
            this.Answer1Label.Location = new System.Drawing.Point(19, 395);
            this.Answer1Label.Name = "Answer1Label";
            this.Answer1Label.Size = new System.Drawing.Size(54, 13);
            this.Answer1Label.TabIndex = 15;
            this.Answer1Label.Text = "Answer 1:";
            // 
            // Answer2Label
            // 
            this.Answer2Label.AutoSize = true;
            this.Answer2Label.Location = new System.Drawing.Point(19, 447);
            this.Answer2Label.Name = "Answer2Label";
            this.Answer2Label.Size = new System.Drawing.Size(54, 13);
            this.Answer2Label.TabIndex = 19;
            this.Answer2Label.Text = "Answer 2:";
            // 
            // Question2Box
            // 
            this.Question2Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Question2Box.FormattingEnabled = true;
            this.Question2Box.Location = new System.Drawing.Point(112, 418);
            this.Question2Box.Name = "Question2Box";
            this.Question2Box.Size = new System.Drawing.Size(370, 21);
            this.Question2Box.TabIndex = 9;
            this.Question2Box.TextChanged += new System.EventHandler(this.QuestionBox_TextChanged);
            // 
            // Question2Label
            // 
            this.Question2Label.AutoSize = true;
            this.Question2Label.Location = new System.Drawing.Point(19, 421);
            this.Question2Label.Name = "Question2Label";
            this.Question2Label.Size = new System.Drawing.Size(61, 13);
            this.Question2Label.TabIndex = 17;
            this.Question2Label.Text = "Question 2:";
            // 
            // Answer2Box
            // 
            this.Answer2Box.Location = new System.Drawing.Point(112, 444);
            this.Answer2Box.Name = "Answer2Box";
            this.Answer2Box.Size = new System.Drawing.Size(370, 20);
            this.Answer2Box.TabIndex = 10;
            // 
            // Answer3Label
            // 
            this.Answer3Label.AutoSize = true;
            this.Answer3Label.Location = new System.Drawing.Point(19, 499);
            this.Answer3Label.Name = "Answer3Label";
            this.Answer3Label.Size = new System.Drawing.Size(54, 13);
            this.Answer3Label.TabIndex = 23;
            this.Answer3Label.Text = "Answer 3:";
            // 
            // Question3Box
            // 
            this.Question3Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Question3Box.FormattingEnabled = true;
            this.Question3Box.Location = new System.Drawing.Point(112, 470);
            this.Question3Box.Name = "Question3Box";
            this.Question3Box.Size = new System.Drawing.Size(370, 21);
            this.Question3Box.TabIndex = 11;
            this.Question3Box.TextChanged += new System.EventHandler(this.QuestionBox_TextChanged);
            // 
            // Question3Label
            // 
            this.Question3Label.AutoSize = true;
            this.Question3Label.Location = new System.Drawing.Point(19, 473);
            this.Question3Label.Name = "Question3Label";
            this.Question3Label.Size = new System.Drawing.Size(61, 13);
            this.Question3Label.TabIndex = 21;
            this.Question3Label.Text = "Question 3:";
            // 
            // Answer3Box
            // 
            this.Answer3Box.Location = new System.Drawing.Point(112, 496);
            this.Answer3Box.Name = "Answer3Box";
            this.Answer3Box.Size = new System.Drawing.Size(370, 20);
            this.Answer3Box.TabIndex = 12;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(19, 291);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.LastNameLabel.TabIndex = 27;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(112, 288);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(371, 20);
            this.LastNameBox.TabIndex = 4;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(19, 265);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.FirstNameLabel.TabIndex = 25;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(112, 262);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(371, 20);
            this.FirstNameBox.TabIndex = 3;
            // 
            // GradeBox
            // 
            this.GradeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GradeBox.FormattingEnabled = true;
            this.GradeBox.Location = new System.Drawing.Point(112, 340);
            this.GradeBox.Name = "GradeBox";
            this.GradeBox.Size = new System.Drawing.Size(371, 21);
            this.GradeBox.TabIndex = 6;
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Location = new System.Drawing.Point(19, 343);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(39, 13);
            this.GradeLabel.TabIndex = 28;
            this.GradeLabel.Text = "Grade:";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(495, 611);
            this.Controls.Add(this.GradeBox);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.Answer3Label);
            this.Controls.Add(this.Question3Box);
            this.Controls.Add(this.Question3Label);
            this.Controls.Add(this.Answer3Box);
            this.Controls.Add(this.Answer2Label);
            this.Controls.Add(this.Question2Box);
            this.Controls.Add(this.Question2Label);
            this.Controls.Add(this.Answer2Box);
            this.Controls.Add(this.Answer1Label);
            this.Controls.Add(this.Question1Box);
            this.Controls.Add(this.Question1Label);
            this.Controls.Add(this.Answer1Box);
            this.Controls.Add(this.StudentNumberLabel);
            this.Controls.Add(this.StudentNumberBox);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.FillOutFieldsLabel);
            this.Controls.Add(this.LogoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.Text = "FBLA CSA Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUp_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label FillOutFieldsLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button SettingsButton;
        public System.Windows.Forms.TextBox UserBox;
        public System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label StudentNumberLabel;
        public System.Windows.Forms.TextBox StudentNumberBox;
        private System.Windows.Forms.Label Question1Label;
        public System.Windows.Forms.TextBox Answer1Box;
        private System.Windows.Forms.ComboBox Question1Box;
        private System.Windows.Forms.Label Answer1Label;
        private System.Windows.Forms.Label Answer2Label;
        private System.Windows.Forms.ComboBox Question2Box;
        private System.Windows.Forms.Label Question2Label;
        public System.Windows.Forms.TextBox Answer2Box;
        private System.Windows.Forms.Label Answer3Label;
        private System.Windows.Forms.ComboBox Question3Box;
        private System.Windows.Forms.Label Question3Label;
        public System.Windows.Forms.TextBox Answer3Box;
        private System.Windows.Forms.Label LastNameLabel;
        public System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label FirstNameLabel;
        public System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.ComboBox GradeBox;
        private System.Windows.Forms.Label GradeLabel;
    }
}

