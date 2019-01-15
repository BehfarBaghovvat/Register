using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Resetbutton_Click(object sender, EventArgs e)
        {

            Resetbutton.Enabled = false;
            UserNametextBox.Text = string.Empty;
            UserNametextBox.Focus();            

            NewPasswordtextBox.Text = string.Empty;
            

            ConfirmPasswordtextBox.Text = string.Empty;
            
        }

        private void UserNametextBox_Leave(object sender, EventArgs e)
        {
            if (UserNametextBox.Text==string.Empty)
            {
                MessageBox.Show("Please enter name for [USER ACCOUNT]...! ");
                UserNametextBox.Focus();
            }
        }

        private void NewPasswordtextBox_Leave(object sender, EventArgs e)
        {
            if (NewPasswordtextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter new password...!");
                NewPasswordtextBox.Focus();
            }
        }

        private void ConfirmPasswordtextBox_Leave(object sender, EventArgs e)
        {
            if (ConfirmPasswordtextBox.Text == string.Empty)
            {
                MessageBox.Show("Please confirm the password...!");
                ConfirmPasswordtextBox.Focus();
            }
            
        }

        private void ConfirmPasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            if (ConfirmPasswordtextBox.Text !=string.Empty)
            {
                Registerbutton.Enabled = true;
            }
            else
            {
                Registerbutton.Enabled = false;
            }


            
                   
        }

        private void UserNametextBox_TextChanged(object sender, EventArgs e)
        {
            if (UserNametextBox.Text != string.Empty)
            {
                Resetbutton.Enabled = true;
            }
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            if (ConfirmPasswordtextBox.Text == NewPasswordtextBox.Text)
            {
                ConfirmPasswordtextBox.BackColor = SystemColors.Window;
                MessageBox.Show("Registration completed...");                
            }
            else
            {

                MessageBox.Show("Passwords do not match. Please try again.");

                ConfirmPasswordtextBox.BackColor = Color.Salmon;
                ConfirmPasswordtextBox.Focus();
            }
        }
    }
}
