using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace SalesMate
{
    class Items
    {
        private Int32 plu;
        private String description;
        private float price;
        static String conString = "server=localhost;User Id=root;password=root;database=salesmate";
        MySqlConnection con = new MySqlConnection();

        public Items()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public Items(Int32 plu)
        {
            this.plu = plu;
        }

        public Items(Int32 plu, string description)
        {
            this.plu = plu;
            this.description = description;
        }

        public Items(Int32 plu, string description, float price)
        {
            this.plu = plu;
            this.description = description;
            this.price = price;
        }

        public int Plu
        {
            get
            {
                return plu;
            }
            set
            {
                plu = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public void addItem(Int32 plu, string description, float price)
        {
            con.ConnectionString = conString;
            String sql = "INSERT INTO cashieritem (plu, description, price) VALUES";
            sql += "(" + plu + ", '" + description + "', " + price + ")";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose(); //Optional
            }
            finally
            {
                con.Close();
            }
        }

        public void updateItem(Int32 plu, string description, float price)
        {
            con.ConnectionString = conString;
            String sql = "UPDATE cashieritem SET description='" + description + "', price=" + price + "";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose(); //Optional
            }
            finally
            {
                con.Close();
            }
        }

        public void deleteItem(Int32 plu)
        {
            con.ConnectionString = conString;
            String sql = "DELETE FROM cashieritem WHERE plu=" + plu + ";";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose(); //Optional
            }
            finally
            {
                con.Close();
            }
        }
    }
}