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
    public partial class frmIcos : Form
    {
        Items it = new Items();
        static String conString = "server=localhost;User Id=root;password=root;database=salesmate";
        MySqlConnection con = new MySqlConnection();
     
        public frmIcos()
        {
            InitializeComponent();
        }

        public void LoadAndRefresh()
        {
            try
            {
                lviewIcost.BeginUpdate();
                lviewIcost.Items.Clear();
                con.ConnectionString = conString;
                con.Open();
                String query = "SELECT * FROM cashieritem";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr["plu"].ToString());
                    item.SubItems.Add(rdr["description"].ToString());
                    item.SubItems.Add(rdr["price"].ToString());
                    lviewIcost.Items.Add(item);
                }
                lviewIcost.EndUpdate();
                lviewIcost.Refresh();
                con.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void reset()
        {
            txtPLU.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtPLU.Enabled = Enabled;
            btnAdd.Enabled = Enabled;
            btnUpdate.Enabled = !Enabled;
            btnDelete.Enabled = !Enabled;
        }

        public void updateItem()
        {
            btnUpdate.Enabled = Enabled;
            btnAdd.Enabled = !Enabled;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            updateItem();
        }

        private void frmIcos_Load(object sender, EventArgs e)
        {
            reset();
            LoadAndRefresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                it.addItem(int.Parse(txtPLU.Text), txtDescription.Text, float.Parse(txtPrice.Text));
                reset();
                LoadAndRefresh();
                MessageBox.Show("Your Item has been Added!", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Your Item is not Added! or PLU number is already assigned!                     Please Check Your Input and Add again.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lviewIcost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviewIcost.SelectedItems.Count > 0)
            {
                txtPLU.Enabled = !Enabled; //Disables Textbox PLU
                btnAdd.Enabled = !Enabled; //Disables Add Button
                btnUpdate.Enabled = Enabled; // Enables Update Button
                btnDelete.Enabled = Enabled; // Enables Delete Button
                ListViewItem item = lviewIcost.SelectedItems[0];
                txtPLU.Text = item.Text;
                txtDescription.Text = item.SubItems[1].Text;
                txtPrice.Text = item.SubItems[2].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                it.updateItem(int.Parse(txtPLU.Text),txtDescription.Text, float.Parse(txtPrice.Text));
                reset();
                LoadAndRefresh();
                MessageBox.Show("Your Item has been Updated!", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Your Item is not Updated! or PLU number is already assigned!                     Please Check Your Input and Add again.", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do you want to Delete " + txtDescription.Text + "?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            try
            {
                if (dlgResult == DialogResult.Yes)
                {
                    it.deleteItem(int.Parse(txtPLU.Text));
                    reset();
                    LoadAndRefresh();
                    MessageBox.Show("Your Item has been Deleted!", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                 MessageBox.Show("Your Item is not Deleted!", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmIcos_Click(object sender, EventArgs e)
        {
            reset();
            txtPLU.Focus();
        }
    }
}