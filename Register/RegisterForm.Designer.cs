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
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.ButtongroupBox = new System.Windows.Forms.GroupBox();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Registerbutton = new System.Windows.Forms.Button();
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
            this.RegistergroupBox.Controls.Add(this.UserNametextBox);
            this.RegistergroupBox.Controls.Add(this.UserNamelabel);
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
            // UserNametextBox
            // 
            this.UserNametextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNametextBox.ForeColor = System.Drawing.Color.Gray;
            this.UserNametextBox.Location = new System.Drawing.Point(107, 20);
            this.UserNametextBox.MaxLength = 25;
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(272, 21);
            this.UserNametextBox.TabIndex = 1;
            this.UserNametextBox.Tag = "";
            this.UserNametextBox.Text = "Example: Behfar or Ali Moradi";
            this.UserNametextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserNametextBox_MouseClick);
            this.UserNametextBox.TextChanged += new System.EventHandler(this.UserNametextBox_TextChanged);
            this.UserNametextBox.Enter += new System.EventHandler(this.UserNametextBox_Enter);
            this.UserNametextBox.Leave += new System.EventHandler(this.UserNametextBox_Leave);
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.Location = new System.Drawing.Point(4, 23);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(63, 13);
            this.UserNamelabel.TabIndex = 0;
            this.UserNamelabel.Text = "&User Name:";
            // 
            // ButtongroupBox
            // 
            this.ButtongroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtongroupBox.Controls.Add(this.Resetbutton);
            this.ButtongroupBox.Controls.Add(this.Exitbutton);
            this.ButtongroupBox.Controls.Add(this.Registerbutton);
            this.ButtongroupBox.Location = new System.Drawing.Point(12, 177);
            this.ButtongroupBox.Name = "ButtongroupBox";
            this.ButtongroupBox.Size = new System.Drawing.Size(387, 46);
            this.ButtongroupBox.TabIndex = 1;
            this.ButtongroupBox.TabStop = false;
            // 
            // Resetbutton
            // 
            this.Resetbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Resetbutton.Enabled = false;
            this.Resetbutton.Location = new System.Drawing.Point(147, 16);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(93, 23);
            this.Resetbutton.TabIndex = 11;
            this.Resetbutton.Text = "Re&set";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exitbutton.Location = new System.Drawing.Point(246, 16);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(93, 23);
            this.Exitbutton.TabIndex = 12;
            this.Exitbutton.Text = "E&xit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Registerbutton
            // 
            this.Registerbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Registerbutton.Enabled = false;
            this.Registerbutton.Location = new System.Drawing.Point(48, 16);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(93, 23);
            this.Registerbutton.TabIndex = 10;
            this.Registerbutton.Text = "&Register";
            this.Registerbutton.UseVisualStyleBackColor = true;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.Registerbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exitbutton;
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
        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.GroupBox ButtongroupBox;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Button Resetbutton;
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

