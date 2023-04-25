using StockTracking.BLL;
using StockTracking.DAL.DAO;
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
    public partial class frmAddStock : Form
    {
        public frmAddStock()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ProductBLL bll = new ProductBLL();
        ProductDTO dto = new ProductDTO();

        private void frmAddStock_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dgvAddStock.DataSource = dto.products;
            dgvAddStock.Columns[0].HeaderText = "Product Name";
            dgvAddStock.Columns[1].HeaderText = "Category Name";
            dgvAddStock.Columns[2].HeaderText = "Stock Name";
            dgvAddStock.Columns[3].HeaderText = "Price";
            dgvAddStock.Columns[4].Visible = false;
            dgvAddStock.Columns[5].Visible = false;
            cmbCategory.DataSource = dto.categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;
            if (dto.categories.Count > 0)
            {
                combofull = true;
            }
        }
        bool combofull = false;

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                List<ProductDetailsDTO> list = dto.products;
                list = list.Where(x=>x.CategoryID == Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
                dgvAddStock.DataSource = list;
                if (list.Count == 0)
                {
                    txtProductPrice.Clear();
                    txtProductName.Clear();
                    txtProductStock.Clear();
                }
            }
        }
        ProductDetailsDTO detail = new ProductDetailsDTO();

        private void dgvAddStock_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ProductName = dgvAddStock.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProductName.Text = detail.ProductName;
            detail.Price = Convert.ToInt32(dgvAddStock.Rows[e.RowIndex].Cells[3].Value);
            txtProductPrice.Text = detail.Price.ToString();
            detail.StockAmount = Convert.ToInt32(dgvAddStock.Rows[e.RowIndex].Cells[2].Value);
            detail.ProductID = Convert.ToInt32(dgvAddStock.Rows[e.RowIndex].Cells[4].Value);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == "")
            {
                MessageBox.Show("Please select a Product from the table.");
            }
            else if (txtProductStock.Text.Trim() == "")
            {
                MessageBox.Show("Please give a stock amount.");
            }
            else 
            {
                int sumstock = detail.StockAmount;
                sumstock += Convert.ToInt32(txtProductStock.Text);
                detail.StockAmount = sumstock;
                if (bll.Update(detail))
                {
                    MessageBox.Show("Stock was added");
                    bll = new ProductBLL();
                    dto = bll.Select();
                    dgvAddStock.DataSource = dto.products;
                    txtProductStock.Clear();
                }
            }
        }
    }
}
