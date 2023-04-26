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
    public partial class frmCategoryList : Form
    {
        public frmCategoryList()
        {
            InitializeComponent();
        }

        CategoryDTO dto = new CategoryDTO();
        CategoryBLL bll = new CategoryBLL();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dgvCategoryList.DataSource = dto.categories;
        }

        private void frmCategoryList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dgvCategoryList.DataSource = dto.categories;
            dgvCategoryList.Columns[0].Visible = false;
            dgvCategoryList.Columns[1].HeaderText = "Category Name";
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            List<CategoryDetailsDTO> list = dto.categories;
            list = list.Where(x => x.CategoryName.Contains(txtCategoryName.Text)).ToList();
            dgvCategoryList.DataSource = list;
        }
        CategoryDetailsDTO detail = new CategoryDetailsDTO();
        private void dgvCategoryList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new CategoryDetailsDTO();
            detail.ID = Convert.ToInt32(dgvCategoryList.Rows[e.RowIndex].Cells[0].Value);
            detail.CategoryName = dgvCategoryList.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
            {
                MessageBox.Show("Please select a category from the table");
            }
            else
            {
                frmCategory frm = new frmCategory();
                frm.detail = detail;
                frm.isUpdate = true;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                bll = new CategoryBLL();
                dto = bll.Select();
                dgvCategoryList.DataSource = dto.categories;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
            {
                MessageBox.Show("Please selecta a category from the Table!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you Sure?", "Warning!!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Category was Deleted");
                        bll = new CategoryBLL();
                        dto = bll.Select();
                        dgvCategoryList.DataSource = dto.categories;
                        txtCategoryName.Clear();
                    }
                }
            }
        }
    }
}
