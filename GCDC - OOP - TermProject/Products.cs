using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GCDC___OOP___TermProject
{
    public abstract class Products
    {
        /*NAME: Products
        * DESCRIPTION: Products class, base class that contains the code, description, price, stock, and image path
        */

        //Products Properties
        public string Code;
        public string Description;
        public decimal Price;
        public int InStock;
        public string Image;


        //Products Default Constructor
        public Products() { }

        //Products Custom Constructor: Code, Description, Price, InStock
        public Products(string inCode, string inDescription, decimal inPrice, int stockAmount)
        {
            Code = inCode;
            Description = inDescription;
            Price = inPrice;
            InStock = stockAmount;
        }

        //Products operator overloading --
        //Deduct 1 from a product's stock as long as it is greater than 0. Returns the product object.
        public static Products operator --(Products inProduct)
        {
            if(inProduct.InStock > 0)
                inProduct.InStock = inProduct.InStock - 1;
            return inProduct;
        }

        //Abstract method to validate stock, does nothing
        public abstract void ValidateStock();

        //Virtual method, returns a formatted string
        public virtual string DisplayProduct() => Price.ToString("c2");
    }
}
