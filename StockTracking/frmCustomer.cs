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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        CustomerBLL bll = new CustomerBLL();
        public CustomerDetailsDTO detail = new CustomerDetailsDTO();
        public bool isUpdate = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Trim() == "")
            {
                MessageBox.Show("Customer Name was empty!");
            }
            else
            {
                if (!isUpdate)
                {
                    CustomerDetailsDTO customer = new CustomerDetailsDTO();
                    customer.CustomerName = txtCustomerName.Text;
                    if (bll.Insert(customer))
                    {
                        MessageBox.Show("Customer was Added.");
                        txtCustomerName.Clear();
                    }
                }
                else
                {
                    if (detail.CustomerName == txtCustomerName.Text)
                    {
                        MessageBox.Show("There is no change!");
                    }
                    else
                    {
                        detail.CustomerName = txtCustomerName.Text;
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Customer was Updated.");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtCustomerName.Text = detail.CustomerName;
            }
        }
    }
}
