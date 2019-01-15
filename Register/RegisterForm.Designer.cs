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
            this.RegistergroupBox1 = new System.Windows.Forms.GroupBox();
            this.ConfirmPasswordtextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordtextBox = new System.Windows.Forms.TextBox();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordlabel = new System.Windows.Forms.Label();
            this.NewPasswordlabel = new System.Windows.Forms.Label();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.ButtongroupBox1 = new System.Windows.Forms.GroupBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.RegistergroupBox1.SuspendLayout();
            this.ButtongroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistergroupBox1
            // 
            this.RegistergroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistergroupBox1.Controls.Add(this.ConfirmPasswordtextBox);
            this.RegistergroupBox1.Controls.Add(this.NewPasswordtextBox);
            this.RegistergroupBox1.Controls.Add(this.UserNametextBox);
            this.RegistergroupBox1.Controls.Add(this.ConfirmPasswordlabel);
            this.RegistergroupBox1.Controls.Add(this.NewPasswordlabel);
            this.RegistergroupBox1.Controls.Add(this.UserNamelabel);
            this.RegistergroupBox1.Location = new System.Drawing.Point(12, 12);
            this.RegistergroupBox1.Name = "RegistergroupBox1";
            this.RegistergroupBox1.Size = new System.Drawing.Size(305, 108);
            this.RegistergroupBox1.TabIndex = 0;
            this.RegistergroupBox1.TabStop = false;
            this.RegistergroupBox1.Text = "Register Box";
            // 
            // ConfirmPasswordtextBox
            // 
            this.ConfirmPasswordtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmPasswordtextBox.Location = new System.Drawing.Point(109, 74);
            this.ConfirmPasswordtextBox.MaxLength = 50;
            this.ConfirmPasswordtextBox.Name = "ConfirmPasswordtextBox";
            this.ConfirmPasswordtextBox.Size = new System.Drawing.Size(190, 21);
            this.ConfirmPasswordtextBox.TabIndex = 5;
            this.ConfirmPasswordtextBox.UseSystemPasswordChar = true;
            this.ConfirmPasswordtextBox.TextChanged += new System.EventHandler(this.ConfirmPasswordtextBox_TextChanged);
            this.ConfirmPasswordtextBox.Leave += new System.EventHandler(this.ConfirmPasswordtextBox_Leave);
            // 
            // NewPasswordtextBox
            // 
            this.NewPasswordtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPasswordtextBox.Location = new System.Drawing.Point(109, 47);
            this.NewPasswordtextBox.MaxLength = 50;
            this.NewPasswordtextBox.Name = "NewPasswordtextBox";
            this.NewPasswordtextBox.Size = new System.Drawing.Size(190, 21);
            this.NewPasswordtextBox.TabIndex = 3;
            this.NewPasswordtextBox.UseSystemPasswordChar = true;
            this.NewPasswordtextBox.Leave += new System.EventHandler(this.NewPasswordtextBox_Leave);
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNametextBox.Location = new System.Drawing.Point(109, 20);
            this.UserNametextBox.MaxLength = 25;
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(190, 21);
            this.UserNametextBox.TabIndex = 1;
            this.UserNametextBox.TextChanged += new System.EventHandler(this.UserNametextBox_TextChanged);
            this.UserNametextBox.Leave += new System.EventHandler(this.UserNametextBox_Leave);
            // 
            // ConfirmPasswordlabel
            // 
            this.ConfirmPasswordlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmPasswordlabel.AutoSize = true;
            this.ConfirmPasswordlabel.Location = new System.Drawing.Point(6, 77);
            this.ConfirmPasswordlabel.Name = "ConfirmPasswordlabel";
            this.ConfirmPasswordlabel.Size = new System.Drawing.Size(97, 13);
            this.ConfirmPasswordlabel.TabIndex = 4;
            this.ConfirmPasswordlabel.Text = "&Confirm Password:";
            // 
            // NewPasswordlabel
            // 
            this.NewPasswordlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPasswordlabel.AutoSize = true;
            this.NewPasswordlabel.Location = new System.Drawing.Point(6, 50);
            this.NewPasswordlabel.Name = "NewPasswordlabel";
            this.NewPasswordlabel.Size = new System.Drawing.Size(81, 13);
            this.NewPasswordlabel.TabIndex = 2;
            this.NewPasswordlabel.Text = "New &Password:";
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.Location = new System.Drawing.Point(6, 23);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(63, 13);
            this.UserNamelabel.TabIndex = 0;
            this.UserNamelabel.Text = "&User Name:";
            // 
            // ButtongroupBox1
            // 
            this.ButtongroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtongroupBox1.Controls.Add(this.Resetbutton);
            this.ButtongroupBox1.Controls.Add(this.Exitbutton);
            this.ButtongroupBox1.Controls.Add(this.Registerbutton);
            this.ButtongroupBox1.Location = new System.Drawing.Point(12, 126);
            this.ButtongroupBox1.Name = "ButtongroupBox1";
            this.ButtongroupBox1.Size = new System.Drawing.Size(305, 46);
            this.ButtongroupBox1.TabIndex = 1;
            this.ButtongroupBox1.TabStop = false;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitbutton.Location = new System.Drawing.Point(206, 16);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(93, 23);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "E&xit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Registerbutton
            // 
            this.Registerbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Registerbutton.Enabled = false;
            this.Registerbutton.Location = new System.Drawing.Point(8, 16);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(93, 23);
            this.Registerbutton.TabIndex = 0;
            this.Registerbutton.Text = "&Register";
            this.Registerbutton.UseVisualStyleBackColor = true;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Resetbutton.Enabled = false;
            this.Resetbutton.Location = new System.Drawing.Point(107, 16);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(93, 23);
            this.Resetbutton.TabIndex = 1;
            this.Resetbutton.Text = "Re&set";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.Registerbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exitbutton;
            this.ClientSize = new System.Drawing.Size(329, 182);
            this.Controls.Add(this.ButtongroupBox1);
            this.Controls.Add(this.RegistergroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.RegistergroupBox1.ResumeLayout(false);
            this.RegistergroupBox1.PerformLayout();
            this.ButtongroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RegistergroupBox1;
        private System.Windows.Forms.TextBox ConfirmPasswordtextBox;
        private System.Windows.Forms.TextBox NewPasswordtextBox;
        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.Label ConfirmPasswordlabel;
        private System.Windows.Forms.Label NewPasswordlabel;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.GroupBox ButtongroupBox1;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Button Resetbutton;
    }
}

