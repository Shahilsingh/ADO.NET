using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADONET
{  
    class Program6
    {
            static void Main(string[] args)
        {
              new Program6().Connecting();
        }
        public void Connecting()
        {
            using (
                     // Creating Connection  
                     SqlConnection con = new SqlConnection("data source=.; database=student; integrated security=SSPI")
                 )
            {
                con.Open();
                Console.WriteLine("Connection Established Successfully");
                Console.ReadLine();
            }
        }
    }
}