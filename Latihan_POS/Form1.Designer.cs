namespace Latihan_POS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnCustSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCustCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCustEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCustDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCustNew = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DataGridViewCust = new System.Windows.Forms.DataGridView();
            this.custidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custphonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posdbDataSet1 = new Latihan_POS.posdbDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCustAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCustHP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCustEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCustID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCustName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCustSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnProductSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnProductCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnProductEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnProductDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnProductNew = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productinitialamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producthpppriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsellingpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtProductSellingPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtProductHPPPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtProductInitialAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtProductName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtProductID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtProductSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.BtnSuppliersDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnSuppliersSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSuppliersCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSuppliersEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSuppliersNew = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.suppliers_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierszipcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersphonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtSuppliersID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel31 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSuppliersPhoneNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSuppliersZipCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSuppliersAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSuppliersName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSuppliersEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSuppliersSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.TxtPurTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPurProductID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TxtPurSupplierID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel39 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnPurchaseSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnPurchaseEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnPurchaseDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnPurchaseLogout = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnPurchaseLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnPurchaseAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtPurSupplierEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel32 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtPurSupplierPhoneNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtPurSupplierZipCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtPurSupplierAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtPurSupplierName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.TxtSaleTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtSaleProductID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtSaleCustID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnSaleSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSaleCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSaleEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSaleDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSaleLogout = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSaleLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSaleAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TxtSaleCustAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSaleCustPhoneNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSaleCustEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel30 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSaleCustName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel37 = new MaterialSkin.Controls.MaterialLabel();
            this.customersTableAdapter = new Latihan_POS.posdbDataSet1TableAdapters.customersTableAdapter();
            this.productsTableAdapter = new Latihan_POS.posdbDataSet1TableAdapters.productsTableAdapter();
            this.suppliersTableAdapter = new Latihan_POS.posdbDataSet1TableAdapters.suppliersTableAdapter();
            this.suppliersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productinitialamountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producthpppriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsellingpriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productinitialamountDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producthpppriceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsellingpriceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posdbDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "login-icon.jpg");
            this.imageList1.Images.SetKeyName(1, "rdp.png");
            this.imageList1.Images.SetKeyName(2, "Cash_register.png");
            this.imageList1.Images.SetKeyName(3, "search.png");
            this.imageList1.Images.SetKeyName(4, "customer.png");
            this.imageList1.Images.SetKeyName(5, "product.png");
            this.imageList1.Images.SetKeyName(6, "supplier.png");
            this.imageList1.Images.SetKeyName(7, "Purcase.png");
            this.imageList1.Images.SetKeyName(8, "sale.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 445);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.ImageKey = "login-icon.jpg";
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.ImageList = this.imageList1;
            this.tabControl2.Location = new System.Drawing.Point(6, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(597, 425);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage3.Controls.Add(this.BtnCustSave);
            this.tabPage3.Controls.Add(this.BtnCustCancel);
            this.tabPage3.Controls.Add(this.BtnCustEdit);
            this.tabPage3.Controls.Add(this.BtnCustDelete);
            this.tabPage3.Controls.Add(this.BtnCustNew);
            this.tabPage3.Controls.Add(this.DataGridViewCust);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.TxtCustSearch);
            this.tabPage3.Controls.Add(this.materialLabel6);
            this.tabPage3.ImageKey = "customer.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(589, 398);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Customers";
            // 
            // BtnCustSave
            // 
            this.BtnCustSave.Depth = 0;
            this.BtnCustSave.Location = new System.Drawing.Point(427, 367);
            this.BtnCustSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCustSave.Name = "BtnCustSave";
            this.BtnCustSave.Primary = true;
            this.BtnCustSave.Size = new System.Drawing.Size(75, 23);
            this.BtnCustSave.TabIndex = 4;
            this.BtnCustSave.Text = "Save";
            this.BtnCustSave.UseVisualStyleBackColor = true;
            this.BtnCustSave.Click += new System.EventHandler(this.BtnCustSave_Click);
            // 
            // BtnCustCancel
            // 
            this.BtnCustCancel.Depth = 0;
            this.BtnCustCancel.Location = new System.Drawing.Point(508, 367);
            this.BtnCustCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCustCancel.Name = "BtnCustCancel";
            this.BtnCustCancel.Primary = true;
            this.BtnCustCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCustCancel.TabIndex = 3;
            this.BtnCustCancel.Text = "Cancel";
            this.BtnCustCancel.UseVisualStyleBackColor = true;
            this.BtnCustCancel.Click += new System.EventHandler(this.BtnCustCancel_Click);
            // 
            // BtnCustEdit
            // 
            this.BtnCustEdit.Depth = 0;
            this.BtnCustEdit.Location = new System.Drawing.Point(265, 367);
            this.BtnCustEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCustEdit.Name = "BtnCustEdit";
            this.BtnCustEdit.Primary = true;
            this.BtnCustEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnCustEdit.TabIndex = 2;
            this.BtnCustEdit.Text = "Edit";
            this.BtnCustEdit.UseVisualStyleBackColor = true;
            this.BtnCustEdit.Click += new System.EventHandler(this.BtnCustEdit_Click);
            // 
            // BtnCustDelete
            // 
            this.BtnCustDelete.Depth = 0;
            this.BtnCustDelete.Location = new System.Drawing.Point(346, 367);
            this.BtnCustDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCustDelete.Name = "BtnCustDelete";
            this.BtnCustDelete.Primary = true;
            this.BtnCustDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnCustDelete.TabIndex = 1;
            this.BtnCustDelete.Text = "Delete";
            this.BtnCustDelete.UseVisualStyleBackColor = true;
            this.BtnCustDelete.Click += new System.EventHandler(this.BtnCustDelete_Click);
            // 
            // BtnCustNew
            // 
            this.BtnCustNew.Depth = 0;
            this.BtnCustNew.Location = new System.Drawing.Point(184, 367);
            this.BtnCustNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCustNew.Name = "BtnCustNew";
            this.BtnCustNew.Primary = true;
            this.BtnCustNew.Size = new System.Drawing.Size(75, 23);
            this.BtnCustNew.TabIndex = 1;
            this.BtnCustNew.Text = "New";
            this.BtnCustNew.UseVisualStyleBackColor = true;
            this.BtnCustNew.Click += new System.EventHandler(this.BtnCustNew_Click);
            // 
            // DataGridViewCust
            // 
            this.DataGridViewCust.AllowUserToAddRows = false;
            this.DataGridViewCust.AutoGenerateColumns = false;
            this.DataGridViewCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custidDataGridViewTextBoxColumn,
            this.custnameDataGridViewTextBoxColumn,
            this.custemailDataGridViewTextBoxColumn,
            this.custphonenumberDataGridViewTextBoxColumn,
            this.custaddressDataGridViewTextBoxColumn});
            this.DataGridViewCust.DataSource = this.customersBindingSource;
            this.DataGridViewCust.Location = new System.Drawing.Point(7, 208);
            this.DataGridViewCust.Name = "DataGridViewCust";
            this.DataGridViewCust.Size = new System.Drawing.Size(576, 150);
            this.DataGridViewCust.TabIndex = 3;
            // 
            // custidDataGridViewTextBoxColumn
            // 
            this.custidDataGridViewTextBoxColumn.DataPropertyName = "cust_id";
            this.custidDataGridViewTextBoxColumn.HeaderText = "cust_id";
            this.custidDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.custidDataGridViewTextBoxColumn.Name = "custidDataGridViewTextBoxColumn";
            this.custidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custnameDataGridViewTextBoxColumn
            // 
            this.custnameDataGridViewTextBoxColumn.DataPropertyName = "cust_name";
            this.custnameDataGridViewTextBoxColumn.HeaderText = "cust_name";
            this.custnameDataGridViewTextBoxColumn.Name = "custnameDataGridViewTextBoxColumn";
            this.custnameDataGridViewTextBoxColumn.Width = 180;
            // 
            // custemailDataGridViewTextBoxColumn
            // 
            this.custemailDataGridViewTextBoxColumn.DataPropertyName = "cust_email";
            this.custemailDataGridViewTextBoxColumn.HeaderText = "cust_email";
            this.custemailDataGridViewTextBoxColumn.Name = "custemailDataGridViewTextBoxColumn";
            this.custemailDataGridViewTextBoxColumn.Width = 150;
            // 
            // custphonenumberDataGridViewTextBoxColumn
            // 
            this.custphonenumberDataGridViewTextBoxColumn.DataPropertyName = "cust_phone_number";
            this.custphonenumberDataGridViewTextBoxColumn.HeaderText = "cust_phone_number";
            this.custphonenumberDataGridViewTextBoxColumn.Name = "custphonenumberDataGridViewTextBoxColumn";
            this.custphonenumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // custaddressDataGridViewTextBoxColumn
            // 
            this.custaddressDataGridViewTextBoxColumn.DataPropertyName = "cust_address";
            this.custaddressDataGridViewTextBoxColumn.HeaderText = "cust_address";
            this.custaddressDataGridViewTextBoxColumn.Name = "custaddressDataGridViewTextBoxColumn";
            this.custaddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.posdbDataSet1;
            // 
            // posdbDataSet1
            // 
            this.posdbDataSet1.DataSetName = "posdbDataSet1";
            this.posdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.TxtCustAddress);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.TxtCustHP);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.TxtCustEmail);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.TxtCustID);
            this.panel1.Controls.Add(this.TxtCustName);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 151);
            this.panel1.TabIndex = 2;
            // 
            // TxtCustAddress
            // 
            this.TxtCustAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cust_address", true));
            this.TxtCustAddress.Depth = 0;
            this.TxtCustAddress.Hint = "";
            this.TxtCustAddress.Location = new System.Drawing.Point(125, 122);
            this.TxtCustAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCustAddress.Name = "TxtCustAddress";
            this.TxtCustAddress.PasswordChar = '\0';
            this.TxtCustAddress.SelectedText = "";
            this.TxtCustAddress.SelectionLength = 0;
            this.TxtCustAddress.SelectionStart = 0;
            this.TxtCustAddress.Size = new System.Drawing.Size(443, 23);
            this.TxtCustAddress.TabIndex = 4;
            this.TxtCustAddress.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(10, 122);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(72, 19);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Address :";
            // 
            // TxtCustHP
            // 
            this.TxtCustHP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cust_phone_number", true));
            this.TxtCustHP.Depth = 0;
            this.TxtCustHP.Hint = "";
            this.TxtCustHP.Location = new System.Drawing.Point(125, 93);
            this.TxtCustHP.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCustHP.Name = "TxtCustHP";
            this.TxtCustHP.PasswordChar = '\0';
            this.TxtCustHP.SelectedText = "";
            this.TxtCustHP.SelectionLength = 0;
            this.TxtCustHP.SelectionStart = 0;
            this.TxtCustHP.Size = new System.Drawing.Size(443, 23);
            this.TxtCustHP.TabIndex = 3;
            this.TxtCustHP.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(10, 93);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(116, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Phone Number :";
            // 
            // TxtCustEmail
            // 
            this.TxtCustEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cust_email", true));
            this.TxtCustEmail.Depth = 0;
            this.TxtCustEmail.Hint = "";
            this.TxtCustEmail.Location = new System.Drawing.Point(125, 64);
            this.TxtCustEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCustEmail.Name = "TxtCustEmail";
            this.TxtCustEmail.PasswordChar = '\0';
            this.TxtCustEmail.SelectedText = "";
            this.TxtCustEmail.SelectionLength = 0;
            this.TxtCustEmail.SelectionStart = 0;
            this.TxtCustEmail.Size = new System.Drawing.Size(443, 23);
            this.TxtCustEmail.TabIndex = 2;
            this.TxtCustEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(10, 64);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(55, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Email :";
            // 
            // TxtCustID
            // 
            this.TxtCustID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cust_id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "1", "N0"));
            this.TxtCustID.Depth = 0;
            this.TxtCustID.Enabled = false;
            this.TxtCustID.Hint = "";
            this.TxtCustID.Location = new System.Drawing.Point(125, 6);
            this.TxtCustID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCustID.Name = "TxtCustID";
            this.TxtCustID.PasswordChar = '\0';
            this.TxtCustID.SelectedText = "";
            this.TxtCustID.SelectionLength = 0;
            this.TxtCustID.SelectionStart = 0;
            this.TxtCustID.Size = new System.Drawing.Size(443, 23);
            this.TxtCustID.TabIndex = 0;
            this.TxtCustID.UseSystemPasswordChar = false;
            // 
            // TxtCustName
            // 
            this.TxtCustName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cust_name", true));
            this.TxtCustName.Depth = 0;
            this.TxtCustName.Hint = "";
            this.TxtCustName.Location = new System.Drawing.Point(125, 35);
            this.TxtCustName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCustName.Name = "TxtCustName";
            this.TxtCustName.PasswordChar = '\0';
            this.TxtCustName.SelectedText = "";
            this.TxtCustName.SelectionLength = 0;
            this.TxtCustName.SelectionStart = 0;
            this.TxtCustName.Size = new System.Drawing.Size(443, 23);
            this.TxtCustName.TabIndex = 1;
            this.TxtCustName.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(10, 35);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(85, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Full Name :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(10, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Customer ID :";
            // 
            // TxtCustSearch
            // 
            this.TxtCustSearch.Depth = 0;
            this.TxtCustSearch.Hint = "";
            this.TxtCustSearch.Location = new System.Drawing.Point(122, 174);
            this.TxtCustSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCustSearch.Name = "TxtCustSearch";
            this.TxtCustSearch.PasswordChar = '\0';
            this.TxtCustSearch.SelectedText = "";
            this.TxtCustSearch.SelectionLength = 0;
            this.TxtCustSearch.SelectionStart = 0;
            this.TxtCustSearch.Size = new System.Drawing.Size(451, 23);
            this.TxtCustSearch.TabIndex = 1;
            this.TxtCustSearch.UseSystemPasswordChar = false;
            this.TxtCustSearch.TextChanged += new System.EventHandler(this.TxtCustSearch_TextChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel6.ImageKey = "search.png";
            this.materialLabel6.ImageList = this.imageList1;
            this.materialLabel6.Location = new System.Drawing.Point(14, 178);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(83, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "     Search :";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage4.Controls.Add(this.materialLabel12);
            this.tabPage4.Controls.Add(this.BtnProductSave);
            this.tabPage4.Controls.Add(this.BtnProductCancel);
            this.tabPage4.Controls.Add(this.BtnProductEdit);
            this.tabPage4.Controls.Add(this.BtnProductDelete);
            this.tabPage4.Controls.Add(this.BtnProductNew);
            this.tabPage4.Controls.Add(this.DataGridViewProduct);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.TxtProductSearch);
            this.tabPage4.ImageKey = "product.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(589, 398);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Product";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel12.ImageKey = "search.png";
            this.materialLabel12.ImageList = this.imageList1;
            this.materialLabel12.Location = new System.Drawing.Point(14, 179);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(83, 19);
            this.materialLabel12.TabIndex = 13;
            this.materialLabel12.Text = "     Search :";
            // 
            // BtnProductSave
            // 
            this.BtnProductSave.Depth = 0;
            this.BtnProductSave.Location = new System.Drawing.Point(427, 368);
            this.BtnProductSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnProductSave.Name = "BtnProductSave";
            this.BtnProductSave.Primary = true;
            this.BtnProductSave.Size = new System.Drawing.Size(75, 23);
            this.BtnProductSave.TabIndex = 3;
            this.BtnProductSave.Text = "Save";
            this.BtnProductSave.UseVisualStyleBackColor = true;
            this.BtnProductSave.Click += new System.EventHandler(this.BtnProductSave_Click);
            // 
            // BtnProductCancel
            // 
            this.BtnProductCancel.Depth = 0;
            this.BtnProductCancel.Location = new System.Drawing.Point(508, 368);
            this.BtnProductCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnProductCancel.Name = "BtnProductCancel";
            this.BtnProductCancel.Primary = true;
            this.BtnProductCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnProductCancel.TabIndex = 4;
            this.BtnProductCancel.Text = "Cancel";
            this.BtnProductCancel.UseVisualStyleBackColor = true;
            this.BtnProductCancel.Click += new System.EventHandler(this.BtnProductCancel_Click);
            // 
            // BtnProductEdit
            // 
            this.BtnProductEdit.Depth = 0;
            this.BtnProductEdit.Location = new System.Drawing.Point(265, 368);
            this.BtnProductEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnProductEdit.Name = "BtnProductEdit";
            this.BtnProductEdit.Primary = true;
            this.BtnProductEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnProductEdit.TabIndex = 1;
            this.BtnProductEdit.Text = "Edit";
            this.BtnProductEdit.UseVisualStyleBackColor = true;
            this.BtnProductEdit.Click += new System.EventHandler(this.BtnProductEdit_Click);
            // 
            // BtnProductDelete
            // 
            this.BtnProductDelete.Depth = 0;
            this.BtnProductDelete.Location = new System.Drawing.Point(346, 368);
            this.BtnProductDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnProductDelete.Name = "BtnProductDelete";
            this.BtnProductDelete.Primary = true;
            this.BtnProductDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnProductDelete.TabIndex = 2;
            this.BtnProductDelete.Text = "Delete";
            this.BtnProductDelete.UseVisualStyleBackColor = true;
            this.BtnProductDelete.Click += new System.EventHandler(this.BtnProductDelete_Click);
            // 
            // BtnProductNew
            // 
            this.BtnProductNew.Depth = 0;
            this.BtnProductNew.Location = new System.Drawing.Point(184, 368);
            this.BtnProductNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnProductNew.Name = "BtnProductNew";
            this.BtnProductNew.Primary = true;
            this.BtnProductNew.Size = new System.Drawing.Size(75, 23);
            this.BtnProductNew.TabIndex = 0;
            this.BtnProductNew.Text = "New";
            this.BtnProductNew.UseVisualStyleBackColor = true;
            this.BtnProductNew.Click += new System.EventHandler(this.BtnProductNew_Click);
            // 
            // DataGridViewProduct
            // 
            this.DataGridViewProduct.AllowUserToAddRows = false;
            this.DataGridViewProduct.AutoGenerateColumns = false;
            this.DataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productinitialamountDataGridViewTextBoxColumn,
            this.producthpppriceDataGridViewTextBoxColumn,
            this.productsellingpriceDataGridViewTextBoxColumn});
            this.DataGridViewProduct.DataSource = this.productsBindingSource;
            this.DataGridViewProduct.Location = new System.Drawing.Point(7, 209);
            this.DataGridViewProduct.Name = "DataGridViewProduct";
            this.DataGridViewProduct.Size = new System.Drawing.Size(576, 150);
            this.DataGridViewProduct.TabIndex = 8;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // productinitialamountDataGridViewTextBoxColumn
            // 
            this.productinitialamountDataGridViewTextBoxColumn.DataPropertyName = "product_initial_amount";
            this.productinitialamountDataGridViewTextBoxColumn.HeaderText = "product_initial_amount";
            this.productinitialamountDataGridViewTextBoxColumn.Name = "productinitialamountDataGridViewTextBoxColumn";
            this.productinitialamountDataGridViewTextBoxColumn.Width = 120;
            // 
            // producthpppriceDataGridViewTextBoxColumn
            // 
            this.producthpppriceDataGridViewTextBoxColumn.DataPropertyName = "product_hpp_price";
            this.producthpppriceDataGridViewTextBoxColumn.HeaderText = "product_hpp_price";
            this.producthpppriceDataGridViewTextBoxColumn.Name = "producthpppriceDataGridViewTextBoxColumn";
            // 
            // productsellingpriceDataGridViewTextBoxColumn
            // 
            this.productsellingpriceDataGridViewTextBoxColumn.DataPropertyName = "product_selling_price";
            this.productsellingpriceDataGridViewTextBoxColumn.HeaderText = "product_selling_price";
            this.productsellingpriceDataGridViewTextBoxColumn.Name = "productsellingpriceDataGridViewTextBoxColumn";
            this.productsellingpriceDataGridViewTextBoxColumn.Width = 120;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.posdbDataSet1;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.TxtProductSellingPrice);
            this.panel2.Controls.Add(this.materialLabel7);
            this.panel2.Controls.Add(this.TxtProductHPPPrice);
            this.panel2.Controls.Add(this.materialLabel8);
            this.panel2.Controls.Add(this.TxtProductInitialAmount);
            this.panel2.Controls.Add(this.materialLabel9);
            this.panel2.Controls.Add(this.TxtProductName);
            this.panel2.Controls.Add(this.materialLabel10);
            this.panel2.Controls.Add(this.TxtProductID);
            this.panel2.Controls.Add(this.materialLabel11);
            this.panel2.Location = new System.Drawing.Point(5, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 151);
            this.panel2.TabIndex = 7;
            // 
            // TxtProductSellingPrice
            // 
            this.TxtProductSellingPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_selling_price", true));
            this.TxtProductSellingPrice.Depth = 0;
            this.TxtProductSellingPrice.Hint = "";
            this.TxtProductSellingPrice.Location = new System.Drawing.Point(125, 122);
            this.TxtProductSellingPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtProductSellingPrice.Name = "TxtProductSellingPrice";
            this.TxtProductSellingPrice.PasswordChar = '\0';
            this.TxtProductSellingPrice.SelectedText = "";
            this.TxtProductSellingPrice.SelectionLength = 0;
            this.TxtProductSellingPrice.SelectionStart = 0;
            this.TxtProductSellingPrice.Size = new System.Drawing.Size(443, 23);
            this.TxtProductSellingPrice.TabIndex = 4;
            this.TxtProductSellingPrice.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(10, 122);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(100, 19);
            this.materialLabel7.TabIndex = 2;
            this.materialLabel7.Text = "Selling Price :";
            // 
            // TxtProductHPPPrice
            // 
            this.TxtProductHPPPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_hpp_price", true));
            this.TxtProductHPPPrice.Depth = 0;
            this.TxtProductHPPPrice.Hint = "";
            this.TxtProductHPPPrice.Location = new System.Drawing.Point(125, 93);
            this.TxtProductHPPPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtProductHPPPrice.Name = "TxtProductHPPPrice";
            this.TxtProductHPPPrice.PasswordChar = '\0';
            this.TxtProductHPPPrice.SelectedText = "";
            this.TxtProductHPPPrice.SelectionLength = 0;
            this.TxtProductHPPPrice.SelectionStart = 0;
            this.TxtProductHPPPrice.Size = new System.Drawing.Size(443, 23);
            this.TxtProductHPPPrice.TabIndex = 3;
            this.TxtProductHPPPrice.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(10, 93);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(84, 19);
            this.materialLabel8.TabIndex = 3;
            this.materialLabel8.Text = "HPP Price :";
            // 
            // TxtProductInitialAmount
            // 
            this.TxtProductInitialAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_initial_amount", true));
            this.TxtProductInitialAmount.Depth = 0;
            this.TxtProductInitialAmount.Hint = "";
            this.TxtProductInitialAmount.Location = new System.Drawing.Point(125, 64);
            this.TxtProductInitialAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtProductInitialAmount.Name = "TxtProductInitialAmount";
            this.TxtProductInitialAmount.PasswordChar = '\0';
            this.TxtProductInitialAmount.SelectedText = "";
            this.TxtProductInitialAmount.SelectionLength = 0;
            this.TxtProductInitialAmount.SelectionStart = 0;
            this.TxtProductInitialAmount.Size = new System.Drawing.Size(443, 23);
            this.TxtProductInitialAmount.TabIndex = 2;
            this.TxtProductInitialAmount.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(10, 64);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(111, 19);
            this.materialLabel9.TabIndex = 4;
            this.materialLabel9.Text = "Initial Amount :";
            // 
            // TxtProductName
            // 
            this.TxtProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_name", true));
            this.TxtProductName.Depth = 0;
            this.TxtProductName.Hint = "";
            this.TxtProductName.Location = new System.Drawing.Point(125, 35);
            this.TxtProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.PasswordChar = '\0';
            this.TxtProductName.SelectedText = "";
            this.TxtProductName.SelectionLength = 0;
            this.TxtProductName.SelectionStart = 0;
            this.TxtProductName.Size = new System.Drawing.Size(443, 23);
            this.TxtProductName.TabIndex = 1;
            this.TxtProductName.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(10, 35);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(57, 19);
            this.materialLabel10.TabIndex = 5;
            this.materialLabel10.Text = "Name :";
            // 
            // TxtProductID
            // 
            this.TxtProductID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_id", true));
            this.TxtProductID.Depth = 0;
            this.TxtProductID.Enabled = false;
            this.TxtProductID.Hint = "";
            this.TxtProductID.Location = new System.Drawing.Point(125, 6);
            this.TxtProductID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.PasswordChar = '\0';
            this.TxtProductID.SelectedText = "";
            this.TxtProductID.SelectionLength = 0;
            this.TxtProductID.SelectionStart = 0;
            this.TxtProductID.Size = new System.Drawing.Size(443, 23);
            this.TxtProductID.TabIndex = 0;
            this.TxtProductID.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(10, 6);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(87, 19);
            this.materialLabel11.TabIndex = 6;
            this.materialLabel11.Text = "Product ID :";
            // 
            // TxtProductSearch
            // 
            this.TxtProductSearch.Depth = 0;
            this.TxtProductSearch.Hint = "";
            this.TxtProductSearch.Location = new System.Drawing.Point(122, 175);
            this.TxtProductSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtProductSearch.Name = "TxtProductSearch";
            this.TxtProductSearch.PasswordChar = '\0';
            this.TxtProductSearch.SelectedText = "";
            this.TxtProductSearch.SelectionLength = 0;
            this.TxtProductSearch.SelectionStart = 0;
            this.TxtProductSearch.Size = new System.Drawing.Size(451, 23);
            this.TxtProductSearch.TabIndex = 6;
            this.TxtProductSearch.UseSystemPasswordChar = false;
            this.TxtProductSearch.TextChanged += new System.EventHandler(this.TxtProductSearch_TextChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage5.Controls.Add(this.BtnSuppliersDelete);
            this.tabPage5.Controls.Add(this.materialLabel18);
            this.tabPage5.Controls.Add(this.BtnSuppliersSave);
            this.tabPage5.Controls.Add(this.BtnSuppliersCancel);
            this.tabPage5.Controls.Add(this.BtnSuppliersEdit);
            this.tabPage5.Controls.Add(this.BtnSuppliersNew);
            this.tabPage5.Controls.Add(this.DataGridViewSuppliers);
            this.tabPage5.Controls.Add(this.panel3);
            this.tabPage5.Controls.Add(this.TxtSuppliersSearch);
            this.tabPage5.ImageKey = "supplier.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(589, 398);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Suppliers";
            // 
            // BtnSuppliersDelete
            // 
            this.BtnSuppliersDelete.Depth = 0;
            this.BtnSuppliersDelete.Location = new System.Drawing.Point(346, 368);
            this.BtnSuppliersDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSuppliersDelete.Name = "BtnSuppliersDelete";
            this.BtnSuppliersDelete.Primary = true;
            this.BtnSuppliersDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnSuppliersDelete.TabIndex = 2;
            this.BtnSuppliersDelete.Text = "Delete";
            this.BtnSuppliersDelete.UseVisualStyleBackColor = true;
            this.BtnSuppliersDelete.Click += new System.EventHandler(this.BtnSuppliersDelete_Click);
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel18.ImageKey = "search.png";
            this.materialLabel18.ImageList = this.imageList1;
            this.materialLabel18.Location = new System.Drawing.Point(14, 200);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(83, 19);
            this.materialLabel18.TabIndex = 13;
            this.materialLabel18.Text = "     Search :";
            // 
            // BtnSuppliersSave
            // 
            this.BtnSuppliersSave.Depth = 0;
            this.BtnSuppliersSave.Location = new System.Drawing.Point(427, 368);
            this.BtnSuppliersSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSuppliersSave.Name = "BtnSuppliersSave";
            this.BtnSuppliersSave.Primary = true;
            this.BtnSuppliersSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSuppliersSave.TabIndex = 3;
            this.BtnSuppliersSave.Text = "Save";
            this.BtnSuppliersSave.UseVisualStyleBackColor = true;
            this.BtnSuppliersSave.Click += new System.EventHandler(this.BtnSuppliersSave_Click);
            // 
            // BtnSuppliersCancel
            // 
            this.BtnSuppliersCancel.Depth = 0;
            this.BtnSuppliersCancel.Location = new System.Drawing.Point(508, 368);
            this.BtnSuppliersCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSuppliersCancel.Name = "BtnSuppliersCancel";
            this.BtnSuppliersCancel.Primary = true;
            this.BtnSuppliersCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnSuppliersCancel.TabIndex = 4;
            this.BtnSuppliersCancel.Text = "Cancel";
            this.BtnSuppliersCancel.UseVisualStyleBackColor = true;
            this.BtnSuppliersCancel.Click += new System.EventHandler(this.BtnSuppliersCancel_Click);
            // 
            // BtnSuppliersEdit
            // 
            this.BtnSuppliersEdit.Depth = 0;
            this.BtnSuppliersEdit.Location = new System.Drawing.Point(265, 368);
            this.BtnSuppliersEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSuppliersEdit.Name = "BtnSuppliersEdit";
            this.BtnSuppliersEdit.Primary = true;
            this.BtnSuppliersEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnSuppliersEdit.TabIndex = 1;
            this.BtnSuppliersEdit.Text = "Edit";
            this.BtnSuppliersEdit.UseVisualStyleBackColor = true;
            this.BtnSuppliersEdit.Click += new System.EventHandler(this.BtnSuppliersEdit_Click);
            // 
            // BtnSuppliersNew
            // 
            this.BtnSuppliersNew.Depth = 0;
            this.BtnSuppliersNew.Location = new System.Drawing.Point(184, 368);
            this.BtnSuppliersNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSuppliersNew.Name = "BtnSuppliersNew";
            this.BtnSuppliersNew.Primary = true;
            this.BtnSuppliersNew.Size = new System.Drawing.Size(75, 23);
            this.BtnSuppliersNew.TabIndex = 0;
            this.BtnSuppliersNew.Text = "New";
            this.BtnSuppliersNew.UseVisualStyleBackColor = true;
            this.BtnSuppliersNew.Click += new System.EventHandler(this.BtnSuppliersNew_Click);
            // 
            // DataGridViewSuppliers
            // 
            this.DataGridViewSuppliers.AllowUserToAddRows = false;
            this.DataGridViewSuppliers.AutoGenerateColumns = false;
            this.DataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suppliers_id,
            this.suppliersemailDataGridViewTextBoxColumn,
            this.suppliersnameDataGridViewTextBoxColumn,
            this.suppliersaddressDataGridViewTextBoxColumn,
            this.supplierszipcodeDataGridViewTextBoxColumn,
            this.suppliersphonenumberDataGridViewTextBoxColumn});
            this.DataGridViewSuppliers.DataSource = this.suppliersBindingSource;
            this.DataGridViewSuppliers.Location = new System.Drawing.Point(7, 227);
            this.DataGridViewSuppliers.Name = "DataGridViewSuppliers";
            this.DataGridViewSuppliers.Size = new System.Drawing.Size(576, 132);
            this.DataGridViewSuppliers.TabIndex = 8;
            // 
            // suppliers_id
            // 
            this.suppliers_id.DataPropertyName = "suppliers_id";
            this.suppliers_id.HeaderText = "suppliers_id";
            this.suppliers_id.Name = "suppliers_id";
            this.suppliers_id.ReadOnly = true;
            // 
            // suppliersemailDataGridViewTextBoxColumn
            // 
            this.suppliersemailDataGridViewTextBoxColumn.DataPropertyName = "suppliers_email";
            this.suppliersemailDataGridViewTextBoxColumn.HeaderText = "suppliers_email";
            this.suppliersemailDataGridViewTextBoxColumn.Name = "suppliersemailDataGridViewTextBoxColumn";
            // 
            // suppliersnameDataGridViewTextBoxColumn
            // 
            this.suppliersnameDataGridViewTextBoxColumn.DataPropertyName = "suppliers_name";
            this.suppliersnameDataGridViewTextBoxColumn.HeaderText = "suppliers_name";
            this.suppliersnameDataGridViewTextBoxColumn.Name = "suppliersnameDataGridViewTextBoxColumn";
            // 
            // suppliersaddressDataGridViewTextBoxColumn
            // 
            this.suppliersaddressDataGridViewTextBoxColumn.DataPropertyName = "suppliers_address";
            this.suppliersaddressDataGridViewTextBoxColumn.HeaderText = "suppliers_address";
            this.suppliersaddressDataGridViewTextBoxColumn.Name = "suppliersaddressDataGridViewTextBoxColumn";
            // 
            // supplierszipcodeDataGridViewTextBoxColumn
            // 
            this.supplierszipcodeDataGridViewTextBoxColumn.DataPropertyName = "suppliers_zip_code";
            this.supplierszipcodeDataGridViewTextBoxColumn.HeaderText = "suppliers_zip_code";
            this.supplierszipcodeDataGridViewTextBoxColumn.Name = "supplierszipcodeDataGridViewTextBoxColumn";
            // 
            // suppliersphonenumberDataGridViewTextBoxColumn
            // 
            this.suppliersphonenumberDataGridViewTextBoxColumn.DataPropertyName = "suppliers_phone_number";
            this.suppliersphonenumberDataGridViewTextBoxColumn.HeaderText = "suppliers_phone_number";
            this.suppliersphonenumberDataGridViewTextBoxColumn.Name = "suppliersphonenumberDataGridViewTextBoxColumn";
            this.suppliersphonenumberDataGridViewTextBoxColumn.Width = 140;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "suppliers";
            this.suppliersBindingSource.DataSource = this.posdbDataSet1;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.TxtSuppliersID);
            this.panel3.Controls.Add(this.materialLabel31);
            this.panel3.Controls.Add(this.TxtSuppliersPhoneNumber);
            this.panel3.Controls.Add(this.materialLabel13);
            this.panel3.Controls.Add(this.TxtSuppliersZipCode);
            this.panel3.Controls.Add(this.materialLabel14);
            this.panel3.Controls.Add(this.TxtSuppliersAddress);
            this.panel3.Controls.Add(this.materialLabel15);
            this.panel3.Controls.Add(this.TxtSuppliersName);
            this.panel3.Controls.Add(this.materialLabel16);
            this.panel3.Controls.Add(this.TxtSuppliersEmail);
            this.panel3.Controls.Add(this.materialLabel17);
            this.panel3.Location = new System.Drawing.Point(5, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 182);
            this.panel3.TabIndex = 7;
            // 
            // TxtSuppliersID
            // 
            this.TxtSuppliersID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "suppliers_id", true));
            this.TxtSuppliersID.Depth = 0;
            this.TxtSuppliersID.Hint = "";
            this.TxtSuppliersID.Location = new System.Drawing.Point(127, 6);
            this.TxtSuppliersID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSuppliersID.Name = "TxtSuppliersID";
            this.TxtSuppliersID.PasswordChar = '\0';
            this.TxtSuppliersID.SelectedText = "";
            this.TxtSuppliersID.SelectionLength = 0;
            this.TxtSuppliersID.SelectionStart = 0;
            this.TxtSuppliersID.Size = new System.Drawing.Size(443, 23);
            this.TxtSuppliersID.TabIndex = 0;
            this.TxtSuppliersID.UseSystemPasswordChar = false;
            // 
            // materialLabel31
            // 
            this.materialLabel31.AutoSize = true;
            this.materialLabel31.Depth = 0;
            this.materialLabel31.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel31.Location = new System.Drawing.Point(12, 6);
            this.materialLabel31.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel31.Name = "materialLabel31";
            this.materialLabel31.Size = new System.Drawing.Size(89, 19);
            this.materialLabel31.TabIndex = 8;
            this.materialLabel31.Text = "Supplier ID :";
            // 
            // TxtSuppliersPhoneNumber
            // 
            this.TxtSuppliersPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "suppliers_phone_number", true));
            this.TxtSuppliersPhoneNumber.Depth = 0;
            this.TxtSuppliersPhoneNumber.Hint = "";
            this.TxtSuppliersPhoneNumber.Location = new System.Drawing.Point(125, 150);
            this.TxtSuppliersPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSuppliersPhoneNumber.Name = "TxtSuppliersPhoneNumber";
            this.TxtSuppliersPhoneNumber.PasswordChar = '\0';
            this.TxtSuppliersPhoneNumber.SelectedText = "";
            this.TxtSuppliersPhoneNumber.SelectionLength = 0;
            this.TxtSuppliersPhoneNumber.SelectionStart = 0;
            this.TxtSuppliersPhoneNumber.Size = new System.Drawing.Size(443, 23);
            this.TxtSuppliersPhoneNumber.TabIndex = 5;
            this.TxtSuppliersPhoneNumber.UseSystemPasswordChar = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(10, 150);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(116, 19);
            this.materialLabel13.TabIndex = 2;
            this.materialLabel13.Text = "Phone Number :";
            // 
            // TxtSuppliersZipCode
            // 
            this.TxtSuppliersZipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "suppliers_zip_code", true));
            this.TxtSuppliersZipCode.Depth = 0;
            this.TxtSuppliersZipCode.Hint = "";
            this.TxtSuppliersZipCode.Location = new System.Drawing.Point(125, 121);
            this.TxtSuppliersZipCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSuppliersZipCode.Name = "TxtSuppliersZipCode";
            this.TxtSuppliersZipCode.PasswordChar = '\0';
            this.TxtSuppliersZipCode.SelectedText = "";
            this.TxtSuppliersZipCode.SelectionLength = 0;
            this.TxtSuppliersZipCode.SelectionStart = 0;
            this.TxtSuppliersZipCode.Size = new System.Drawing.Size(443, 23);
            this.TxtSuppliersZipCode.TabIndex = 4;
            this.TxtSuppliersZipCode.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(10, 121);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(77, 19);
            this.materialLabel14.TabIndex = 3;
            this.materialLabel14.Text = "Zip Code :";
            // 
            // TxtSuppliersAddress
            // 
            this.TxtSuppliersAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "suppliers_address", true));
            this.TxtSuppliersAddress.Depth = 0;
            this.TxtSuppliersAddress.Hint = "";
            this.TxtSuppliersAddress.Location = new System.Drawing.Point(125, 92);
            this.TxtSuppliersAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSuppliersAddress.Name = "TxtSuppliersAddress";
            this.TxtSuppliersAddress.PasswordChar = '\0';
            this.TxtSuppliersAddress.SelectedText = "";
            this.TxtSuppliersAddress.SelectionLength = 0;
            this.TxtSuppliersAddress.SelectionStart = 0;
            this.TxtSuppliersAddress.Size = new System.Drawing.Size(443, 23);
            this.TxtSuppliersAddress.TabIndex = 3;
            this.TxtSuppliersAddress.UseSystemPasswordChar = false;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(10, 92);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(72, 19);
            this.materialLabel15.TabIndex = 4;
            this.materialLabel15.Text = "Address :";
            // 
            // TxtSuppliersName
            // 
            this.TxtSuppliersName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "suppliers_name", true));
            this.TxtSuppliersName.Depth = 0;
            this.TxtSuppliersName.Hint = "";
            this.TxtSuppliersName.Location = new System.Drawing.Point(125, 63);
            this.TxtSuppliersName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSuppliersName.Name = "TxtSuppliersName";
            this.TxtSuppliersName.PasswordChar = '\0';
            this.TxtSuppliersName.SelectedText = "";
            this.TxtSuppliersName.SelectionLength = 0;
            this.TxtSuppliersName.SelectionStart = 0;
            this.TxtSuppliersName.Size = new System.Drawing.Size(443, 23);
            this.TxtSuppliersName.TabIndex = 2;
            this.TxtSuppliersName.UseSystemPasswordChar = false;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(10, 63);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(57, 19);
            this.materialLabel16.TabIndex = 5;
            this.materialLabel16.Text = "Name :";
            // 
            // TxtSuppliersEmail
            // 
            this.TxtSuppliersEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "suppliers_email", true));
            this.TxtSuppliersEmail.Depth = 0;
            this.TxtSuppliersEmail.Hint = "";
            this.TxtSuppliersEmail.Location = new System.Drawing.Point(125, 34);
            this.TxtSuppliersEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSuppliersEmail.Name = "TxtSuppliersEmail";
            this.TxtSuppliersEmail.PasswordChar = '\0';
            this.TxtSuppliersEmail.SelectedText = "";
            this.TxtSuppliersEmail.SelectionLength = 0;
            this.TxtSuppliersEmail.SelectionStart = 0;
            this.TxtSuppliersEmail.Size = new System.Drawing.Size(443, 23);
            this.TxtSuppliersEmail.TabIndex = 1;
            this.TxtSuppliersEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(10, 34);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(55, 19);
            this.materialLabel17.TabIndex = 6;
            this.materialLabel17.Text = "Email :";
            // 
            // TxtSuppliersSearch
            // 
            this.TxtSuppliersSearch.Depth = 0;
            this.TxtSuppliersSearch.Hint = "";
            this.TxtSuppliersSearch.Location = new System.Drawing.Point(122, 196);
            this.TxtSuppliersSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSuppliersSearch.Name = "TxtSuppliersSearch";
            this.TxtSuppliersSearch.PasswordChar = '\0';
            this.TxtSuppliersSearch.SelectedText = "";
            this.TxtSuppliersSearch.SelectionLength = 0;
            this.TxtSuppliersSearch.SelectionStart = 0;
            this.TxtSuppliersSearch.Size = new System.Drawing.Size(451, 23);
            this.TxtSuppliersSearch.TabIndex = 6;
            this.TxtSuppliersSearch.UseSystemPasswordChar = false;
            this.TxtSuppliersSearch.TextChanged += new System.EventHandler(this.TxtSuppliersSearch_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl3);
            this.tabPage2.ImageKey = "Cash_register.png";
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(606, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transaction";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.ImageList = this.imageList1;
            this.tabControl3.Location = new System.Drawing.Point(6, 6);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(597, 425);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage6.Controls.Add(this.TxtPurTotal);
            this.tabPage6.Controls.Add(this.TxtPurProductID);
            this.tabPage6.Controls.Add(this.materialLabel24);
            this.tabPage6.Controls.Add(this.materialLabel23);
            this.tabPage6.Controls.Add(this.panel7);
            this.tabPage6.Controls.Add(this.BtnPurchaseSave);
            this.tabPage6.Controls.Add(this.BtnPurchaseEdit);
            this.tabPage6.Controls.Add(this.BtnPurchaseDelete);
            this.tabPage6.Controls.Add(this.BtnPurchaseLogout);
            this.tabPage6.Controls.Add(this.BtnPurchaseLogin);
            this.tabPage6.Controls.Add(this.BtnPurchaseAdd);
            this.tabPage6.Controls.Add(this.dataGridView1);
            this.tabPage6.Controls.Add(this.panel4);
            this.tabPage6.ImageKey = "Purcase.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 23);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(589, 398);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Purchase";
            // 
            // TxtPurTotal
            // 
            this.TxtPurTotal.Depth = 0;
            this.TxtPurTotal.Enabled = false;
            this.TxtPurTotal.Hint = "";
            this.TxtPurTotal.Location = new System.Drawing.Point(437, 224);
            this.TxtPurTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPurTotal.Name = "TxtPurTotal";
            this.TxtPurTotal.PasswordChar = '\0';
            this.TxtPurTotal.SelectedText = "";
            this.TxtPurTotal.SelectionLength = 0;
            this.TxtPurTotal.SelectionStart = 0;
            this.TxtPurTotal.Size = new System.Drawing.Size(146, 23);
            this.TxtPurTotal.TabIndex = 1;
            this.TxtPurTotal.UseSystemPasswordChar = false;
            // 
            // TxtPurProductID
            // 
            this.TxtPurProductID.Depth = 0;
            this.TxtPurProductID.Hint = "";
            this.TxtPurProductID.Location = new System.Drawing.Point(99, 223);
            this.TxtPurProductID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPurProductID.Name = "TxtPurProductID";
            this.TxtPurProductID.PasswordChar = '\0';
            this.TxtPurProductID.SelectedText = "";
            this.TxtPurProductID.SelectionLength = 0;
            this.TxtPurProductID.SelectionStart = 0;
            this.TxtPurProductID.Size = new System.Drawing.Size(89, 23);
            this.TxtPurProductID.TabIndex = 1;
            this.TxtPurProductID.UseSystemPasswordChar = false;
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel24.Location = new System.Drawing.Point(379, 224);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(52, 19);
            this.materialLabel24.TabIndex = 5;
            this.materialLabel24.Text = "Total :";
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel23.Location = new System.Drawing.Point(6, 224);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(87, 19);
            this.materialLabel23.TabIndex = 5;
            this.materialLabel23.Text = "Product ID :";
            // 
            // panel7
            // 
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.TxtPurSupplierID);
            this.panel7.Controls.Add(this.materialLabel39);
            this.panel7.Location = new System.Drawing.Point(4, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(407, 38);
            this.panel7.TabIndex = 6;
            // 
            // TxtPurSupplierID
            // 
            this.TxtPurSupplierID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "suppliers_id", true));
            this.TxtPurSupplierID.Depth = 0;
            this.TxtPurSupplierID.Hint = "";
            this.TxtPurSupplierID.Location = new System.Drawing.Point(140, 10);
            this.TxtPurSupplierID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPurSupplierID.Name = "TxtPurSupplierID";
            this.TxtPurSupplierID.PasswordChar = '\0';
            this.TxtPurSupplierID.SelectedText = "";
            this.TxtPurSupplierID.SelectionLength = 0;
            this.TxtPurSupplierID.SelectionStart = 0;
            this.TxtPurSupplierID.Size = new System.Drawing.Size(256, 23);
            this.TxtPurSupplierID.TabIndex = 1;
            this.TxtPurSupplierID.UseSystemPasswordChar = false;
            // 
            // materialLabel39
            // 
            this.materialLabel39.AutoSize = true;
            this.materialLabel39.Depth = 0;
            this.materialLabel39.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel39.Location = new System.Drawing.Point(10, 10);
            this.materialLabel39.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel39.Name = "materialLabel39";
            this.materialLabel39.Size = new System.Drawing.Size(100, 19);
            this.materialLabel39.TabIndex = 5;
            this.materialLabel39.Text = "Supplier\'s ID :";
            // 
            // BtnPurchaseSave
            // 
            this.BtnPurchaseSave.Depth = 0;
            this.BtnPurchaseSave.Location = new System.Drawing.Point(427, 367);
            this.BtnPurchaseSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnPurchaseSave.Name = "BtnPurchaseSave";
            this.BtnPurchaseSave.Primary = true;
            this.BtnPurchaseSave.Size = new System.Drawing.Size(75, 23);
            this.BtnPurchaseSave.TabIndex = 4;
            this.BtnPurchaseSave.Text = "Save";
            this.BtnPurchaseSave.UseVisualStyleBackColor = true;
            // 
            // BtnPurchaseEdit
            // 
            this.BtnPurchaseEdit.Depth = 0;
            this.BtnPurchaseEdit.Location = new System.Drawing.Point(346, 367);
            this.BtnPurchaseEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnPurchaseEdit.Name = "BtnPurchaseEdit";
            this.BtnPurchaseEdit.Primary = true;
            this.BtnPurchaseEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnPurchaseEdit.TabIndex = 2;
            this.BtnPurchaseEdit.Text = "Edit";
            this.BtnPurchaseEdit.UseVisualStyleBackColor = true;
            // 
            // BtnPurchaseDelete
            // 
            this.BtnPurchaseDelete.Depth = 0;
            this.BtnPurchaseDelete.Location = new System.Drawing.Point(508, 367);
            this.BtnPurchaseDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnPurchaseDelete.Name = "BtnPurchaseDelete";
            this.BtnPurchaseDelete.Primary = true;
            this.BtnPurchaseDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnPurchaseDelete.TabIndex = 1;
            this.BtnPurchaseDelete.Text = "Delete";
            this.BtnPurchaseDelete.UseVisualStyleBackColor = true;
            // 
            // BtnPurchaseLogout
            // 
            this.BtnPurchaseLogout.Depth = 0;
            this.BtnPurchaseLogout.Location = new System.Drawing.Point(508, 15);
            this.BtnPurchaseLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnPurchaseLogout.Name = "BtnPurchaseLogout";
            this.BtnPurchaseLogout.Primary = true;
            this.BtnPurchaseLogout.Size = new System.Drawing.Size(75, 23);
            this.BtnPurchaseLogout.TabIndex = 1;
            this.BtnPurchaseLogout.Text = "Logout";
            this.BtnPurchaseLogout.UseVisualStyleBackColor = true;
            // 
            // BtnPurchaseLogin
            // 
            this.BtnPurchaseLogin.Depth = 0;
            this.BtnPurchaseLogin.Location = new System.Drawing.Point(427, 15);
            this.BtnPurchaseLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnPurchaseLogin.Name = "BtnPurchaseLogin";
            this.BtnPurchaseLogin.Primary = true;
            this.BtnPurchaseLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnPurchaseLogin.TabIndex = 1;
            this.BtnPurchaseLogin.Text = "Login";
            this.BtnPurchaseLogin.UseVisualStyleBackColor = true;
            // 
            // BtnPurchaseAdd
            // 
            this.BtnPurchaseAdd.Depth = 0;
            this.BtnPurchaseAdd.Location = new System.Drawing.Point(216, 223);
            this.BtnPurchaseAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnPurchaseAdd.Name = "BtnPurchaseAdd";
            this.BtnPurchaseAdd.Primary = true;
            this.BtnPurchaseAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnPurchaseAdd.TabIndex = 1;
            this.BtnPurchaseAdd.Text = "Add";
            this.BtnPurchaseAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn1,
            this.productnameDataGridViewTextBoxColumn1,
            this.productinitialamountDataGridViewTextBoxColumn1,
            this.producthpppriceDataGridViewTextBoxColumn1,
            this.productsellingpriceDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 104);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.TxtPurSupplierEmail);
            this.panel4.Controls.Add(this.materialLabel32);
            this.panel4.Controls.Add(this.TxtPurSupplierPhoneNumber);
            this.panel4.Controls.Add(this.materialLabel19);
            this.panel4.Controls.Add(this.TxtPurSupplierZipCode);
            this.panel4.Controls.Add(this.materialLabel20);
            this.panel4.Controls.Add(this.TxtPurSupplierAddress);
            this.panel4.Controls.Add(this.materialLabel21);
            this.panel4.Controls.Add(this.TxtPurSupplierName);
            this.panel4.Controls.Add(this.materialLabel22);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(4, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(579, 155);
            this.panel4.TabIndex = 2;
            // 
            // TxtPurSupplierEmail
            // 
            this.TxtPurSupplierEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "suppliers_email", true));
            this.TxtPurSupplierEmail.Depth = 0;
            this.TxtPurSupplierEmail.Enabled = false;
            this.TxtPurSupplierEmail.Hint = "";
            this.TxtPurSupplierEmail.Location = new System.Drawing.Point(125, 40);
            this.TxtPurSupplierEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPurSupplierEmail.Name = "TxtPurSupplierEmail";
            this.TxtPurSupplierEmail.PasswordChar = '\0';
            this.TxtPurSupplierEmail.SelectedText = "";
            this.TxtPurSupplierEmail.SelectionLength = 0;
            this.TxtPurSupplierEmail.SelectionStart = 0;
            this.TxtPurSupplierEmail.Size = new System.Drawing.Size(443, 23);
            this.TxtPurSupplierEmail.TabIndex = 6;
            this.TxtPurSupplierEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel32
            // 
            this.materialLabel32.AutoSize = true;
            this.materialLabel32.Depth = 0;
            this.materialLabel32.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel32.Location = new System.Drawing.Point(10, 40);
            this.materialLabel32.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel32.Name = "materialLabel32";
            this.materialLabel32.Size = new System.Drawing.Size(55, 19);
            this.materialLabel32.TabIndex = 7;
            this.materialLabel32.Text = "Email :";
            // 
            // TxtPurSupplierPhoneNumber
            // 
            this.TxtPurSupplierPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "suppliers_phone_number", true));
            this.TxtPurSupplierPhoneNumber.Depth = 0;
            this.TxtPurSupplierPhoneNumber.Enabled = false;
            this.TxtPurSupplierPhoneNumber.Hint = "";
            this.TxtPurSupplierPhoneNumber.Location = new System.Drawing.Point(125, 127);
            this.TxtPurSupplierPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPurSupplierPhoneNumber.Name = "TxtPurSupplierPhoneNumber";
            this.TxtPurSupplierPhoneNumber.PasswordChar = '\0';
            this.TxtPurSupplierPhoneNumber.SelectedText = "";
            this.TxtPurSupplierPhoneNumber.SelectionLength = 0;
            this.TxtPurSupplierPhoneNumber.SelectionStart = 0;
            this.TxtPurSupplierPhoneNumber.Size = new System.Drawing.Size(443, 23);
            this.TxtPurSupplierPhoneNumber.TabIndex = 4;
            this.TxtPurSupplierPhoneNumber.UseSystemPasswordChar = false;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(10, 127);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(116, 19);
            this.materialLabel19.TabIndex = 2;
            this.materialLabel19.Text = "Phone Number :";
            // 
            // TxtPurSupplierZipCode
            // 
            this.TxtPurSupplierZipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "suppliers_zip_code", true));
            this.TxtPurSupplierZipCode.Depth = 0;
            this.TxtPurSupplierZipCode.Enabled = false;
            this.TxtPurSupplierZipCode.Hint = "";
            this.TxtPurSupplierZipCode.Location = new System.Drawing.Point(125, 98);
            this.TxtPurSupplierZipCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPurSupplierZipCode.Name = "TxtPurSupplierZipCode";
            this.TxtPurSupplierZipCode.PasswordChar = '\0';
            this.TxtPurSupplierZipCode.SelectedText = "";
            this.TxtPurSupplierZipCode.SelectionLength = 0;
            this.TxtPurSupplierZipCode.SelectionStart = 0;
            this.TxtPurSupplierZipCode.Size = new System.Drawing.Size(443, 23);
            this.TxtPurSupplierZipCode.TabIndex = 3;
            this.TxtPurSupplierZipCode.UseSystemPasswordChar = false;
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(10, 98);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(77, 19);
            this.materialLabel20.TabIndex = 3;
            this.materialLabel20.Text = "Zip Code :";
            // 
            // TxtPurSupplierAddress
            // 
            this.TxtPurSupplierAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "suppliers_address", true));
            this.TxtPurSupplierAddress.Depth = 0;
            this.TxtPurSupplierAddress.Enabled = false;
            this.TxtPurSupplierAddress.Hint = "";
            this.TxtPurSupplierAddress.Location = new System.Drawing.Point(125, 69);
            this.TxtPurSupplierAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPurSupplierAddress.Name = "TxtPurSupplierAddress";
            this.TxtPurSupplierAddress.PasswordChar = '\0';
            this.TxtPurSupplierAddress.SelectedText = "";
            this.TxtPurSupplierAddress.SelectionLength = 0;
            this.TxtPurSupplierAddress.SelectionStart = 0;
            this.TxtPurSupplierAddress.Size = new System.Drawing.Size(443, 23);
            this.TxtPurSupplierAddress.TabIndex = 2;
            this.TxtPurSupplierAddress.UseSystemPasswordChar = false;
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel21.Location = new System.Drawing.Point(10, 69);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(72, 19);
            this.materialLabel21.TabIndex = 4;
            this.materialLabel21.Text = "Address :";
            // 
            // TxtPurSupplierName
            // 
            this.TxtPurSupplierName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "suppliers_name", true));
            this.TxtPurSupplierName.Depth = 0;
            this.TxtPurSupplierName.Enabled = false;
            this.TxtPurSupplierName.Hint = "";
            this.TxtPurSupplierName.Location = new System.Drawing.Point(125, 10);
            this.TxtPurSupplierName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPurSupplierName.Name = "TxtPurSupplierName";
            this.TxtPurSupplierName.PasswordChar = '\0';
            this.TxtPurSupplierName.SelectedText = "";
            this.TxtPurSupplierName.SelectionLength = 0;
            this.TxtPurSupplierName.SelectionStart = 0;
            this.TxtPurSupplierName.Size = new System.Drawing.Size(443, 23);
            this.TxtPurSupplierName.TabIndex = 1;
            this.TxtPurSupplierName.UseSystemPasswordChar = false;
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel22.Location = new System.Drawing.Point(10, 10);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(85, 19);
            this.materialLabel22.TabIndex = 5;
            this.materialLabel22.Text = "Full Name :";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage7.Controls.Add(this.TxtSaleTotal);
            this.tabPage7.Controls.Add(this.TxtSaleProductID);
            this.tabPage7.Controls.Add(this.materialLabel25);
            this.tabPage7.Controls.Add(this.materialLabel26);
            this.tabPage7.Controls.Add(this.panel5);
            this.tabPage7.Controls.Add(this.BtnSaleSave);
            this.tabPage7.Controls.Add(this.BtnSaleCancel);
            this.tabPage7.Controls.Add(this.BtnSaleEdit);
            this.tabPage7.Controls.Add(this.BtnSaleDelete);
            this.tabPage7.Controls.Add(this.BtnSaleLogout);
            this.tabPage7.Controls.Add(this.BtnSaleLogin);
            this.tabPage7.Controls.Add(this.BtnSaleAdd);
            this.tabPage7.Controls.Add(this.dataGridView2);
            this.tabPage7.Controls.Add(this.panel8);
            this.tabPage7.ImageKey = "sale.png";
            this.tabPage7.Location = new System.Drawing.Point(4, 23);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(589, 398);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Sale";
            // 
            // TxtSaleTotal
            // 
            this.TxtSaleTotal.Depth = 0;
            this.TxtSaleTotal.Enabled = false;
            this.TxtSaleTotal.Hint = "";
            this.TxtSaleTotal.Location = new System.Drawing.Point(438, 190);
            this.TxtSaleTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSaleTotal.Name = "TxtSaleTotal";
            this.TxtSaleTotal.PasswordChar = '\0';
            this.TxtSaleTotal.SelectedText = "";
            this.TxtSaleTotal.SelectionLength = 0;
            this.TxtSaleTotal.SelectionStart = 0;
            this.TxtSaleTotal.Size = new System.Drawing.Size(146, 23);
            this.TxtSaleTotal.TabIndex = 7;
            this.TxtSaleTotal.UseSystemPasswordChar = false;
            // 
            // TxtSaleProductID
            // 
            this.TxtSaleProductID.Depth = 0;
            this.TxtSaleProductID.Hint = "";
            this.TxtSaleProductID.Location = new System.Drawing.Point(100, 190);
            this.TxtSaleProductID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSaleProductID.Name = "TxtSaleProductID";
            this.TxtSaleProductID.PasswordChar = '\0';
            this.TxtSaleProductID.SelectedText = "";
            this.TxtSaleProductID.SelectionLength = 0;
            this.TxtSaleProductID.SelectionStart = 0;
            this.TxtSaleProductID.Size = new System.Drawing.Size(111, 23);
            this.TxtSaleProductID.TabIndex = 8;
            this.TxtSaleProductID.UseSystemPasswordChar = false;
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel25.Location = new System.Drawing.Point(380, 190);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(52, 19);
            this.materialLabel25.TabIndex = 18;
            this.materialLabel25.Text = "Total :";
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel26.Location = new System.Drawing.Point(7, 190);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(87, 19);
            this.materialLabel26.TabIndex = 19;
            this.materialLabel26.Text = "Product ID :";
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.TxtSaleCustID);
            this.panel5.Controls.Add(this.materialLabel27);
            this.panel5.Location = new System.Drawing.Point(5, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(407, 38);
            this.panel5.TabIndex = 20;
            // 
            // TxtSaleCustID
            // 
            this.TxtSaleCustID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cust_name", true));
            this.TxtSaleCustID.Depth = 0;
            this.TxtSaleCustID.Hint = "";
            this.TxtSaleCustID.Location = new System.Drawing.Point(125, 10);
            this.TxtSaleCustID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSaleCustID.Name = "TxtSaleCustID";
            this.TxtSaleCustID.PasswordChar = '\0';
            this.TxtSaleCustID.SelectedText = "";
            this.TxtSaleCustID.SelectionLength = 0;
            this.TxtSaleCustID.SelectionStart = 0;
            this.TxtSaleCustID.Size = new System.Drawing.Size(271, 23);
            this.TxtSaleCustID.TabIndex = 1;
            this.TxtSaleCustID.UseSystemPasswordChar = false;
            // 
            // materialLabel27
            // 
            this.materialLabel27.AutoSize = true;
            this.materialLabel27.Depth = 0;
            this.materialLabel27.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel27.Location = new System.Drawing.Point(10, 10);
            this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel27.Name = "materialLabel27";
            this.materialLabel27.Size = new System.Drawing.Size(101, 19);
            this.materialLabel27.TabIndex = 5;
            this.materialLabel27.Text = "Customer ID :";
            // 
            // BtnSaleSave
            // 
            this.BtnSaleSave.Depth = 0;
            this.BtnSaleSave.Location = new System.Drawing.Point(428, 368);
            this.BtnSaleSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSaleSave.Name = "BtnSaleSave";
            this.BtnSaleSave.Primary = true;
            this.BtnSaleSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSaleSave.TabIndex = 17;
            this.BtnSaleSave.Text = "Save";
            this.BtnSaleSave.UseVisualStyleBackColor = true;
            // 
            // BtnSaleCancel
            // 
            this.BtnSaleCancel.Depth = 0;
            this.BtnSaleCancel.Location = new System.Drawing.Point(509, 368);
            this.BtnSaleCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSaleCancel.Name = "BtnSaleCancel";
            this.BtnSaleCancel.Primary = true;
            this.BtnSaleCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnSaleCancel.TabIndex = 15;
            this.BtnSaleCancel.Text = "Cancel";
            this.BtnSaleCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSaleEdit
            // 
            this.BtnSaleEdit.Depth = 0;
            this.BtnSaleEdit.Location = new System.Drawing.Point(266, 368);
            this.BtnSaleEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSaleEdit.Name = "BtnSaleEdit";
            this.BtnSaleEdit.Primary = true;
            this.BtnSaleEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnSaleEdit.TabIndex = 13;
            this.BtnSaleEdit.Text = "Edit";
            this.BtnSaleEdit.UseVisualStyleBackColor = true;
            // 
            // BtnSaleDelete
            // 
            this.BtnSaleDelete.Depth = 0;
            this.BtnSaleDelete.Location = new System.Drawing.Point(347, 368);
            this.BtnSaleDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSaleDelete.Name = "BtnSaleDelete";
            this.BtnSaleDelete.Primary = true;
            this.BtnSaleDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnSaleDelete.TabIndex = 9;
            this.BtnSaleDelete.Text = "Delete";
            this.BtnSaleDelete.UseVisualStyleBackColor = true;
            // 
            // BtnSaleLogout
            // 
            this.BtnSaleLogout.Depth = 0;
            this.BtnSaleLogout.Location = new System.Drawing.Point(509, 16);
            this.BtnSaleLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSaleLogout.Name = "BtnSaleLogout";
            this.BtnSaleLogout.Primary = true;
            this.BtnSaleLogout.Size = new System.Drawing.Size(75, 23);
            this.BtnSaleLogout.TabIndex = 10;
            this.BtnSaleLogout.Text = "Logout";
            this.BtnSaleLogout.UseVisualStyleBackColor = true;
            // 
            // BtnSaleLogin
            // 
            this.BtnSaleLogin.Depth = 0;
            this.BtnSaleLogin.Location = new System.Drawing.Point(428, 16);
            this.BtnSaleLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSaleLogin.Name = "BtnSaleLogin";
            this.BtnSaleLogin.Primary = true;
            this.BtnSaleLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnSaleLogin.TabIndex = 11;
            this.BtnSaleLogin.Text = "Login";
            this.BtnSaleLogin.UseVisualStyleBackColor = true;
            // 
            // BtnSaleAdd
            // 
            this.BtnSaleAdd.Depth = 0;
            this.BtnSaleAdd.Location = new System.Drawing.Point(217, 189);
            this.BtnSaleAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSaleAdd.Name = "BtnSaleAdd";
            this.BtnSaleAdd.Primary = true;
            this.BtnSaleAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnSaleAdd.TabIndex = 12;
            this.BtnSaleAdd.Text = "Add";
            this.BtnSaleAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn2,
            this.productnameDataGridViewTextBoxColumn2,
            this.productinitialamountDataGridViewTextBoxColumn2,
            this.producthpppriceDataGridViewTextBoxColumn2,
            this.productsellingpriceDataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.productsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 222);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(576, 137);
            this.dataGridView2.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.TxtSaleCustAddress);
            this.panel8.Controls.Add(this.materialLabel28);
            this.panel8.Controls.Add(this.TxtSaleCustPhoneNumber);
            this.panel8.Controls.Add(this.materialLabel29);
            this.panel8.Controls.Add(this.TxtSaleCustEmail);
            this.panel8.Controls.Add(this.materialLabel30);
            this.panel8.Controls.Add(this.TxtSaleCustName);
            this.panel8.Controls.Add(this.materialLabel37);
            this.panel8.Enabled = false;
            this.panel8.Location = new System.Drawing.Point(5, 51);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(579, 129);
            this.panel8.TabIndex = 14;
            // 
            // TxtSaleCustAddress
            // 
            this.TxtSaleCustAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cust_address", true));
            this.TxtSaleCustAddress.Depth = 0;
            this.TxtSaleCustAddress.Enabled = false;
            this.TxtSaleCustAddress.Hint = "";
            this.TxtSaleCustAddress.Location = new System.Drawing.Point(125, 97);
            this.TxtSaleCustAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSaleCustAddress.Name = "TxtSaleCustAddress";
            this.TxtSaleCustAddress.PasswordChar = '\0';
            this.TxtSaleCustAddress.SelectedText = "";
            this.TxtSaleCustAddress.SelectionLength = 0;
            this.TxtSaleCustAddress.SelectionStart = 0;
            this.TxtSaleCustAddress.Size = new System.Drawing.Size(443, 23);
            this.TxtSaleCustAddress.TabIndex = 4;
            this.TxtSaleCustAddress.UseSystemPasswordChar = false;
            // 
            // materialLabel28
            // 
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel28.Location = new System.Drawing.Point(10, 97);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(72, 19);
            this.materialLabel28.TabIndex = 2;
            this.materialLabel28.Text = "Address :";
            // 
            // TxtSaleCustPhoneNumber
            // 
            this.TxtSaleCustPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cust_phone_number", true));
            this.TxtSaleCustPhoneNumber.Depth = 0;
            this.TxtSaleCustPhoneNumber.Enabled = false;
            this.TxtSaleCustPhoneNumber.Hint = "";
            this.TxtSaleCustPhoneNumber.Location = new System.Drawing.Point(125, 68);
            this.TxtSaleCustPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSaleCustPhoneNumber.Name = "TxtSaleCustPhoneNumber";
            this.TxtSaleCustPhoneNumber.PasswordChar = '\0';
            this.TxtSaleCustPhoneNumber.SelectedText = "";
            this.TxtSaleCustPhoneNumber.SelectionLength = 0;
            this.TxtSaleCustPhoneNumber.SelectionStart = 0;
            this.TxtSaleCustPhoneNumber.Size = new System.Drawing.Size(443, 23);
            this.TxtSaleCustPhoneNumber.TabIndex = 3;
            this.TxtSaleCustPhoneNumber.UseSystemPasswordChar = false;
            // 
            // materialLabel29
            // 
            this.materialLabel29.AutoSize = true;
            this.materialLabel29.Depth = 0;
            this.materialLabel29.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel29.Location = new System.Drawing.Point(10, 68);
            this.materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel29.Name = "materialLabel29";
            this.materialLabel29.Size = new System.Drawing.Size(116, 19);
            this.materialLabel29.TabIndex = 3;
            this.materialLabel29.Text = "Phone Number :";
            // 
            // TxtSaleCustEmail
            // 
            this.TxtSaleCustEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cust_email", true));
            this.TxtSaleCustEmail.Depth = 0;
            this.TxtSaleCustEmail.Enabled = false;
            this.TxtSaleCustEmail.Hint = "";
            this.TxtSaleCustEmail.Location = new System.Drawing.Point(125, 39);
            this.TxtSaleCustEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSaleCustEmail.Name = "TxtSaleCustEmail";
            this.TxtSaleCustEmail.PasswordChar = '\0';
            this.TxtSaleCustEmail.SelectedText = "";
            this.TxtSaleCustEmail.SelectionLength = 0;
            this.TxtSaleCustEmail.SelectionStart = 0;
            this.TxtSaleCustEmail.Size = new System.Drawing.Size(443, 23);
            this.TxtSaleCustEmail.TabIndex = 2;
            this.TxtSaleCustEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel30
            // 
            this.materialLabel30.AutoSize = true;
            this.materialLabel30.Depth = 0;
            this.materialLabel30.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel30.Location = new System.Drawing.Point(10, 39);
            this.materialLabel30.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel30.Name = "materialLabel30";
            this.materialLabel30.Size = new System.Drawing.Size(55, 19);
            this.materialLabel30.TabIndex = 4;
            this.materialLabel30.Text = "Email :";
            // 
            // TxtSaleCustName
            // 
            this.TxtSaleCustName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cust_name", true));
            this.TxtSaleCustName.Depth = 0;
            this.TxtSaleCustName.Enabled = false;
            this.TxtSaleCustName.Hint = "";
            this.TxtSaleCustName.Location = new System.Drawing.Point(125, 10);
            this.TxtSaleCustName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSaleCustName.Name = "TxtSaleCustName";
            this.TxtSaleCustName.PasswordChar = '\0';
            this.TxtSaleCustName.SelectedText = "";
            this.TxtSaleCustName.SelectionLength = 0;
            this.TxtSaleCustName.SelectionStart = 0;
            this.TxtSaleCustName.Size = new System.Drawing.Size(443, 23);
            this.TxtSaleCustName.TabIndex = 1;
            this.TxtSaleCustName.UseSystemPasswordChar = false;
            // 
            // materialLabel37
            // 
            this.materialLabel37.AutoSize = true;
            this.materialLabel37.Depth = 0;
            this.materialLabel37.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel37.Location = new System.Drawing.Point(10, 10);
            this.materialLabel37.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel37.Name = "materialLabel37";
            this.materialLabel37.Size = new System.Drawing.Size(85, 19);
            this.materialLabel37.TabIndex = 5;
            this.materialLabel37.Text = "Full Name :";
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersBindingSource1
            // 
            this.suppliersBindingSource1.DataMember = "suppliers";
            this.suppliersBindingSource1.DataSource = this.posdbDataSet1;
            // 
            // productidDataGridViewTextBoxColumn1
            // 
            this.productidDataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn1.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn1.Name = "productidDataGridViewTextBoxColumn1";
            this.productidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn1
            // 
            this.productnameDataGridViewTextBoxColumn1.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn1.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn1.Name = "productnameDataGridViewTextBoxColumn1";
            // 
            // productinitialamountDataGridViewTextBoxColumn1
            // 
            this.productinitialamountDataGridViewTextBoxColumn1.DataPropertyName = "product_initial_amount";
            this.productinitialamountDataGridViewTextBoxColumn1.HeaderText = "product_initial_amount";
            this.productinitialamountDataGridViewTextBoxColumn1.Name = "productinitialamountDataGridViewTextBoxColumn1";
            this.productinitialamountDataGridViewTextBoxColumn1.Width = 140;
            // 
            // producthpppriceDataGridViewTextBoxColumn1
            // 
            this.producthpppriceDataGridViewTextBoxColumn1.DataPropertyName = "product_hpp_price";
            this.producthpppriceDataGridViewTextBoxColumn1.HeaderText = "product_hpp_price";
            this.producthpppriceDataGridViewTextBoxColumn1.Name = "producthpppriceDataGridViewTextBoxColumn1";
            // 
            // productsellingpriceDataGridViewTextBoxColumn1
            // 
            this.productsellingpriceDataGridViewTextBoxColumn1.DataPropertyName = "product_selling_price";
            this.productsellingpriceDataGridViewTextBoxColumn1.HeaderText = "product_selling_price";
            this.productsellingpriceDataGridViewTextBoxColumn1.Name = "productsellingpriceDataGridViewTextBoxColumn1";
            this.productsellingpriceDataGridViewTextBoxColumn1.Width = 140;
            // 
            // productidDataGridViewTextBoxColumn2
            // 
            this.productidDataGridViewTextBoxColumn2.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn2.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn2.Name = "productidDataGridViewTextBoxColumn2";
            this.productidDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn2
            // 
            this.productnameDataGridViewTextBoxColumn2.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn2.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn2.Name = "productnameDataGridViewTextBoxColumn2";
            // 
            // productinitialamountDataGridViewTextBoxColumn2
            // 
            this.productinitialamountDataGridViewTextBoxColumn2.DataPropertyName = "product_initial_amount";
            this.productinitialamountDataGridViewTextBoxColumn2.HeaderText = "product_initial_amount";
            this.productinitialamountDataGridViewTextBoxColumn2.Name = "productinitialamountDataGridViewTextBoxColumn2";
            this.productinitialamountDataGridViewTextBoxColumn2.Width = 140;
            // 
            // producthpppriceDataGridViewTextBoxColumn2
            // 
            this.producthpppriceDataGridViewTextBoxColumn2.DataPropertyName = "product_hpp_price";
            this.producthpppriceDataGridViewTextBoxColumn2.HeaderText = "product_hpp_price";
            this.producthpppriceDataGridViewTextBoxColumn2.Name = "producthpppriceDataGridViewTextBoxColumn2";
            // 
            // productsellingpriceDataGridViewTextBoxColumn2
            // 
            this.productsellingpriceDataGridViewTextBoxColumn2.DataPropertyName = "product_selling_price";
            this.productsellingpriceDataGridViewTextBoxColumn2.HeaderText = "product_selling_price";
            this.productsellingpriceDataGridViewTextBoxColumn2.Name = "productsellingpriceDataGridViewTextBoxColumn2";
            this.productsellingpriceDataGridViewTextBoxColumn2.Width = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 449);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posdbDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCustAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCustHP;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCustEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCustName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCustSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCustSave;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCustCancel;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCustEdit;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCustNew;
        private System.Windows.Forms.DataGridView DataGridViewCust;
        private MaterialSkin.Controls.MaterialRaisedButton BtnProductSave;
        private MaterialSkin.Controls.MaterialRaisedButton BtnProductCancel;
        private MaterialSkin.Controls.MaterialRaisedButton BtnProductEdit;
        private MaterialSkin.Controls.MaterialRaisedButton BtnProductNew;
        private System.Windows.Forms.DataGridView DataGridViewProduct;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtProductSellingPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtProductHPPPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtProductInitialAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtProductName;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtProductID;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtProductSearch;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSuppliersSave;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSuppliersCancel;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSuppliersEdit;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSuppliersNew;
        private System.Windows.Forms.DataGridView DataGridViewSuppliers;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSuppliersPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSuppliersZipCode;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSuppliersAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSuppliersName;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSuppliersEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSuppliersSearch;
        private posdbDataSet1 posdbDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private posdbDataSet1TableAdapters.customersTableAdapter customersTableAdapter;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCustID;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private posdbDataSet1TableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productinitialamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producthpppriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsellingpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private posdbDataSet1TableAdapters.suppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custphonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custaddressDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCustDelete;
        private MaterialSkin.Controls.MaterialRaisedButton BtnProductDelete;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSuppliersDelete;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private MaterialSkin.Controls.MaterialRaisedButton BtnPurchaseSave;
        private MaterialSkin.Controls.MaterialRaisedButton BtnPurchaseEdit;
        private MaterialSkin.Controls.MaterialRaisedButton BtnPurchaseDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPurSupplierPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPurSupplierZipCode;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPurSupplierAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPurSupplierName;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Panel panel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPurSupplierID;
        private MaterialSkin.Controls.MaterialLabel materialLabel39;
        private MaterialSkin.Controls.MaterialRaisedButton BtnPurchaseLogout;
        private MaterialSkin.Controls.MaterialRaisedButton BtnPurchaseLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPurTotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPurProductID;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private MaterialSkin.Controls.MaterialRaisedButton BtnPurchaseAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSaleTotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSaleProductID;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSaleCustID;
        private MaterialSkin.Controls.MaterialLabel materialLabel27;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSaleSave;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSaleCancel;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSaleEdit;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSaleDelete;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSaleLogout;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSaleLogin;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSaleAdd;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSaleCustAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel28;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSaleCustPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel29;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSaleCustEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel30;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSaleCustName;
        private MaterialSkin.Controls.MaterialLabel materialLabel37;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliers_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliersemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliersnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliersaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierszipcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliersphonenumberDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSuppliersID;
        private MaterialSkin.Controls.MaterialLabel materialLabel31;
        private System.Windows.Forms.BindingSource suppliersBindingSource1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPurSupplierEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel32;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productinitialamountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn producthpppriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsellingpriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productinitialamountDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn producthpppriceDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsellingpriceDataGridViewTextBoxColumn2;
    }
}

