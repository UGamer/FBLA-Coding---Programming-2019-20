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
            this.label1 = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please sign in.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(75, 211);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(190, 20);
            this.UserBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(75, 237);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(190, 20);
            this.PassBox.TabIndex = 4;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(168, 315);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(97, 36);
            this.SignInButton.TabIndex = 6;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(22, 315);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(97, 36);
            this.SignUpButton.TabIndex = 7;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            // 
            // ForgotLabel
            // 
            this.ForgotLabel.AutoSize = true;
            this.ForgotLabel.LinkColor = System.Drawing.Color.Blue;
            this.ForgotLabel.Location = new System.Drawing.Point(72, 261);
            this.ForgotLabel.Name = "ForgotLabel";
            this.ForgotLabel.Size = new System.Drawing.Size(65, 13);
            this.ForgotLabel.TabIndex = 8;
            this.ForgotLabel.TabStop = true;
            this.ForgotLabel.Text = "Can\'t log-in?";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(22, 357);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(39, 36);
            this.SettingsButton.TabIndex = 9;
            this.SettingsButton.Text = "⚙";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // RememberBox
            // 
            this.RememberBox.AutoSize = true;
            this.RememberBox.Location = new System.Drawing.Point(22, 281);
            this.RememberBox.Name = "RememberBox";
            this.RememberBox.Size = new System.Drawing.Size(94, 17);
            this.RememberBox.TabIndex = 10;
            this.RememberBox.Text = "Remember me";
            this.RememberBox.UseVisualStyleBackColor = true;
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::CSA_Tracker_for_FBLA.Properties.Resources.logo;
            this.LogoBox.Location = new System.Drawing.Point(22, 12);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(243, 155);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(289, 406);
            this.Controls.Add(this.RememberBox);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ForgotLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoBox);
            this.Name = "Login";
            this.Text = "CSA Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.LinkLabel ForgotLabel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.CheckBox RememberBox;
    }
}

