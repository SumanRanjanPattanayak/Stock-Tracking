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
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }

        CustomerBLL bll = new CustomerBLL();
        CustomerDTO dto = new CustomerDTO();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dgvCustomerList.DataSource = dto.customers;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dgvCustomerList.DataSource = dto.customers;
            dgvCustomerList.Columns[0].Visible = false;
            dgvCustomerList.Columns[1].HeaderText = "Customer Name";
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            List<CustomerDetailsDTO> list = dto.customers;
            list = list.Where(x => x.CustomerName.Contains(txtCustomerName.Text)).ToList();
            dgvCustomerList.DataSource = list;
        }
        CustomerDetailsDTO detail = new CustomerDetailsDTO();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
            {
                MessageBox.Show("Please select a customer from the table");
            }
            else
            {
                frmCustomer frm = new frmCustomer();
                frm.detail = detail;
                frm.isUpdate = true;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                bll = new CustomerBLL();
                dto = bll.Select();
                dgvCustomerList.DataSource= dto.customers;
            }
        }

        private void dgvCustomerList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new CustomerDetailsDTO();
            detail.ID = Convert.ToInt32(dgvCustomerList.Rows[e.RowIndex].Cells[0].Value);
            detail.CustomerName = dgvCustomerList.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
            {
                MessageBox.Show("Please select a customer from the Table.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you Sure?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Customer was Deleted");
                        bll = new CustomerBLL();
                        dto = bll.Select();
                        dgvCustomerList.DataSource = dto.customers;
                        txtCustomerName.Clear();
                    }
                }
            }
        }
    }
}
