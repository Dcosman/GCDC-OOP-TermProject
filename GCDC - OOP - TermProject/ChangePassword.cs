using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCDC___OOP___TermProject
{
    public partial class frmChangePassword : Form
    {
        /*NAME: frmChangePassword
        * DESCRIPTION: Form that lets a user change their password
        */

        //class level list of valid users
        List<Users> validUsers;

        public frmChangePassword()
        {
            InitializeComponent();
        }

        // Event: Form Load
        // Desc: Loads the users using tag
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            validUsers = (List<Users>)this.Tag;
        }

        // Event: btnUpdatePassword clicked
        // Desc: Validates inputs and new password inputs. If success, display a messagebox confirmation and overwrites the users file.
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (Validator.ValidateTextBox(txtUserID) && Validator.ValidateTextBox(txtNewPassword) && Validator.ValidateTextBox(txtConfirmPassword))
            {
                foreach (Users user in validUsers)
                {
                    if (user.UserID == txtUserID.Text)
                    {
                        if (txtNewPassword.Text == txtConfirmPassword.Text)
                        {
                            user.Password = txtConfirmPassword.Text;
                            MessageBox.Show("Password successfully updated!", "Password Changed");
                            Close();
                            FileHelper.SetUsers(validUsers);
                        }
                        else
                        {
                            MessageBox.Show("Passwords did not match. Please try again.", "Cannot Set New Password");
                            txtNewPassword.Clear();
                            txtConfirmPassword.Clear();
                        }
                    }
                }
            }

        }

        // Event: btnBack clicked
        // Desc: Closes the form
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
