using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class Connection
    {
        //public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HAFGCMF;Initial Catalog=WokPlazaBP;Integrated Security=True");
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0ELSQI6;Initial Catalog=WokPlazaBP;Integrated Security=True");
        
        public void ExecuteCommand(SqlCommand command)
        {
            try
            {
                con.Open();
                command.Connection = con;

                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.Write("An error has occurred: " + ex.Message);
                con.Close();
            }
        }
    }
}
