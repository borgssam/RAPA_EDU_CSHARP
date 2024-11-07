using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPro.Lib.DB
{

    public class DBAssist
    {

        public virtual bool TestConnection() { return false; }
        public virtual DbConnection NewConnection() { return null; }
        public virtual DataTable SelectQuery(string aQuery) { return null; }
        public virtual DataTable SelectQuery(DbConnection connection, string aQuery) { return null; }
        public virtual DataTable SelectQuery(DbConnection connection, string aQuery, String TableName) { return null; }
        public virtual DataSet SelectQueryDataSet(DbConnection _db_connection, string aQuery) { return null; }
        public virtual DataSet SelectQueryDataSet(DbConnection _db_connection, ArrayList aQueryArray) { return null; }

        public virtual object ExcuteScalar(DbConnection _db_connection, string aQuery) { return null; }

        public virtual int ExcuteQueryArray(DbConnection _connection, ArrayList aQueryArray) { return -1; }

        public virtual int ExcuteQuery(DbConnection _connection, string aQuery) { return -1; }

    }
}
