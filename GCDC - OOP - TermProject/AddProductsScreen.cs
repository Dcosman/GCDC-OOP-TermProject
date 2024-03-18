using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GCDC___OOP___TermProject
{
    public partial class frmProducts : Form
    {
        /*NAME: AddProductsScreen
        * DESCRIPTION: Form that lets the admin add, update, and delete products
        */

        //class level list of products and image path
        List<Products> newProducts = new List<Products>();
        Products updatedProduct = null;

        public frmProducts()
        {
            InitializeComponent();
        }

        // Event: radHamsters clicked
        // Desc: Calls ShowHamsters
        private void radHamsters_CheckedChanged(object sender, EventArgs e)
        {
            ShowHamsters();
        }

        // Event: radNecessities clicked
        // Desc: Calls ShowNecessities
        private void radNecessities_CheckedChanged(object sender, EventArgs e)
        {
            ShowNecessities();
        }

        //Name: ShowNecessities
        //Sent: -
        //Return: -
        //Desc: Shows the appropriate controls for adding a necessity product
        private void ShowNecessities()
        {
            grpMenu.Show();
            grpGender.Hide();
            lblColour.Show();
            txtColour.Show();
        }

        //Name: ShowHamsters
        //Sent: -
        //Return: -
        //Desc: Shows the appropriate controls for adding a hamster product
        private void ShowHamsters()
        {
            grpMenu.Show();
            grpGender.Show();
            lblColour.Hide();
            txtColour.Hide();
        }

        // Event: btnBack clicked
        // Desc: Closes the form
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Event: btnAddProduct clicked
        // Desc: Validates all user input for new product creation. Adds the product to the list if every input is validated.
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            bool validate = ValidateFields();

            //determine if it is a hamster or a necessity
            if (validate)
            {
                if (radNecessities.Checked)
                {
                    try
                    {
                        SetNecessity().ValidateStock();
                        newProducts.Add(SetNecessity());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nStock must be greater than 0 and less than 1000");
                        validate = false;
                    }
                }
                if (radHamsters.Checked)
                {
                    try
                    {
                        SetHamster().ValidateStock();
                        newProducts.Add(SetHamster());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nStock must be greater than 0 and less than 1000");
                        validate = false;
                    }
                }

                if (validate)
                {
                    MessageBox.Show(txtName.Text + " has been added to the product list.", "Product Added");
                    ResetInputs();
                }
            }
        }

        // Event: btnAddProduct clicked
        // Desc: Opens an OFD to prompt user to select an image. Updates product listing image once done.
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = ofdImage.ShowDialog();
            picProduct.Tag = ofdImage.FileName;
            try
            {
                picProduct.Image = Image.FromFile(picProduct.Tag.ToString());
            }
            catch
            {
                picProduct.Image = picProduct.ErrorImage;
            }
        }

        // Event: Form closed
        // Desc: Assigns the list of new product to the tag
        private void frmProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (updatedProduct == null)
                this.Tag = newProducts;
        }

        //Name: ResetInputs
        //Sent: -
        //Return: -
        //Desc: Clears all inputs
        private void ResetInputs()
        {
            radHamsters.Checked = true;
            txtCode.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtName.Clear();
            txtColour.Clear();
        }

        // Event: Form load
        // Desc: Pre-loads the inputs using Tag if admin chooses to update a product
        private void frmProducts_Load(object sender, EventArgs e)
        {
            if (this.Tag.GetType().Name == "Hamsters")
            {
                Hamsters hamster = (Hamsters)this.Tag;
                updatedProduct = hamster;
                ShowHamsters();
                radHamsters.Checked = true;
                HideControls();

                //pre-loaded info
                txtCode.Text = hamster.Code;
                txtName.Text = hamster.Breed;
                txtDescription.Text = hamster.Description;
                txtPrice.Text = hamster.Price.ToString();
                txtStock.Text = hamster.InStock.ToString();
                if (hamster.Gender == "Male")
                    radMale.Checked = true;
                else
                    radFemale.Checked = true;
                try
                {
                    picProduct.Image = Image.FromFile(hamster.Image);
                    picProduct.Tag = hamster.Image;
                }
                catch
                {
                    picProduct.Image = picProduct.ErrorImage;
                    picProduct.Tag = picProduct.ErrorImage;
                }

            }
            else if (this.Tag.GetType().Name == "Necessities")
            {
                Necessities necessity = (Necessities)this.Tag;
                updatedProduct = necessity;
                ShowNecessities();
                radNecessities.Checked = true;
                HideControls();

                //pre-loaded info
                txtCode.Text = necessity.Code;
                txtColour.Text = necessity.Colour;
                txtName.Text = necessity.Category;
                txtDescription.Text = necessity.Description;
                txtStock.Text = necessity.InStock.ToString();
                txtPrice.Text = necessity.Price.ToString();
                try
                {
                    picProduct.Image = Image.FromFile(necessity.Image);
                    picProduct.Tag = necessity.Image;
                }
                catch
                {
                    picProduct.Image = picProduct.ErrorImage;
                    picProduct.Tag = picProduct.ErrorImage;
                }
            }
        }

        // Event: btnUpdate click event
        // Desc: updates the list of products by grabbing it from the tag. Shows a messagebox confirmation
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool validate = ValidateFields();

            if (radNecessities.Checked && validate)
            {
                try
                {
                    SetNecessity().ValidateStock();
                    updatedProduct = SetNecessity();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nStock must be greater than 0 and less than 1000");
                    validate = false;
                }
            }
            if (radHamsters.Checked && validate)
            {
                try
                {
                    SetHamster().ValidateStock();
                    updatedProduct = SetHamster();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nStock must be greater than 0 and less than 1000");
                    validate = false;
                }
            }

            if (validate)
            {
                if (this.Tag.GetType().Name == "Hamsters" && (Hamsters)this.Tag == (Hamsters)updatedProduct)
                {
                    MessageBox.Show("No changes made", "Update Cancel");
                    this.Tag = "NoChange";
                    Close();
                }
                else if (this.Tag.GetType().Name == "Necessities" && (Necessities)this.Tag == (Necessities)updatedProduct)
                {
                    MessageBox.Show("No changes made", "Update Cancel");
                    this.Tag = "NoChange";
                    Close();
                }
                else
                {
                    this.Tag = updatedProduct;
                    MessageBox.Show("Product has been updated. Returning to menu.", "Update Success");
                    Close();
                }
            }
        }

        //Name: SetNecessity
        //Sent: -
        //Return: Necessities object
        //Desc: Grabs all the info from the textboxes into a new necessity and returns a necessity object
        private Necessities SetNecessity()
        {

            Necessities newNecessity = new Necessities(txtCode.Text, txtDescription.Text, decimal.Parse(txtPrice.Text), int.Parse(txtStock.Text), txtName.Text, txtColour.Text);
            if (picProduct.Tag != null)
                newNecessity.Image = picProduct.Tag.ToString();
            return newNecessity;
        }

        //Name: SetHamster
        //Sent: -
        //Return: Hamster object
        //Desc: Grabs all the info from the textboxes into a new hamster and returns a hamster object
        private Hamsters SetHamster()
        {
            Hamsters newHamster = new Hamsters(txtCode.Text, txtDescription.Text, decimal.Parse(txtPrice.Text), int.Parse(txtStock.Text), txtName.Text, radMale.Checked ? "Male" : "Female");
            if (picProduct.Tag != null)
                newHamster.Image = picProduct.Tag.ToString();
            return newHamster;
        }

        //Name: HideControls
        //Sent: -
        //Return: -
        //Desc: Hides all the controls in the form
        private void HideControls()
        {
            grpProduct.Hide();
            btnAddProduct.Hide();
            btnUpdate.Show();
            btnCancel.Show();
            btnBack.Hide();
        }

        //Event: btnCancel click event
        //Desc: Closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Tag = "Cancel";
            Close();
        }

        //Name: ValidateFields
        //Sent: -
        //Return: bool
        //Desc: Validates the input fields using the Validator class. Returns false if any field are not valid
        private bool ValidateFields()
        {
            bool validate = true;
            if (!Validator.ValidateTextBox(txtCode))
                validate = false;
            else if (!Validator.ValidateTextBox(txtName))
                validate = false;
            else if (!Validator.ValidateTextBox(txtDescription))
                validate = false;
            else if (!Validator.ValidateInt(txtStock))
                validate = false;
            else if (!Validator.ValidateDecimal(txtPrice))
                validate = false;
            else if (radNecessities.Checked && !Validator.ValidateTextBox(txtColour))
                validate = false;
            return validate;
        }
    }
}
