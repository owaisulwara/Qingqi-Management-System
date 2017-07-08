using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Qingqi_Management_System
{
    public class database
    {
        public SqlConnection con = new SqlConnection();
        public void conString() {
            con.ConnectionString = @"Server=.\SQLEXPRESS; Integrated Security=true; User Instance = True; AttachDbFilename=|DataDirectory|QingqiDb.mdf;Database=QingqiData;Trusted_Connection=Yes;";
        }
    }
}
