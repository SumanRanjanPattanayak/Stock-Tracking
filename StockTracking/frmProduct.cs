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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
        public ProductDTO dto = new ProductDTO();
        public ProductDetailsDTO detail = new ProductDetailsDTO();
        public bool isUpdate = false;
        private void frmProduct_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = dto.categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;
            if (isUpdate)
            {
                txtProductName.Text = detail.ProductName;
                txtPrice.Text = detail.Price.ToString();
                cmbCategory.SelectedValue = detail.CategoryID;
            }
        }

        ProductBLL bll = new ProductBLL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == "")
            {
                MessageBox.Show("Product Name was empty!");
            }
            else if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category!");
            }
            else if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("Price field is empty!");
            }
            else
            {
                if (!isUpdate)
                {
                    ProductDetailsDTO product = new ProductDetailsDTO();
                    product.ProductName = txtProductName.Text;
                    product.CategoryID = Convert.ToInt32(cmbCategory.SelectedValue);
                    product.Price = Convert.ToInt32(txtPrice.Text);
                    if (bll.Insert(product))
                    {
                        MessageBox.Show("Product was Added.");
                        txtPrice.Clear();
                        txtProductName.Clear();
                        cmbCategory.SelectedIndex = -1;
                    }
                }
                else
                {
                    if (detail.ProductName == txtProductName.Text && detail.CategoryID == Convert.ToInt32(cmbCategory.SelectedValue) && detail.Price == Convert.ToInt32(txtPrice.Text))
                    {
                        MessageBox.Show("No changes!");
                    }
                    else
                    {
                        detail.ProductName = txtProductName.Text;
                        detail.CategoryID = Convert.ToInt32(cmbCategory.SelectedValue);
                        detail.Price = Convert.ToInt32(txtPrice.Text);
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Product was updated");
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
