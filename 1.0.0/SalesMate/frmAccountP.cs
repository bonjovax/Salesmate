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
        User u = new User();
       
        public frmAccountP()
        {
            InitializeComponent();
        }

        public void clearTextBox()
        {
            txtBoxFName.Text = "";
            txtBoxMName.Text = "";
            txtBoxLName.Text = "";
            txtBoxUser.Text = "";
            txtBoxPassword.Text = "";
            cBoxIsAdmin.Text = "";
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
            btnPurgeAccount.Enabled = Enabled;
        }

        private void frmAccountP_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clearTextBox();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grpCreateAccount.Visible = !true;
            btnCreateAccount.Enabled = Enabled;
            btnUpdateAccount.Enabled = Enabled;
            btnPurgeAccount.Enabled = Enabled;
            clearTextBox();
        }

        private void btnCloseUpdate_Click(object sender, EventArgs e)
        {
            grpUpdate.Visible = !true;
            btnCreateAccount.Enabled = Enabled;
            btnUpdateAccount.Enabled = Enabled;
            btnPurgeAccount.Enabled = Enabled;
        }

        private void btnPurgeAccount_Click(object sender, EventArgs e)
        {
        }
    }
}
