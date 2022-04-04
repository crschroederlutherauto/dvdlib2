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
            return new SqlConnection("server=(localdb)\\mssqllocaldb;database=DVDLibrary;Integrated Security=True"); //TODO! read from app settings or whatever
        }
    }
}