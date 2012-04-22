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
    public partial class frmMain : Form
    {
        private bool enable = true;
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        MessageBoxIcon icon = MessageBoxIcon.Exclamation;
        DialogResult result;
        private const String testtxt = "UserName";
        //This Syntax is Exclusive for Replublic Act No. 9257
        private const String ra9257 = "You are now attempt to Grant BENEFITS AND PRIVILEGES TO SENIOR CITIZENS. Would you like to Transact?";
        private const String caption = "Republic Act No. 9257";
        //////////////////////////////////////////////////////////////////////////////////////
        //This Syntax is Exclusive for 5% Discount
        private const String fivep = "Your are now attempt to transact 5% Discount.                    Administrator Account is Required! Do you want to continue?";
        private const String caption1 = "5% Discount";
        //////////////////////////////////////////////////////////////////////////////////////
        //This Syntax is Exclusive for 10% Discount
        private const String tenp = "Your are now attempt to transact 10% Discount.                    Administrator Account is Required! Do you want to continue?";
        private const String caption2 = "10% Discount";
        //////////////////////////////////////////////////////////////////////////////////////
        
        frmLogin fl = new frmLogin();
        frmTender ften = new frmTender();
        frmIcos ficos = new frmIcos();
        frmTwentyP ftp = new frmTwentyP();
        frmAuthP fap = new frmAuthP();
        frmNoSale fns = new frmNoSale();
        frmCheck fc = new frmCheck();
        frmAccountP facp = new frmAccountP();
        frmPriceLookUp fplu = new frmPriceLookUp();

        public void enableControls()
        {
            btnSubTotal.Enabled = !enable;
            btnNoSale.Enabled = !enable;
            btnVoid.Enabled = !enable;
            txtBoxPLU.Enabled = !enable;
            txtBoxQty.Enabled = !enable;
            btnCash.Enabled = enable;
            btnCheck.Enabled = enable;
            btnRefund.Enabled = enable;
            btnFive.Enabled = enable;
            btnTen.Enabled = enable;
            btnTwenty.Enabled = enable;
        }

        public void isnotAdmin()
        {
            adminToolStripMenuItem.Enabled = !enable;
        }
        public void fivepercentSelected()
        {
            btnFive.Enabled = !enable;
            btnTen.Hide();
            btnTwenty.Hide();
        }

        public void tenpercentSelected()
        {
            btnFive.Hide();
            btnTen.Enabled = !enable;
            btnTwenty.Hide();
        }

        public void twentypercentSelected()
        {
            btnFive.Hide();
            btnTen.Hide();
            btnTwenty.Enabled = !enable;
        }

        public void controlsNextTransaction()
        {
            btnSubTotal.Enabled = enable;
            btnNoSale.Enabled = enable;
            btnVoid.Enabled = enable;
            txtBoxPLU.Enabled = enable;
            btnCash.Enabled = !enable;
            btnCheck.Enabled = !enable;
            btnRefund.Enabled = !enable;
            btnFive.Enabled = !enable;
            btnTen.Enabled = !enable;
            btnTwenty.Enabled = !enable;
        }
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            ften.ShowDialog();
        }

        private void btnSubTotal_Click(object sender, EventArgs e)
        {
            enableControls();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ficos.ShowDialog();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show(fivep, caption1, buttons, icon);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                fap.ShowDialog();
                fivepercentSelected();
            }
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show(tenp, caption2, buttons, icon);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                fap.ShowDialog();
                tenpercentSelected();
            }
        }

        private void btnTwenty_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show(ra9257, caption, buttons,icon);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                ftp.ShowDialog();
                twentypercentSelected();
            }
        }

        private void btnNoSale_Click(object sender, EventArgs e)
        {
            fns.ShowDialog();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            fc.ShowDialog();
        }

        private void accountPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facp.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            String userName = frmLogin.User.Cashieruser;
            this.Text = "AC/DC COMPONENT PART SALES & SERVICE CENTER (SalesMate v1.0) | " + userName;
            statusDate.Text = DateTime.Now.Date.ToLongDateString();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fl.Show();
        }

        private void txtBoxPLU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxQty.Focus();
            }
        }

        private void btnPriceLookUp_Click(object sender, EventArgs e)
        {
            fplu.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}