using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExtensionMethods;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// May 3rd, 2020
// Project 4 - Sales Project

namespace SalesProject
{
    public partial class frmShop : Form
    {
        ValidationManager vm = new ValidationManager();
        DatabaseManager db = new DatabaseManager();

        //Assign event handlers for validation to the appropriate controls(i.e. all the textboxes)
        public frmShop()
        {
            InitializeComponent();
            pnlProduct.Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Validating += new CancelEventHandler(this.textBox_Validating));
            pnlDataProcess.Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Validating += new CancelEventHandler(this.textBox_Validating));
            pnlProduct.Controls.OfType<Panel>().ToList().ForEach(pnl =>
            {
                pnl.Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Validating += new CancelEventHandler(this.textBox_Validating));
            });

        }

        // Empty all the textboxes on a specific panel
        private void emptyTextBox(Panel pnl)
        {
            pnl.Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Text = "");
        }

        // Empty all the textboxes on the center area of the form
        private void emptyAllTextBoxes()
        {
            emptyTextBox(pnlProduct);
            pnlProduct.Controls.OfType<Panel>().ToList().ForEach(pnl => emptyTextBox(pnl));
        }
        
        // Clear form button click handler, resets form
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        // Exit button click handler, exits application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Validate UPC then enable bottom controls if UPC is valid, else show error message.
        private void btnEnterUPC_Click(object sender, EventArgs e)
        {
            string upc = txtEnterUPC.Text;
            string type = txtEnterUPC.Tag.ToString();
            if (errorProvider1.HasErrors())
            {
                MessageBox.Show("You need to correct the errors in your data before you can move on", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                emptyAllTextBoxes();
                btnDisplay.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnEnterUPC.Enabled = false;
            }
        }
        //Display the product associated with the UPC provided if it exists, otherwise display error message
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDisplay.Enabled = false;
            if (!db.FindProduct(txtEnterUPC.Text))
            {
                MessageBox.Show("Product not found, please try again!", "Product Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterUPC.Enabled = true;
                btnEnterUPC.Enabled = true;
                btnDisplay.Enabled = false;
                txtEnterUPC.Focus();
            }
            else
            {
                bool success;
                Product product = db.GetProduct(txtEnterUPC.Text, out success);
                if (success)
                {
                    displayProductInTextbox(product);
                }
            }
        }

        // Try to update a product in the database with the data provided in textboxes by user.
        // If the data is valid controls are enabled that allow them to enter information
        // And the current information for the product is displayed
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtEnterUPC.Enabled = false;
            btnEnterUPC.Enabled = false;
            btnDisplay.Enabled = false;
            btnDelete.Enabled = false;
            if (!db.FindProduct(txtEnterUPC.Text))
            {
                MessageBox.Show("Product not found, please try again!", "Product Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterUPC.Enabled = true;
                btnEnterUPC.Enabled = true;
                btnUpdate.Enabled = false;
                btnSaveUpdates.Enabled = false;
                txtEnterUPC.Focus();
            }
            else
            {
                bool success;
                Product product = db.GetProduct(txtEnterUPC.Text, out success);
                if (success)
                {
                    pnlCreateProduct.Enabled = false;
                    btnSaveUpdates.Enabled = true;
                    pnlProduct.Enabled = true;
                    if (product.Type == "BookCIS")
                    {
                        pnlBook.Enabled = true;
                        pnlCISBook.Enabled = true;
                        displayProductInTextbox(product);
                    }
                    else if (product.Type == "Book")
                    {
                        pnlBook.Enabled = true;
                        displayProductInTextbox(product);
                    }
                    else if (product.Type == "DVD")
                    {
                        pnlDVD.Enabled = true;
                        displayProductInTextbox(product);
                    }
                    else if (product.Type == "CDChamber")
                    {
                        pnlCDClassical.Enabled = true;
                        pnlCDChamber.Enabled = true;
                        displayProductInTextbox(product);
                    }
                    else if (product.Type == "CDOrchestra")
                    {
                        pnlCDClassical.Enabled = true;
                        pnlCDOrchestra.Enabled = true;
                        displayProductInTextbox(product);
                    }
                    txtUPC.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error retrieving product from db", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Click handler for save updates button
        // Checks that textbox entries are valid, then updates product entry in db
        private void btnSaveUpdates_Click(object sender, EventArgs e)
        {
            if (errorProvider1.HasErrors())
            {
                MessageBox.Show("You need to correct the errors in your data before you can move on", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Product newProduct;
                if (pnlCISBook.Enabled == true)
                {
                    newProduct = new BookCIS(txtUPC.Text, txtTitle.Text, decimal.Parse(txtPrice.Text), Int32.Parse(txtQuantity.Text), "BookCIS", txtISBN.Text, txtAuthor.Text, Int32.Parse(txtPages.Text), txtCISArea.Text);
                }
                else if (pnlBook.Enabled == true)
                {
                    newProduct = new Book(txtUPC.Text, txtTitle.Text, decimal.Parse(txtPrice.Text), Int32.Parse(txtQuantity.Text), "Book", txtISBN.Text, txtAuthor.Text, Int32.Parse(txtPages.Text));
                }
                else if (pnlDVD.Enabled == true)
                {
                    newProduct = new DVD(txtUPC.Text, txtTitle.Text, decimal.Parse(txtPrice.Text), Int32.Parse(txtQuantity.Text), "DVD", txtLeadActor.Text, dtpReleaseDate.Value, Int32.Parse(txtRuntime.Text));
                }
                else if (pnlCDChamber.Enabled == true)
                {
                    newProduct = new CDChamber(txtUPC.Text, txtTitle.Text, decimal.Parse(txtPrice.Text), Int32.Parse(txtQuantity.Text), "CDChamber", txtLabel.Text, txtArtists.Text, txtInstruments.Text);
                }
                else
                {
                    // Last option left
                    newProduct = new CDOrchestra(txtUPC.Text, txtTitle.Text, decimal.Parse(txtPrice.Text), Int32.Parse(txtQuantity.Text), "CDOrchestra", txtLabel.Text, txtArtists.Text, txtConductor.Text);
                }
                // Update product
                bool update = db.UpdateProduct(txtUPC.Text, newProduct);
                if (update)
                {
                    MessageBox.Show("Product successfully updated to:\n\n" + newProduct.DisplayProduct(), "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetForm();
                }
            }
        }

        // Click handler for delete button
        // Checks that product upc exists, and then prompts user to delete product from db
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtEnterUPC.Enabled = false;
            btnEnterUPC.Enabled = false;
            btnDisplay.Enabled = false;
            btnUpdate.Enabled = false;
            if (!db.FindProduct(txtEnterUPC.Text))
            {
                MessageBox.Show("Product not found, please try again!", "Product Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterUPC.Enabled = true;
                btnEnterUPC.Enabled = true;
                btnDelete.Enabled = false;
                txtEnterUPC.Focus();
            }
            else
            {
                bool success;
                Product p = db.GetProduct(txtEnterUPC.Text, out success);
                if (success)
                {
                    DialogResult result = MessageBox.Show("Confirm Product Delete \n\n" + p.DisplayProduct(), "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        bool del = db.DeleteProduct(txtEnterUPC.Text);
                        if (del)
                        {
                            MessageBox.Show("Delete Successful!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    txtEnterUPC.Enabled = true;
                    txtEnterUPC.Text = "";
                    btnEnterUPC.Enabled = true;
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error retrieving product from db", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Create product click handlers
        // Click handler for create book button, enables respective panels
        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            pnlProduct.Enabled = true;
            pnlBook.Enabled = true;
            pnlDataProcess.Enabled = false;
            pnlCreateProduct.Enabled = false;
            btnAddProduct.Enabled = true;
            emptyAllTextBoxes();
            errorProvider1.Forget();
        }

        // Click handler for create cis book button, enables respective panels
        private void btnCreateCIS_Click(object sender, EventArgs e)
        {
            pnlProduct.Enabled = true;
            pnlCISBook.Enabled = true;
            pnlBook.Enabled = true;
            pnlDataProcess.Enabled = false;
            pnlCreateProduct.Enabled = false;
            btnAddProduct.Enabled = true;
            emptyAllTextBoxes();
            errorProvider1.Forget();
        }

        // Click handler for create dvd button, enables respective panels
        private void btnCreateDVD_Click(object sender, EventArgs e)
        {
            pnlProduct.Enabled = true;
            pnlDVD.Enabled = true;
            pnlDataProcess.Enabled = false;
            pnlCreateProduct.Enabled = false;
            btnAddProduct.Enabled = true;
            emptyAllTextBoxes();
            errorProvider1.Forget();
        }

        // Click handler for create orchestra cd button, enables respective panels
        private void btnCreateOrchestra_Click(object sender, EventArgs e)
        {
            pnlProduct.Enabled = true;
            pnlCDOrchestra.Enabled = true;
            pnlCDClassical.Enabled = true;
            pnlDataProcess.Enabled = false;
            pnlCreateProduct.Enabled = false;
            btnAddProduct.Enabled = true;
            emptyAllTextBoxes();
            errorProvider1.Forget();
        }

        // Click handler for create chamber cd button, enables respective panels
        private void btnCreateChamber_Click(object sender, EventArgs e)
        {
            pnlProduct.Enabled = true;
            pnlCDChamber.Enabled = true;
            pnlCDClassical.Enabled = true;
            pnlDataProcess.Enabled = false;
            pnlCreateProduct.Enabled = false;
            btnAddProduct.Enabled = true;
            emptyAllTextBoxes();
            errorProvider1.Forget();
        }

        // Click handler for add product button, checks for valid textbox input and creates product to be added to db
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (errorProvider1.HasErrors())
            {
                MessageBox.Show("You need to correct the errors in your data before you can move on", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (db.FindProduct(txtUPC.Text))
            {
                MessageBox.Show("Product UPC already exists, please choose new UPC.", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Product newProduct;
                if (pnlCISBook.Enabled == true)
                {
                    newProduct = new BookCIS(txtUPC.Text, txtTitle.Text, decimal.Parse(txtPrice.Text.Trim('$')), Int32.Parse(txtQuantity.Text), "BookCIS", txtISBN.Text, txtAuthor.Text, Int32.Parse(txtPages.Text), txtCISArea.Text);
                }
                else if (pnlBook.Enabled == true)
                {
                    newProduct = new Book(txtUPC.Text, txtTitle.Text, decimal.Parse(txtPrice.Text.Trim('$')), Int32.Parse(txtQuantity.Text), "Book", txtISBN.Text, txtAuthor.Text, Int32.Parse(txtPages.Text));
                }
                else if (pnlDVD.Enabled == true)
                {
                   newProduct = new DVD(txtUPC.Text, txtTitle.Text, decimal.Parse(txtPrice.Text.Trim('$')), Int32.Parse(txtQuantity.Text), "DVD", txtLeadActor.Text, dtpReleaseDate.Value, Int32.Parse(txtRuntime.Text));
                }
                else if (pnlCDChamber.Enabled == true)
                {
                    newProduct = new CDChamber(txtUPC.Text, txtTitle.Text, decimal.Parse(txtPrice.Text.Trim('$')), Int32.Parse(txtQuantity.Text), "CDChamber", txtLabel.Text, txtArtists.Text, txtInstruments.Text);
                }
                else
                {
                    // Last option left
                    newProduct = new CDOrchestra(txtUPC.Text, txtTitle.Text, decimal.Parse(txtPrice.Text.Trim('$')), Int32.Parse(txtQuantity.Text), "CDOrchestra", txtLabel.Text, txtArtists.Text, txtConductor.Text);
                }

                bool add = db.InsertProduct(newProduct);
                if (add)
                {
                    MessageBox.Show("Product successfully added", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Product add failed, try again", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
 
        // Called whenever a form control with "Causes Validation" property set to true is focused(i.e. interacted with)
        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Enabled == false)
                return;
        
            string type = textbox.Tag.ToString();
            string text = textbox.Text;
            
            if(!vm.Validate(text, type))
            {
                errorProvider1.SetErrorWithCount(textbox, "Invalid Value");
            }
            else
            {
                errorProvider1.SetErrorWithCount(textbox,"");
            }
        }
        
        // Displays product in proper textboxes depending on what type of product it is
        private void displayProductInTextbox(Product p)
        {
            txtUPC.Text = p.Upc;
            txtPrice.Text = p.Price.ToString();
            txtTitle.Text = p.Title;
            txtQuantity.Text = p.Quantity.ToString();
            if (p.Type == "BookCIS" || p.Type == "Book")
            {
                Book b = (Book)p;
                txtISBN.Text = b.Isbn;
                txtAuthor.Text = b.Author;
                txtPages.Text = b.Pages.ToString();
                if (p.Type == "BookCIS")
                {
                    BookCIS b2 = (BookCIS)p;
                    txtCISArea.Text = b2.CISAREA;
                }
            }
            else if (p.Type == "DVD")
            {
                DVD d = (DVD)p;
                txtLeadActor.Text = d.LeadActor;
                txtRuntime.Text = d.RunTime.ToString();
                dtpReleaseDate.Value = d.ReleaseDate;
            }
            else if (p.Type == "CDClassical" || p.Type == "CDChamber" || p.Type == "CDOrchestra")
            {
                CDClassical cd = (CDClassical)p;
                txtLabel.Text = cd.Label;
                txtArtists.Text = cd.Artists;
                if (p.GetType() == typeof(CDOrchestra))
                {
                    CDOrchestra cd1 = (CDOrchestra)p;
                    txtConductor.Text = cd1.Conductor;
                }
                if (p.GetType() == typeof(CDChamber))
                {
                    CDChamber cd2 = (CDChamber)p;
                    txtInstruments.Text = cd2.InstrumentList;
                }
            }
        }
        
        // Resets form controls to default config, for reset form button and other instances
        // Empties textboxes and disables all but initial form controls
        private void resetForm()
        {
            emptyTextBox(pnlProduct);
            pnlProduct.Controls.OfType<Panel>().ToList().ForEach(pnl => emptyTextBox(pnl));

            btnAddProduct.Enabled = false;
            pnlProduct.Controls.OfType<Panel>().ToList().ForEach(pnl => pnl.Enabled = false);
            pnlProduct.Enabled = false;
            pnlCreateProduct.Enabled = true;
            pnlDataProcess.Enabled = true;

            pnlDataProcess.Controls.OfType<Button>().ToList().ForEach(btn =>
            {
                if (string.Equals(btn.Text, "Enter UPC")) btn.Enabled = true; else btn.Enabled = false;
            });

            txtEnterUPC.Text = "";
            txtEnterUPC.Enabled = true;
            txtUPC.Enabled = true;
            txtEnterUPC.Focus();
            errorProvider1.Forget();
        }
    }
}
