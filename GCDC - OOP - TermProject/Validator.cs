using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCDC___OOP___TermProject
{
    public static class Validator
    {
        /*NAME: Validator
        * DESCRIPTION: Static class that validates all textbox inputs
        */

        //Name: validateTextBox
        //Sent: TextBox
        //Return: bool
        //Desc: validates the sent TextBox to ensure it is not empty, and returns false and a message if not valid
        public static bool ValidateTextBox(TextBox txtBox)
        {
            bool valid = true;
            if (txtBox.Text == "")
            {
                valid = false;
                MessageBox.Show("Must enter a valid " + txtBox.Tag, txtBox.Tag + " Error");
                txtBox.Focus();
            }

            return valid;
        }

        //Name: ValidateDecimal
        //Sent: TextBox
        //Return: bool
        //Desc: Validates the sent Textbox to make sure input is a decimal
        public static bool ValidateDecimal(TextBox txtBox)
        {
            bool valid = true;
            if (!decimal.TryParse(txtBox.Text, out decimal amount) || amount <= 0)
            {
                valid = false;
                MessageBox.Show("Must enter a valid " + txtBox.Tag, txtBox.Tag + " Error");
                txtBox.Focus();
            }

            return valid;
        }

        //Name: ValidateInt
        //Sent: TextBox
        //Return: bool
        //Desc: Validates the sent TextBox to make sure input is an integer
        public static bool ValidateInt(TextBox txtBox)
        {
            bool valid = true;
            if (!int.TryParse(txtBox.Text, out int amount))
            {
                valid = false;
                MessageBox.Show("Must enter a valid " + txtBox.Tag, txtBox.Tag + " Error");
                txtBox.Focus();
            }

            return valid;
        }
    }
}
