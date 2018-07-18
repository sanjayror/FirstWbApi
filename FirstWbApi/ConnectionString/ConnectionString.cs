using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace FirstWbApi
{
    public class ConnectionString
    {
        public SqlConnection sqlcon
        {
            get; set;
        }
        public SqlCommand sqlcom { get; set; }
        public SqlDataAdapter sd { get; set; }
        
        public ConnectionString()
        {
            this.sqlcon = new SqlConnection("Data Source = NAVJOT\\SQLEXPRESS;Initial Catalog = Starting_App; User ID = sa; Password=petroit@1234");
            this.sqlcom = new SqlCommand();
            this.sd = new SqlDataAdapter(sqlcom);
        }



    }
}