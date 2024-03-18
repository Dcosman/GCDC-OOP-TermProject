using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDC___OOP___TermProject
{
    public class Hamsters : Products, ICloneable
    {
        /*NAME: Hamsters
        * DESCRIPTION: Hamster class; derived from Products class and ICloneable interface
        */

        //Hamsters Properties
        public string Breed;
        public string Gender;

        //Hamsters Default Constructor
        public Hamsters() { }

        //Hamsters Custom Constructor: base, Breed, Gender
        public Hamsters(string inCode, string inDescription, decimal inPrice, int stockAmount, string inBreed, string inGender) : base(inCode, inDescription, inPrice, stockAmount) 
        {
            Breed = inBreed;
            Gender = inGender;
        }

        //Adds a new clone hamster of opposite gender of the selected hamster using ICloneable
        public object Clone()
        {
            Hamsters ham = new Hamsters(this.Code, this.Description, this.Price, 0, this.Breed, (this.Gender == "Male") ? "Female" : "Male");
            ham.Image = this.Image;
            return ham;
        }

        //Operator overloading ==
        //checks if 2 Hamster objects are exactly the same. Return true if it is, false if not.
        public static bool operator ==(Hamsters ham1, Hamsters ham2)
        {
            bool match = true;
            if (ham1.Code != ham2.Code)
                match = false;
            else if (ham1.Description != ham2.Description)
                match = false;
            else if (ham1.Price != ham2.Price)
                match = false;
            else if (ham1.InStock != ham2.InStock)
                match = false;
            else if (ham1.Breed != ham2.Breed)
                match = false;
            else if (ham1.Gender != ham2.Gender)
                match = false;
            else if (ham1.Image != ham2.Image)
                match = false;
            return match;
        }

        //Operator overloading !=
        //needed to overload because of ==, return false
        public static bool operator !=(Hamsters ham1, Hamsters ham2)
        {
            return !(ham1 == ham2);
        }

        //Override method to check if an object is a hamster
        public override bool Equals(object obj)
        {
            return this == (Hamsters)obj;
        }

        //Required overriding for Equals
        public override int GetHashCode()
        {
            string hashString = this.Code;
            return hashString.GetHashCode();
        }

        //Validates the stock amount if it is within range
        public override void ValidateStock()
        {
            if (InStock < 0)
                throw new ArgumentOutOfRangeException();
            if (InStock >= 1000)
                throw new ArgumentOutOfRangeException();
        }

        //Override method DisplayProduct to display formatted hamster information
        public override string DisplayProduct() => String.Format("{0,-20}{1,-70}{2,-35}{3,0}", Code, Breed, Gender, base.DisplayProduct());
    }
}