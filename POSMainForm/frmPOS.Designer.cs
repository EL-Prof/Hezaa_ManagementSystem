namespace POSMainForm
{
    partial class frmPOS
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlLeft1 = new System.Windows.Forms.Panel();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblProductcode = new System.Windows.Forms.Label();
            this.pnlInvoiceNumber = new System.Windows.Forms.Panel();
            this.lblInvoiceNumberValue = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.dsReportC = new POSMainForm.dsReportC();
            this.dailySalesByStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlLstViewProduct = new System.Windows.Forms.Panel();
            this.lstviewProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlStaffInfo = new System.Windows.Forms.Panel();
            this.lblNameValue = new System.Windows.Forms.TextBox();
            this.lblPositionValue = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblStaffInfo = new System.Windows.Forms.Label();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRePrint = new System.Windows.Forms.Button();
            this.btnSettle = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlBasketInfo = new System.Windows.Forms.Panel();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblBasketInfo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft1.SuspendLayout();
            this.pnlInvoiceNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailySalesByStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksInBindingSource)).BeginInit();
            this.pnlLstViewProduct.SuspendLayout();
            this.PnlStaffInfo.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.pnlBasketInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSize = true;
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(664, 52);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Teal;
            this.lblHeader.Location = new System.Drawing.Point(237, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(212, 39);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Point of Sale";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 52);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 433);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // pnlLeft1
            // 
            this.pnlLeft1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLeft1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlLeft1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft1.Controls.Add(this.txtBarCode);
            this.pnlLeft1.Controls.Add(this.lblBarCode);
            this.pnlLeft1.Controls.Add(this.txtTotalPrice);
            this.pnlLeft1.Controls.Add(this.txtQuantity);
            this.pnlLeft1.Controls.Add(this.txtUnitPrice);
            this.pnlLeft1.Controls.Add(this.txtProductCode);
            this.pnlLeft1.Controls.Add(this.lblTotalPrice);
            this.pnlLeft1.Controls.Add(this.txtItemDescription);
            this.pnlLeft1.Controls.Add(this.lblQuantity);
            this.pnlLeft1.Controls.Add(this.lblItemDescription);
            this.pnlLeft1.Controls.Add(this.lblUnitPrice);
            this.pnlLeft1.Controls.Add(this.lblProductcode);
            this.pnlLeft1.Location = new System.Drawing.Point(3, 42);
            this.pnlLeft1.Name = "pnlLeft1";
            this.pnlLeft1.Size = new System.Drawing.Size(482, 47);
            this.pnlLeft1.TabIndex = 4;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(3, 24);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(60, 20);
            this.txtBarCode.TabIndex = 12;
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBarCode.Location = new System.Drawing.Point(3, 8);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(48, 13);
            this.lblBarCode.TabIndex = 11;
            this.lblBarCode.Text = "BarCode";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(409, 24);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(60, 20);
            this.txtTotalPrice.TabIndex = 10;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(346, 24);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(60, 20);
            this.txtQuantity.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(283, 24);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(60, 20);
            this.txtUnitPrice.TabIndex = 9;
            // 
            // txtProductCode
            // 
            this.txtProductCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProductCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProductCode.Location = new System.Drawing.Point(66, 24);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(60, 20);
            this.txtProductCode.TabIndex = 8;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTotalPrice.Location = new System.Drawing.Point(409, 8);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(34, 13);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "Total ";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(135, 24);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(145, 20);
            this.txtItemDescription.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblQuantity.Location = new System.Drawing.Point(346, 8);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblItemDescription.Location = new System.Drawing.Point(135, 8);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(83, 13);
            this.lblItemDescription.TabIndex = 4;
            this.lblItemDescription.Text = "Item Description";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUnitPrice.Location = new System.Drawing.Point(283, 8);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 5;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblProductcode
            // 
            this.lblProductcode.AutoSize = true;
            this.lblProductcode.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblProductcode.Location = new System.Drawing.Point(66, 8);
            this.lblProductcode.Name = "lblProductcode";
            this.lblProductcode.Size = new System.Drawing.Size(71, 13);
            this.lblProductcode.TabIndex = 3;
            this.lblProductcode.Text = "Product code";
            // 
            // pnlInvoiceNumber
            // 
            this.pnlInvoiceNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlInvoiceNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlInvoiceNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInvoiceNumber.Controls.Add(this.lblInvoiceNumberValue);
            this.pnlInvoiceNumber.Controls.Add(this.lblInvoiceNumber);
            this.pnlInvoiceNumber.Location = new System.Drawing.Point(487, 42);
            this.pnlInvoiceNumber.Name = "pnlInvoiceNumber";
            this.pnlInvoiceNumber.Padding = new System.Windows.Forms.Padding(3);
            this.pnlInvoiceNumber.Size = new System.Drawing.Size(180, 47);
            this.pnlInvoiceNumber.TabIndex = 0;
            // 
            // lblInvoiceNumberValue
            // 
            this.lblInvoiceNumberValue.AutoSize = true;
            this.lblInvoiceNumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumberValue.ForeColor = System.Drawing.Color.Teal;
            this.lblInvoiceNumberValue.Location = new System.Drawing.Point(99, 8);
            this.lblInvoiceNumberValue.Name = "lblInvoiceNumberValue";
            this.lblInvoiceNumberValue.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblInvoiceNumberValue.Size = new System.Drawing.Size(72, 28);
            this.lblInvoiceNumberValue.TabIndex = 1;
            this.lblInvoiceNumberValue.Text = "15001";
            this.lblInvoiceNumberValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumber.ForeColor = System.Drawing.Color.Teal;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(2, 8);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblInvoiceNumber.Size = new System.Drawing.Size(131, 28);
            this.lblInvoiceNumber.TabIndex = 0;
            this.lblInvoiceNumber.Text = "Invoice No : ";
            // 
            // dsReportC
            // 
            this.dsReportC.DataSetName = "dsReportC";
            this.dsReportC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dailySalesByStaffBindingSource
            // 
            this.dailySalesByStaffBindingSource.DataMember = "DailySalesByStaff";
            this.dailySalesByStaffBindingSource.DataSource = this.dsReportC;
            // 
            // stocksInBindingSource
            // 
            this.stocksInBindingSource.DataMember = "StocksIn";
            this.stocksInBindingSource.DataSource = this.dsReportC;
            // 
            // pnlLstViewProduct
            // 
            this.pnlLstViewProduct.Controls.Add(this.lstviewProduct);
            this.pnlLstViewProduct.Location = new System.Drawing.Point(3, 93);
            this.pnlLstViewProduct.Name = "pnlLstViewProduct";
            this.pnlLstViewProduct.Size = new System.Drawing.Size(482, 403);
            this.pnlLstViewProduct.TabIndex = 5;
            // 
            // lstviewProduct
            // 
            this.lstviewProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstviewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader7,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstviewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstviewProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lstviewProduct.FullRowSelect = true;
            this.lstviewProduct.GridLines = true;
            this.lstviewProduct.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstviewProduct.Location = new System.Drawing.Point(0, 0);
            this.lstviewProduct.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lstviewProduct.Name = "lstviewProduct";
            this.lstviewProduct.Scrollable = false;
            this.lstviewProduct.Size = new System.Drawing.Size(482, 403);
            this.lstviewProduct.TabIndex = 6;
            this.lstviewProduct.UseCompatibleStateImageBehavior = false;
            this.lstviewProduct.View = System.Windows.Forms.View.Details;
            this.lstviewProduct.SelectedIndexChanged += new System.EventHandler(this.lstviewProduct_SelectedIndexChanged);
            this.lstviewProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstviewProduct_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Code";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Description";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Color";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Size";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Price";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Discount";
            this.columnHeader6.Width = 61;
            // 
            // PnlStaffInfo
            // 
            this.PnlStaffInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlStaffInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PnlStaffInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlStaffInfo.Controls.Add(this.lblNameValue);
            this.PnlStaffInfo.Controls.Add(this.lblPositionValue);
            this.PnlStaffInfo.Controls.Add(this.lblName);
            this.PnlStaffInfo.Controls.Add(this.lblPosition);
            this.PnlStaffInfo.Controls.Add(this.lblStaffInfo);
            this.PnlStaffInfo.ForeColor = System.Drawing.Color.Aqua;
            this.PnlStaffInfo.Location = new System.Drawing.Point(487, 93);
            this.PnlStaffInfo.Name = "PnlStaffInfo";
            this.PnlStaffInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PnlStaffInfo.Size = new System.Drawing.Size(180, 70);
            this.PnlStaffInfo.TabIndex = 2;
            // 
            // lblNameValue
            // 
            this.lblNameValue.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNameValue.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNameValue.Location = new System.Drawing.Point(76, 47);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.ReadOnly = true;
            this.lblNameValue.Size = new System.Drawing.Size(100, 20);
            this.lblNameValue.TabIndex = 8;
            this.lblNameValue.Text = "Hamada";
            // 
            // lblPositionValue
            // 
            this.lblPositionValue.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPositionValue.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPositionValue.Location = new System.Drawing.Point(76, 24);
            this.lblPositionValue.Name = "lblPositionValue";
            this.lblPositionValue.ReadOnly = true;
            this.lblPositionValue.Size = new System.Drawing.Size(100, 20);
            this.lblPositionValue.TabIndex = 7;
            this.lblPositionValue.Text = "Admin";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Teal;
            this.lblName.Location = new System.Drawing.Point(8, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.Teal;
            this.lblPosition.Location = new System.Drawing.Point(8, 25);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(70, 18);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Position:";
            // 
            // lblStaffInfo
            // 
            this.lblStaffInfo.AutoSize = true;
            this.lblStaffInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffInfo.ForeColor = System.Drawing.Color.Teal;
            this.lblStaffInfo.Location = new System.Drawing.Point(-1, 3);
            this.lblStaffInfo.Name = "lblStaffInfo";
            this.lblStaffInfo.Size = new System.Drawing.Size(163, 22);
            this.lblStaffInfo.TabIndex = 0;
            this.lblStaffInfo.Text = "Staff Information";
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTransactions.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTransactions.Controls.Add(this.btnRemove);
            this.pnlTransactions.Controls.Add(this.btnDiscount);
            this.pnlTransactions.Controls.Add(this.btnEnter);
            this.pnlTransactions.Controls.Add(this.btnClose);
            this.pnlTransactions.Controls.Add(this.btnRePrint);
            this.pnlTransactions.Controls.Add(this.btnSettle);
            this.pnlTransactions.Controls.Add(this.btnNew);
            this.pnlTransactions.Location = new System.Drawing.Point(487, 292);
            this.pnlTransactions.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(180, 204);
            this.pnlTransactions.TabIndex = 7;
            this.pnlTransactions.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTransactions_Paint);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRemove.Location = new System.Drawing.Point(90, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 39);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove Item [F2]";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDiscount.Location = new System.Drawing.Point(90, 58);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(89, 39);
            this.btnDiscount.TabIndex = 5;
            this.btnDiscount.Text = "Discount [F4]";
            this.btnDiscount.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEnter.Location = new System.Drawing.Point(0, 104);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(89, 39);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter Quantity [F5]";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.Location = new System.Drawing.Point(90, 104);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close [F6]";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRePrint
            // 
            this.btnRePrint.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRePrint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRePrint.Location = new System.Drawing.Point(46, 149);
            this.btnRePrint.Name = "btnRePrint";
            this.btnRePrint.Size = new System.Drawing.Size(89, 39);
            this.btnRePrint.TabIndex = 2;
            this.btnRePrint.Text = "Re-Print Invoice [F7]";
            this.btnRePrint.UseVisualStyleBackColor = false;
            this.btnRePrint.Click += new System.EventHandler(this.btnRePrint_Click);
            // 
            // btnSettle
            // 
            this.btnSettle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSettle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSettle.Location = new System.Drawing.Point(0, 58);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(89, 39);
            this.btnSettle.TabIndex = 1;
            this.btnSettle.Text = "Settle Payment [F3]";
            this.btnSettle.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnNew.Location = new System.Drawing.Point(0, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 39);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New transaction [F1]";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // pnlBasketInfo
            // 
            this.pnlBasketInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBasketInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlBasketInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBasketInfo.Controls.Add(this.txtTotalAmount);
            this.pnlBasketInfo.Controls.Add(this.txtSubTotal);
            this.pnlBasketInfo.Controls.Add(this.txtVal);
            this.pnlBasketInfo.Controls.Add(this.txtTotalItems);
            this.pnlBasketInfo.Controls.Add(this.lblTotalAmount);
            this.pnlBasketInfo.Controls.Add(this.lblSubTotal);
            this.pnlBasketInfo.Controls.Add(this.lblValue);
            this.pnlBasketInfo.Controls.Add(this.lblTotalItems);
            this.pnlBasketInfo.Controls.Add(this.lblBasketInfo);
            this.pnlBasketInfo.Location = new System.Drawing.Point(487, 167);
            this.pnlBasketInfo.Name = "pnlBasketInfo";
            this.pnlBasketInfo.Size = new System.Drawing.Size(180, 121);
            this.pnlBasketInfo.TabIndex = 3;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTotalAmount.Location = new System.Drawing.Point(94, 95);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(72, 20);
            this.txtTotalAmount.TabIndex = 9;
            this.txtTotalAmount.Text = "0.00";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSubTotal.Location = new System.Drawing.Point(94, 66);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(72, 20);
            this.txtSubTotal.TabIndex = 8;
            this.txtSubTotal.Text = "0.00";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVal
            // 
            this.txtVal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtVal.Location = new System.Drawing.Point(94, 45);
            this.txtVal.Name = "txtVal";
            this.txtVal.ReadOnly = true;
            this.txtVal.Size = new System.Drawing.Size(72, 20);
            this.txtVal.TabIndex = 7;
            this.txtVal.Text = "0.00";
            this.txtVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTotalItems.Location = new System.Drawing.Point(94, 24);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.ReadOnly = true;
            this.txtTotalItems.Size = new System.Drawing.Size(72, 20);
            this.txtTotalItems.TabIndex = 2;
            this.txtTotalItems.Text = "0";
            this.txtTotalItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Teal;
            this.lblTotalAmount.Location = new System.Drawing.Point(3, 95);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(115, 19);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.Teal;
            this.lblSubTotal.Location = new System.Drawing.Point(8, 68);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(72, 17);
            this.lblSubTotal.TabIndex = 5;
            this.lblSubTotal.Text = "Sub Total:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.Teal;
            this.lblValue.Location = new System.Drawing.Point(8, 47);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(31, 17);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Val:";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.ForeColor = System.Drawing.Color.Teal;
            this.lblTotalItems.Location = new System.Drawing.Point(8, 26);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(82, 17);
            this.lblTotalItems.TabIndex = 1;
            this.lblTotalItems.Text = "Total Items:";
            // 
            // lblBasketInfo
            // 
            this.lblBasketInfo.AutoSize = true;
            this.lblBasketInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasketInfo.ForeColor = System.Drawing.Color.Teal;
            this.lblBasketInfo.Location = new System.Drawing.Point(-1, 4);
            this.lblBasketInfo.Name = "lblBasketInfo";
            this.lblBasketInfo.Size = new System.Drawing.Size(185, 22);
            this.lblBasketInfo.TabIndex = 0;
            this.lblBasketInfo.Text = "Basket Information";
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 485);
            this.Controls.Add(this.pnlBasketInfo);
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.PnlStaffInfo);
            this.Controls.Add(this.pnlLstViewProduct);
            this.Controls.Add(this.pnlInvoiceNumber);
            this.Controls.Add(this.pnlLeft1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlHeader);
            this.KeyPreview = true;
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPOS_KeyDown);
            this.Resize += new System.EventHandler(this.frmPOS_Resize);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft1.ResumeLayout(false);
            this.pnlLeft1.PerformLayout();
            this.pnlInvoiceNumber.ResumeLayout(false);
            this.pnlInvoiceNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailySalesByStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksInBindingSource)).EndInit();
            this.pnlLstViewProduct.ResumeLayout(false);
            this.PnlStaffInfo.ResumeLayout(false);
            this.PnlStaffInfo.PerformLayout();
            this.pnlTransactions.ResumeLayout(false);
            this.pnlBasketInfo.ResumeLayout(false);
            this.pnlBasketInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlLeft1;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.Panel pnlInvoiceNumber;
        private System.Windows.Forms.BindingSource dailySalesByStaffBindingSource;
        private dsReportC dsReportC;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblProductcode;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblInvoiceNumberValue;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.BindingSource stocksInBindingSource;
        private System.Windows.Forms.Panel pnlLstViewProduct;
        internal System.Windows.Forms.ListView lstviewProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel PnlStaffInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblStaffInfo;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Panel pnlBasketInfo;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblBasketInfo;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.TextBox txtTotalItems;
        private System.Windows.Forms.TextBox lblNameValue;
        private System.Windows.Forms.TextBox lblPositionValue;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRePrint;
        private System.Windows.Forms.Button btnSettle;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}