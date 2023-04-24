using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace MP
{
    class DB
    {OleDbCommand cmd;
        OleDbDataReader dr;
        OleDbConnection con;
        string str;
        public DB()
        {
            str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\KGN COMPUTER\Videos\CLMS\MP.accdb";
            //str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\BCA5\Suyash Mihir\Books Mgmt\MP.accdb";
            con = new OleDbConnection(str);
            connect();
           
        }
        public void connect()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            else if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
        }
        public int Execute(string SQL)
        {
            cmd = new OleDbCommand(SQL, con);
            int r = cmd.ExecuteNonQuery();
            return r;
        }
        public OleDbDataReader read(string SQL)
        {
            cmd = new OleDbCommand(SQL, con);
            dr = cmd.ExecuteReader();
            return dr;

        }
        public OleDbDataAdapter adapt(string SQL)
        {
            OleDbDataAdapter d = new OleDbDataAdapter(SQL, con);
            return d;
        }
    }
}
