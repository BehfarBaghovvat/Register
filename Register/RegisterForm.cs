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
        bool NewEmailbool1, NewEmailbool2, ConfirmEmailbool1, ConfirmEmailbool2;
        DialogResult dialogResult;


        public RegisterForm()
        {
            InitializeComponent();
        }        

        private void UserNametextBox_Enter(object sender, EventArgs e)
        {
            if (UserNametextBox.Text== "Example: Behfar or Ali Moradi")
            {
                UserNametextBox.Text = string.Empty; 
            }
        }

        private void UserNametextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (UserNametextBox.Text == "Example: Behfar or Ali Moradi")
            {
                UserNametextBox.Text = string.Empty;
            }
        }

        private void UserNametextBox_Leave(object sender, EventArgs e)
        {

            //------------------------------------------------------------------------------------
            //-----If the condition is set, the control settings return to the default state------
            //------------------------------------------------------------------------------------

            if (UserNametextBox.Text == string.Empty ||
                UserNametextBox.Text == "Example: Behfar or Ali Moradi")
            {
                UserNametextBox.Text = "Example: Behfar or Ali Moradi";
                UserNametextBox.ForeColor = Color.Gray;
            }
        }       

        private void UserNametextBox_TextChanged(object sender, EventArgs e)
        {
            UserNametextBox.ForeColor = SystemColors.WindowText;
            
            //------------------------------------------------------------------------------------
            //----------The condition for activating or deactivating the button is reset----------
            //------------------------------------------------------------------------------------

            if ((UserNametextBox.Text != "Example: Behfar or Ali Moradi" &&
                UserNametextBox.Text != string.Empty)||
                (NewEmailtextBox.Text != "Example: Behfar.Baghovvat@Gmail.com" &&
                NewEmailtextBox.Text != string.Empty))
            {
                UserNametextBox.ForeColor = SystemColors.WindowText;
                Resetbutton.Enabled = true;
            }
            else
            {
                
                Resetbutton.Enabled = false;
            }
        }               

        private void NewEmailtextBox_Enter(object sender, EventArgs e)
        {
            if (NewEmailtextBox.Text == "Example: Behfar.Baghovvat@Gmail.com")
            {
                NewEmailtextBox.Text = string.Empty;
            }
            
        }

        private void NewEmailtextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (NewEmailtextBox.Text == "Example: Behfar.Baghovvat@Gmail.com")
            {
                NewEmailtextBox.Text = string.Empty;
            }
        }

        private void NewEmailtextBox_Leave(object sender, EventArgs e)
        {

            //---------------------------------------------------------------------------------
            //----If the condition is set, the control settings return to the default state----
            //---------------------------------------------------------------------------------

            if (NewEmailtextBox.Text == string.Empty ||
                NewEmailtextBox.Text == "Example: Behfar.Baghovvat@Gmail.com")
            {
                NewEmailtextBox.Text = "Example: Behfar.Baghovvat@Gmail.com";
                NewEmailtextBox.ForeColor = Color.Gray;
            }

            //------------------------------------------------------------
            //---------------------Check email format.--------------------
            //------------------------------------------------------------

            NewEmailbool1 = (NewEmailtextBox.Text).Contains('@');
            NewEmailbool2 = (NewEmailtextBox.Text).EndsWith(".com");

            if (NewEmailbool1 == false || NewEmailbool2 == false)
            {
                dialogResult = MessageBox.Show
                     ("The type of email template is not correct. Please re-enter the correct email.", "", MessageBoxButtons.OK);

                if (dialogResult == DialogResult.OK)
                {
                    NewEmailtextBox.BackColor = Color.Salmon;
                    NewEmailtextBox.Focus();
                    NewEmailtextBox.SelectAll();
                }
            }
            else
            {
                NewEmailtextBox.BackColor = SystemColors.Window;
            }


        }

        private void NewEmailtextBox_TextChanged(object sender, EventArgs e)
        {
            NewEmailtextBox.ForeColor = SystemColors.WindowText;
            //--------------------------------------------------------------------------
            //-----The condition for activating or deactivating the button is reset-----
            //--------------------------------------------------------------------------

            if ((NewEmailtextBox.Text != "Example: Behfar.Baghovvat@Gmail.com" &&
                NewEmailtextBox.Text != string.Empty) ||(
                UserNametextBox.Text != "Example: Behfar or Ali Moradi" &&
                UserNametextBox.Text != string.Empty))
            {
                NewEmailtextBox.ForeColor = SystemColors.WindowText;
                Resetbutton.Enabled = true;
            }
            else
            {
                Resetbutton.Enabled = false;
            }
        }        

        private void ConfirmaEmailtextBox_TextChanged(object sender, EventArgs e)
        {

            //--------------------------------------------------------------------------
            //-----The condition for activating or deactivating the button is reset-----
            //--------------------------------------------------------------------------
            if (ConfirmaEmailtextBox.Text != string.Empty)
            {
                Resetbutton.Enabled = true;
            }
            else
            {
                Resetbutton.Enabled = false;
            }
        }

        private void NewPasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            //--------------------------------------------------------------------------
            //-----The condition for activating or deactivating the button is reset-----
            //--------------------------------------------------------------------------

            if (NewPasswordtextBox.Text != string.Empty)
            {                
                Resetbutton.Enabled = true;
            }
            else
            {
                Resetbutton.Enabled = false;
            }
        }

        private void ConfirmPasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            //----------The condition for activating or deactivating the button is reset

            if (ConfirmPasswordtextBox.Text != string.Empty)
            {
                Resetbutton.Enabled = true;
            }
            else
            {
                Resetbutton.Enabled = false;
            }

            //-------The condition for activating or deactivating the registration button

            if ((UserNametextBox.Text != "Example: Behfar or Ali Moradi" &&
                UserNametextBox.Text != string.Empty) ||
                (NewEmailtextBox.Text != "Example: Behfar.Baghovvat@Gmail.com" &&
                NewEmailtextBox.Text != string.Empty)&&
                ConfirmaEmailtextBox.Text!=string.Empty &&
                NewEmailtextBox.Text!=string.Empty &&
                ConfirmPasswordtextBox.Text!=string.Empty)
            {
                Registerbutton.Enabled = true;
            }
            else
            {
                Registerbutton.Enabled = false;
            }


        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            //---------------------------------------------------------
            //---Check all box controls to confirm the registration!---
            //---------------------------------------------------------
            if ((UserNametextBox.Text != "Example: Behfar or Ali Moradi" ||
                UserNametextBox.Text != string.Empty)
                && ConfirmPasswordtextBox.Text == NewPasswordtextBox.Text &&
                ConfirmaEmailtextBox.Text == NewEmailtextBox.Text)
            {

                UserNametextBox.BackColor = SystemColors.Window;
                NewEmailtextBox.BackColor = SystemColors.Window;
                ConfirmaEmailtextBox.BackColor = SystemColors.Window;
                NewPasswordtextBox.BackColor = SystemColors.Window;
                ConfirmPasswordtextBox.BackColor = SystemColors.Window;
                MessageBox.Show("Registration completed...");
            }

            //---------------------------------------------------------
            //-------------------Check Email One!----------------------
            //---------------------------------------------------------

            else if (ConfirmaEmailtextBox.Text != NewEmailtextBox.Text)
            {
                MessageBox.Show("E-Mail do not match. Please try again.");

                ConfirmaEmailtextBox.BackColor = Color.Salmon;
                ConfirmaEmailtextBox.Focus();
            }

            //---------------------------------------------------------
            //--------------Checking one's password!-------------------
            //---------------------------------------------------------

            else if (ConfirmPasswordtextBox.Text != NewPasswordtextBox.Text)
            {

                MessageBox.Show("Passwords do not match. Please try again.");

                ConfirmPasswordtextBox.BackColor = Color.Salmon;
                ConfirmPasswordtextBox.Focus();
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {

            //-----Exit Application-----

            this.Close();
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            //--------------------------------------------------------------------------------------
            //-----------Clear all text box controls and return to the original state---------------
            //--------------------------------------------------------------------------------------

            Resetbutton.Enabled = false;

            UserNametextBox.Text = "Example: Behfar or Ali Moradi";
            UserNametextBox.ForeColor = Color.Gray;

            NewEmailtextBox.Text = "Example: Behfar.Baghovvat@Gmail.com";
            NewEmailtextBox.ForeColor = Color.Gray;

            ConfirmaEmailtextBox.Text = string.Empty;

            NewPasswordtextBox.Text = string.Empty;

            ConfirmPasswordtextBox.Text = string.Empty;

        }

    }
}
