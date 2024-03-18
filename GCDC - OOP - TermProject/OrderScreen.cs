using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GCDC___OOP___TermProject
{
    public partial class frmOrder : Form
    {
        /*NAME: OrderScreen
        * DESCRIPTION: The main form that displays all products to the user
        */

        //Class level lists
        List<Hamsters> hamsterList = new List<Hamsters>();
        List<Necessities> necessityList = new List<Necessities>();

        Users user;
        public frmOrder()
        {
            InitializeComponent();
        }


        // Event: Form Load
        // Desc: Loads Hamsters and Necessity Products from an xml file and stores
        //  in class level lists. Also displays the products in thier respective
        //  list boxes. Exception thrown if file error.
        private void frmOrder_Load(object sender, EventArgs e)
        {
            if (this.Tag.GetType().Name == "Customer")
            {
                Customer customer = (Customer)this.Tag;
                customer.Cart.Clear();
                user = customer;
            }
            else
            {
                user = (Admin)this.Tag;
                ShowAdmin();
            }

            lblWelcome.Text += "\n" + user.Name.ToUpper() + "?" + " (" + user.Access.ToUpper() + ")";

            hamsterList = FileHelper.GetHamsters();
            if(hamsterList != null)
                necessityList = FileHelper.GetNecessities();

            if (hamsterList == null)
            {
                MessageBox.Show("Error loading Products", "File Error");
                Close();
            }
            else if (necessityList == null)
            {
                MessageBox.Show("Error loading Products", "File Error");
                Close();
            }
            else
                UpdateProducts();
        }

        //Name: ShowHamsters
        //Sent: -
        //Return: -
        //Desc: Hides the Necessity controls, and shows the Hamster controls
        private void ShowHamsters()
        {
            lstHamsters.Show();
            lstNecessities.ClearSelected();
            lstHamsters.SelectedIndex = 0;
            lstNecessities.Hide();
            grpPicture.Show();
            grpOrderControls.Show();
            grpMenu.Show();
            lblItem.Hide();
            lblBreed.Show();
        }
        //Name: ShowHamsters overloading
        //Sent: string
        //Return: -
        //Desc: if the access is an admin, show the Clone button
        private void ShowHamsters(string inAccess)
        {
            ShowHamsters();
            if (inAccess == "admin")
                btnClone.Show();
        }

        //Name: ShowHamsters
        //Sent: -
        //Return: -
        //Desc: Hides the Hamster controls, and shows the Necessity controls
        private void ShowNecessities()
        {
            lstNecessities.Show();
            lstHamsters.ClearSelected();
            lstNecessities.SelectedIndex = 0;
            lstHamsters.Hide();
            grpPicture.Show();
            grpOrderControls.Show();
            grpMenu.Show();
            lblBreed.Hide();
            lblItem.Show();
            btnClone.Hide();
        }

        // Event: Hamster Button Click
        // Desc: calls ShowHamsters to show proper controls
        private void btnHamsters_Click(object sender, EventArgs e)
        {
            ShowHamsters(user.Access);
        }

        // Event: Necessity Button Click
        // Desc: calls ShowNecessities to show proper controls
        private void btnNecessities_Click(object sender, EventArgs e)
        {
            ShowNecessities();
        }

        // Event: lstHamster Index Changed
        // Desc: Changes the info for the product in the according controls
        private void lstHamsters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHamsters.SelectedIndex != -1)
            {
                Hamsters selectedHamster = hamsterList[lstHamsters.SelectedIndex];
                SetInfo(selectedHamster, selectedHamster.Breed);
                if (user.Access == "admin")
                {
                    btnClone.Text = btnClone.Tag.ToString() + ((selectedHamster.Gender == "Male") ? " FE&MALE" : " &MALE");
                }
            }
        }

        // Event: lstNecessities Index Changed
        // Desc: Changes the info for the product in the according controls
        private void lstNecessities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNecessities.SelectedIndex != -1)
            {
                Necessities selectedNecessity = necessityList[lstNecessities.SelectedIndex];
                SetInfo(selectedNecessity, selectedNecessity.Category);
            }
        }

        // Event: Add to Cart button clicked
        // Desc: Adds the selected item to cart, including the quantity selected
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int index;
            if (lstNecessities.SelectedIndex != -1)
                index = lstNecessities.SelectedIndex;
            else
                index = lstHamsters.SelectedIndex;

            if (lstNecessities.SelectedIndex != -1 && (necessityList[index].InStock - numQuantity.Value) >= 0)
            {
                for (int i = 0; i < numQuantity.Value; i++)
                {
                    user = (Customer)user + necessityList[index];
                    necessityList[index].InStock--;
                }
                SetInfo(necessityList[index], necessityList[index].Category);
            }
            else if (lstHamsters.SelectedIndex != -1 && (hamsterList[index].InStock - numQuantity.Value) >= 0)
            {
                for (int i = 0; i < numQuantity.Value; i++)
                {
                    user = (Customer)user + hamsterList[index];
                    hamsterList[index].InStock--;
                }
                SetInfo(hamsterList[index], hamsterList[index].Breed);
            }
            else
            {
                MessageBox.Show("Insufficient stock for product", "Add to cart error");
            }
            lblCart.Text = lblCart.Tag.ToString() + user.GetCart().Count;
        }

        //Name: ShowHamsters
        //Sent: Product, string
        //Return: none
        //Desc: Adds the product image, description, name, and all other info of the product
        private void SetInfo(Products inProduct, string inName)
        {
            try
            {
                picProduct.Image = Image.FromFile(inProduct.Image);
            }
            catch
            {
                picProduct.Image = picProduct.ErrorImage;
            }
            txtDescription.Text = "Code: " + inProduct.Code + Environment.NewLine + Environment.NewLine + inProduct.Description;
            lblName.Text = inName;
            lblStock.Text = inProduct.InStock.ToString();
            if (lblStock.Text == "0")
                lblStock.ForeColor = Color.Red;
            else
                lblStock.ForeColor = Color.LimeGreen;
            lblPrice.Text = inProduct.Price.ToString("c2");
        }

        // Event: btnBuyNow clicked
        // Desc: Shows the checkout form together with the cart info
        private void btnCart_Click(object sender, EventArgs e)
        {
            frmCheckout checkoutScreen = new frmCheckout
            {
                Tag = user
            };
            Customer checkoutCustomer = (Customer)user;
            checkoutScreen.ShowDialog();
            if (checkoutScreen.Tag.ToString() != "Purchase")
            {
                user = (Customer)checkoutScreen.Tag;
                lblCart.Text = lblCart.Tag.ToString() + user.GetCart().Count;

                if (lstHamsters.SelectedIndex != -1)
                    SetInfo(hamsterList[lstHamsters.SelectedIndex], hamsterList[lstHamsters.SelectedIndex].Breed);
                else if (lstNecessities.SelectedIndex != -1)
                    SetInfo(necessityList[lstNecessities.SelectedIndex], necessityList[lstNecessities.SelectedIndex].Category);
            }
            else
            {
                FileHelper.SetProducts(hamsterList, necessityList);
                UpdateProducts();
                checkoutCustomer.Cart.Clear();
                user = checkoutCustomer;
                lblCart.Text = lblCart.Tag.ToString() + user.GetCart().Count;
            }
        }

        //Name: ShowAdmin
        //Sent: none
        //Return: none
        //Desc: Shows all admin controls and hides all customer controls
        private void ShowAdmin()
        {
            btnAddProduct.Show();
            btnRemoveProduct.Show();
            btnUpdateProduct.Show();
            lblQuantity.Hide();
            numQuantity.Hide();
            btnCart.Hide();
            btnAddToCart.Hide();
            btnClone.Show();
        }

        // Event: btnRemoveProduct clicked
        // Desc: Removes the product from the list
        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            Products selectedProduct = null;
            if (lstHamsters.SelectedIndex != -1)
                selectedProduct = hamsterList[lstHamsters.SelectedIndex];
            else if (lstNecessities.SelectedIndex != -1)
                selectedProduct = necessityList[lstNecessities.SelectedIndex];

            if (selectedProduct != null)
            {
                DialogResult button = MessageBox.Show("Are you sure you want to remove " + selectedProduct.GetType().Name + " " + selectedProduct.Code, "Remove Product", MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    if (selectedProduct.GetType().Name == "Necessities")
                        necessityList.Remove((Necessities)selectedProduct);
                    if (selectedProduct.GetType().Name == "Hamsters")
                        hamsterList.Remove((Hamsters)selectedProduct);
                    MessageBox.Show("Product Removed", "Removal Confirmation");
                    FileHelper.SetProducts(hamsterList, necessityList);
                    UpdateProducts();
                }
                else
                    MessageBox.Show("Canceled product removal", "Removal Cancel");
            }
        }

        //Name: UpdateProducts
        //Sent: none
        //Return: none
        //Desc: Shows all admin controls and hides all customer controls
        private void UpdateProducts()
        {
            lstHamsters.Items.Clear();
            lstNecessities.Items.Clear();
            foreach (Hamsters item in hamsterList)
            {
                lstHamsters.Items.Add(item.Breed + " (" + item.Gender + ")");
            }
            foreach (Necessities item in necessityList)
            {
                lstNecessities.Items.Add(item.Category + " (" + item.Colour + ")");
            }

        }

        // Event: btnRemoveProduct clicked
        // Desc: Removes the product from the list
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProducts productsScreen = new frmProducts();
            productsScreen.Tag = "";
            productsScreen.ShowDialog();
            if ((List<Products>)productsScreen.Tag != null)
            {
                foreach (Products item in (List<Products>)productsScreen.Tag)
                {
                    if (item.GetType().Name == "Hamsters")
                        hamsterList.Add((Hamsters)item);
                    else if (item.GetType().Name == "Necessities")
                        necessityList.Add((Necessities)item);
                }
            }
            FileHelper.SetProducts(hamsterList, necessityList);
            UpdateProducts();

        }

        // Event: Calls AdminProductChange function 
        // Desc: Updates the product and opens up AddProductsScreen form
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            frmProducts productsScreen = new frmProducts();
            if (lstHamsters.SelectedIndex != -1)
            {
                productsScreen.Tag = hamsterList[lstHamsters.SelectedIndex];
                productsScreen.ShowDialog();
                if (productsScreen.Tag.ToString() != "Cancel" && productsScreen.Tag.ToString() != "NoChange")
                    hamsterList[lstHamsters.SelectedIndex] = (Hamsters)productsScreen.Tag;
            }
            else if (lstNecessities.SelectedIndex != -1)
            {
                productsScreen.Tag = necessityList[lstNecessities.SelectedIndex];
                productsScreen.ShowDialog();
                if (productsScreen.Tag.ToString() != "Cancel" && productsScreen.Tag.ToString() != "NoChange")
                {
                    necessityList[lstNecessities.SelectedIndex] = (Necessities)productsScreen.Tag;
                }
            }

            FileHelper.SetProducts(hamsterList, necessityList);
            UpdateProducts();
        }

        // Event: btnSignOut click event
        // Desc: Closes the form and signs out the user
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Event: Form closing event
        // Desc: Displays a messagebox for signout confirmation.
        private void frmOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hamsterList != null && necessityList != null)
            {
                string message = "Are you sure you would like to sign out?";
                if (user.Access == "customer")
                    message += " \nSigning out will clear your cart.";
                DialogResult button = MessageBox.Show(message, "Sign Out", MessageBoxButtons.YesNo);

                if (button == DialogResult.No)
                    e.Cancel = true;
            }
        }

        // Event: btnClone click event
        // Desc: Calls ICloneable interface and clones the hamster object and adding the same hamster of the opposite gender.
        private void btnClone_Click(object sender, EventArgs e)
        {
            if (lstHamsters.SelectedIndex != -1)
            {
                Hamsters hamClone = (Hamsters)hamsterList[lstHamsters.SelectedIndex].Clone();
                if (!CheckHamsters(hamClone))
                {
                    hamsterList.Add(hamClone);
                    FileHelper.SetProducts(hamsterList, necessityList);
                    UpdateProducts();
                }
            }
        }

        //Name: CheckHamsters
        //Sent: Hamster object
        //Return: bool
        //Desc: Sends in a hamster object and checks to see if the same object already exists. Returns true if it exists
        private bool CheckHamsters(Hamsters inHam)
        {
            bool exists = false;
            foreach (Hamsters item in hamsterList)
            {
                if ((item.Breed == inHam.Breed) && (item.Gender == inHam.Gender))
                {
                    exists = true;
                    MessageBox.Show(inHam.Gender + " " + inHam.Breed + " already exists", "Product Error");
                    break;
                }
            }
            return exists;
        }
    }
}
