namespace StockTracking
{
    partial class frmSales
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
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.lblCustomerNameCustomerField = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblProductSalesAmount = new System.Windows.Forms.Label();
            this.txtProductSalesAmount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbCustomers = new System.Windows.Forms.GroupBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.pnlCustomers = new System.Windows.Forms.Panel();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.pnlCustomers.SuspendLayout();
            this.gbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProductStock
            // 
            this.txtProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductStock.Location = new System.Drawing.Point(225, 119);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.ReadOnly = true;
            this.txtProductStock.Size = new System.Drawing.Size(188, 26);
            this.txtProductStock.TabIndex = 17;
            // 
            // lblProductStock
            // 
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductStock.Location = new System.Drawing.Point(22, 122);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(122, 20);
            this.lblProductStock.TabIndex = 16;
            this.lblProductStock.Text = "Product Stock";
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerSearch.Location = new System.Drawing.Point(16, 34);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(212, 26);
            this.txtCustomerSearch.TabIndex = 0;
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            // 
            // lblCustomerNameCustomerField
            // 
            this.lblCustomerNameCustomerField.AutoSize = true;
            this.lblCustomerNameCustomerField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNameCustomerField.Location = new System.Drawing.Point(12, 11);
            this.lblCustomerNameCustomerField.Name = "lblCustomerNameCustomerField";
            this.lblCustomerNameCustomerField.Size = new System.Drawing.Size(137, 20);
            this.lblCustomerNameCustomerField.TabIndex = 14;
            this.lblCustomerNameCustomerField.Text = "Customer Name";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(22, 55);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(122, 20);
            this.lblProductName.TabIndex = 14;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(225, 55);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(188, 26);
            this.txtProductName.TabIndex = 15;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(22, 90);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 20);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(225, 87);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(188, 26);
            this.txtPrice.TabIndex = 17;
            // 
            // lblProductSalesAmount
            // 
            this.lblProductSalesAmount.AutoSize = true;
            this.lblProductSalesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSalesAmount.Location = new System.Drawing.Point(22, 154);
            this.lblProductSalesAmount.Name = "lblProductSalesAmount";
            this.lblProductSalesAmount.Size = new System.Drawing.Size(188, 20);
            this.lblProductSalesAmount.TabIndex = 16;
            this.lblProductSalesAmount.Text = "Product Sales Amount";
            // 
            // txtProductSalesAmount
            // 
            this.txtProductSalesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSalesAmount.Location = new System.Drawing.Point(225, 151);
            this.txtProductSalesAmount.Name = "txtProductSalesAmount";
            this.txtProductSalesAmount.Size = new System.Drawing.Size(188, 26);
            this.txtProductSalesAmount.TabIndex = 0;
            this.txtProductSalesAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbCustomers);
            this.panel1.Controls.Add(this.gbProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(444, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 450);
            this.panel1.TabIndex = 18;
            // 
            // gbCustomers
            // 
            this.gbCustomers.Controls.Add(this.dgvCustomers);
            this.gbCustomers.Controls.Add(this.pnlCustomers);
            this.gbCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomers.Location = new System.Drawing.Point(0, 216);
            this.gbCustomers.Name = "gbCustomers";
            this.gbCustomers.Size = new System.Drawing.Size(270, 234);
            this.gbCustomers.TabIndex = 0;
            this.gbCustomers.TabStop = false;
            this.gbCustomers.Text = "Customers";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 94);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(264, 137);
            this.dgvCustomers.TabIndex = 1;
            this.dgvCustomers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_RowEnter);
            // 
            // pnlCustomers
            // 
            this.pnlCustomers.Controls.Add(this.txtCustomerSearch);
            this.pnlCustomers.Controls.Add(this.lblCustomerNameCustomerField);
            this.pnlCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomers.Location = new System.Drawing.Point(3, 19);
            this.pnlCustomers.Name = "pnlCustomers";
            this.pnlCustomers.Size = new System.Drawing.Size(264, 75);
            this.pnlCustomers.TabIndex = 0;
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.dgvProducts);
            this.gbProducts.Controls.Add(this.pnlProducts);
            this.gbProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducts.Location = new System.Drawing.Point(0, 0);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(270, 216);
            this.gbProducts.TabIndex = 0;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Products";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(3, 69);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(264, 144);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_RowEnter);
            // 
            // pnlProducts
            // 
            this.pnlProducts.Controls.Add(this.cmbCategory);
            this.pnlProducts.Controls.Add(this.lblCategory);
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProducts.Location = new System.Drawing.Point(3, 19);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(264, 50);
            this.pnlProducts.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(118, 8);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(128, 28);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(12, 11);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 20);
            this.lblCategory.TabIndex = 12;
            this.lblCategory.Text = "Category";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(225, 23);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(188, 26);
            this.txtCustomerName.TabIndex = 17;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(22, 26);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(137, 20);
            this.lblCustomerName.TabIndex = 16;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(248, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 60);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(130, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 60);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtProductSalesAmount);
            this.Controls.Add(this.lblProductSalesAmount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductStock);
            this.Controls.Add(this.lblProductName);
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.panel1.ResumeLayout(false);
            this.gbCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.pnlCustomers.ResumeLayout(false);
            this.pnlCustomers.PerformLayout();
            this.gbProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlProducts.ResumeLayout(false);
            this.pnlProducts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Label lblCustomerNameCustomerField;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblProductSalesAmount;
        private System.Windows.Forms.TextBox txtProductSalesAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbCustomers;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel pnlCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}