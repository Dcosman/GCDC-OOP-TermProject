using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GCDC___OOP___TermProject
{
    public partial class frmLogin : Form
    {
        /*NAME: Dallas Cosman, Gabriel Catajoy
        * DATE: April 5, 2023
        * DESCRIPTION: Term project for OOP - A store that sells different types hamsters and supplies.
        * Admins can add, update, and delete the products while users can browse through the products and save an order txt file.
        */

        //Class level list of users
        List<Users> validUsers;
        int loginAttempt = 3;

        public frmLogin()
        {
            InitializeComponent();
        }

        // Event: Login button click
        // Desc: Validates there is a valid login entry and if the entry matches an existing
        // user, it then logs in the user and opens the Order form.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validator.ValidateTextBox(txtUserID) && Validator.ValidateTextBox(txtPassword))
            {
                bool success = false;
                foreach (Users user in validUsers)
                {
                    if (user.UserID == txtUserID.Text && user.Password == txtPassword.Text)
                    {
                        success = true;
                        frmOrder orderScreen = new frmOrder();
                        if (user.Access == "admin")
                            orderScreen.Tag = (Admin)user;
                        else
                            orderScreen.Tag = (Customer)user;

                        orderScreen.ShowDialog();
                        ResetControls();
                        loginAttempt = 3;
                    }
                }
                if (!success)
                {
                    loginAttempt--;
                    MessageBox.Show("Username or password is incorrect, please try again.\n" + "Number of attempts left: " + loginAttempt, "Login Not Recognized");
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }
                if (loginAttempt == 0)
                {
                    MessageBox.Show("Already reached 3 unsuccessful attempts. Program now exiting.", "Maximum Attempts Reached");
                    this.Close();
                }
            }
        }

        // Event: Form Load
        // Desc: Loads the users using FileHelper
        private void frmLogin_Load(object sender, EventArgs e)
        {
            validUsers = FileHelper.GetUsers();
            if (validUsers == null)
            {
                MessageBox.Show("No valid users found.", "User Load Error");
                Close();
            }
        }

        // Event: Forgot Password link click event
        // Desc: Prompts the user to if they want to change their new password. Show changePassword form if OK
        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult button = MessageBox.Show("Do you want to change your password?", "Forgot Password", MessageBoxButtons.YesNo);

            if (button == DialogResult.Yes)
            {
                frmChangePassword changePassword = new frmChangePassword();
                changePassword.Tag = validUsers;
                changePassword.ShowDialog();
                ResetControls();
            }
        }

        //Name: ResetControls
        //Sent: -
        //Return: -
        //Desc: Clears user input on the textboxes and focuses on the userID control
        private void ResetControls()
        {
            txtUserID.Text = "";
            txtPassword.Text = "";
            txtUserID.Focus();
        }

        //Event: btnExit click event
        //Desc: Closes the form and exits the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
