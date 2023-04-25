﻿using System;
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
    public partial class frmDeleted : Form
    {
        public frmDeleted()
        {
            InitializeComponent();
        }

        private void frmDeleted_Load(object sender, EventArgs e)
        {
            cmbDeletedData.Items.Add("Category");
            cmbDeletedData.Items.Add("Product");
            cmbDeletedData.Items.Add("Customer");
            cmbDeletedData.Items.Add("Sales");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
