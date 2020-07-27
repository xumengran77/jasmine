using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jasmine.DBUtils
{
    class ConnectUtil
    {
        //与数据库建立连接
        public static MySqlConnection getConnection()
        {
            string connectstr = "server=175.24.106.249;port=3306;database=mydb;user=root;password=xmr123;";
            MySqlConnection conn = new MySqlConnection(connectstr);
            return conn;
        }
    }
}
