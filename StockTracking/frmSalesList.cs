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
    public partial class frmSalesList : Form
    {
        public frmSalesList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtSalesAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSales frm = new frmSales();
            frm.dto = dto;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dgvSalesList.DataSource = dto.Sales;
            CleanFilter();
        }
        SalesBLL bll = new SalesBLL();
        SalesDTO dto = new SalesDTO();
        SalesDetailsDTO detail = new SalesDetailsDTO();
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSalesList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dgvSalesList.DataSource = dto.Sales;
            dgvSalesList.Columns[0].HeaderText = "Customer Name";
            dgvSalesList.Columns[1].HeaderText = "Product Name";
            dgvSalesList.Columns[2].HeaderText = "Category Name";
            dgvSalesList.Columns[6].HeaderText = "Sales Amount";
            dgvSalesList.Columns[7].HeaderText = "Price";
            dgvSalesList.Columns[8].HeaderText = "Sales Date";
            dgvSalesList.Columns[3].Visible = false;
            dgvSalesList.Columns[4].Visible = false;
            dgvSalesList.Columns[5].Visible = false;
            dgvSalesList.Columns[9].Visible = false;
            dgvSalesList.Columns[10].Visible = false;
            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<SalesDetailsDTO> list = dto.Sales;
            if (txtProductName.Text.Trim() != "")
            {
                list = list.Where(x => x.ProductName.Contains(txtProductName.Text)).ToList();
            }
            if (txtCustomerName.Text.Trim() != "")
            {
                list = list.Where(x => x.CustomerName.Contains(txtCustomerName.Text)).ToList();
            }
            if (cmbCategory.SelectedIndex != -1)
            {
                list = list.Where(x => x.CategoryID == Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
            }
            if (txtProductPrice.Text.Trim() != "")
            {
                if (rbPriceEqual.Checked)
                {
                    list = list.Where(x => x.Price == Convert.ToInt32(txtProductPrice.Text)).ToList();
                }
                else if (rbPriceMore.Checked)
                {
                    list = list.Where(x => x.Price > Convert.ToInt32(txtProductPrice.Text)).ToList();
                }
                else if (rbPriceLess.Checked)
                {
                    list = list.Where(x => x.Price < Convert.ToInt32(txtProductPrice.Text)).ToList();
                }
                else
                {
                    MessageBox.Show("Please select a criteria from the Price group!!");
                }
            }
            if (txtSalesAmount.Text.Trim() != "")
            {
                if (rbSalesEqual.Checked)
                {
                    list = list.Where(x => x.SalesAmount == Convert.ToInt32(txtSalesAmount.Text)).ToList();
                }
                else if (rbSalesMore.Checked)
                {
                    list = list.Where(x => x.SalesAmount > Convert.ToInt32(txtSalesAmount.Text)).ToList();
                }
                else if (rbSalesless.Checked)
                {
                    list = list.Where(x => x.SalesAmount < Convert.ToInt32(txtSalesAmount.Text)).ToList();
                }
                else
                {
                    MessageBox.Show("Please select a criteria from the Sales Amount group!!");
                }
            }
            if (chDate.Checked)
            {
                list = list.Where(x => x.SalesDate > dtpFrom.Value && x.SalesDate < dtpTo.Value).ToList();
            }
            dgvSalesList.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanFilter();
        }

        private void CleanFilter()
        {
            txtProductPrice.Clear();
            txtSalesAmount.Clear();
            txtCustomerName.Clear();
            txtProductName.Clear();
            rbPriceEqual.Checked = false;
            rbSalesMore.Checked = false;
            rbSalesless.Checked = false;
            rbSalesEqual.Checked = false;
            rbSalesMore.Checked = false;
            rbSalesless.Checked = false;
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
            chDate.Checked = false;
            cmbCategory.SelectedIndex = -1;
            dgvSalesList.DataSource = dto.Sales;
        }

        private void dgvSalesList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new SalesDetailsDTO();
            detail.SalesID = Convert.ToInt32(dgvSalesList.Rows[e.RowIndex].Cells[10].Value);
            detail.ProductID = Convert.ToInt32(dgvSalesList.Rows[e.RowIndex].Cells[4].Value);
            detail.Price = Convert.ToInt32(dgvSalesList.Rows[e.RowIndex].Cells[7].Value);
            detail.SalesAmount = Convert.ToInt32(dgvSalesList.Rows[e.RowIndex].Cells[6].Value);
            detail.CustomerName = dgvSalesList.Rows[e.RowIndex].Cells[0].Value.ToString();
            detail.ProductName = dgvSalesList.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.SalesID == 0)
            {
                MessageBox.Show("Please select a sales data from the table!");
            }
            else
            {
                frmSales frm = new frmSales();
                frm.isUpdate = true;
                frm.detail = detail;
                frm.dto = dto;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                bll = new SalesBLL();
                dto = bll.Select();
                dgvSalesList.DataSource = dto.Sales;
                CleanFilter();
            }
        }
    }
}
