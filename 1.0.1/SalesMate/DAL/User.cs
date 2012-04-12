using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SalesMate
{
    public class User
    {
        private Int32 cashierid;
        private String cashieruser;
        private String cashierpass;
        private String isadmin;
        private String cashierfname;
        private String cashiermname;
        private String cashierlname;
        
        static String conString = "server=localhost;User Id=root;password=root;database=salesmate";
        MySqlConnection con = new MySqlConnection();
        frmMain fm = new frmMain();

        public User(String cashieruser)
        {
            this.cashieruser = cashieruser;
        }

        public User(String cashierlname, String cashierfname, String cashiermname, Int32 cashierid, String cashieruser, String cashierpass, String isadmin)
        {
            this.cashierlname = cashierlname;
            this.cashierfname = cashierfname;
            this.cashiermname = cashiermname;
            this.cashierid = cashierid;
            this.cashieruser = cashieruser;
            this.cashierpass = cashierpass;
            this.isadmin = isadmin;
        }

        public User(String cashierlname, String cashierfname, String cashiermname)
        {
            this.cashierlname = cashierlname;
            this.cashierfname = cashierfname;
            this.cashiermname = cashiermname;
        }

        public String Cashieruser
        {
            get
            {
                return cashieruser;
            }
            set
            {
                cashieruser = value;
            }
        }

        public String Cashierpass{
            get{
                return cashierpass;
            }
            set
            {
                cashierpass = value;
            }
        }

        public String Cashierfname
        {
            get
            {
                return cashierfname;
            }
            set
            {
                cashierfname = value;
            }
        }

        public String Cashierlname
        {
            get
            {
                return cashierlname;
            }
            set
            {
                cashierlname = value;
            }
        }
        //isAuthenticated
        public bool isAuth(String cashieruser, String cashierpass)
        {
            /* 1' or 'ab'='a' 'b (type in your username and password)
             * Security Issue occured at April 12, 2012 */
            cashieruser = cashieruser.Replace("''", ""); //Suggested by: Sir Russel Beceril
            cashierpass = cashierpass.Replace("''","");  //Suggested by: Sir Russel Beceril
            bool IsAuth = false;
            con.ConnectionString = conString;
            String sql = "SELECT * FROM cashieraccount WHERE cashieruser='" + cashieruser + "' AND cashierpass='" + cashierpass + "'";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    IsAuth = true;
                }
                else
                    IsAuth = false;
            }
            finally
            {
                con.Close();
            }
            return IsAuth;
        }
        //Retrieves the Cashier from From the Database
        public String getCashierIDfromDB()
        {
            con.ConnectionString = conString;
            String sql = "SELECT cashierid from cashieraccount WHERE cashieruser = '" + cashieruser + "'";
            String CashierID = "";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    CashierID = rdr["cashierid"].ToString();
                }
            }
            finally
            {
                con.Close();
            }
            return CashierID;
        }
        //Checks the User Account if Admin
        public bool isAdmin()
        {
            bool isNotAdmin = true;
            String cID = getCashierIDfromDB();
            con.ConnectionString = conString;
            String sql = "SELECT isadmin FROM cashieraccount WHERE cashierid = '" + cID + "';";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr["isadmin"].ToString() == "Yes")
                        isNotAdmin = false;
                }
            }
            finally
            {
                con.Close();
            }
            return isNotAdmin;
        }

        public void createAccount(String cashierfname, String cashiermname, String cashierlname, String cashieruser, String cashierpass, String isadmin)
        { 
            con.ConnectionString = conString;
            String sql = "INSERT INTO cashieraccount(cashieruser, cashierpass, isadmin, cashierfname, cashiermname, cashierlname, datejoined) VALUES";
            sql += "('" + cashieruser + "', '" + cashierpass + "', '" + isadmin + "','" + cashierfname + "','" + cashiermname + "', '" + cashierlname + "', '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "')";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            
            finally
            {
                con.Close();
            }
        }

        public void updateAccount(Int32 cashierid, string cashieruser, string isadmin, string cashierfname, string cashiermname, string cashierlname, string cashierpass)
        {
            con.ConnectionString = conString;
            String sql = "UPDATE cashieraccount SET cashieruser='" + cashieruser + "', cashierpass='" + cashierpass + "', isadmin='" + isadmin +"', cashierfname='" + cashierfname + "', cashiermname='" + cashiermname +"', cashierlname='" + cashierlname +"'";
            sql += "WHERE cashierid=" + cashierid + "";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose(); //optional
            }
            finally
            {
                con.Close();
            }
        }

        public void purgeAccount(Int32 cashierid)
        {
            con.ConnectionString = conString;
            String sql = "DELETE FROM cashieraccount WHERE cashierid=" + cashierid +"";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose(); //optional
            }
            finally
            {
                con.Close();
            }
        }
    }
}
