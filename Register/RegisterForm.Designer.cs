namespace Register
{
    partial class registerForm
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
            this.registerGroupBox = new System.Windows.Forms.GroupBox();
            this.confrirmemailaddressTextBox = new System.Windows.Forms.TextBox();
            this.emailaddressTextBox = new System.Windows.Forms.TextBox();
            this.confirmemailaddressLabel = new System.Windows.Forms.Label();
            this.emailaddressLabel = new System.Windows.Forms.Label();
            this.confirmpasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmpasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerGroupBox.SuspendLayout();
            this.buttonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerGroupBox
            // 
            this.registerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.registerGroupBox.Controls.Add(this.confrirmemailaddressTextBox);
            this.registerGroupBox.Controls.Add(this.emailaddressTextBox);
            this.registerGroupBox.Controls.Add(this.confirmemailaddressLabel);
            this.registerGroupBox.Controls.Add(this.emailaddressLabel);
            this.registerGroupBox.Controls.Add(this.confirmpasswordTextBox);
            this.registerGroupBox.Controls.Add(this.passwordTextBox);
            this.registerGroupBox.Controls.Add(this.confirmpasswordLabel);
            this.registerGroupBox.Controls.Add(this.passwordLabel);
            this.registerGroupBox.Controls.Add(this.usernameTextBox);
            this.registerGroupBox.Controls.Add(this.usernameLabel);
            this.registerGroupBox.Location = new System.Drawing.Point(12, 11);
            this.registerGroupBox.Name = "registerGroupBox";
            this.registerGroupBox.Size = new System.Drawing.Size(422, 160);
            this.registerGroupBox.TabIndex = 0;
            this.registerGroupBox.TabStop = false;
            this.registerGroupBox.Text = "Register Box";
            // 
            // confrirmemailaddressTextBox
            // 
            this.confrirmemailaddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.confrirmemailaddressTextBox.Location = new System.Drawing.Point(127, 128);
            this.confrirmemailaddressTextBox.MaxLength = 70;
            this.confrirmemailaddressTextBox.Name = "confrirmemailaddressTextBox";
            this.confrirmemailaddressTextBox.Size = new System.Drawing.Size(283, 21);
            this.confrirmemailaddressTextBox.TabIndex = 9;
            this.confrirmemailaddressTextBox.TextChanged += new System.EventHandler(this.confrirmemailaddressTextBox_TextChanged);
            // 
            // emailaddressTextBox
            // 
            this.emailaddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.emailaddressTextBox.ForeColor = System.Drawing.Color.Gray;
            this.emailaddressTextBox.Location = new System.Drawing.Point(127, 101);
            this.emailaddressTextBox.MaxLength = 70;
            this.emailaddressTextBox.Name = "emailaddressTextBox";
            this.emailaddressTextBox.Size = new System.Drawing.Size(283, 21);
            this.emailaddressTextBox.TabIndex = 7;
            this.emailaddressTextBox.Text = "Example: Behfar.Baghovvat@Gmail.com";
            this.emailaddressTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.emailaddressTextBox_MouseClick);
            this.emailaddressTextBox.TextChanged += new System.EventHandler(this.emailaddressTextBox_TextChanged);
            this.emailaddressTextBox.Enter += new System.EventHandler(this.emailaddressTextBox_Enter);
            this.emailaddressTextBox.Leave += new System.EventHandler(this.emailaddressTextBox_Leave);
            // 
            // confirmemailaddressLabel
            // 
            this.confirmemailaddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmemailaddressLabel.AutoSize = true;
            this.confirmemailaddressLabel.Location = new System.Drawing.Point(4, 131);
            this.confirmemailaddressLabel.Name = "confirmemailaddressLabel";
            this.confirmemailaddressLabel.Size = new System.Drawing.Size(117, 13);
            this.confirmemailaddressLabel.TabIndex = 8;
            this.confirmemailaddressLabel.Text = "&Confirm Email Address:";
            // 
            // emailaddressLabel
            // 
            this.emailaddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailaddressLabel.AutoSize = true;
            this.emailaddressLabel.Location = new System.Drawing.Point(4, 104);
            this.emailaddressLabel.Name = "emailaddressLabel";
            this.emailaddressLabel.Size = new System.Drawing.Size(77, 13);
            this.emailaddressLabel.TabIndex = 6;
            this.emailaddressLabel.Text = "&Email Address:";
            // 
            // confirmpasswordTextBox
            // 
            this.confirmpasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.confirmpasswordTextBox.Location = new System.Drawing.Point(127, 74);
            this.confirmpasswordTextBox.MaxLength = 40;
            this.confirmpasswordTextBox.Name = "confirmpasswordTextBox";
            this.confirmpasswordTextBox.Size = new System.Drawing.Size(283, 21);
            this.confirmpasswordTextBox.TabIndex = 5;
            this.confirmpasswordTextBox.UseSystemPasswordChar = true;
            this.confirmpasswordTextBox.TextChanged += new System.EventHandler(this.confirmpasswordTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.passwordTextBox.Location = new System.Drawing.Point(127, 47);
            this.passwordTextBox.MaxLength = 40;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(283, 21);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // confirmpasswordLabel
            // 
            this.confirmpasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmpasswordLabel.AutoSize = true;
            this.confirmpasswordLabel.Location = new System.Drawing.Point(4, 77);
            this.confirmpasswordLabel.Name = "confirmpasswordLabel";
            this.confirmpasswordLabel.Size = new System.Drawing.Size(97, 13);
            this.confirmpasswordLabel.TabIndex = 4;
            this.confirmpasswordLabel.Text = "C&onfirm Password:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(4, 50);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = " &Password:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.usernameTextBox.Location = new System.Drawing.Point(127, 20);
            this.usernameTextBox.MaxLength = 20;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(283, 21);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Tag = "";
            this.usernameTextBox.Text = "Example: Behfar or Ali Moradi";
            this.usernameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernameTextBox_MouseClick);
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(4, 23);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(59, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "&Username:";
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGroupBox.Controls.Add(this.resetButton);
            this.buttonGroupBox.Controls.Add(this.exitButton);
            this.buttonGroupBox.Controls.Add(this.registerButton);
            this.buttonGroupBox.Location = new System.Drawing.Point(12, 177);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Size = new System.Drawing.Size(422, 42);
            this.buttonGroupBox.TabIndex = 1;
            this.buttonGroupBox.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(165, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(93, 23);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Re&set";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(264, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Enabled = false;
            this.registerButton.Location = new System.Drawing.Point(66, 12);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(93, 23);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "&Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerForm
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(444, 231);
            this.Controls.Add(this.buttonGroupBox);
            this.Controls.Add(this.registerGroupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximumSize = new System.Drawing.Size(460, 270);
            this.MinimumSize = new System.Drawing.Size(460, 270);
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.registerGroupBox.ResumeLayout(false);
            this.registerGroupBox.PerformLayout();
            this.buttonGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registerGroupBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.GroupBox buttonGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox confirmpasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label confirmpasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox confrirmemailaddressTextBox;
        private System.Windows.Forms.TextBox emailaddressTextBox;
        private System.Windows.Forms.Label confirmemailaddressLabel;
        private System.Windows.Forms.Label emailaddressLabel;
    }
}

