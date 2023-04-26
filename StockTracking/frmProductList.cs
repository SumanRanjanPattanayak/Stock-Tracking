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
    public partial class frmProductList : Form
    {
        public frmProductList()
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

        private void txtProductStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.dto = dto;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dgvProductList.DataSource = dto.products;
            CleanFilters();
        }

        ProductBLL bll = new ProductBLL();
        ProductDTO dto = new ProductDTO();

        private void frmProductList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbCategory.DataSource = dto.categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;
            dgvProductList.DataSource = dto.products;
            dgvProductList.Columns[0].HeaderText = "Product Name";
            dgvProductList.Columns[1].HeaderText = "Category Name";
            dgvProductList.Columns[2].HeaderText = "Stock Name";
            dgvProductList.Columns[3].HeaderText = "Price";
            dgvProductList.Columns[4].Visible = false;
            dgvProductList.Columns[5].Visible = false;
            dgvProductList.Columns[6].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ProductDetailsDTO> list = dto.products;
            if (txtProductName.Text.Trim() != null)
            {
                list = list.Where(x => x.ProductName.Contains(txtProductName.Text)).ToList();
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
            if (txtProductStock.Text.Trim() != "")
            {
                if (rbStockEqual.Checked)
                {
                    list = list.Where(x => x.StockAmount == Convert.ToInt32(txtProductStock.Text)).ToList();
                }
                else if (rbStockMore.Checked)
                {
                    list = list.Where(x => x.StockAmount > Convert.ToInt32(txtProductStock.Text)).ToList();
                }
                else if (rbPriceLess.Checked)
                {
                    list = list.Where(x => x.StockAmount < Convert.ToInt32(txtProductStock.Text)).ToList();
                }
                else
                {
                    MessageBox.Show("Please select a criteria from the Stock group!!");
                }
            }
            dgvProductList.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanFilters();
        }

        private void CleanFilters()
        {
            txtProductPrice.Clear();
            txtProductStock.Clear();
            txtProductName.Clear();
            cmbCategory.SelectedIndex = -1;
            rbPriceEqual.Checked = false;
            rbPriceMore.Checked = false;
            rbPriceLess.Checked = false;
            rbStockEqual.Checked = false;
            rbStockless.Checked = false;
            rbStockMore.Checked = false;
            dgvProductList.DataSource = dto.products;
        }
        ProductDetailsDTO detail = new ProductDetailsDTO();
        private void dgvProductList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new ProductDetailsDTO();
            detail.ProductID = Convert.ToInt32(dgvProductList.Rows[e.RowIndex].Cells[4].Value);
            detail.CategoryID = Convert.ToInt32(dgvProductList.Rows[e.RowIndex].Cells[5].Value);
            detail.Price = Convert.ToInt32(dgvProductList.Rows[e.RowIndex].Cells[3].Value);
            detail.ProductName = dgvProductList.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.ProductID == 0)
            {
                MessageBox.Show("Please select a product from the table");
            }
            else
            {
                frmProduct frm = new frmProduct();
                frm.detail = detail;
                frm.isUpdate = true;
                frm.dto = dto;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                bll = new ProductBLL();
                dto = bll.Select();
                dgvProductList.DataSource = dto.products;
                CleanFilters();
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.ProductID == 0)
            {
                MessageBox.Show("Please select a product from Table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you Sure?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Product was Deleted.");
                        bll = new ProductBLL();
                        dto = bll.Select();
                        dgvProductList.DataSource = dto.products;
                        cmbCategory.DataSource = dto.categories;
                        CleanFilters() ;
                    }
                }
            }
        }
    }
}
