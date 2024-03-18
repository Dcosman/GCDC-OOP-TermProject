using System;
using System.Windows.Forms;

namespace GCDC___OOP___TermProject
{
    public partial class frmCheckout : Form
    {
        /*NAME: CheckOutScreen
        * DESCRIPTION: Checkout form which displays the order summary and prompts the user to save their order
        */

        //Class level object, variables, and constant
        Customer customer;
        string cart;
        const decimal TAXRATE = 0.15m;

        public frmCheckout()
        {
            InitializeComponent();
        }

        //Event: Form load
        //Desc: Grabs the customer object from the tag
        private void frmCheckout_Load(object sender, EventArgs e)
        {
            customer = (Customer)this.Tag;
            lblOrderSummary.Text += " FOR " + customer.Name.ToUpper();
            foreach (Products item in customer.Cart)
            {
                lstCart.Items.Add(item.DisplayProduct());
            }
            SetCheckoutInfo();
        }

        //Event: btnRemove click event
        //Desc: Removes the selected product from the cart
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedIndex != -1)
            {
                customer.Cart[lstCart.SelectedIndex].InStock++;
                customer.Cart.RemoveAt(lstCart.SelectedIndex);
                lstCart.Items.RemoveAt(lstCart.SelectedIndex);
                SetCheckoutInfo();
            }
        }

        //Event: Form closing event
        //Desc: Sets the tag to the customer object if they didn't purchased
        private void frmCheckout_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Tag.ToString() != "Purchase")
                this.Tag = customer;
        }

        //Name: SetCheckoutInfo
        //Sent: -
        //Return: -
        //Desc: Sets the order summar (subtotal, tax rate, and total) to the textboxes.
        private void SetCheckoutInfo()
        {
            decimal subTotal = customer.GetSubTotal();
            lblSubtotal.Text = subTotal.ToString("c2");
            lblTaxRate.Text = lblTaxRate.Tag.ToString() + " (" + TAXRATE.ToString("p0") + ")";
            lblTax.Text = (TAXRATE * subTotal).ToString("c2");
            lblTotal.Text = (subTotal + (TAXRATE * subTotal)).ToString("c2");
        }

        //Event: btnClear click event
        //Desc: Prompts the user to clear the cart. Clears everything in the cart if OK and send a confirmation message
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (customer.Cart.Count > 0)
            {
                DialogResult button = MessageBox.Show("Are you sure you want to clear your cart?", "Confirm Clear", MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    for (int i = customer.Cart.Count - 1; i >= 0; i--)
                    {
                        customer.Cart[i].InStock++;
                        customer.Cart.RemoveAt(i);
                        lstCart.Items.RemoveAt(i);
                    }
                    SetCheckoutInfo();
                    MessageBox.Show("Cart cleared", "Cart Confirmation");
                }
                else
                    MessageBox.Show("Cart not cleared", "Cart Confirmation");
            }
            else
                MessageBox.Show("Cart is empty", "Cart Confirmation");
        }

        //Event: Checkout click event
        //Desc: Saves the user's order summary to a txt file
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string payment;

            if (customer.Cart.Count <= 0)
                MessageBox.Show("No items in cart", "Cart Error");
            else if (!radCard.Checked && !radInterac.Checked && !radPaypal.Checked)
                MessageBox.Show("Please select a payment method", "Payment Method");
            else
            {
                if (radCard.Checked)
                    payment = radCard.Text;
                else if (radInterac.Checked)
                    payment = radInterac.Text;
                else
                    payment = radPaypal.Text;
                DialogResult result = MessageBox.Show("Total: " + lblTotal.Text + "\nPurchase order using " + payment + "?", "Confirm Purchase", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sfdOrder.Title = "Save Your Order";
                    sfdOrder.FileName = "Order.txt";
                    sfdOrder.DefaultExt = "txt";
                    DialogResult userSelection = sfdOrder.ShowDialog();

                    if (userSelection == DialogResult.Cancel)
                        MessageBox.Show("Order not Saved", "Order Canceled");

                    else
                    {
                        FileHelper.SaveOrder(customer, sfdOrder.FileName, TAXRATE);
                        MessageBox.Show("File saved to " + sfdOrder.FileName, "Confirm Save");
                        this.Tag = "Purchase";
                        Close();
                    }
                }
            }

        }
    }
}
