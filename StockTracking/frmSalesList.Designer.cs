namespace StockTracking
{
    partial class frmSalesList
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chDate = new System.Windows.Forms.CheckBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.gbSalesAmount = new System.Windows.Forms.GroupBox();
            this.rbSalesEqual = new System.Windows.Forms.RadioButton();
            this.rbSalesless = new System.Windows.Forms.RadioButton();
            this.rbSalesMore = new System.Windows.Forms.RadioButton();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.rbPriceEqual = new System.Windows.Forms.RadioButton();
            this.rbPriceLess = new System.Windows.Forms.RadioButton();
            this.rbPriceMore = new System.Windows.Forms.RadioButton();
            this.txtSalesAmount = new System.Windows.Forms.TextBox();
            this.lblSalesAmount = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSalesDateFrom = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvSalesList = new System.Windows.Forms.DataGridView();
            this.pnlSearch.SuspendLayout();
            this.gbSalesAmount.SuspendLayout();
            this.gbPrice.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnClear);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.chDate);
            this.pnlSearch.Controls.Add(this.dtpTo);
            this.pnlSearch.Controls.Add(this.dtpFrom);
            this.pnlSearch.Controls.Add(this.gbSalesAmount);
            this.pnlSearch.Controls.Add(this.gbPrice);
            this.pnlSearch.Controls.Add(this.txtSalesAmount);
            this.pnlSearch.Controls.Add(this.lblSalesAmount);
            this.pnlSearch.Controls.Add(this.txtProductPrice);
            this.pnlSearch.Controls.Add(this.lblProductPrice);
            this.pnlSearch.Controls.Add(this.cmbCategory);
            this.pnlSearch.Controls.Add(this.lblTo);
            this.pnlSearch.Controls.Add(this.lblSalesDateFrom);
            this.pnlSearch.Controls.Add(this.lblCategory);
            this.pnlSearch.Controls.Add(this.txtProductName);
            this.pnlSearch.Controls.Add(this.lblProductName);
            this.pnlSearch.Controls.Add(this.txtCustomerName);
            this.pnlSearch.Controls.Add(this.lblCustomerName);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(800, 146);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(653, 109);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 33);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(567, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 33);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chDate
            // 
            this.chDate.AutoSize = true;
            this.chDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chDate.Location = new System.Drawing.Point(469, 109);
            this.chDate.Name = "chDate";
            this.chDate.Size = new System.Drawing.Size(61, 21);
            this.chDate.TabIndex = 9;
            this.chDate.Text = "Date";
            this.chDate.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(329, 106);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(128, 23);
            this.dtpTo.TabIndex = 8;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(160, 106);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(128, 23);
            this.dtpFrom.TabIndex = 7;
            // 
            // gbSalesAmount
            // 
            this.gbSalesAmount.Controls.Add(this.rbSalesEqual);
            this.gbSalesAmount.Controls.Add(this.rbSalesless);
            this.gbSalesAmount.Controls.Add(this.rbSalesMore);
            this.gbSalesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSalesAmount.Location = new System.Drawing.Point(567, 59);
            this.gbSalesAmount.Name = "gbSalesAmount";
            this.gbSalesAmount.Size = new System.Drawing.Size(221, 49);
            this.gbSalesAmount.TabIndex = 6;
            this.gbSalesAmount.TabStop = false;
            this.gbSalesAmount.Text = "Sales Amount";
            // 
            // rbSalesEqual
            // 
            this.rbSalesEqual.AutoSize = true;
            this.rbSalesEqual.Location = new System.Drawing.Point(6, 19);
            this.rbSalesEqual.Name = "rbSalesEqual";
            this.rbSalesEqual.Size = new System.Drawing.Size(67, 21);
            this.rbSalesEqual.TabIndex = 0;
            this.rbSalesEqual.TabStop = true;
            this.rbSalesEqual.Text = "Equal";
            this.rbSalesEqual.UseVisualStyleBackColor = true;
            // 
            // rbSalesless
            // 
            this.rbSalesless.AutoSize = true;
            this.rbSalesless.Location = new System.Drawing.Point(147, 19);
            this.rbSalesless.Name = "rbSalesless";
            this.rbSalesless.Size = new System.Drawing.Size(60, 21);
            this.rbSalesless.TabIndex = 2;
            this.rbSalesless.TabStop = true;
            this.rbSalesless.Text = "Less";
            this.rbSalesless.UseVisualStyleBackColor = true;
            // 
            // rbSalesMore
            // 
            this.rbSalesMore.AutoSize = true;
            this.rbSalesMore.Location = new System.Drawing.Point(79, 19);
            this.rbSalesMore.Name = "rbSalesMore";
            this.rbSalesMore.Size = new System.Drawing.Size(62, 21);
            this.rbSalesMore.TabIndex = 1;
            this.rbSalesMore.TabStop = true;
            this.rbSalesMore.Text = "More";
            this.rbSalesMore.UseVisualStyleBackColor = true;
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.rbPriceEqual);
            this.gbPrice.Controls.Add(this.rbPriceLess);
            this.gbPrice.Controls.Add(this.rbPriceMore);
            this.gbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrice.Location = new System.Drawing.Point(567, 4);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(221, 49);
            this.gbPrice.TabIndex = 4;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "Price";
            // 
            // rbPriceEqual
            // 
            this.rbPriceEqual.AutoSize = true;
            this.rbPriceEqual.Location = new System.Drawing.Point(6, 19);
            this.rbPriceEqual.Name = "rbPriceEqual";
            this.rbPriceEqual.Size = new System.Drawing.Size(67, 21);
            this.rbPriceEqual.TabIndex = 0;
            this.rbPriceEqual.TabStop = true;
            this.rbPriceEqual.Text = "Equal";
            this.rbPriceEqual.UseVisualStyleBackColor = true;
            // 
            // rbPriceLess
            // 
            this.rbPriceLess.AutoSize = true;
            this.rbPriceLess.Location = new System.Drawing.Point(147, 19);
            this.rbPriceLess.Name = "rbPriceLess";
            this.rbPriceLess.Size = new System.Drawing.Size(60, 21);
            this.rbPriceLess.TabIndex = 2;
            this.rbPriceLess.TabStop = true;
            this.rbPriceLess.Text = "Less";
            this.rbPriceLess.UseVisualStyleBackColor = true;
            // 
            // rbPriceMore
            // 
            this.rbPriceMore.AutoSize = true;
            this.rbPriceMore.Location = new System.Drawing.Point(79, 19);
            this.rbPriceMore.Name = "rbPriceMore";
            this.rbPriceMore.Size = new System.Drawing.Size(62, 21);
            this.rbPriceMore.TabIndex = 1;
            this.rbPriceMore.TabStop = true;
            this.rbPriceMore.Text = "More";
            this.rbPriceMore.UseVisualStyleBackColor = true;
            // 
            // txtSalesAmount
            // 
            this.txtSalesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesAmount.Location = new System.Drawing.Point(433, 66);
            this.txtSalesAmount.Name = "txtSalesAmount";
            this.txtSalesAmount.Size = new System.Drawing.Size(128, 26);
            this.txtSalesAmount.TabIndex = 5;
            this.txtSalesAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalesAmount_KeyPress);
            // 
            // lblSalesAmount
            // 
            this.lblSalesAmount.AutoSize = true;
            this.lblSalesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesAmount.Location = new System.Drawing.Point(294, 69);
            this.lblSalesAmount.Name = "lblSalesAmount";
            this.lblSalesAmount.Size = new System.Drawing.Size(121, 20);
            this.lblSalesAmount.TabIndex = 24;
            this.lblSalesAmount.Text = "Sales Amount";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(433, 22);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(128, 26);
            this.txtProductPrice.TabIndex = 3;
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrice_KeyPress);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(294, 25);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(116, 20);
            this.lblProductPrice.TabIndex = 25;
            this.lblProductPrice.Text = "Product Price";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(160, 72);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(128, 28);
            this.cmbCategory.TabIndex = 2;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(294, 108);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 20);
            this.lblTo.TabIndex = 20;
            this.lblTo.Text = "To";
            // 
            // lblSalesDateFrom
            // 
            this.lblSalesDateFrom.AutoSize = true;
            this.lblSalesDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesDateFrom.Location = new System.Drawing.Point(10, 108);
            this.lblSalesDateFrom.Name = "lblSalesDateFrom";
            this.lblSalesDateFrom.Size = new System.Drawing.Size(144, 20);
            this.lblSalesDateFrom.TabIndex = 20;
            this.lblSalesDateFrom.Text = "Sales Date From";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(10, 72);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 20);
            this.lblCategory.TabIndex = 20;
            this.lblCategory.Text = "Category";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(160, 41);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(128, 26);
            this.txtProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(9, 41);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(122, 20);
            this.lblProductName.TabIndex = 21;
            this.lblProductName.Text = "Product Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(160, 9);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(128, 26);
            this.txtCustomerName.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(9, 11);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(137, 20);
            this.lblCustomerName.TabIndex = 18;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 382);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(800, 68);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(534, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(418, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(186, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(302, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 39);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvSalesList
            // 
            this.dgvSalesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesList.Location = new System.Drawing.Point(0, 146);
            this.dgvSalesList.Name = "dgvSalesList";
            this.dgvSalesList.ReadOnly = true;
            this.dgvSalesList.Size = new System.Drawing.Size(800, 236);
            this.dgvSalesList.TabIndex = 1;
            this.dgvSalesList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesList_RowEnter);
            // 
            // frmSalesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSalesList);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlSearch);
            this.Name = "frmSalesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales List";
            this.Load += new System.EventHandler(this.frmSalesList_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.gbSalesAmount.ResumeLayout(false);
            this.gbSalesAmount.PerformLayout();
            this.gbPrice.ResumeLayout(false);
            this.gbPrice.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.DataGridView dgvSalesList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbSalesAmount;
        private System.Windows.Forms.RadioButton rbSalesEqual;
        private System.Windows.Forms.RadioButton rbSalesless;
        private System.Windows.Forms.RadioButton rbSalesMore;
        private System.Windows.Forms.GroupBox gbPrice;
        private System.Windows.Forms.RadioButton rbPriceEqual;
        private System.Windows.Forms.RadioButton rbPriceLess;
        private System.Windows.Forms.RadioButton rbPriceMore;
        private System.Windows.Forms.TextBox txtSalesAmount;
        private System.Windows.Forms.Label lblSalesAmount;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.CheckBox chDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSalesDateFrom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
    }
}