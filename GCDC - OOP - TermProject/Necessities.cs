using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GCDC___OOP___TermProject
{
    public class Necessities : Products
    {
        /*NAME: Necessities
        * DESCRIPTION: Necessities class; derived from Products class
        */

        //Necessities Properties
        public string Category;
        public string Colour;

        //Necessities Default Constructor
        public Necessities() { }

        //Necessities Custom Constructor: base, Category, OnClearance
        public Necessities(string inCode, string inDescription, decimal inPrice, int stockAmount, string inCategory, string inColour) : base(inCode, inDescription, inPrice, stockAmount) 
        {
            Category = inCategory;
            Colour = inColour;
        }

        //Necessities operator overloading, compares if two necessity objects are the same
        public static bool operator ==(Necessities nec1, Necessities nec2)
        {
            bool match = true;
            if (nec1.Code != nec2.Code)
                match = false;
            else if (nec1.Description != nec2.Description)
                match = false;
            else if (nec1.Price != nec2.Price)
                match = false;
            else if (nec1.InStock != nec2.InStock)
                match = false;
            else if (nec1.Category != nec2.Category)
                match = false;
            else if (nec1.Colour != nec2.Colour)
                match = false;
            else if (nec1.Image != nec2.Image)
                match = false;
            return match;
        }

        //Required operator overloading for ==
        public static bool operator !=(Necessities nec1, Necessities nec2)
        {
            return !(nec1 == nec2);
        }

        //Override method to check if an object is a necessity
        public override bool Equals(object obj)
        {
            return this == (Necessities)obj;
        }

        //Required overriding for Equals
        public override int GetHashCode()
        {
            string hashString = this.Code;
            return hashString.GetHashCode();
        }

        //Validates if stock is within range
        public override void ValidateStock()
        {
            if (InStock <= 0)
                throw new ArgumentOutOfRangeException();
            if (InStock >= 1000)
                throw new ArgumentOutOfRangeException();
        }

        //Name: DisplayProduct
        //Sent: -
        //Return: string
        //Desc: Returns a formatted string containing the product code, category (name), colour
        public override string DisplayProduct() => String.Format("{0,-20}{1,-70}{2,-35}{3,0}", Code, Category, Colour, base.DisplayProduct()) ;
    }
}
