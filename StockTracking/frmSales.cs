using StockTracking.BLL;
using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTracking
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
        public SalesDTO dto = new SalesDTO();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;
            if (!isUpdate)
            {
                dgvProducts.DataSource = dto.Products;
                dgvProducts.Columns[0].HeaderText = "Product Name";
                dgvProducts.Columns[1].HeaderText = "Category Name";
                dgvProducts.Columns[2].HeaderText = "Stock Name";
                dgvProducts.Columns[3].HeaderText = "Price";
                dgvProducts.Columns[4].Visible = false;
                dgvProducts.Columns[5].Visible = false;
                dgvCustomers.DataSource = dto.Customers;
                dgvCustomers.Columns[0].Visible = false;
                dgvCustomers.Columns[1].HeaderText = "Customer Name";
                if (dto.Categories.Count > 0)
                {
                    combofull = true;
                }
            }
            else
            {
                panel1.Hide();
                txtCustomerName.Text = detail.CustomerName;
                txtProductName.Text = detail.ProductName;
                txtPrice.Text = detail.Price.ToString();
                txtProductSalesAmount.Text = detail.SalesAmount.ToString();
                ProductDetailsDTO product = dto.Products.First(x => x.ProductID == detail.ProductID);
                detail.StockAmount = product.StockAmount;
                txtProductStock.Text = detail.StockAmount.ToString();
            }
        }

        bool combofull = false;
        SalesBLL bll = new SalesBLL();
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                List<ProductDetailsDTO> list = dto.Products;
                list = list.Where(x => x.CategoryID == Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
                dgvProducts.DataSource = list;
                if (list.Count == 0)
                {
                    txtPrice.Clear();
                    txtProductName.Clear();
                    txtProductStock.Clear();
                }
            }
        }

        public SalesDetailsDTO detail = new SalesDetailsDTO();
        public bool isUpdate = false;
        private void dgvProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ProductName = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
            detail.Price = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[3].Value);
            detail.StockAmount = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[2].Value);
            detail.ProductID = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[4].Value);
            detail.CategoryID = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[5].Value);
            txtProductName.Text = detail.ProductName;
            txtPrice.Text = detail.Price.ToString();
            txtProductStock.Text = detail.StockAmount.ToString();
        }

        private void dgvCustomers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.CustomerName = dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
            detail.CustomerID = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells[0].Value);
            txtCustomerName.Text = detail.CustomerName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (detail.ProductID == 0)
            {
                MessageBox.Show("Please select a product from the product table!");
            }
            
            else 
            {
                if (!isUpdate)
                {
                    if (detail.CustomerID == 0)
                    {
                        MessageBox.Show("Please select a customer from the customer table!");
                    }
                    else if (detail.StockAmount < Convert.ToInt32(txtProductSalesAmount.Text))
                    {
                        MessageBox.Show("You don't have enough products for Sale");
                    }
                    else
                    {
                        detail.SalesAmount = Convert.ToInt32(txtProductSalesAmount.Text);
                        detail.SalesDate = DateTime.Today;
                        if (bll.Insert(detail))
                        {
                            MessageBox.Show("Sold...");
                            bll = new SalesBLL();
                            dto = bll.Select();
                            dgvProducts.DataSource = dto.Products;
                            dto.Customers = dto.Customers;
                            combofull = false;
                            cmbCategory.DataSource = dto.Categories;
                            if (dto.Products.Count > 0)
                            {
                                combofull = true;
                            }
                            txtProductSalesAmount.Clear();
                        }
                    }
                }
                else
                {
                    if (detail.SalesAmount == Convert.ToInt32())
                    {

                    }
                }
            }
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            List<CustomerDetailsDTO> list = dto.Customers;
            list = list.Where(x => x.CustomerName.Contains(txtCustomerSearch.Text)).ToList();
            dgvCustomers.DataSource = list;
            if (list.Count == 0)
            {
                txtCustomerName.Clear();
            }
        }
    }
}
