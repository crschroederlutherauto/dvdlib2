using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DvdLibrary.Helpers
{
    public static class SqlConnectionHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("server=MIT8896NOTE;database=DVDLibrary;Integrated Security=True");
        }
    }
}