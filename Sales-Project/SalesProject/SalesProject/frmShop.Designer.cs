namespace SalesProject
{
    partial class frmShop
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
            this.components = new System.ComponentModel.Container();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlCreateProduct = new System.Windows.Forms.Panel();
            this.btnCreateChamber = new System.Windows.Forms.Button();
            this.btnCreateOrchestra = new System.Windows.Forms.Button();
            this.btnCreateDVD = new System.Windows.Forms.Button();
            this.btnCreateCIS = new System.Windows.Forms.Button();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.lblNewProduct = new System.Windows.Forms.Label();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.pnlCDChamber = new System.Windows.Forms.Panel();
            this.lblInstruments = new System.Windows.Forms.Label();
            this.lblCDChamber = new System.Windows.Forms.Label();
            this.txtInstruments = new System.Windows.Forms.TextBox();
            this.pnlCDOrchestra = new System.Windows.Forms.Panel();
            this.lblConductor = new System.Windows.Forms.Label();
            this.txtConductor = new System.Windows.Forms.TextBox();
            this.lblCDOrchestra = new System.Windows.Forms.Label();
            this.pnlCDClassical = new System.Windows.Forms.Panel();
            this.txtArtists = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.lblArtists = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblCDClassical = new System.Windows.Forms.Label();
            this.pnlDVD = new System.Windows.Forms.Panel();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtRuntime = new System.Windows.Forms.TextBox();
            this.txtLeadActor = new System.Windows.Forms.TextBox();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lblDVD = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblLeadActor = new System.Windows.Forms.Label();
            this.pnlCISBook = new System.Windows.Forms.Panel();
            this.lblCISArea = new System.Windows.Forms.Label();
            this.txtCISArea = new System.Windows.Forms.TextBox();
            this.lblCISBook = new System.Windows.Forms.Label();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUPC = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.pnlDataProcess = new System.Windows.Forms.Panel();
            this.txtEnterUPC = new System.Windows.Forms.TextBox();
            this.lblUPCRequired = new System.Windows.Forms.Label();
            this.btnEnterUPC = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSaveUpdates = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDataProcessing = new System.Windows.Forms.Label();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlCreateProduct.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            this.pnlCDChamber.SuspendLayout();
            this.pnlCDOrchestra.SuspendLayout();
            this.pnlCDClassical.SuspendLayout();
            this.pnlDVD.SuspendLayout();
            this.pnlCISBook.SuspendLayout();
            this.pnlBook.SuspendLayout();
            this.pnlDataProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblWelcome.Location = new System.Drawing.Point(225, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(331, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Book CD DVD Shop";
            // 
            // pnlCreateProduct
            // 
            this.pnlCreateProduct.Controls.Add(this.btnCreateChamber);
            this.pnlCreateProduct.Controls.Add(this.btnCreateOrchestra);
            this.pnlCreateProduct.Controls.Add(this.btnCreateDVD);
            this.pnlCreateProduct.Controls.Add(this.btnCreateCIS);
            this.pnlCreateProduct.Controls.Add(this.btnCreateBook);
            this.pnlCreateProduct.Location = new System.Drawing.Point(43, 46);
            this.pnlCreateProduct.Name = "pnlCreateProduct";
            this.pnlCreateProduct.Size = new System.Drawing.Size(702, 57);
            this.pnlCreateProduct.TabIndex = 1;
            // 
            // btnCreateChamber
            // 
            this.btnCreateChamber.CausesValidation = false;
            this.btnCreateChamber.Location = new System.Drawing.Point(542, 22);
            this.btnCreateChamber.Name = "btnCreateChamber";
            this.btnCreateChamber.Size = new System.Drawing.Size(119, 23);
            this.btnCreateChamber.TabIndex = 4;
            this.btnCreateChamber.Text = "Create Chamber CD";
            this.btnCreateChamber.UseVisualStyleBackColor = true;
            this.btnCreateChamber.Click += new System.EventHandler(this.btnCreateChamber_Click);
            // 
            // btnCreateOrchestra
            // 
            this.btnCreateOrchestra.CausesValidation = false;
            this.btnCreateOrchestra.Location = new System.Drawing.Point(387, 22);
            this.btnCreateOrchestra.Name = "btnCreateOrchestra";
            this.btnCreateOrchestra.Size = new System.Drawing.Size(121, 23);
            this.btnCreateOrchestra.TabIndex = 3;
            this.btnCreateOrchestra.Text = "Create Orchestra CD";
            this.btnCreateOrchestra.UseVisualStyleBackColor = true;
            this.btnCreateOrchestra.Click += new System.EventHandler(this.btnCreateOrchestra_Click);
            // 
            // btnCreateDVD
            // 
            this.btnCreateDVD.CausesValidation = false;
            this.btnCreateDVD.Location = new System.Drawing.Point(281, 22);
            this.btnCreateDVD.Name = "btnCreateDVD";
            this.btnCreateDVD.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDVD.TabIndex = 2;
            this.btnCreateDVD.Text = "Create DVD";
            this.btnCreateDVD.UseVisualStyleBackColor = true;
            this.btnCreateDVD.Click += new System.EventHandler(this.btnCreateDVD_Click);
            // 
            // btnCreateCIS
            // 
            this.btnCreateCIS.CausesValidation = false;
            this.btnCreateCIS.Location = new System.Drawing.Point(148, 22);
            this.btnCreateCIS.Name = "btnCreateCIS";
            this.btnCreateCIS.Size = new System.Drawing.Size(96, 23);
            this.btnCreateCIS.TabIndex = 1;
            this.btnCreateCIS.Text = "Create CIS Book";
            this.btnCreateCIS.UseVisualStyleBackColor = true;
            this.btnCreateCIS.Click += new System.EventHandler(this.btnCreateCIS_Click);
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.CausesValidation = false;
            this.btnCreateBook.Location = new System.Drawing.Point(40, 22);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(75, 23);
            this.btnCreateBook.TabIndex = 0;
            this.btnCreateBook.Text = "Create Book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // lblNewProduct
            // 
            this.lblNewProduct.AutoSize = true;
            this.lblNewProduct.Location = new System.Drawing.Point(71, 49);
            this.lblNewProduct.Name = "lblNewProduct";
            this.lblNewProduct.Size = new System.Drawing.Size(112, 13);
            this.lblNewProduct.TabIndex = 2;
            this.lblNewProduct.Text = "Create a New Product";
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.pnlCDChamber);
            this.pnlProduct.Controls.Add(this.pnlCDOrchestra);
            this.pnlProduct.Controls.Add(this.pnlCDClassical);
            this.pnlProduct.Controls.Add(this.pnlDVD);
            this.pnlProduct.Controls.Add(this.pnlCISBook);
            this.pnlProduct.Controls.Add(this.pnlBook);
            this.pnlProduct.Controls.Add(this.lblQuantity);
            this.pnlProduct.Controls.Add(this.lblTitle);
            this.pnlProduct.Controls.Add(this.lblPrice);
            this.pnlProduct.Controls.Add(this.lblUPC);
            this.pnlProduct.Controls.Add(this.txtQuantity);
            this.pnlProduct.Controls.Add(this.txtTitle);
            this.pnlProduct.Controls.Add(this.txtPrice);
            this.pnlProduct.Controls.Add(this.txtUPC);
            this.pnlProduct.Controls.Add(this.lblProduct);
            this.pnlProduct.Enabled = false;
            this.pnlProduct.Location = new System.Drawing.Point(43, 149);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(636, 363);
            this.pnlProduct.TabIndex = 3;
            // 
            // pnlCDChamber
            // 
            this.pnlCDChamber.Controls.Add(this.lblInstruments);
            this.pnlCDChamber.Controls.Add(this.lblCDChamber);
            this.pnlCDChamber.Controls.Add(this.txtInstruments);
            this.pnlCDChamber.Enabled = false;
            this.pnlCDChamber.Location = new System.Drawing.Point(320, 293);
            this.pnlCDChamber.Name = "pnlCDChamber";
            this.pnlCDChamber.Size = new System.Drawing.Size(298, 58);
            this.pnlCDChamber.TabIndex = 26;
            // 
            // lblInstruments
            // 
            this.lblInstruments.AutoSize = true;
            this.lblInstruments.Location = new System.Drawing.Point(43, 25);
            this.lblInstruments.Name = "lblInstruments";
            this.lblInstruments.Size = new System.Drawing.Size(61, 13);
            this.lblInstruments.TabIndex = 27;
            this.lblInstruments.Text = "Instruments";
            // 
            // lblCDChamber
            // 
            this.lblCDChamber.AutoSize = true;
            this.lblCDChamber.Location = new System.Drawing.Point(3, 3);
            this.lblCDChamber.Name = "lblCDChamber";
            this.lblCDChamber.Size = new System.Drawing.Size(98, 13);
            this.lblCDChamber.TabIndex = 28;
            this.lblCDChamber.Text = "Chamber Music CD";
            // 
            // txtInstruments
            // 
            this.txtInstruments.Location = new System.Drawing.Point(109, 22);
            this.txtInstruments.Name = "txtInstruments";
            this.txtInstruments.Size = new System.Drawing.Size(174, 20);
            this.txtInstruments.TabIndex = 19;
            this.txtInstruments.Tag = "6";
            this.toolTip1.SetToolTip(this.txtInstruments, "Comma seperated list e.g. Guitar, obo, drum, tuba");
            // 
            // pnlCDOrchestra
            // 
            this.pnlCDOrchestra.Controls.Add(this.lblConductor);
            this.pnlCDOrchestra.Controls.Add(this.txtConductor);
            this.pnlCDOrchestra.Controls.Add(this.lblCDOrchestra);
            this.pnlCDOrchestra.Enabled = false;
            this.pnlCDOrchestra.Location = new System.Drawing.Point(24, 293);
            this.pnlCDOrchestra.Name = "pnlCDOrchestra";
            this.pnlCDOrchestra.Size = new System.Drawing.Size(289, 58);
            this.pnlCDOrchestra.TabIndex = 23;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Location = new System.Drawing.Point(30, 25);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(56, 13);
            this.lblConductor.TabIndex = 24;
            this.lblConductor.Text = "Conductor";
            // 
            // txtConductor
            // 
            this.txtConductor.Location = new System.Drawing.Point(91, 22);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.Size = new System.Drawing.Size(129, 20);
            this.txtConductor.TabIndex = 18;
            this.txtConductor.Tag = "4";
            this.toolTip1.SetToolTip(this.txtConductor, "Name: Can include apostrophes, comamas, titles. E.g. Dr Frank Fried-man");
            // 
            // lblCDOrchestra
            // 
            this.lblCDOrchestra.AutoSize = true;
            this.lblCDOrchestra.Location = new System.Drawing.Point(4, 3);
            this.lblCDOrchestra.Name = "lblCDOrchestra";
            this.lblCDOrchestra.Size = new System.Drawing.Size(73, 13);
            this.lblCDOrchestra.TabIndex = 0;
            this.lblCDOrchestra.Text = "Orchestral CD";
            // 
            // pnlCDClassical
            // 
            this.pnlCDClassical.Controls.Add(this.txtArtists);
            this.pnlCDClassical.Controls.Add(this.txtLabel);
            this.pnlCDClassical.Controls.Add(this.lblArtists);
            this.pnlCDClassical.Controls.Add(this.lblLabel);
            this.pnlCDClassical.Controls.Add(this.lblCDClassical);
            this.pnlCDClassical.Enabled = false;
            this.pnlCDClassical.Location = new System.Drawing.Point(24, 235);
            this.pnlCDClassical.Name = "pnlCDClassical";
            this.pnlCDClassical.Size = new System.Drawing.Size(594, 52);
            this.pnlCDClassical.TabIndex = 22;
            // 
            // txtArtists
            // 
            this.txtArtists.Location = new System.Drawing.Point(274, 21);
            this.txtArtists.Name = "txtArtists";
            this.txtArtists.Size = new System.Drawing.Size(210, 20);
            this.txtArtists.TabIndex = 17;
            this.txtArtists.Tag = "4";
            this.toolTip1.SetToolTip(this.txtArtists, "Name: Can include apostrophes, comamas, titles. E.g. Dr Frank Fried-man");
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(69, 21);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(100, 20);
            this.txtLabel.TabIndex = 16;
            this.txtLabel.Tag = "7";
            this.toolTip1.SetToolTip(this.txtLabel, "Non empty string");
            // 
            // lblArtists
            // 
            this.lblArtists.AutoSize = true;
            this.lblArtists.Location = new System.Drawing.Point(233, 24);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(35, 13);
            this.lblArtists.TabIndex = 2;
            this.lblArtists.Text = "Artists";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(30, 24);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(33, 13);
            this.lblLabel.TabIndex = 1;
            this.lblLabel.Text = "Label";
            // 
            // lblCDClassical
            // 
            this.lblCDClassical.AutoSize = true;
            this.lblCDClassical.Location = new System.Drawing.Point(4, 3);
            this.lblCDClassical.Name = "lblCDClassical";
            this.lblCDClassical.Size = new System.Drawing.Size(66, 13);
            this.lblCDClassical.TabIndex = 0;
            this.lblCDClassical.Text = "Classical CD";
            // 
            // pnlDVD
            // 
            this.pnlDVD.Controls.Add(this.dtpReleaseDate);
            this.pnlDVD.Controls.Add(this.txtRuntime);
            this.pnlDVD.Controls.Add(this.txtLeadActor);
            this.pnlDVD.Controls.Add(this.lblRuntime);
            this.pnlDVD.Controls.Add(this.lblDVD);
            this.pnlDVD.Controls.Add(this.lblReleaseDate);
            this.pnlDVD.Controls.Add(this.lblLeadActor);
            this.pnlDVD.Enabled = false;
            this.pnlDVD.Location = new System.Drawing.Point(24, 176);
            this.pnlDVD.Name = "pnlDVD";
            this.pnlDVD.Size = new System.Drawing.Size(594, 52);
            this.pnlDVD.TabIndex = 21;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.CausesValidation = false;
            this.dtpReleaseDate.Location = new System.Drawing.Point(274, 19);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReleaseDate.TabIndex = 14;
            // 
            // txtRuntime
            // 
            this.txtRuntime.Location = new System.Drawing.Point(532, 19);
            this.txtRuntime.Name = "txtRuntime";
            this.txtRuntime.Size = new System.Drawing.Size(47, 20);
            this.txtRuntime.TabIndex = 15;
            this.txtRuntime.Tag = "3";
            this.toolTip1.SetToolTip(this.txtRuntime, "Positive Integer less than 300");
            // 
            // txtLeadActor
            // 
            this.txtLeadActor.Location = new System.Drawing.Point(93, 19);
            this.txtLeadActor.Name = "txtLeadActor";
            this.txtLeadActor.Size = new System.Drawing.Size(86, 20);
            this.txtLeadActor.TabIndex = 13;
            this.txtLeadActor.Tag = "4";
            this.toolTip1.SetToolTip(this.txtLeadActor, "Name: Can include apostrophes, comamas, titles. E.g. Dr Frank Fried-man");
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(484, 22);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(46, 13);
            this.lblRuntime.TabIndex = 24;
            this.lblRuntime.Text = "Runtime";
            // 
            // lblDVD
            // 
            this.lblDVD.AutoSize = true;
            this.lblDVD.Location = new System.Drawing.Point(4, 3);
            this.lblDVD.Name = "lblDVD";
            this.lblDVD.Size = new System.Drawing.Size(30, 13);
            this.lblDVD.TabIndex = 0;
            this.lblDVD.Text = "DVD";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(200, 22);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(72, 13);
            this.lblReleaseDate.TabIndex = 23;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // lblLeadActor
            // 
            this.lblLeadActor.AutoSize = true;
            this.lblLeadActor.Location = new System.Drawing.Point(30, 22);
            this.lblLeadActor.Name = "lblLeadActor";
            this.lblLeadActor.Size = new System.Drawing.Size(59, 13);
            this.lblLeadActor.TabIndex = 22;
            this.lblLeadActor.Text = "Lead Actor";
            // 
            // pnlCISBook
            // 
            this.pnlCISBook.Controls.Add(this.lblCISArea);
            this.pnlCISBook.Controls.Add(this.txtCISArea);
            this.pnlCISBook.Controls.Add(this.lblCISBook);
            this.pnlCISBook.Enabled = false;
            this.pnlCISBook.Location = new System.Drawing.Point(24, 112);
            this.pnlCISBook.Name = "pnlCISBook";
            this.pnlCISBook.Size = new System.Drawing.Size(594, 53);
            this.pnlCISBook.TabIndex = 20;
            // 
            // lblCISArea
            // 
            this.lblCISArea.AutoSize = true;
            this.lblCISArea.Location = new System.Drawing.Point(30, 26);
            this.lblCISArea.Name = "lblCISArea";
            this.lblCISArea.Size = new System.Drawing.Size(49, 13);
            this.lblCISArea.TabIndex = 21;
            this.lblCISArea.Text = "CIS Area";
            // 
            // txtCISArea
            // 
            this.txtCISArea.Location = new System.Drawing.Point(86, 23);
            this.txtCISArea.Name = "txtCISArea";
            this.txtCISArea.Size = new System.Drawing.Size(203, 20);
            this.txtCISArea.TabIndex = 12;
            this.txtCISArea.Tag = "7";
            this.toolTip1.SetToolTip(this.txtCISArea, "Non empty string");
            // 
            // lblCISBook
            // 
            this.lblCISBook.AutoSize = true;
            this.lblCISBook.Location = new System.Drawing.Point(4, 3);
            this.lblCISBook.Name = "lblCISBook";
            this.lblCISBook.Size = new System.Drawing.Size(52, 13);
            this.lblCISBook.TabIndex = 0;
            this.lblCISBook.Text = "CIS Book";
            // 
            // pnlBook
            // 
            this.pnlBook.Controls.Add(this.txtPages);
            this.pnlBook.Controls.Add(this.lblPages);
            this.pnlBook.Controls.Add(this.lblAuthor);
            this.pnlBook.Controls.Add(this.txtAuthor);
            this.pnlBook.Controls.Add(this.lblISBN);
            this.pnlBook.Controls.Add(this.lblBook);
            this.pnlBook.Controls.Add(this.txtISBN);
            this.pnlBook.Enabled = false;
            this.pnlBook.Location = new System.Drawing.Point(24, 54);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(594, 50);
            this.pnlBook.TabIndex = 13;
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(449, 22);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(100, 20);
            this.txtPages.TabIndex = 11;
            this.txtPages.Tag = "3";
            this.toolTip1.SetToolTip(this.txtPages, "Positive Integer");
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(408, 25);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(37, 13);
            this.lblPages.TabIndex = 17;
            this.lblPages.Text = "Pages";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(187, 25);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 18;
            this.lblAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(228, 22);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(150, 20);
            this.txtAuthor.TabIndex = 10;
            this.txtAuthor.Tag = "4";
            this.toolTip1.SetToolTip(this.txtAuthor, "Name: Can include apostrophes, comamas, titles. E.g. Dr Frank Fried-man");
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(30, 25);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 19;
            this.lblISBN.Text = "ISBN";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(4, 3);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(32, 13);
            this.lblBook.TabIndex = 0;
            this.lblBook.Text = "Book";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(71, 22);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(98, 20);
            this.txtISBN.TabIndex = 9;
            this.txtISBN.Tag = "5";
            this.toolTip1.SetToolTip(this.txtISBN, "ISBN Number: ###-###");
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(515, 26);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(317, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Title";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(163, 26);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // lblUPC
            // 
            this.lblUPC.AutoSize = true;
            this.lblUPC.Location = new System.Drawing.Point(34, 26);
            this.lblUPC.Name = "lblUPC";
            this.lblUPC.Size = new System.Drawing.Size(29, 13);
            this.lblUPC.TabIndex = 9;
            this.lblUPC.Text = "UPC";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(564, 23);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(46, 20);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.Tag = "3";
            this.toolTip1.SetToolTip(this.txtQuantity, "Number greater than 0");
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(347, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(138, 20);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.Tag = "7";
            this.toolTip1.SetToolTip(this.txtTitle, "Non empty string");
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(197, 23);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(95, 20);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.Tag = "2";
            this.toolTip1.SetToolTip(this.txtPrice, "Dollar sign optional price $###.## ");
            // 
            // txtUPC
            // 
            this.txtUPC.Location = new System.Drawing.Point(66, 23);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(73, 20);
            this.txtUPC.TabIndex = 5;
            this.txtUPC.Tag = "1";
            this.toolTip1.SetToolTip(this.txtUPC, "5 Digits, not starting with 0. E.g. 12345");
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(28, 3);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 4;
            this.lblProduct.Text = "Product";
            // 
            // pnlDataProcess
            // 
            this.pnlDataProcess.Controls.Add(this.txtEnterUPC);
            this.pnlDataProcess.Controls.Add(this.lblUPCRequired);
            this.pnlDataProcess.Controls.Add(this.btnEnterUPC);
            this.pnlDataProcess.Controls.Add(this.btnDisplay);
            this.pnlDataProcess.Controls.Add(this.btnUpdate);
            this.pnlDataProcess.Controls.Add(this.btnSaveUpdates);
            this.pnlDataProcess.Controls.Add(this.btnDelete);
            this.pnlDataProcess.Controls.Add(this.lblDataProcessing);
            this.pnlDataProcess.Location = new System.Drawing.Point(67, 529);
            this.pnlDataProcess.Name = "pnlDataProcess";
            this.pnlDataProcess.Size = new System.Drawing.Size(594, 100);
            this.pnlDataProcess.TabIndex = 27;
            // 
            // txtEnterUPC
            // 
            this.txtEnterUPC.Location = new System.Drawing.Point(16, 47);
            this.txtEnterUPC.Name = "txtEnterUPC";
            this.txtEnterUPC.Size = new System.Drawing.Size(84, 20);
            this.txtEnterUPC.TabIndex = 20;
            this.txtEnterUPC.Tag = "1";
            this.toolTip1.SetToolTip(this.txtEnterUPC, "5 Digits, not starting with 0. E.g. 12345");
            // 
            // lblUPCRequired
            // 
            this.lblUPCRequired.AutoSize = true;
            this.lblUPCRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblUPCRequired.ForeColor = System.Drawing.Color.Red;
            this.lblUPCRequired.Location = new System.Drawing.Point(4, 19);
            this.lblUPCRequired.Name = "lblUPCRequired";
            this.lblUPCRequired.Size = new System.Drawing.Size(529, 17);
            this.lblUPCRequired.TabIndex = 28;
            this.lblUPCRequired.Text = "Must enter a valid UPC in the textbox below to execute these operations";
            // 
            // btnEnterUPC
            // 
            this.btnEnterUPC.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnEnterUPC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnterUPC.Location = new System.Drawing.Point(16, 73);
            this.btnEnterUPC.Name = "btnEnterUPC";
            this.btnEnterUPC.Size = new System.Drawing.Size(75, 23);
            this.btnEnterUPC.TabIndex = 21;
            this.btnEnterUPC.Text = "Enter UPC";
            this.btnEnterUPC.UseVisualStyleBackColor = false;
            this.btnEnterUPC.Click += new System.EventHandler(this.btnEnterUPC_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Enabled = false;
            this.btnDisplay.Location = new System.Drawing.Point(152, 58);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(86, 23);
            this.btnDisplay.TabIndex = 22;
            this.btnDisplay.Text = "Find/ Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(251, 58);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Edit/ Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSaveUpdates
            // 
            this.btnSaveUpdates.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveUpdates.Enabled = false;
            this.btnSaveUpdates.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveUpdates.Location = new System.Drawing.Point(349, 58);
            this.btnSaveUpdates.Name = "btnSaveUpdates";
            this.btnSaveUpdates.Size = new System.Drawing.Size(88, 23);
            this.btnSaveUpdates.TabIndex = 24;
            this.btnSaveUpdates.Text = "Save Updates";
            this.btnSaveUpdates.UseVisualStyleBackColor = false;
            this.btnSaveUpdates.Click += new System.EventHandler(this.btnSaveUpdates_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(445, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDataProcessing
            // 
            this.lblDataProcessing.AutoSize = true;
            this.lblDataProcessing.Location = new System.Drawing.Point(4, 3);
            this.lblDataProcessing.Name = "lblDataProcessing";
            this.lblDataProcessing.Size = new System.Drawing.Size(85, 13);
            this.lblDataProcessing.TabIndex = 0;
            this.lblDataProcessing.Text = "Data Processing";
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.Red;
            this.btnResetForm.CausesValidation = false;
            this.btnResetForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResetForm.Location = new System.Drawing.Point(696, 199);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 37);
            this.btnResetForm.TabIndex = 27;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.CausesValidation = false;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(696, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(71, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "To display, edit, or delete a product, see bottom controls";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddProduct.Enabled = false;
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddProduct.Location = new System.Drawing.Point(696, 147);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 37);
            this.btnAddProduct.TabIndex = 26;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 647);
            this.Controls.Add(this.pnlDataProcess);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.lblNewProduct);
            this.Controls.Add(this.pnlCreateProduct);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmShop";
            this.Text = "Shop";
            this.pnlCreateProduct.ResumeLayout(false);
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.pnlCDChamber.ResumeLayout(false);
            this.pnlCDChamber.PerformLayout();
            this.pnlCDOrchestra.ResumeLayout(false);
            this.pnlCDOrchestra.PerformLayout();
            this.pnlCDClassical.ResumeLayout(false);
            this.pnlCDClassical.PerformLayout();
            this.pnlDVD.ResumeLayout(false);
            this.pnlDVD.PerformLayout();
            this.pnlCISBook.ResumeLayout(false);
            this.pnlCISBook.PerformLayout();
            this.pnlBook.ResumeLayout(false);
            this.pnlBook.PerformLayout();
            this.pnlDataProcess.ResumeLayout(false);
            this.pnlDataProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlCreateProduct;
        private System.Windows.Forms.Button btnCreateChamber;
        private System.Windows.Forms.Button btnCreateOrchestra;
        private System.Windows.Forms.Button btnCreateDVD;
        private System.Windows.Forms.Button btnCreateCIS;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.Label lblNewProduct;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Panel pnlBook;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblUPC;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUPC;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel pnlCISBook;
        private System.Windows.Forms.Label lblCISArea;
        private System.Windows.Forms.TextBox txtCISArea;
        private System.Windows.Forms.Label lblCISBook;
        private System.Windows.Forms.Panel pnlCDClassical;
        private System.Windows.Forms.Label lblCDClassical;
        private System.Windows.Forms.Panel pnlDVD;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.TextBox txtRuntime;
        private System.Windows.Forms.TextBox txtLeadActor;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Label lblDVD;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblLeadActor;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtArtists;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Panel pnlDataProcess;
        private System.Windows.Forms.Label lblUPCRequired;
        private System.Windows.Forms.Button btnEnterUPC;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSaveUpdates;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDataProcessing;
        private System.Windows.Forms.Panel pnlCDChamber;
        private System.Windows.Forms.Label lblInstruments;
        private System.Windows.Forms.Label lblCDChamber;
        private System.Windows.Forms.TextBox txtInstruments;
        private System.Windows.Forms.Panel pnlCDOrchestra;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.TextBox txtConductor;
        private System.Windows.Forms.Label lblCDOrchestra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtEnterUPC;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

