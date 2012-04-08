using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesMate
{
    public partial class frmNoSale : Form
    {
        public frmNoSale()
        {
            InitializeComponent();
        }

        private void btnNSProceed_Click(object sender, EventArgs e)
        {
            txtBoxReason.Text = "";
            this.Close();
        }
    }
}
