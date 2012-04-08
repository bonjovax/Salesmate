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
            btnAdd.Enabled = Enabled;
            btnUpdate.Enabled = !Enabled;
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
                MessageBox.Show("Your Item has been Added!", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                LoadAndRefresh();
            }
            catch(Exception)
            {
                MessageBox.Show("Your Item is not Added! or PLU number is already assigned!                     Please Check Your Input and Add again.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}