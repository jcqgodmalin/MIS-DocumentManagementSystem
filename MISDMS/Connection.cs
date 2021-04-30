using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MISDMS
{
    class Connection
    {
        private string server = "";
        private string database = "";
        private string username = "";
        private string password = "";
        SqlConnection con;

        public Connection(string serv, string uid, string pwd, string db="")
        {
            this.server = serv;
            this.database = db;
            this.username = uid;
            this.password = pwd;
        }

        private bool Connect()
        {
            string conString;
            if (this.database != null)
            {
                conString = "Data Source=" + this.server + ";Initial Catalog=" + this.database + ";User ID=" + this.username + ";Password=" + this.password;
            }
            else
            {
                conString = "Data Source=" + this.server + ";User ID=" + this.username + ";Password=" + this.password;
            }
           con = new SqlConnection(conString);
            try
            {
                con.Open();
                con.Close();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public SqlConnection getConnection()
        {
            return this.con;
        }
        public bool checkConnection()
        {
            if (this.Connect())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable getDatabases()
        {
            String query = "select name from sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb') AND name NOT LIKE '%Report%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                sda.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable getTables()
        {
            String query = "SELECT TABLE_NAME FROM " + this.database + ".INFORMATION_SCHEMA.TABLES";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                sda.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        
    }
}
