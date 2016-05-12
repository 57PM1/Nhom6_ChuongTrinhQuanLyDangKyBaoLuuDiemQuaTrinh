using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLiDuAn.Connect
{
    
    public class Connector
    {
        public SqlCommand cmd { get; set; }
        public SqlConnection conn { get; set; }
        public SqlDataReader dr { get; set; }
        public Connector()
        {
         
        }

        
    }
}
