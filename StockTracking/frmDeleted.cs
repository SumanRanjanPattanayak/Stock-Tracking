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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StockTracking
{
    public partial class frmDeleted : Form
    {
        public frmDeleted()
        {
            InitializeComponent();
        }
        SalesDTO dto = new SalesDTO();
        SalesBLL bll = new SalesBLL();
        private void frmDeleted_Load(object sender, EventArgs e)
        {
            cmbDeletedData.Items.Add("Category");
            cmbDeletedData.Items.Add("Customer");
            cmbDeletedData.Items.Add("Product");
            cmbDeletedData.Items.Add("Sales");
            dto = bll.Select(true);
            dto = bll.Select();
            dgvFormDeleted.DataSource = dto.Sales;
            dgvFormDeleted.Columns[0].HeaderText = "Customer Name";
            dgvFormDeleted.Columns[1].HeaderText = "Product Name";
            dgvFormDeleted.Columns[2].HeaderText = "Category Name";
            dgvFormDeleted.Columns[6].HeaderText = "Sales Amount";
            dgvFormDeleted.Columns[7].HeaderText = "Price";
            dgvFormDeleted.Columns[10].HeaderText = "Sales Date";
            dgvFormDeleted.Columns[3].Visible = false;
            dgvFormDeleted.Columns[4].Visible = false;
            dgvFormDeleted.Columns[5].Visible = false;
            dgvFormDeleted.Columns[9].Visible = false;
            dgvFormDeleted.Columns[8].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SalesDetailsDTO salesdetail = new SalesDetailsDTO();
        ProductDetailsDTO productdetail = new ProductDetailsDTO();
        CategoryDetailsDTO categorydetail = new CategoryDetailsDTO();
        CustomerDetailsDTO customerdetail = new CustomerDetailsDTO();
        CategoryBLL CategoryBLL = new CategoryBLL();
        ProductBLL ProductBLL = new ProductBLL();
        CustomerBLL CustomerBLL = new CustomerBLL();
        SalesBLL SalesBLL = new SalesBLL();
        private void cmbDeletedData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeletedData.SelectedIndex == 0)
            {
                dgvFormDeleted.DataSource = dto.Categories;
                dgvFormDeleted.Columns[0].Visible = false;
                dgvFormDeleted.Columns[1].HeaderText = "Category Name";
            }
            else if (cmbDeletedData.SelectedIndex == 1)
            {
                dgvFormDeleted.DataSource = dto.Customers;
                dgvFormDeleted.Columns[0].Visible = false;
                dgvFormDeleted.Columns[1].HeaderText = "Customer Name";
            }
            else if (cmbDeletedData.SelectedIndex == 2)
            {
                dgvFormDeleted.DataSource = dto.Products;
                dgvFormDeleted.Columns[0].HeaderText = "Product Name";
                dgvFormDeleted.Columns[1].HeaderText = "Category Name";
                dgvFormDeleted.Columns[2].HeaderText = "Stock Name";
                dgvFormDeleted.Columns[3].HeaderText = "Price";
                dgvFormDeleted.Columns[4].Visible = false;
                dgvFormDeleted.Columns[5].Visible = false;
                dgvFormDeleted.Columns[6].Visible = false;
            }
            else 
            {
                dgvFormDeleted.Columns[0].HeaderText = "Customer Name";
                dgvFormDeleted.Columns[1].HeaderText = "Product Name";
                dgvFormDeleted.Columns[2].HeaderText = "Category Name";
                dgvFormDeleted.Columns[6].HeaderText = "Sales Amount";
                dgvFormDeleted.Columns[7].HeaderText = "Price";
                dgvFormDeleted.Columns[10].HeaderText = "Sales Date";
                dgvFormDeleted.Columns[3].Visible = false;
                dgvFormDeleted.Columns[4].Visible = false;
                dgvFormDeleted.Columns[5].Visible = false;
                dgvFormDeleted.Columns[9].Visible = false;
                dgvFormDeleted.Columns[8].Visible = false;
                dgvFormDeleted.Columns[11].Visible = false;
                dgvFormDeleted.Columns[12].Visible = false;
                dgvFormDeleted.Columns[13].Visible = false;
            }
        }

        private void dgvFormDeleted_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbDeletedData.SelectedIndex == 0)
            {
                categorydetail = new CategoryDetailsDTO();
                categorydetail.ID = Convert.ToInt32(dgvFormDeleted.Rows[e.RowIndex].Cells[0].Value);
                categorydetail.CategoryName = dgvFormDeleted.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cmbDeletedData.SelectedIndex == 1)
            {
                customerdetail = new CustomerDetailsDTO();
                customerdetail.ID = Convert.ToInt32(dgvFormDeleted.Rows[e.RowIndex].Cells[0].Value);
                customerdetail.CustomerName = dgvFormDeleted.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cmbDeletedData.SelectedIndex == 2)
            {
                productdetail = new ProductDetailsDTO();
                productdetail.ProductID = Convert.ToInt32(dgvFormDeleted.Rows[e.RowIndex].Cells[4].Value);
                productdetail.CategoryID = Convert.ToInt32(dgvFormDeleted.Rows[e.RowIndex].Cells[5].Value);
                productdetail.Price = Convert.ToInt32(dgvFormDeleted.Rows[e.RowIndex].Cells[3].Value);
                productdetail.ProductName = dgvFormDeleted.Rows[e.RowIndex].Cells[0].Value.ToString();
                productdetail.isCategoryDeleted = Convert.ToBoolean(dgvFormDeleted.Rows[e.RowIndex].Cells[6].Value);
            }
            else 
            {
                salesdetail = new SalesDetailsDTO();
                salesdetail.SalesID = Convert.ToInt32(dgvFormDeleted.Rows[e.RowIndex].Cells[9].Value);
                salesdetail.ProductID = Convert.ToInt32(dgvFormDeleted.Rows[e.RowIndex].Cells[4].Value);
                salesdetail.Price = Convert.ToInt32(dgvFormDeleted.Rows[e.RowIndex].Cells[7].Value);
                salesdetail.SalesAmount = Convert.ToInt32(dgvFormDeleted.Rows[e.RowIndex].Cells[6].Value);
                salesdetail.CustomerName = dgvFormDeleted.Rows[e.RowIndex].Cells[0].Value.ToString();
                salesdetail.ProductName = dgvFormDeleted.Rows[e.RowIndex].Cells[1].Value.ToString();
                salesdetail.isCustomerDeleted = Convert.ToBoolean(dgvFormDeleted.Rows[e.RowIndex].Cells[12].Value);
                salesdetail.isCategoryDeleted = Convert.ToBoolean(dgvFormDeleted.Rows[e.RowIndex].Cells[11].Value);
                salesdetail.isProductDeleted = Convert.ToBoolean(dgvFormDeleted.Rows[e.RowIndex].Cells[13].Value);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (cmbDeletedData.SelectedIndex == 0)
            {
                if (CategoryBLL.GetBack(categorydetail))
                {
                    MessageBox.Show("Category data was Restored.");
                    dto = bll.Select(true);
                    dgvFormDeleted.DataSource = dto.Categories;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 1)
            {
                if (CustomerBLL.GetBack(customerdetail))
                {
                    MessageBox.Show("Customer data was Restored.");
                    dto = bll.Select(true);
                    dgvFormDeleted.DataSource = dto.Customers;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 2)
            {
                if (productdetail.isCategoryDeleted)
                {
                    MessageBox.Show("Category was Deleted, Restore first...");
                }
                else if (ProductBLL.GetBack(productdetail))
                {
                    MessageBox.Show("Product data was Restored.");
                    dto = bll.Select(true);
                    dgvFormDeleted.DataSource = dto.Products;
                }
            }
            else
            {
                if (salesdetail.isCategoryDeleted || salesdetail.isProductDeleted || salesdetail.isCustomerDeleted)
                {
                    if (salesdetail.isCategoryDeleted)
                    {
                        MessageBox.Show("Category was Deleted, Restore first...");
                    }
                    else if (salesdetail.isProductDeleted)
                    {
                        MessageBox.Show("Product was Deleted, Restore first...");
                    }
                    else if (salesdetail.isCustomerDeleted)
                    {
                        MessageBox.Show("Customer was Deleted, Restore first...");
                    }
                }
                else if (SalesBLL.GetBack(salesdetail))
                {
                    MessageBox.Show("Sales data was Restored.");
                    dto = bll.Select(true);
                    dgvFormDeleted.DataSource = dto.Sales;
                }
            }
        }
    }
}
