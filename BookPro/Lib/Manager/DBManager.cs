using BookPro.Lib.DB;
using BookPro.Lib.Utils;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

    public int GetSequence(String aSeqName)
    {
      int _iResult = -1;
      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection != null)
      {
        string _query = $"UPDATE sequence SET current_value = current_value + 1 WHERE name = '{aSeqName}';";
        _query += $"SELECT current_value FROM sequence WHERE name = '{aSeqName}';";
        object _result = m_MySqlAssist.ExcuteScalar(_Connection, _query);
        if (_result != null) { _iResult = Convert.ToInt32(_result); }
      }
      return _iResult;
    }

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

    public int AddStaff(string stf_id, string stf_name, string stf_pwd,
      DateTime stf_regdate, DateTime stf_retiredate,
      string stf_work_state, string stf_gender, string stf_picture)
    {

      int _result = 0;
      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection == null)
      {
        _result = -999;
      }
      else
      {
        int _ucode = this.GetSequence("seq_staff");
        string _strQuery = "INSERT INTO staff(stf_ucode, stf_id, stf_name, stf_pwd, stf_regdate,  stf_work_state, stf_gender, stf_create_ucode, stf_create_date, stf_picture) ";
        _strQuery += "VALUES( ";
        _strQuery += $"{_ucode}, ";
        _strQuery += $"'{stf_id}', ";
        _strQuery += $"'{stf_name}', ";
        _strQuery += $"'{stf_pwd}', ";
        _strQuery += $"now(), ";
        _strQuery += $"'{stf_work_state}', ";
        _strQuery += $"'{stf_gender}', ";
        _strQuery += $"{StaffInfo.ucode}, ";
        _strQuery += $"now(), ";
        _strQuery += $"'' ";
        _strQuery += "); ";

        _result = m_MySqlAssist.ExcuteQuery(_Connection, _strQuery);

        if (_result > 0)
        {
          _result = _ucode;
        }
      }
      return _result;
    }


    public int ModifyStaff(int stf_ucode,string stf_id, string stf_name, string stf_pwd, 
      DateTime stf_regdate, DateTime stf_retiredate, 
      string stf_work_state, string stf_gender, string stf_picture)
    {

      int _result = 0;
      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection == null)
      {
        _result = -999;
      }
      else
      {
        string _strQuery = "UPDATE staff ";
        _strQuery += "SET ";
        _strQuery += $"stf_name = '{stf_name}', ";
        _strQuery += $"stf_pwd = '{stf_pwd}', ";
        _strQuery += $"stf_id = '{stf_id}', ";
        _strQuery += $"stf_work_state = '{stf_work_state}', ";
        _strQuery += $"stf_gender = '{stf_gender}', ";        
        _strQuery += $"stf_regdate = '{stf_regdate.ToString("yyyy-MM-dd")}', ";
        _strQuery += $"stf_retiredate = '{stf_retiredate.ToString("yyyy-MM-dd")}', ";
        _strQuery += $"stf_modify_ucode = {StaffInfo.ucode}, ";
        _strQuery += $"stf_modify_date = now(), ";
        _strQuery += $"stf_picture = '{stf_picture}' ";
        _strQuery += $"WHERE stf_ucode = {stf_ucode} ";
        _result = m_MySqlAssist.ExcuteQuery(_Connection, _strQuery);

        if (_result > 0)
        {
          _result = stf_ucode;
        }
      }
      return _result;
    }

    public DataTable ReadCategory()
    {
      DataTable _dt = null;

      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection != null)
      {
        String _strQuery = "SELECT ctg_ucode, ctg_name FROM category ORDER BY ctg_ucode ASC; ";
        _dt = m_MySqlAssist.SelectQuery(_Connection, _strQuery, "staffs");
      }
      return _dt;

    }


  }
}
