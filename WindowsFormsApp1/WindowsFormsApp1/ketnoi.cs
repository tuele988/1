using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class ketnoi
    {
        string strConnection = ConfigurationManager.ConnectionStrings["chuoiKN"].ToString();
        SqlConnection conn;
        public SqlConnection getketnoi()
        {
            conn = new SqlConnection(strConnection);
            return conn;
        }

        public void closeKetnoi()
        {
            conn.Close();
        }
    }

}
