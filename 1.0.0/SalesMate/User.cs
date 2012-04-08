using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SalesMate
{
    class User
    {
        private int cashierid;
        private String cashieruser;
        private String cashierpass;
        private String isadmin;
        private String cashierfname;
        private String cashiermname;
        private String cashierlname;
        
        static String conString = "server=localhost;User Id=root;password=root;database=salesmate";
        MySqlConnection con = new MySqlConnection();
        public User()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public User(String cashieruser)
        {
            this.cashieruser = cashieruser;
        }

        public User(String cashierlname, String cashierfname, String cashiermname, int cashierid, String cashieruser, String cashierpass, String isadmin)
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
        //isAuthenticated
        public bool isAuth(String cashieruser, String cashierpass)
        {
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

        public String getUserNamefromDB(string cashieruser)
        {
            con.ConnectionString = conString;
            String sql = "SELECT cashieruser FROM cashieraccount WHERE cashieruser='" + cashieruser + "';";
            //String cashieruser = "";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql,con);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    cashieruser = rdr["cashieruser"].ToString();
                }
            }

            finally
            {
                con.Close();
            }

            return cashieruser;
        }

        public String getCashierIDfromDB()
        {
            con.ConnectionString = conString;
            String sql = "SELECT cashierid FROM cashieraccount WHERE cashieruser='" + cashieruser + "';";
            String cashierid = "";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    cashierid = rdr["cashierid"].ToString();
                }
            }
            finally
            {
                con.Close();
            }

            return cashierid;
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
        public string isAdmin()
        {
            
            con.ConnectionString = conString;
            bool IsAdmin = false;
            String cID = getCashierIDfromDB();

            String sql = "SELECT isadmin FROM cashieraccount WHERE cashierid='" + cID + "';";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr["isadmin"].ToString() == "yes")
                    {
                        IsAdmin = true;
                    }
                }
            }

            finally
            {
                con.Close();
            }
            return cID;// IsAdmin;
        }

        //public bool isAdministrator()
        //{
        //    bool isAdmin = false;
        //    OleDbConnection con = new OleDbConnection();
        //    con.ConnectionString = conString;
        //    String sql = "SELECT isadmin FROM cashieraccount WHERE islog='" + true + "';";
        //    try
        //    {
        //        con.Open();
        //        OleDbCommand cmd = new OleDbCommand(sql, con);
        //        cmd.CommandType = CommandType.Text;
        //        OleDbDataReader rdr = cmd.ExecuteReader();
        //        if (rdr.Read())
        //        {
        //            if (rdr["isadmin"].ToString() == "yes")
        //            {
        //                isAdmin = true;
        //            }
        //        }
        //    }

        //    finally
        //    {
        //        con.Close();
        //    }
        //    return isAdmin;
        //}

        //public int whoLogged()
        //{
        //    OleDbConnection con = new OleDbConnection();
        //    con.ConnectionString = conString;
        //    String sql = "SELECT cashierid FROM cashieraccount WHERE islog='" + true + "';";
        //    int cashierid = 0;

        //    try
        //    {
        //        con.Open();
        //        OleDbCommand cmd = new OleDbCommand(sql, con);
        //        cmd.CommandType = CommandType.Text;
        //        OleDbDataReader rdr = cmd.ExecuteReader();
        //        if (rdr.Read())
        //        {
        //            cashierid = Convert.ToInt32(rdr["cashierid"].ToString());
        //        }
        //    }

        //    finally
        //    {
        //        con.Close();
        //    }
        //    return cashierid;
        //}

        //public bool ChangePasswordController()
        //{
        //    OleDbConnection con = new OleDbConnection();
        //    con.ConnectionString = conString;
        //    bool ok = false;
        //    String sql = "SELECT cashierpass FROM cashieraccount WHERE cashierid=" + whoLogged() + ";";
        //    try
        //    {
        //        con.Open();
        //        OleDbCommand cmd = new OleDbCommand(sql, con);
        //        cmd.CommandType = CommandType.Text;
        //        OleDbDataReader rdr = cmd.ExecuteReader();
        //        if (rdr.Read())
        //        {
        //            if (rdr["cashierpass"].ToString() == cashierpass)
        //                ok = true;
        //        }
        //    }

        //    finally
        //    {
        //        con.Close();
        //    }

        //    return ok;
        //}
    }
}
