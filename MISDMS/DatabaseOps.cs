using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace MISDMS
{
    class DatabaseOps
    {
        SqlConnection con;
        public DatabaseOps(SqlConnection connection)
        {
            this.con = connection;
        }
        public DataTable getData(string query)
        {
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
        public bool insertData(string table,string[] targetCols,string[] parameters, object[] values)
        {
            string query = "INSERT INTO " + table + "(";
            //Insert target cols
            for (int a = 0; a < targetCols.Length; a++)
            {
                if (a != targetCols.Length - 1)
                {
                    query = query + targetCols[a] + ",";
                }
                else
                {
                    query = query + targetCols[a] + ")";
                }
            }
            query = query + " VALUES(";
            //Insert parameters
            for (int b = 0; b < parameters.Length; b++)
            {
                if (b != parameters.Length - 1)
                {
                    query = query + "@" + parameters[b] + ",";
                }
                else
                {
                    query = query + "@" + parameters[b] + ")";
                }
            }
            //Commands Here
            SqlCommand com = new SqlCommand(query, con);
            for (int c = 0; c < values.Length; c++)
            {
                com.Parameters.AddWithValue("@" + parameters[c], values[c]);
            }
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool deleteData(string table, string colCon, string conVal)
        {
            string param = conVal;
            //Remove points and spaces
            param = param.Replace(" ", String.Empty);
            param = param.Replace(".", String.Empty);
            string query = "DELETE FROM " + table + " WHERE " + colCon + "=@" + param + "";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue(param, conVal);
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool checkDuplicate(string table,string column,string conditon,int condition2 = 0)
        {
            string query = "";
            if (table == "Type")
            {
                query = "SELECT " + column + " FROM " + table + " WHERE " + column + "='" + conditon + "' AND cat_id=" + condition2;
            }
            else
            {
                query = "SELECT " + column + " FROM " + table + " WHERE " + column + "='" + conditon + "'";
            }
            
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable x = new DataTable();
            try
            {
                con.Open();
                sda.Fill(x);
            }
            catch
            {
                MessageBox.Show("An error occured in the server. Please try again later.");
            }
            finally
            {
                con.Close();
            }
            if (x.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool updateData(string table, string[] targetCols, string[] parameters, object[] values, string targetColCondition,string targetValueCondition){
            string query = "UPDATE " + table + " SET ";
            //insert cols and params
            for (int a = 0; a < targetCols.Length; a++)
            {
                if (a != targetCols.Length - 1)
                {
                    query = query + targetCols[a] + "=@" + parameters[a] + ",";
                }
                else
                {
                    query = query + targetCols[a] + "=@" + parameters[a] + " ";
                }
            }
            query = query + " WHERE " + targetColCondition + " = '" + targetValueCondition + "'";
            //Commands Here
            SqlCommand com = new SqlCommand(query, con);
            //Add values to parameters
            for (int b = 0; b < values.Length; b++)
            {
                com.Parameters.AddWithValue("@" + parameters[b], values[b]);
            }

            try
            {
                con.Open();
                com.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
