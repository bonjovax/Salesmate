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
    public partial class frmPriceLookUp : Form
    {
        static String conString = "server=localhost;User Id=root;password=root;database=salesmate";
        MySqlConnection con = new MySqlConnection();

        public frmPriceLookUp()
        {
            InitializeComponent();
        }

        public void clearTextBoxes()
        {
            txtLookPLU.Text = "";
            txtLookItemDes.Text = "";
            txtLookPrice.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            this.Close();
        }

        private void txtLookPLU_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = conString;
                con.Open();
                String query = "SELECT * FROM cashieritem WHERE plu=" + txtLookPLU.Text + "";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                txtLookItemDes.Text = rdr["description"].ToString();
                txtLookPrice.Text = rdr["price"].ToString();
                con.Close();
            }
            catch (Exception)
            {
                txtLookItemDes.Text = "Not Found";
                txtLookPrice.Text = "0.00";
                con.Close();
            }
        }

        private void frmPriceLookUp_Load(object sender, EventArgs e)
        {
            clearTextBoxes();
        }
    }
}
