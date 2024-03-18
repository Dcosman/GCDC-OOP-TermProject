using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GCDC___OOP___TermProject
{
    public abstract class Users
    {
        /*NAME: Users
        * DESCRIPTION: Base user class that contains all the user properties
        */

        //User Properties
        public string UserID;
        public string Password;
        public string Name;
        public string Access;

        //User Default Constructor
        public Users() { }

        //User Custom Constructor: UserID, Password, Name, Access
        public Users(string inUserID, string inPassword, string inName, string inAccess) 
        {
            UserID = inUserID;
            Password = inPassword;
            Name = inName;
            Access = inAccess;
        }

        //Virtual method OrderProduct, does nothing
        public virtual void OrderProduct(Products inProduct) { }

        //Name: GetCart
        //Sent: List<string>
        //Return: List<string>
        //Desc: Returns a list of orders (string)
        public virtual List<string> GetCart() 
        {
            return new List<string>();
        }

        //Name: DisplayUser
        //Sent: -
        //Return: string
        //Desc: Returns a formated string of the UserID and Name.
        public abstract string DisplayUser();
    }
}
