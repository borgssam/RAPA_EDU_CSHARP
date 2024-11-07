using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookPro.Lib.DB
{

    class MySqlAssist : DBAssist
    {
        private String m_connectString = "";
        protected MySqlConnection m_MySqlConnection = null;

        public MySqlAssist()
        {
            m_connectString = "";
            m_MySqlConnection = null;
        }
        //private ~MySQLAssist() { }

        // For MySQL
        public MySqlAssist(string aHost, int aPort, string aID, string aPWD, string aDatabase)
        {
            if (aPort < 0)
            {
                aPort = 3306;
            }
            m_connectString = string.Format(
                @"Data Source={0};Database={1};User Id={2};Password={3};Charset=utf8;Connect Timeout=300;;Port={4}",
                aHost, aDatabase, aID, aPWD, aPort);

            m_MySqlConnection = new MySqlConnection(m_connectString);
        }

        public String MakeConnectString(string aHost, int aPort, string aID, string aPWD, string aDatabase)
        {
            if (aPort < 0)
            {
                aPort = 3306;
            }
            m_connectString = string.Format(
                @"Data Source={0};Database={1};User Id={2};Password={3};Charset=utf8;Connect Timeout=300;;Port={4}",
                aHost, aDatabase, aID, aPWD, aPort);

            return m_connectString;
        }

        public MySqlConnection GetConnection
        {
            get { return m_MySqlConnection; }
        }

        public string SetConnectionString
        {
            set
            {
                m_connectString = value;
                m_MySqlConnection = new MySqlConnection(value);
            }
        }

        public MySqlConnection GetNewConnection()
        {
            return new MySqlConnection(m_connectString);
        }

        public string ConnectString
        {
            get { return m_connectString; }
        }

        public override DbConnection NewConnection()
        {

            MySqlConnection _connection = null;
            //   bool _success = false;
            try
            {
                _connection = GetNewConnection();
                _connection.Open();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //				KMessages.ShowError(ex.Message, false);
                _connection = null;
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }
            }
            return _connection as DbConnection;
        }

        public override bool TestConnection()
        {
            MySqlConnection _connection = null;
            bool _success = false;
            try
            {
                _connection = GetNewConnection();
                _connection.Open();

                //if (m_MySqlConnection.State == ConnectionState.Open) {
                //    m_MySqlConnection.Close(); 
                //}
                //m_MySqlConnection.Open();
                //  m_MySqlConnection _connect
                _success = true;
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //				KMessages.ShowError(ex.Message, false);

            }
            finally
            {
                _connection.Close();//.Close();
                //        m_MySqlConnection.Close();            
            }
            return _success;
        }

        public override object ExcuteScalar(DbConnection _db_connection, string aQuery)
        {
            MySqlConnection connection = _db_connection as MySqlConnection;
            object _result = null;
            DataRow _DataRow = ReadQuery(aQuery);
            if (_DataRow != null)
            {
                _result = _DataRow[0];
            }
            return _result;
        }




        public DataRow ReadQuery(String aQuery)
        {
            DataRow _DataRow = null;
            DataTable _DataTable = SelectQuery(aQuery);
            if (_DataTable.Rows.Count > 0)
            {
                _DataRow = _DataTable.Rows[0];
            }
            return _DataRow;
        }



        public override DataTable SelectQuery(DbConnection _db_connection, string aQuery, String TableName)
        {
            MySqlConnection connection = _db_connection as MySqlConnection;

            DataTable _DataTable = new DataTable();

            try
            {
                if (connection == null)
                {
                    connection = GetNewConnection();
                }
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                //MySqlDataAdapter oddaResult = new MySqlDataAdapter(query, connection);
                MySqlCommand command = new MySqlCommand(aQuery, connection);
                command.CommandTimeout = 300;
                MySqlDataAdapter _SqlAdapter = new MySqlDataAdapter(command);
                int _count = _SqlAdapter.Fill(_DataTable);

                //connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

                //throw ex;
            }
            finally
            {
                connection.Close();
            }

            try
            {
                if (TableName.Length > 0)
                {
                    _DataTable.TableName = TableName;
                }
                else
                {
                    _DataTable.TableName = GetTableNameFromQuery(aQuery);
                }
            }
            catch { }

            return _DataTable;
        }

        public override DataTable SelectQuery(string aQuery)
        {
            DataTable _DataTable = new DataTable();

            try
            {
                MySqlConnection connection;
                if (m_MySqlConnection.State == ConnectionState.Open)
                    connection = GetNewConnection();
                else
                    connection = m_MySqlConnection;

                //MySqlDataAdapter oddaResult = new MySqlDataAdapter(query, connection);
                MySqlCommand command = new MySqlCommand(aQuery, connection);
                command.CommandTimeout = 300;
                MySqlDataAdapter _SqlAdapter = new MySqlDataAdapter(command);
                int _count = _SqlAdapter.Fill(_DataTable);

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

                //throw ex;
            }
            finally
            {
                m_MySqlConnection.Close();
            }

            try
            {
                _DataTable.TableName = GetTableNameFromQuery(aQuery);
            }
            catch { }

            return _DataTable;
        }




        public override DataSet SelectQueryDataSet(DbConnection _db_connection, ArrayList aQueryArray)
        {
            string _Querys = "";
            foreach (object _QueryItem in aQueryArray)
            {

                string _tablename = "";
                string _query = "";
                if (_QueryItem is KeyValuePair<string, string>)
                {
                    KeyValuePair<string, string> _KeyValue = (KeyValuePair<string, string>)_QueryItem;
                    _tablename = _KeyValue.Key;
                    _query = _KeyValue.Value.TrimEnd();
                }
                else if (_QueryItem is string)
                {
                    _query = (_QueryItem as string).TrimEnd();
                }

                // string _Query = _QueryItem
                char _last = _query.Last<char>();

                if (_last != ';' && _query.Length > 0)
                {
                    _query += "; ";
                }
                _Querys += _query;
            }
            DataSet _set = SelectQueryDataSet(_db_connection, _Querys);
            if (_set != null)
            {
                for (int _idx = 0; _idx < _set.Tables.Count; _idx++)
                {
                    //object _Table = ;
                    if (aQueryArray[_idx] is KeyValuePair<string, string>)
                    {
                        KeyValuePair<string, string> _KeyValue = (KeyValuePair<string, string>)aQueryArray[_idx];
                        _set.Tables[_idx].TableName = _KeyValue.Key;
                    }
                }
            }

            return _set;
        }

        public override DataSet SelectQueryDataSet(DbConnection _db_connection, string aQuery)
        {
            MySqlConnection connection = _db_connection as MySqlConnection;

            DataSet _DataSet = new DataSet();

            try
            {
                if (connection == null)
                {
                    connection = GetNewConnection();
                }
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                //MySqlDataAdapter oddaResult = new MySqlDataAdapter(query, connection);
                MySqlCommand command = new MySqlCommand(aQuery, connection);
                command.CommandTimeout = 300;
                MySqlDataAdapter _SqlAdapter = new MySqlDataAdapter(command);
                int _count = _SqlAdapter.Fill(_DataSet);

                //connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

                //throw ex;
            }
            finally
            {
                connection.Close();
            }

            try
            {
                //if (TableName.Length > 0)
                //{
                //    _DataSet.DataSetName = TableName;
                //}
                //else
                //{
                //    //_DataSet.DataSetName = GetTableNameFromQuery(aQuery);
                //}
            }
            catch { }

            return _DataSet;
        }


        public int ExcuteQuery(string aQuery)
        {
            ArrayList _QueryArray = new ArrayList();
            _QueryArray.Add(aQuery);
            return ExcuteQueryArray(_QueryArray);
        }

        public override int ExcuteQuery(DbConnection _connection, string aQuery)
        {
            ArrayList _QueryArray = new ArrayList();
            _QueryArray.Add(aQuery);
            return ExcuteQueryArray(_connection, _QueryArray);
        }

        public virtual int ExcuteQueryArray(ArrayList aQueryArray)
        {
            MySqlConnection _connection;
            if (m_MySqlConnection.State == ConnectionState.Open)
            {
                _connection = GetNewConnection();
            }
            else
            {
                _connection = m_MySqlConnection;
            }

            _connection.Open();
            int affectedRows = 0;
            if (_connection.State == ConnectionState.Open)
            {
                MySqlTransaction trans = _connection.BeginTransaction();
                String _tryQuery = "";
                try
                {
                    MySqlCommand _cmd = new MySqlCommand();
                    _cmd.Connection = _connection;
                    _cmd.Transaction = trans;

                    foreach (string query in aQueryArray)
                    {
                        _tryQuery = query;
                        _cmd.CommandText = query;
                        _cmd.ExecuteNonQuery();
                        affectedRows += 1;
                    }
                    trans.Commit();

                    _connection.Close();
                }
                catch //(OleDbException ex)
                {
                    Console.WriteLine(_tryQuery);
                    affectedRows = -1;
                    trans.Rollback();
                }
                finally
                {
                    m_MySqlConnection.Close();
                }
            }

            return affectedRows;
        }
        public override int ExcuteQueryArray(DbConnection _db_connection, ArrayList aQueryArray)
        {
            MySqlConnection _connection = _db_connection as MySqlConnection;
            if (_connection == null)
            {
                _connection = GetNewConnection();
            }
            _connection.Open();

            MySqlTransaction trans = _connection.BeginTransaction();
            int affectedRows = 0;
            string _old_query = ""; string _now_query = "";
            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _connection;
                _cmd.Transaction = trans;

                foreach (string query in aQueryArray)
                {
                    _now_query = query;
                    _cmd.CommandText = query;
                    _cmd.ExecuteNonQuery();
                    affectedRows += 1;
                    _old_query = query;
                }
                trans.Commit();

                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "::" + _old_query + "::" + _now_query);
                affectedRows = -1;
                trans.Rollback();
            }
            finally
            {
                m_MySqlConnection.Close();
            }

            return affectedRows;
        }




        public virtual int ExcuteCommandArray(MySqlConnection _connection, ArrayList aCommandArray)
        {
            if (_connection == null)
            {
                _connection = GetNewConnection();
            }

            _connection.Open();
            MySqlTransaction trans = _connection.BeginTransaction();
            int affectedRows = 0;
            String _query = "";
            try
            {
                foreach (MySqlCommand _cmd in aCommandArray)
                {
                    _query = _cmd.CommandText;
                    _cmd.Connection = _connection;
                    _cmd.Transaction = trans;
                    affectedRows += _cmd.ExecuteNonQuery();
                    //idx += 1;
                }
                trans.Commit();
                _connection.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(_query);
                Console.WriteLine(ex.Message);
                ////Console.WriteLine("KOledb.cs 214~222 Line : Execute Ole Command Fail");
                trans.Rollback();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                trans.Rollback();
            }
            finally
            {
                _connection.Close();
                //     _connection.Close();
            }

            return affectedRows;
        }


        public virtual int ExcuteCommandArray(ArrayList aCommandArray)
        {
            MySqlConnection _connection;
            if (m_MySqlConnection.State == ConnectionState.Open)
            {
                _connection = GetNewConnection();
            }
            else
            {
                _connection = m_MySqlConnection;
            }

            _connection.Open();
            MySqlTransaction trans = _connection.BeginTransaction();
            int affectedRows = 0;
            try
            {
                foreach (MySqlCommand _cmd in aCommandArray)
                {
                    _cmd.Connection = _connection;
                    _cmd.Transaction = trans;
                    affectedRows += _cmd.ExecuteNonQuery();
                    //idx += 1;
                }
                trans.Commit();
                _connection.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                ////Console.WriteLine("KOledb.cs 214~222 Line : Execute Ole Command Fail");
                trans.Rollback();
            }
            finally
            {
                m_MySqlConnection.Close();
                //     _connection.Close();
            }

            return affectedRows;
        }

        protected string GetTableNameFromQuery(string aQuery)
        {
            aQuery = aQuery.Replace("from", "From");
            aQuery = aQuery.Replace("FROM", "From");

            int startIdx = aQuery.IndexOf("From");
            string tableName = aQuery.Substring(startIdx);
            tableName = tableName.Replace("", "");
            tableName = tableName.Split(new Char[] { ' ' })[1].Trim();

            return tableName;
        }


    }


}
