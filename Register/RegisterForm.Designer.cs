namespace Register
{
    partial class RegisterForm
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
			this.RegistergroupBox = new System.Windows.Forms.GroupBox();
			this.ConfirmPasswordtextBox = new System.Windows.Forms.TextBox();
			this.NewPasswordtextBox = new System.Windows.Forms.TextBox();
			this.ConfirmPasswordlabel = new System.Windows.Forms.Label();
			this.NewPasswordlabel = new System.Windows.Forms.Label();
			this.ConfirmaEmailtextBox = new System.Windows.Forms.TextBox();
			this.NewEmailtextBox = new System.Windows.Forms.TextBox();
			this.ConfirmEmaillabel = new System.Windows.Forms.Label();
			this.NewEmaillabel = new System.Windows.Forms.Label();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.ButtongroupBox = new System.Windows.Forms.GroupBox();
			this.resetButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.registerButton = new System.Windows.Forms.Button();
			this.RegistergroupBox.SuspendLayout();
			this.ButtongroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// RegistergroupBox
			// 
			this.RegistergroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RegistergroupBox.Controls.Add(this.ConfirmPasswordtextBox);
			this.RegistergroupBox.Controls.Add(this.NewPasswordtextBox);
			this.RegistergroupBox.Controls.Add(this.ConfirmPasswordlabel);
			this.RegistergroupBox.Controls.Add(this.NewPasswordlabel);
			this.RegistergroupBox.Controls.Add(this.ConfirmaEmailtextBox);
			this.RegistergroupBox.Controls.Add(this.NewEmailtextBox);
			this.RegistergroupBox.Controls.Add(this.ConfirmEmaillabel);
			this.RegistergroupBox.Controls.Add(this.NewEmaillabel);
			this.RegistergroupBox.Controls.Add(this.usernameTextBox);
			this.RegistergroupBox.Controls.Add(this.usernameLabel);
			this.RegistergroupBox.Location = new System.Drawing.Point(12, 11);
			this.RegistergroupBox.Name = "RegistergroupBox";
			this.RegistergroupBox.Size = new System.Drawing.Size(387, 160);
			this.RegistergroupBox.TabIndex = 0;
			this.RegistergroupBox.TabStop = false;
			this.RegistergroupBox.Text = "Register Box";
			// 
			// ConfirmPasswordtextBox
			// 
			this.ConfirmPasswordtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ConfirmPasswordtextBox.Location = new System.Drawing.Point(109, 128);
			this.ConfirmPasswordtextBox.MaxLength = 50;
			this.ConfirmPasswordtextBox.Name = "ConfirmPasswordtextBox";
			this.ConfirmPasswordtextBox.Size = new System.Drawing.Size(272, 21);
			this.ConfirmPasswordtextBox.TabIndex = 9;
			this.ConfirmPasswordtextBox.UseSystemPasswordChar = true;
			this.ConfirmPasswordtextBox.TextChanged += new System.EventHandler(this.ConfirmPasswordtextBox_TextChanged);
			// 
			// NewPasswordtextBox
			// 
			this.NewPasswordtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NewPasswordtextBox.Location = new System.Drawing.Point(109, 101);
			this.NewPasswordtextBox.MaxLength = 50;
			this.NewPasswordtextBox.Name = "NewPasswordtextBox";
			this.NewPasswordtextBox.Size = new System.Drawing.Size(272, 21);
			this.NewPasswordtextBox.TabIndex = 7;
			this.NewPasswordtextBox.UseSystemPasswordChar = true;
			this.NewPasswordtextBox.TextChanged += new System.EventHandler(this.NewPasswordtextBox_TextChanged);
			// 
			// ConfirmPasswordlabel
			// 
			this.ConfirmPasswordlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ConfirmPasswordlabel.AutoSize = true;
			this.ConfirmPasswordlabel.Location = new System.Drawing.Point(6, 131);
			this.ConfirmPasswordlabel.Name = "ConfirmPasswordlabel";
			this.ConfirmPasswordlabel.Size = new System.Drawing.Size(97, 13);
			this.ConfirmPasswordlabel.TabIndex = 8;
			this.ConfirmPasswordlabel.Text = "C&onfirm Password:";
			// 
			// NewPasswordlabel
			// 
			this.NewPasswordlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NewPasswordlabel.AutoSize = true;
			this.NewPasswordlabel.Location = new System.Drawing.Point(6, 104);
			this.NewPasswordlabel.Name = "NewPasswordlabel";
			this.NewPasswordlabel.Size = new System.Drawing.Size(81, 13);
			this.NewPasswordlabel.TabIndex = 6;
			this.NewPasswordlabel.Text = "New &Password:";
			// 
			// ConfirmaEmailtextBox
			// 
			this.ConfirmaEmailtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ConfirmaEmailtextBox.Location = new System.Drawing.Point(107, 74);
			this.ConfirmaEmailtextBox.MaxLength = 70;
			this.ConfirmaEmailtextBox.Name = "ConfirmaEmailtextBox";
			this.ConfirmaEmailtextBox.Size = new System.Drawing.Size(272, 21);
			this.ConfirmaEmailtextBox.TabIndex = 5;
			this.ConfirmaEmailtextBox.TextChanged += new System.EventHandler(this.ConfirmaEmailtextBox_TextChanged);
			// 
			// NewEmailtextBox
			// 
			this.NewEmailtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NewEmailtextBox.ForeColor = System.Drawing.Color.Gray;
			this.NewEmailtextBox.Location = new System.Drawing.Point(107, 47);
			this.NewEmailtextBox.MaxLength = 70;
			this.NewEmailtextBox.Name = "NewEmailtextBox";
			this.NewEmailtextBox.Size = new System.Drawing.Size(272, 21);
			this.NewEmailtextBox.TabIndex = 3;
			this.NewEmailtextBox.Text = "Example: Behfar.Baghovvat@Gmail.com";
			this.NewEmailtextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NewEmailtextBox_MouseClick);
			this.NewEmailtextBox.TextChanged += new System.EventHandler(this.NewEmailtextBox_TextChanged);
			this.NewEmailtextBox.Enter += new System.EventHandler(this.NewEmailtextBox_Enter);
			this.NewEmailtextBox.Leave += new System.EventHandler(this.NewEmailtextBox_Leave);
			// 
			// ConfirmEmaillabel
			// 
			this.ConfirmEmaillabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ConfirmEmaillabel.AutoSize = true;
			this.ConfirmEmaillabel.Location = new System.Drawing.Point(4, 77);
			this.ConfirmEmaillabel.Name = "ConfirmEmaillabel";
			this.ConfirmEmaillabel.Size = new System.Drawing.Size(75, 13);
			this.ConfirmEmaillabel.TabIndex = 4;
			this.ConfirmEmaillabel.Text = "&Confirm Email:";
			// 
			// NewEmaillabel
			// 
			this.NewEmaillabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NewEmaillabel.AutoSize = true;
			this.NewEmaillabel.Location = new System.Drawing.Point(4, 50);
			this.NewEmaillabel.Name = "NewEmaillabel";
			this.NewEmaillabel.Size = new System.Drawing.Size(59, 13);
			this.NewEmaillabel.TabIndex = 2;
			this.NewEmaillabel.Text = "New &Email:";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.ForeColor = System.Drawing.Color.Gray;
			this.usernameTextBox.Location = new System.Drawing.Point(107, 20);
			this.usernameTextBox.MaxLength = 25;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(272, 21);
			this.usernameTextBox.TabIndex = 1;
			this.usernameTextBox.Tag = "";
			this.usernameTextBox.Text = "Example: Behfar or Ali Moradi";
			this.usernameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserNametextBox_MouseClick);
			this.usernameTextBox.TextChanged += new System.EventHandler(this.UserNametextBox_TextChanged);
			this.usernameTextBox.Enter += new System.EventHandler(this.UserNametextBox_Enter);
			this.usernameTextBox.Leave += new System.EventHandler(this.UserNametextBox_Leave);
			// 
			// usernameLabel
			// 
			this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(4, 23);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(63, 13);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "&User Name:";
			// 
			// ButtongroupBox
			// 
			this.ButtongroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtongroupBox.Controls.Add(this.resetButton);
			this.ButtongroupBox.Controls.Add(this.exitButton);
			this.ButtongroupBox.Controls.Add(this.registerButton);
			this.ButtongroupBox.Location = new System.Drawing.Point(12, 177);
			this.ButtongroupBox.Name = "ButtongroupBox";
			this.ButtongroupBox.Size = new System.Drawing.Size(387, 46);
			this.ButtongroupBox.TabIndex = 1;
			this.ButtongroupBox.TabStop = false;
			// 
			// resetButton
			// 
			this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.resetButton.Enabled = false;
			this.resetButton.Location = new System.Drawing.Point(147, 16);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(93, 23);
			this.resetButton.TabIndex = 11;
			this.resetButton.Text = "Re&set";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.Resetbutton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exitButton.Location = new System.Drawing.Point(246, 16);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(93, 23);
			this.exitButton.TabIndex = 12;
			this.exitButton.Text = "E&xit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.Exitbutton_Click);
			// 
			// registerButton
			// 
			this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.registerButton.Enabled = false;
			this.registerButton.Location = new System.Drawing.Point(48, 16);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(93, 23);
			this.registerButton.TabIndex = 10;
			this.registerButton.Text = "&Register";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.Registerbutton_Click);
			// 
			// RegisterForm
			// 
			this.AcceptButton = this.registerButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.exitButton;
			this.ClientSize = new System.Drawing.Size(411, 231);
			this.Controls.Add(this.ButtongroupBox);
			this.Controls.Add(this.RegistergroupBox);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register";
			this.RegistergroupBox.ResumeLayout(false);
			this.RegistergroupBox.PerformLayout();
			this.ButtongroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RegistergroupBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.GroupBox ButtongroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox ConfirmaEmailtextBox;
        private System.Windows.Forms.TextBox NewEmailtextBox;
        private System.Windows.Forms.Label ConfirmEmaillabel;
        private System.Windows.Forms.Label NewEmaillabel;
        private System.Windows.Forms.TextBox ConfirmPasswordtextBox;
        private System.Windows.Forms.TextBox NewPasswordtextBox;
        private System.Windows.Forms.Label ConfirmPasswordlabel;
        private System.Windows.Forms.Label NewPasswordlabel;
    }
}

