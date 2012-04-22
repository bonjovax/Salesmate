using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesMate
{
    public partial class frmAccountP : Form
    {
        static String conString = "server=localhost;User Id=root;password=root;database=salesmate";
        MySqlConnection con = new MySqlConnection();

        User u;
       
        public frmAccountP()
        {
            InitializeComponent();
            u = frmLogin.User;
        }

        public void clearTextBox()
        {
            txtBoxFName.Text = "";
            btnPurgeAccount.Enabled = !Enabled;
            txtBoxMName.Text = "";
            txtBoxLName.Text = "";
            txtBoxUser.Text = "";
            txtBoxPassword.Text = "";
            cBoxIsAdmin.Text = "";
            txtUpdateCashierID.Text = "";
            txtUpdateCashierUser.Text = "";
            txtUpdatePass.Text = "";
            txtUpdateFName.Text = "";
            txtUpdateMName.Text = "";
            txtUpdateLName.Text = "";
            cBoxUpdateIsAdmin.Text = "";
        }

        public void refreshData()
        {
            try
            {
                lviewAccount.Items.Clear();
                con.ConnectionString = conString;
                con.Open();
                String query = "SELECT cashierid, cashieruser, isadmin, cashierfname, cashiermname, cashierlname, datejoined FROM cashieraccount";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr["cashierid"].ToString());
                    item.SubItems.Add(rdr["cashieruser"].ToString());
                    item.SubItems.Add(rdr["isadmin"].ToString());
                    item.SubItems.Add(rdr["cashierfname"].ToString());
                    item.SubItems.Add(rdr["cashiermname"].ToString());
                    item.SubItems.Add(rdr["cashierlname"].ToString());
                    item.SubItems.Add(rdr["datejoined"].ToString());
                    lviewAccount.Items.Add(item);
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Your Database was NOT Successfully Establish", "SalesMate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadData()
        {
            try
            {
                enableButtons();
                lviewAccount.Items.Clear();
                con.ConnectionString = conString;
                con.Open();
                String query = "SELECT cashierid, cashieruser, isadmin, cashierfname, cashiermname, cashierlname, datejoined FROM cashieraccount";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr["cashierid"].ToString());
                    item.SubItems.Add(rdr["cashieruser"].ToString());
                    item.SubItems.Add(rdr["isadmin"].ToString());
                    item.SubItems.Add(rdr["cashierfname"].ToString());
                    item.SubItems.Add(rdr["cashiermname"].ToString());
                    item.SubItems.Add(rdr["cashierlname"].ToString());
                    item.SubItems.Add(rdr["datejoined"].ToString());
                    lviewAccount.Items.Add(item);
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Your Database was NOT Successfully Establish", "SalesMate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void enableButtons()
        {
            grpCreateAccount.Visible = false;
            grpUpdate.Visible = false;
            btnCreateAccount.Enabled = Enabled;
            btnUpdateAccount.Enabled = Enabled;
            btnPurgeAccount.Enabled = !Enabled;
        }

        private void frmAccountP_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUpdateCashierUser.Text != "" && txtUpdateFName.Text != "" && txtUpdateMName.Text != "" && txtUpdateLName.Text != "" && txtUpdatePass.Text != "")
            {
                try
                {
                    u.updateAccount(Int32.Parse(txtUpdateCashierID.Text), txtUpdateCashierUser.Text, cBoxUpdateIsAdmin.Text, txtUpdateFName.Text, txtUpdateMName.Text, txtUpdateLName.Text, txtUpdatePass.Text);
                    refreshData();
                    MessageBox.Show("You Account has been Updated", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTextBox();
                }
                catch (Exception)
                {
                    MessageBox.Show("Your Account has not been Updated!", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  
                }
            }
            else
                MessageBox.Show("You have not Completely Update your details!", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            btnUpdateAccount.Enabled = !Enabled;
            btnCreateAccount.Enabled = !Enabled;
            btnPurgeAccount.Enabled = !Enabled;
            grpUpdate.Visible = true;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            btnCreateAccount.Enabled = !Enabled;
            btnUpdateAccount.Enabled = !Enabled;
            btnPurgeAccount.Enabled = !Enabled;
            grpCreateAccount.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void btnCloseUpdate_Click(object sender, EventArgs e)
        {
            grpUpdate.Visible = !true;
            btnCreateAccount.Enabled = Enabled;
            btnUpdateAccount.Enabled = Enabled;
            btnPurgeAccount.Enabled = !Enabled;
        }

        private void btnPurgeAccount_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do you want Purge " + txtUpdateFName.Text + " " + txtUpdateLName.Text + "?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            try
            {
                if (dlgResult == DialogResult.Yes)
                {
                    u.purgeAccount(Int32.Parse(txtUpdateCashierID.Text));
                    refreshData();
                    MessageBox.Show("This Account has been Purged", "Purge Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTextBox();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("This Account has not been Purged", "Purge Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lviewAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviewAccount.SelectedItems.Count > 0)
            {
                btnPurgeAccount.Enabled = Enabled;
                ListViewItem item = lviewAccount.SelectedItems[0];
                txtUpdateCashierID.Text = item.Text;
                txtUpdateCashierUser.Text = item.SubItems[1].Text;
                cBoxUpdateIsAdmin.Text = item.SubItems[2].Text;
                txtUpdateFName.Text = item.SubItems[3].Text;
                txtUpdateMName.Text = item.SubItems[4].Text;
                txtUpdateLName.Text = item.SubItems[5].Text;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grpCreateAccount.Visible = !true;
            btnCreateAccount.Enabled = Enabled;
            btnUpdateAccount.Enabled = Enabled;
            btnPurgeAccount.Enabled = !Enabled;
            clearTextBox();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtBoxFName.Text != "" && txtBoxMName.Text != "" && txtBoxLName.Text != "" && txtBoxUser.Text != "" && txtBoxPassword.Text != "" && cBoxIsAdmin.Text != "")
            {
                try
                {
                    u.createAccount(txtBoxFName.Text, txtBoxMName.Text, txtBoxLName.Text, txtBoxUser.Text, txtBoxPassword.Text, cBoxIsAdmin.Text);
                    MessageBox.Show("You have Sucessfully Created Account", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshData();
                    clearTextBox();
                }
                catch (Exception)
                {
                    MessageBox.Show("Your Account was not Successfully Added!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clearTextBox();
                }
            }
            else
                MessageBox.Show("You have not Completed your details!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frmAccountP_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
