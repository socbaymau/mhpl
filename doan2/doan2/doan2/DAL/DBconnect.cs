using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DBconnect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=VANDUC;Initial Catalog=QLSIMDT1;Integrated Security=True");
        private bool connectDB()
        {
            bool re = true;

            try
            {
                if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
                {
                    con.Open();
                }
               
                if (con == null)
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                re = false;
            }
            return re;

        }
        public bool Update(String Sql)
        {
            bool re = true;
            try
            {
                if (connectDB())
                {
                    SqlCommand cmd = new SqlCommand(Sql, con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Loi tai DBconnect"+e);
                re = false;
            }
            return re;
        }
        public DataTable GetData(string Sql)
        {
            DataTable dt = new DataTable();
            
            try
            {
                if (connectDB())
                {
                    SqlCommand com = new SqlCommand(Sql, con);
                    com.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    da.Fill(dt);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Loi tai DBconnect.Getdata" +e);
            }
            return dt;
        }



    }
}
