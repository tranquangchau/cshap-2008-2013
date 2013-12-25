using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace KetNoiCSDL
{
    public static class DB
    {
        public static string getConnectionString()
        {
            return Properties.Settings.Default.connectionString;
        }
        public static SqlConnection getConnection()
        {
            string connectionString = getConnectionString();
            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch
            {
 
            }
            return connection;
        }

        //ham tra ve DataSet lay du lieu trong CSDL
        public static DataSet getDataSet(string sStoreProcedure, CommandType cmdType)
        {
            DataSet ds = new DataSet();
            using (SqlConnection connection = DB.getConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                try
                {
                    SqlCommand command = new SqlCommand(sStoreProcedure, connection);
                    command.CommandType = cmdType;
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return ds;
        }
    }
}
