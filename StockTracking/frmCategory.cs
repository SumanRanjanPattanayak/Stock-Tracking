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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        CategoryBLL bll = new CategoryBLL();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() == "")
            {
                MessageBox.Show("Category Name was empty!");
            }
            else 
            {
                if (!isUpdate)
                {
                    CategoryDetailsDTO category = new CategoryDetailsDTO();
                    category.CategoryName = txtCategoryName.Text;
                    if (bll.Insert(category))
                    {
                        MessageBox.Show("Category was Added.");
                        txtCategoryName.Clear();
                    }
                    else if (isUpdate)
                    {
                        if (detail.CategoryName == txtCategoryName.Text.Trim())
                        {
                            MessageBox.Show("No changes done!");
                        }
                        detail.CategoryName = txtCategoryName.Text;
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Category was Updated.");
                            this.Close();
                        }
                    }
                }
            }
        }
        public CategoryDetailsDTO detail = new CategoryDetailsDTO();
        public bool isUpdate = false;
        private void frmCategory_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtCategoryName.Text = detail.CategoryName;
            }
        }
    }
}
