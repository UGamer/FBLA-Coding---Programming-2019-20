namespace CSA_Tracker_for_FBLA
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PleaseSignInLabel = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.ForgotLabel = new System.Windows.Forms.LinkLabel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.RememberBox = new System.Windows.Forms.CheckBox();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PleaseSignInLabel
            // 
            this.PleaseSignInLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PleaseSignInLabel.AutoSize = true;
            this.PleaseSignInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PleaseSignInLabel.Location = new System.Drawing.Point(160, 335);
            this.PleaseSignInLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PleaseSignInLabel.Name = "PleaseSignInLabel";
            this.PleaseSignInLabel.Size = new System.Drawing.Size(267, 44);
            this.PleaseSignInLabel.TabIndex = 1;
            this.PleaseSignInLabel.Text = "Please sign in.";
            this.PleaseSignInLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserBox
            // 
            this.UserBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserBox.Location = new System.Drawing.Point(150, 406);
            this.UserBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(376, 31);
            this.UserBox.TabIndex = 2;
            this.UserBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserBox_KeyDown);
            // 
            // UserLabel
            // 
            this.UserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(38, 412);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(63, 25);
            this.UserLabel.TabIndex = 3;
            this.UserLabel.Text = "User:";
            // 
            // PassLabel
            // 
            this.PassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(38, 462);
            this.PassLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(112, 25);
            this.PassLabel.TabIndex = 5;
            this.PassLabel.Text = "Password:";
            // 
            // PassBox
            // 
            this.PassBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassBox.Location = new System.Drawing.Point(150, 456);
            this.PassBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(376, 31);
            this.PassBox.TabIndex = 4;
            this.PassBox.UseSystemPasswordChar = true;
            this.PassBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassBox_KeyDown);
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SignInButton.Location = new System.Drawing.Point(336, 606);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(194, 69);
            this.SignInButton.TabIndex = 6;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SignUpButton.Location = new System.Drawing.Point(44, 606);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(194, 69);
            this.SignUpButton.TabIndex = 7;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // ForgotLabel
            // 
            this.ForgotLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ForgotLabel.AutoSize = true;
            this.ForgotLabel.LinkColor = System.Drawing.Color.DodgerBlue;
            this.ForgotLabel.Location = new System.Drawing.Point(144, 502);
            this.ForgotLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ForgotLabel.Name = "ForgotLabel";
            this.ForgotLabel.Size = new System.Drawing.Size(131, 25);
            this.ForgotLabel.TabIndex = 8;
            this.ForgotLabel.TabStop = true;
            this.ForgotLabel.Text = "Can\'t log in?";
            this.ForgotLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotLabel_LinkClicked);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(44, 687);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(78, 69);
            this.SettingsButton.TabIndex = 9;
            this.SettingsButton.Text = "⚙";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // RememberBox
            // 
            this.RememberBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RememberBox.AutoSize = true;
            this.RememberBox.Location = new System.Drawing.Point(44, 540);
            this.RememberBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RememberBox.Name = "RememberBox";
            this.RememberBox.Size = new System.Drawing.Size(183, 29);
            this.RememberBox.TabIndex = 10;
            this.RememberBox.Text = "Remember me";
            this.RememberBox.UseVisualStyleBackColor = true;
            // 
            // LogoBox
            // 
            this.LogoBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogoBox.Image = global::CSA_Tracker_for_FBLA.Properties.Resources.logo;
            this.LogoBox.Location = new System.Drawing.Point(44, 23);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(486, 298);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(578, 781);
            this.Controls.Add(this.RememberBox);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ForgotLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.PleaseSignInLabel);
            this.Controls.Add(this.LogoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Login";
            this.Text = "FBLA CSA Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label PleaseSignInLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.LinkLabel ForgotLabel;
        private System.Windows.Forms.Button SettingsButton;
        public System.Windows.Forms.CheckBox RememberBox;
        public System.Windows.Forms.TextBox UserBox;
        public System.Windows.Forms.TextBox PassBox;
    }
}

