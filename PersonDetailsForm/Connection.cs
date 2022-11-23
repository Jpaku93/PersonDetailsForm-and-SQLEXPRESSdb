using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDetailsForm
{
    internal class Connection
    {
        public SqlConnection con; // Connection object to connect to the database
        public SqlCommand cmd; // Command object to execute the query
        public SqlDataAdapter sda; // Data adapter to fetch the data from the database
        public string pkk; // Primary key of the table

        public void CONNECTION()
        {
            con = new SqlConnection(@"Data Source=ACERPREDATOR\SQLEXPRESS;Initial Catalog=PersonDetails;Integrated Security=True");
            con.Open();
            //cmd = new SqlCommand();
            //sda = new SqlDataAdapter();
        }
        public void DATASEND(string SQL)
        {
            try
            {
                CONNECTION();
                cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                pkk = "";
            }
            catch (Exception)
            {
                pkk = "Data Error";
            }
            con.Close();

        }
        public void DATAGET(string SQL)
        {
            try
            {
                CONNECTION();
                sda = new SqlDataAdapter(SQL, con);
                pkk = "";
            }
            catch (Exception)
            {
                pkk = "Data Error";
            }
            

        }

    }
}
