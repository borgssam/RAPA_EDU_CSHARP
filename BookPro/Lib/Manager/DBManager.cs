using BookPro.Lib.DB;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookPro.Lib.Manager
{
  public class DBManager
  {
    private MySqlAssist m_MySqlAssist;
    public DBAssist dbAssist
    {
        get { return m_MySqlAssist; }
    }

    public void SetConnectInfo(string aAddr, int aPort, string aId, string aPwd, string aDataBase)
    {
        m_MySqlAssist = new MySqlAssist(aAddr, aPort, aId, aPwd, aDataBase);
    }

    public DBManager() { }

    public DataTable ReadStaff(String id, String pwd)
    {
      DataTable _dt = null;
      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection != null) {      
        String _strQuery = "SELECT stf_ucode, stf_id, stf_name, stf_pwd, stf_regdate, stf_retiredate, stf_work_state, stf_gender ";
        _strQuery += "FROM staff ";
        _strQuery += $"WHERE stf_id = '{id}' AND stf_pwd = '{pwd}'; ";
        _dt = m_MySqlAssist.SelectQuery(_Connection, _strQuery,  "staff");
      }
      return _dt;
    }

    public DataTable ReadStaff(int _ucode)
    {
      DataTable _dt = null;
      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection != null)
      {
        String _strQuery = "SELECT stf_ucode, stf_id, stf_name, stf_pwd, stf_regdate, stf_retiredate, stf_work_state, stf_gender, stf_picture ";
        _strQuery += "FROM staff ";
        _strQuery += $"WHERE stf_ucode = {_ucode}; ";
        _dt = m_MySqlAssist.SelectQuery(_Connection, _strQuery, "staff");
      }
      return _dt;
    }


    public DataTable ReadStaffs(String aKindField, string aKeyword)
    {
      DataTable _dt = null;

      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection != null)
      {
        String _strQuery = "SELECT stf_ucode, stf_id, stf_name, stf_pwd, stf_regdate, stf_retiredate, stf_work_state, stf_gender ";
        _strQuery += "FROM staff ";
        if (aKeyword.Length > 0)
        {
          _strQuery += $"WHERE {aKindField} LIKE '%{aKeyword}%'; ";
        }

        _dt = m_MySqlAssist.SelectQuery(_Connection, _strQuery, "staffs");
      }
      return _dt;
    }
    
    public int RetireStaff(int _ucode)
    {
      int _result = 0;
      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection == null) {
        _result = -999;
      } else
      {
        string _strQuery = "UPDATE staff ";
        _strQuery += "SET ";
        _strQuery += "stf_work_state = 'r', ";
        _strQuery += "stf_retiredate = NOW() ";
        _strQuery += $"WHERE stf_ucode = {_ucode} ";
        _result = m_MySqlAssist.ExcuteQuery(_Connection, _strQuery);

        if (_result > 0) {
          _result = _ucode;
        }
      }
      return _result;
    }

  }
}
