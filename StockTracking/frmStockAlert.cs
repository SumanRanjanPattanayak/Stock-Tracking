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
    public partial class frmStockAlert : Form
    {
        public frmStockAlert()
        {
            InitializeComponent();
        }

        ProductBLL bll = new ProductBLL();
        ProductDTO dto = new ProductDTO();

        private void btnOk_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void frmStockAlert_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dto.products = dto.products.Where(x=>x.StockAmount == 10).ToList();
            dgvStockAlert.DataSource = dto.products;
            dgvStockAlert.Columns[0].HeaderText = "Product Name";
            dgvStockAlert.Columns[1].HeaderText = "Category Name";
            dgvStockAlert.Columns[2].HeaderText = "Stock Name";
            dgvStockAlert.Columns[3].HeaderText = "Price";
            dgvStockAlert.Columns[4].Visible = false;
            dgvStockAlert.Columns[5].Visible = false;
            if (dto.products.Count == 0)
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
            }
        }
    }
}
