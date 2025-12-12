using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents_ilmasheva.Classes.Common
{
    public class DBConnect
    {
        public static readonly string Path = @"C:\Users\1\OneDrive\Desktop\Авик\Ощепков\МДК 05.02\ПР15\Database.accdb";
        public static OleDbConnection Connection()
        {
            OleDbConnection oleDBConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Path);
            oleDBConnection.Open();
            return oleDBConnection;
        }
        public static OleDbDataReader Query(string Query, OleDbConnection Connection)
        {
            return new OleDbCommand(Query, Connection).ExecuteReader();
        }
        public static void CloseConnection(OleDbConnection Connection)
        {
            Connection.Close();
        }
    }
}
