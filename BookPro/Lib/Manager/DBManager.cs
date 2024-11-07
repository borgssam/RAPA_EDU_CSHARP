using BookPro.Lib.DB;
using MySql.Data.MySqlClient;
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
    


	}
}
