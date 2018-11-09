using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET
{
    class Industry
    {
        static void Main(string[] args)
        {
            new Industry().CreateTable();
            Console.Read();
        }


        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=bizruntime; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("create table bizruntime(id int not null, name varchar(100), email varchar(50), join_date date)", con);

                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}

            

