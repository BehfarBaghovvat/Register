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
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        #region Variable

        DialogResult resultDialog;
        bool emailaddressBool1, emailaddressBool2, confirmemailaddressBool1, confirmemailaddressBool2;
        
        #endregion /Variable

        #region Username

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Example: Behfar or Ali Moradi")
            {
                usernameTextBox.Text = string.Empty;
            }

        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            //------------------------------------------------------------------------------------
            //-----If the condition is set, the control settings return to the default state------
            //------------------------------------------------------------------------------------

            if (usernameTextBox.Text == string.Empty ||
                usernameTextBox.Text == "Example: Behfar or Ali Moradi")
            {
                usernameTextBox.Text = "Example: Behfar or Ali Moradi";
                usernameTextBox.ForeColor = Color.Gray;
            }

        }         

        private void usernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (usernameTextBox.Text == "Example: Behfar or Ali Moradi")
            {
                usernameTextBox.Text = string.Empty;
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            //------------------------------------------------------------------------------------
            //----------The condition for activating or deactivating the button is reset----------
            //------------------------------------------------------------------------------------

            if ((usernameTextBox.Text != "Example: Behfar or Ali Moradi" &&
                usernameTextBox.Text != string.Empty) ||
                (emailaddressTextBox.Text != "Example: Behfar.Baghovvat@Gmail.com" &&
                emailaddressTextBox.Text != string.Empty))
            {
                usernameTextBox.ForeColor = SystemColors.WindowText;
                resetButton.Enabled = true;
            }
            else
            {

                resetButton.Enabled = false;
            }

        }

        #endregion /Username

        #region Password

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            //--------------------------------------------------------------------------
            //-----The condition for activating or deactivating the button is reset-----
            //--------------------------------------------------------------------------

            if (passwordTextBox.Text != string.Empty)
            {
                resetButton.Enabled = true;
            }
            else
            {
                resetButton.Enabled = false;
            }

        }        

        #endregion /Password

        #region Confirm Password

        private void confirmpasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            //----------The condition for activating or deactivating the button is reset

            if (confirmpasswordTextBox.Text != string.Empty)
            {
                resetButton.Enabled = true;
            }
            else
            {
                resetButton.Enabled = false;
            }

            //-------The condition for activating or deactivating the registration button

            if ((usernameTextBox.Text != "Example: Behfar or Ali Moradi" &&
                usernameTextBox.Text != string.Empty) ||
                (emailaddressTextBox.Text != "Example: Behfar.Baghovvat@Gmail.com" &&
                emailaddressTextBox.Text != string.Empty) &&
                confrirmemailaddressTextBox.Text != string.Empty &&
                emailaddressTextBox.Text != string.Empty &&
                confirmpasswordTextBox.Text != string.Empty)
            {
                registerButton.Enabled = true;
            }
            else
            {
                registerButton.Enabled = false;
            }

        }

        

        #endregion /Confirm Password

        #region Email Address        

        private void emailaddressTextBox_Enter(object sender, EventArgs e)
        {
            if (emailaddressTextBox.Text == "Example: Behfar.Baghovvat@Gmail.com")
            {
                emailaddressTextBox.Text = string.Empty;
            }

        }        

        private void emailaddressTextBox_Leave(object sender, EventArgs e)
        {
            //---------------------------------------------------------------------------------
            //----If the condition is set, the control settings return to the default state----
            //---------------------------------------------------------------------------------

            if (emailaddressTextBox.Text == string.Empty ||
                emailaddressTextBox.Text == "Example: Behfar.Baghovvat@Gmail.com")
            {
                emailaddressTextBox.Text = "Example: Behfar.Baghovvat@Gmail.com";
                emailaddressTextBox.ForeColor = Color.Gray;
            }

            //------------------------------------------------------------
            //---------------------Check email format.--------------------
            //------------------------------------------------------------

            emailaddressBool1 = (emailaddressTextBox.Text).Contains('@');
            emailaddressBool2 = (emailaddressTextBox.Text).EndsWith(".com");

            if (emailaddressBool1 == false || emailaddressBool2 == false)
            {
                resultDialog = MessageBox.Show
                     (text: "The type of email template is not correct. Please re-enter the correct email.",
                     caption: "Not correct",
                     buttons: MessageBoxButtons.OK,
                     icon: MessageBoxIcon.Error);

                if (resultDialog == DialogResult.OK)
                {
                    emailaddressTextBox.BackColor = Color.Salmon;
                    emailaddressTextBox.Focus();
                    emailaddressTextBox.SelectAll();
                }
            }
            else
            {
                emailaddressTextBox.BackColor = SystemColors.Window;
            }

        }        

        private void emailaddressTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (emailaddressTextBox.Text == "Example: Behfar.Baghovvat@Gmail.com")
            {
                emailaddressTextBox.Text = string.Empty;
            }

        }       

        private void emailaddressTextBox_TextChanged(object sender, EventArgs e)
        {
            emailaddressTextBox.ForeColor = SystemColors.WindowText;
            //--------------------------------------------------------------------------
            //-----The condition for activating or deactivating the button is reset-----
            //--------------------------------------------------------------------------

            if ((emailaddressTextBox.Text != "Example: Behfar.Baghovvat@Gmail.com" &&
                emailaddressTextBox.Text != string.Empty) || (
                usernameTextBox.Text != "Example: Behfar or Ali Moradi" &&
                usernameTextBox.Text != string.Empty))
            {
                emailaddressTextBox.ForeColor = SystemColors.WindowText;
                resetButton.Enabled = true;
            }
            else
            {
                resetButton.Enabled = false;
            }

        }

        #endregion /Email Address

        #region Confirm Email Address

        private void confrirmemailaddressTextBox_TextChanged(object sender, EventArgs e)
        {
            //--------------------------------------------------------------------------
            //-----The condition for activating or deactivating the button is reset-----
            //--------------------------------------------------------------------------
            if (confrirmemailaddressTextBox.Text != string.Empty)
            {
                resetButton.Enabled = true;
            }
            else
            {
                resetButton.Enabled = false;
            }
        }

        #endregion /Confirm Email Address

        #region Register

        private void registerButton_Click(object sender, EventArgs e)
        {
            //---------------------------------------------------------
            //---Check all box controls to confirm the registration!---
            //---------------------------------------------------------
            if ((usernameTextBox.Text != "Example: Behfar or Ali Moradi" ||
                usernameTextBox.Text != string.Empty)
                && confirmpasswordTextBox.Text == passwordTextBox.Text &&
                confrirmemailaddressTextBox.Text == emailaddressTextBox.Text)
            {

                usernameTextBox.BackColor = SystemColors.Window;
                emailaddressTextBox.BackColor = SystemColors.Window;
                confrirmemailaddressTextBox.BackColor = SystemColors.Window;
                passwordTextBox.BackColor = SystemColors.Window;
                confirmpasswordTextBox.BackColor = SystemColors.Window;
                MessageBox.Show(text:"Registration completed...",
                    caption: "Sign up confirmation",
                    buttons:MessageBoxButtons.OK,
                    icon:MessageBoxIcon.Information);
            }            

            //---------------------------------------------------------
            //--------------Checking one's password!-------------------
            //---------------------------------------------------------

            else if (confirmpasswordTextBox.Text != passwordTextBox.Text)
            {

                MessageBox.Show(text:"Passwords do not match. Please try again.",
                    caption:"Error Match",
                    buttons:MessageBoxButtons.OK,
                    icon:MessageBoxIcon.Error);

                confirmpasswordTextBox.BackColor = Color.Salmon;
                confirmpasswordTextBox.Focus();
            }            

            //---------------------------------------------------------
            //-------------------Check Email One!----------------------
            //---------------------------------------------------------

            else if (confrirmemailaddressTextBox.Text != emailaddressTextBox.Text)
            {
                MessageBox.Show("E-Mail do not match. Please try again.");

                confrirmemailaddressTextBox.BackColor = Color.Salmon;
                confrirmemailaddressTextBox.Focus();
            }
            else
            {
                confirmpasswordTextBox.BackColor = SystemColors.Window;
                confrirmemailaddressTextBox.BackColor = SystemColors.Window;
            }

        }

        #endregion /Register

        #region Reset
        private void resetButton_Click(object sender, EventArgs e)
        {
            //--------------------------------------------------------------------------------------
            //-----------Clear all text box controls and return to the original state---------------
            //--------------------------------------------------------------------------------------

            resetButton.Enabled = false;

            usernameTextBox.Text = "Example: Behfar or Ali Moradi";
            usernameTextBox.ForeColor = Color.Gray;

            emailaddressTextBox.Text = "Example: Behfar.Baghovvat@Gmail.com";
            emailaddressTextBox.ForeColor = Color.Gray;

            confrirmemailaddressTextBox.Text = string.Empty;

            passwordTextBox.Text = string.Empty;

            confirmpasswordTextBox.Text = string.Empty;

        }
        #endregion /Reset

        #region Exit

        private void exitButton_Click(object sender, EventArgs e)
        {
            //---------------------------------------------------------
            //----------------Message for exit...!---------------------
            //---------------------------------------------------------
            resultDialog = MessageBox.Show
                 (text: "Are you sure you want to leave?",
                 caption: "Exit",
                 buttons: MessageBoxButtons.YesNo,
                 icon: MessageBoxIcon.Hand,
                 defaultButton: MessageBoxDefaultButton.Button2);

            if (resultDialog == DialogResult.Yes)
            {
                //-----------------Exit Application--------------------
                System.Windows.Forms.Application.Exit();
            }
        }

        #endregion /Exit







    }
}
