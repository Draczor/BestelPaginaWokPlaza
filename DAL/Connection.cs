using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class Connection
    {
        public SqlConnection con;
        
        public void connection()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-0ELSQI6;Initial Catalog=WokPlazaBP;Integrated Security=True");
        }

        //public void ExecuteCommand(List<Object> QueryList)
        //{
        //    connection();

        //    using (con)
        //    {
        //        SqlTransaction transaction = null;
        //        try
        //        {
        //            con.Open();
        //            transaction = con.BeginTransaction();

        //            foreach (var item in QueryList)
        //            {
        //                SqlCommand command = new SqlCommand();
        //                command.Connection = con;
        //                command.Transaction = transaction;

        //                for (int i = 0; i < item.Parameters.Count; i++)
        //                {
        //                    command.Parameters.AddWithValue(item.ParameterName[i].ToString(), item.Parameters[i]);
        //                }

        //                command.CommandText = item.Query;
        //                command.ExecuteNonQuery();
        //            }

        //            transaction.Commit();
        //            Console.WriteLine("Query successfully executed");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
        //            Console.WriteLine("  Message: {0}", ex.Message);
        //            try
        //            {
        //                transaction.Rollback();
        //            }
        //            catch (Exception ex2)
        //            {
        //                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
        //                Console.WriteLine("  Message: {0}", ex2.Message);
        //            }
        //        }
        //    }
        //}
    }
}
