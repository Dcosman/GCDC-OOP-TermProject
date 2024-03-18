namespace GCDC___OOP___TermProject
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.grpPicture = new System.Windows.Forms.GroupBox();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNecessities = new System.Windows.Forms.Button();
            this.btnHamsters = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.grpOrderControls = new System.Windows.Forms.GroupBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lstNecessities = new System.Windows.Forms.ListBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lstHamsters = new System.Windows.Forms.ListBox();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.grpPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpOrderControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPicture
            // 
            this.grpPicture.BackColor = System.Drawing.Color.White;
            this.grpPicture.Controls.Add(this.picProduct);
            this.grpPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPicture.Location = new System.Drawing.Point(12, 54);
            this.grpPicture.Name = "grpPicture";
            this.grpPicture.Size = new System.Drawing.Size(418, 383);
            this.grpPicture.TabIndex = 0;
            this.grpPicture.TabStop = false;
            this.grpPicture.Visible = false;
            // 
            // picProduct
            // 
            this.picProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProduct.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picProduct.ErrorImage")));
            this.picProduct.Image = ((System.Drawing.Image)(resources.GetObject("picProduct.Image")));
            this.picProduct.Location = new System.Drawing.Point(3, 19);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(412, 361);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnNecessities);
            this.groupBox2.Controls.Add(this.btnHamsters);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(436, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CATEGORY";
            // 
            // btnNecessities
            // 
            this.btnNecessities.BackColor = System.Drawing.Color.White;
            this.btnNecessities.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNecessities.Location = new System.Drawing.Point(234, 26);
            this.btnNecessities.Margin = new System.Windows.Forms.Padding(0);
            this.btnNecessities.Name = "btnNecessities";
            this.btnNecessities.Size = new System.Drawing.Size(205, 43);
            this.btnNecessities.TabIndex = 1;
            this.btnNecessities.Tag = "NECESSITIES";
            this.btnNecessities.Text = "&NECESSITIES";
            this.btnNecessities.UseVisualStyleBackColor = false;
            this.btnNecessities.Click += new System.EventHandler(this.btnNecessities_Click);
            // 
            // btnHamsters
            // 
            this.btnHamsters.BackColor = System.Drawing.Color.White;
            this.btnHamsters.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHamsters.Location = new System.Drawing.Point(19, 26);
            this.btnHamsters.Margin = new System.Windows.Forms.Padding(0);
            this.btnHamsters.Name = "btnHamsters";
            this.btnHamsters.Size = new System.Drawing.Size(205, 43);
            this.btnHamsters.TabIndex = 0;
            this.btnHamsters.Tag = "HAMSTERS";
            this.btnHamsters.Text = "&HAMSTERS";
            this.btnHamsters.UseVisualStyleBackColor = false;
            this.btnHamsters.Click += new System.EventHandler(this.btnHamsters_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCart.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCart.Location = new System.Drawing.Point(624, 454);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(171, 43);
            this.btnCart.TabIndex = 6;
            this.btnCart.Tag = "";
            this.btnCart.Text = "&VIEW CART";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblName.Location = new System.Drawing.Point(12, 459);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 25);
            this.lblName.TabIndex = 0;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpOrderControls
            // 
            this.grpOrderControls.BackColor = System.Drawing.Color.Transparent;
            this.grpOrderControls.Controls.Add(this.btnClone);
            this.grpOrderControls.Controls.Add(this.btnUpdateProduct);
            this.grpOrderControls.Controls.Add(this.lblStock);
            this.grpOrderControls.Controls.Add(this.label3);
            this.grpOrderControls.Controls.Add(this.btnAddToCart);
            this.grpOrderControls.Controls.Add(this.numQuantity);
            this.grpOrderControls.Controls.Add(this.lblQuantity);
            this.grpOrderControls.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderControls.Location = new System.Drawing.Point(436, 338);
            this.grpOrderControls.Name = "grpOrderControls";
            this.grpOrderControls.Size = new System.Drawing.Size(619, 99);
            this.grpOrderControls.TabIndex = 3;
            this.grpOrderControls.TabStop = false;
            this.grpOrderControls.Visible = false;
            // 
            // btnClone
            // 
            this.btnClone.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClone.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnClone.Location = new System.Drawing.Point(205, 36);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(171, 43);
            this.btnClone.TabIndex = 3;
            this.btnClone.Tag = "ADD";
            this.btnClone.Text = "ADD";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Visible = false;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnUpdateProduct.Location = new System.Drawing.Point(415, 36);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(171, 43);
            this.btnUpdateProduct.TabIndex = 4;
            this.btnUpdateProduct.Tag = "";
            this.btnUpdateProduct.Text = "&UPDATE PRODUCT";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Visible = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // lblStock
            // 
            this.lblStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStock.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblStock.Location = new System.Drawing.Point(16, 48);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(102, 28);
            this.lblStock.TabIndex = 0;
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "IN STOCK";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAddToCart.Location = new System.Drawing.Point(415, 36);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(171, 43);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Tag = "";
            this.btnAddToCart.Text = "ADD TO &CART";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantity.Location = new System.Drawing.Point(188, 48);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(127, 27);
            this.numQuantity.TabIndex = 1;
            this.numQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblQuantity.Location = new System.Drawing.Point(184, 25);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(82, 19);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "QUANTITY";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrice.Location = new System.Drawing.Point(331, 461);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 25);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpMenu
            // 
            this.grpMenu.BackColor = System.Drawing.Color.Transparent;
            this.grpMenu.Controls.Add(this.txtDescription);
            this.grpMenu.Controls.Add(this.lstNecessities);
            this.grpMenu.Controls.Add(this.lblItem);
            this.grpMenu.Controls.Add(this.label5);
            this.grpMenu.Controls.Add(this.lblBreed);
            this.grpMenu.Controls.Add(this.lstHamsters);
            this.grpMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(436, 97);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(619, 239);
            this.grpMenu.TabIndex = 2;
            this.grpMenu.TabStop = false;
            this.grpMenu.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.txtDescription.Location = new System.Drawing.Point(18, 53);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(269, 172);
            this.txtDescription.TabIndex = 0;
            // 
            // lstNecessities
            // 
            this.lstNecessities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNecessities.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNecessities.FormattingEnabled = true;
            this.lstNecessities.ItemHeight = 19;
            this.lstNecessities.Location = new System.Drawing.Point(307, 53);
            this.lstNecessities.Name = "lstNecessities";
            this.lstNecessities.Size = new System.Drawing.Size(295, 173);
            this.lstNecessities.TabIndex = 1;
            this.lstNecessities.SelectedIndexChanged += new System.EventHandler(this.lstNecessities_SelectedIndexChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblItem.Location = new System.Drawing.Point(303, 22);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(130, 19);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "SELECT AN ITEM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(15, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "DESCRIPTION";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreed.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblBreed.Location = new System.Drawing.Point(303, 22);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(135, 19);
            this.lblBreed.TabIndex = 3;
            this.lblBreed.Text = "SELECT A BREED";
            // 
            // lstHamsters
            // 
            this.lstHamsters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHamsters.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHamsters.FormattingEnabled = true;
            this.lstHamsters.ItemHeight = 19;
            this.lstHamsters.Location = new System.Drawing.Point(307, 53);
            this.lstHamsters.Name = "lstHamsters";
            this.lstHamsters.Size = new System.Drawing.Size(295, 173);
            this.lstHamsters.TabIndex = 2;
            this.lstHamsters.SelectedIndexChanged += new System.EventHandler(this.lstHamsters_SelectedIndexChanged);
            // 
            // btnSignOut
            // 
            this.btnSignOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSignOut.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(812, 454);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(243, 43);
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Tag = "";
            this.btnSignOut.Text = "SIGN &OUT";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(900, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduct.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddProduct.Location = new System.Drawing.Point(436, 454);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(171, 43);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Tag = "";
            this.btnAddProduct.Text = "ADD &PRODUCT";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Visible = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveProduct.Location = new System.Drawing.Point(624, 454);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(171, 43);
            this.btnRemoveProduct.TabIndex = 5;
            this.btnRemoveProduct.Tag = "";
            this.btnRemoveProduct.Text = "&REMOVE PRODUCT";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Visible = false;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblWelcome.Location = new System.Drawing.Point(10, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(244, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WHATCHU LOOKIN\' FOR,";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCart.Location = new System.Drawing.Point(447, 464);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(157, 25);
            this.lblCart.TabIndex = 0;
            this.lblCart.Tag = "Items in Cart: ";
            this.lblCart.Text = "Items in Cart: 0";
            this.lblCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmOrder
            // 
            this.AcceptButton = this.btnCart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSignOut;
            this.ClientSize = new System.Drawing.Size(1075, 516);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.grpOrderControls);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpPicture);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.btnRemoveProduct);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HamsBros - Order (Dallas Cosman, Gabriel Catajoy)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.grpPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grpOrderControls.ResumeLayout(false);
            this.grpOrderControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpPicture;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpOrderControls;
        private System.Windows.Forms.Button btnHamsters;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNecessities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstHamsters;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.ListBox lstNecessities;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnClone;
    }
}