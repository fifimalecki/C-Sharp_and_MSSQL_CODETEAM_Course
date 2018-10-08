using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FilipMaleckiLab3
{
    class Film
    {
        public static DataTable GetAll(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Film", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
