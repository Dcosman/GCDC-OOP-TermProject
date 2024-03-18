using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDC___OOP___TermProject
{
    public sealed class Admin : Users
    {
        /*NAME: Admin
        * DESCRIPTION: Admin class; derived from Users Class
        */

        //Admin Default Constructor
        public Admin() { }

        //Admin Custom Constructor: base
        public Admin(string inUserID, string inPassword, string inName, string inAccess) : base(inUserID, inPassword, inName, inAccess) { }

        //Name: DisplayUser
        //Sent: -
        //Return: string
        //Desc: Returns a formated string of the UserID and Name.
        public override string DisplayUser() => "(" + Access + ") " + "UserID: " + UserID + "| Name: " + Name;

    }
}
