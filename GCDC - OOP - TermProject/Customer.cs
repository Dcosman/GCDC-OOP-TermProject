using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GCDC___OOP___TermProject
{
    public sealed class Customer : Users
    {
        /*NAME: Customer
        * DESCRIPTION: Customer class; derived from Users class
        */

        public List<Products> Cart;

        //Customer Default Constructor
        public Customer()
        {
            Cart = new List<Products>();
        }

        //Customer Custom Constructor: base
        public Customer(string inUserID, string inPassword, string inName, string inAccess) : base(inUserID, inPassword, inName, inAccess) 
        {
            Cart = new List<Products>();
        }

        //Sent: Customer + Product
        //Return: Customer
        //Desc: Orders the sent Product for the customer.
        public static Customer operator +(Customer inCustomer, Products inProduct)
        {
            inCustomer.Cart.Add(inProduct);
            return inCustomer;
        }

        //Name: ClearCart
        //Sent: -
        //Return: -
        //Desc: Clears the cart
        public void ClearCart()
        {
            Cart.Clear();
        }

        //Name: DisplayUser
        //Sent: -
        //Return: List
        //Desc: Returns a list of items in the cart
        public override List<string> GetCart()
        {
            List<string> cart = new List<string>();
            foreach (Products item in Cart) 
            {
                cart.Add(item.DisplayProduct());
            }
            return cart;
        }

        //Name: GetSubTotal
        //Sent: -
        //Return: decimal
        //Desc: Returns the subtotal of all items in the cart.
        public decimal GetSubTotal()
        {
            decimal subTotal = 0;
            foreach (Products item in Cart)
            {
                subTotal += item.Price;
            }
            return subTotal;
        }

        //Name: DisplayUser
        //Sent: -
        //Return: string
        //Desc: Returns a formated string of the UserID and Name.
        public override string DisplayUser() => "UserID: " + UserID + "| Name: " + Name;
    }
}
