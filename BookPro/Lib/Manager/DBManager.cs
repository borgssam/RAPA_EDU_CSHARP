using BookPro.Lib.DB;
using BookPro.Lib.Utils;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Metrics;
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
        _strQuery += $"'{stf_picture}' ";
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

    public DataTable ReadBook(int aSelectedIndex, String aKeyword,int aCategoryUcode)
    {
      DataTable _dt = null;

      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection != null)
      {

        //제목  0
        //분류  1
        //저자  2
        //출판사 3

        String _strQuery = "SELECT bk_ucode, bk_title, bk_writer, bk_pubs, bk_price, bk_pub_year, bk_regdate, ";
              _strQuery += "bk_erasedate, bk_create_ucode, bk_create_date, bk_modify_ucode, bk_modify_date, bk.ctg_ucode, ctg.ctg_name ";
        _strQuery += "FROM book as bk ";
        _strQuery += "JOIN category as ctg on bk.ctg_ucode = ctg.ctg_ucode ";
        if (aSelectedIndex == 0 && aKeyword.Length>0) {
//제목  0
              _strQuery += $"where bk_title like '%{aKeyword}%' ";
        }        else if (aSelectedIndex == 1)        {
  //분류  1
              _strQuery += $"where ctg_ucode = {aCategoryUcode} ";
        }        else if (aSelectedIndex == 2 && aKeyword.Length > 0)        {
 //저자  2
              _strQuery += $"WHERE bk_writer LIKE '%{aKeyword}% ";
        }        else if (aSelectedIndex == 3 && aKeyword.Length > 0)        {
//출판사 3
              _strQuery += $"WHERE bk_pubs LIKE '%{aKeyword}%' ";
        }
              _strQuery += "ORDER BY bk_title ASC; ";      


        _dt = m_MySqlAssist.SelectQuery(_Connection, _strQuery, "staffs");
      }
      return _dt;

    }

    public DataRow ReadBook(int aUcode)
    {
      DataRow _row = null;
      DataTable _dt = null;

      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection != null)
      {

        String _strQuery = "SELECT bk_ucode, bk_title, bk_writer, bk_pubs, bk_price, bk_pub_year, bk_regdate, ";
        _strQuery += "bk_erasedate, bk_create_ucode, bk_create_date, bk_modify_ucode, bk_modify_date, bk.ctg_ucode, ctg.ctg_name,bk_picture ";
        _strQuery += "FROM book as bk ";
        _strQuery += "JOIN category as ctg on bk.ctg_ucode = ctg.ctg_ucode ";
       _strQuery += $"WHERE bk_ucode = {aUcode} ";


        _dt = m_MySqlAssist.SelectQuery(_Connection, _strQuery, "book");
      }

      if(_dt !=null && _dt.Rows.Count > 0)
      {
        _row = _dt.Rows[0];
      }
      return _row;

    }
    /*
-- 제목, 저자, 대여상태
SELECT bk.bk_ucode, bk_title, bk_writer, rnt.limit_date,
CASE 
WHEN rnt.limit_date IS NULL THEN '대기중'
WHEN rnt.limit_date < NOW() THEN '연체중'
ELSE '대출중'
END AS rnt_state
FROM book AS bk
LEFT JOIN
(
SELECT bk_ucode, MIN(rnt_limit_date) AS limit_date
FROM rent
WHERE rnt_return_date IS NULL
GROUP BY bk_ucode
) AS rnt ON bk.bk_ucode = rnt.bk_ucode     
     */
    public DataTable ReadBook(int _searchIndex, string _keyword)
    {
      DataTable _dt = null;

      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection != null)
      {


        String _strQuery = "SELECT bk.bk_ucode, bk_title, bk_writer, rnt.limit_date, ";
        _strQuery += "CASE  ";
        _strQuery += "WHEN rnt.limit_date IS NULL THEN '대기중'  ";
        _strQuery += "WHEN rnt.limit_date < NOW() THEN '연체중'  ";
        _strQuery += "ELSE '대출중'  ";
        _strQuery += "END AS rnt_state  ";
        _strQuery += "FROM book AS bk  ";
        _strQuery += "LEFT JOIN (  ";
        _strQuery += "SELECT bk_ucode, MIN(rnt_limit_date) AS limit_date  ";
        _strQuery += "FROM rent WHERE rnt_return_date IS NULL GROUP BY bk_ucode  ";
        _strQuery += ") AS rnt ON bk.bk_ucode = rnt.bk_ucode  ";


        if(_keyword.Length > 0)
        {
          if (_searchIndex == 0) {
            //0제목
            _strQuery += $" WHERE bk.bk_title LIKE '%{_keyword}%' ";
          } else if (_searchIndex == 1) {
            //1저자
            _strQuery += $" WHERE bk.bk_write LIKE '%{_keyword }%' ";
          } else if (_searchIndex == 2) {
            //2출판사
            _strQuery += $" WHERE bk.bk_pubs LIKE '%{_keyword }%' ";
          }
        }

        _strQuery += "ORDER BY bk_title ASC; ";


        _dt = m_MySqlAssist.SelectQuery(_Connection, _strQuery, "books");
      }
      return _dt;


    }
    public int DeleteBook(int _ucode)
    {

      int _result = 0;
      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection == null)
      {
        _result = -999;
      }
      else
      {
        string _strQuery = "DELETE FROM book ";
        _strQuery += $"WHERE bk_ucode = {_ucode} ";

        _result = m_MySqlAssist.ExcuteQuery(_Connection, _strQuery);

        if (_result > 0)
        {
          _result = _ucode;
        }
      }
      return _result;
    }

    public int ModifyBook(int _ucode, string _title, string _writer, string _pubs, int _price, int _pub_year, int _category_ucode, string _picture)
    {

      int _result = 0;
      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection == null)
      {
        _result = -999;
      }
      else
      {
        string _strQuery = "UPDATE book SET ";
        _strQuery += $"bk_title = '{_title}', ";
        _strQuery += $"bk_writer = '{_writer}', ";
        _strQuery += $"bk_pubs = '{_pubs}', ";
        _strQuery += $"bk_price = {_price}, ";
        _strQuery += $"bk_pub_year = {_pub_year}, ";
        _strQuery += $"bk_modify_ucode = {StaffInfo.ucode}, ";
        _strQuery += $"bk_modify_date = now(), ";
        _strQuery += $"ctg_ucode = {_category_ucode}, ";
        _strQuery += $"bk_picture = '{_picture}' ";
        _strQuery += $"WHERE bk_ucode = {_ucode} ";

        _result = m_MySqlAssist.ExcuteQuery(_Connection, _strQuery);

        if (_result > 0)
        {
          _result = _ucode;
        }
      }
      return _result;
    }

    public int AddBook(string _title,string _writer,string _pubs,int _price,int _pub_year,int _category_ucode,string _picture)
    {

      int _result = 0;
      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection == null)
      {
        _result = -999;
      }
      else
      {
        int _ucode = this.GetSequence("seq_book");
        string _strQuery = "INSERT INTO book(bk_ucode,bk_title,bk_writer,bk_pubs,bk_price,bk_pub_year,bk_regdate,bk_erasedate,bk_create_ucode,bk_create_date,ctg_ucode,bk_picture) ";
        _strQuery += "VALUES( ";
        _strQuery += $"{_ucode}, ";
        _strQuery += $"'{_title}', ";
        _strQuery += $"'{_writer}', ";
        _strQuery += $"'{_pubs}', ";
        _strQuery += $"{_price}, ";
        _strQuery += $"{_pub_year}, ";
        _strQuery += $"now(), ";
        _strQuery += $"null, ";
        _strQuery += $"{StaffInfo.ucode}, ";
        _strQuery += $"now(), ";
        _strQuery += $"{_category_ucode}, ";
        _strQuery += $"'{_picture}' ";
        _strQuery += "); ";

        _result = m_MySqlAssist.ExcuteQuery(_Connection, _strQuery);

        if (_result > 0)
        {
          _result = _ucode;
        }
      }
      return _result;
    }

    public DataRow ReadMember(int ucode)
    {
      DataTable _dt = null;
      DataRow _row = null;
      DbConnection _Connection = m_MySqlAssist.NewConnection();

      if (_Connection != null)
      {
        // 쿼리 작성: ucode에 해당하는 멤버 정보 가져오기
        string _strQuery = "SELECT mbr_ucode, mbr_id, mbr_name, mbr_pwd, mbr_gender, mbr_phone, mbr_addr, mbr_picture ";
        _strQuery += "FROM member ";
        _strQuery += string.Format("WHERE mbr_ucode = {0} ", ucode);

        // 쿼리 실행
        _dt = m_MySqlAssist.SelectQuery(_Connection, _strQuery, "member");
        if (_dt != null && _dt.Rows.Count == 1)
        {
          _row = _dt.Rows[0];
        }
      }

      return _row;
    }


/*
SELECT mbr.mbr_ucode, 
mbr_name, 
mbr_phone, 
rnt.limit_date,
CASE
WHEN rnt.limit_date IS NULL THEN '대기중'
WHEN rnt.limit_date < NOW() THEN '연체중'
ELSE '대출중'
END AS rnt_state

FROM MEMBER AS mbr
JOIN 
(
SELECT mbr_ucode, MIN(rnt_limit_date) AS limit_date FROM rent
WHERE rnt_return_date IS NULL
GROUP BY mbr_ucode

) AS rnt ON mbr.mbr_ucode = rnt.mbr_ucode     
 */
    public DataTable ReadMember(int searchIndex, string keyword)
    {

      DataTable _dt = null;  // DataTable 변수 선언
      DbConnection _Connection = m_MySqlAssist.NewConnection();  // DB 연결 생성

      if (_Connection != null)  // 연결이 성공한 경우
      {
        // SQL 쿼리 작성
        string _strQuery = "SELECT mbr.mbr_ucode, mbr_name, mbr_phone, rnt.limit_date, ";
        _strQuery += "CASE ";
        _strQuery += "WHEN rnt.limit_date IS NULL THEN '대기중' ";
        _strQuery += "WHEN rnt.limit_date < NOW() THEN '연체중' ";
        _strQuery += "ELSE '대출중' ";
        _strQuery += "END AS rnt_state ";
        _strQuery += "FROM MEMBER AS mbr ";
        _strQuery += "JOIN ( ";
        _strQuery += "SELECT mbr_ucode, MIN(rnt_limit_date) AS limit_date FROM rent ";
        _strQuery += "WHERE rnt_return_date IS NULL ";
        _strQuery += "GROUP BY mbr_ucode ";
        _strQuery += ") AS rnt ON mbr.mbr_ucode = rnt.mbr_ucode ";

        if(keyword.Length > 0)
        {
          if (searchIndex == 0)
          {
        //0.회원 이름
            _strQuery += $"WHERE mbr.mbr_name like '%{keyword}%' ";

          } else if (searchIndex == 1)
          {
            //1.회원 연락처
            _strQuery += $"WHERE mbr.mbr_phone like '%{keyword}%' ";
          }
        }

        //회원번호 회원이름 연락처 대여상태

        // 회원 정보를 가져오는 쿼리 실행
        _dt = m_MySqlAssist.SelectQuery(_Connection, _strQuery, "member");
      }
      return _dt;  // DataTable 반환

    }
    public DataTable ReadMember(int searchIndex, string keyword, int rent_status_index)
    {
      DataTable _dt = null;  // DataTable 변수 선언
      DbConnection _Connection = m_MySqlAssist.NewConnection();  // DB 연결 생성

      if (_Connection != null)  // 연결이 성공한 경우
      {
        // SQL 쿼리 작성
        string _strQuery = "SELECT mbr_ucode, mbr_name, mbr_id, mbr_pwd, mbr_gender, mbr_phone, mbr_addr, mbr_picture ";
        _strQuery += "FROM member ";
        if (searchIndex == 0)
        {
          if (keyword.Trim() == "")
          {
            _strQuery += string.Format("WHERE mbr_name  like '%{0}%'", keyword);  // 회원 ID 조건
          }
        }
        else if (searchIndex == 1)
        {
          if (keyword.Trim() == "")
          {
            _strQuery += string.Format("WHERE mbr_phone like '%{0}%'", keyword);
          }
        }
        else
        {
        }

        // 회원 정보를 가져오는 쿼리 실행
        _dt = m_MySqlAssist.SelectQuery(_Connection, _strQuery, "member");
      }
      return _dt;  // DataTable 반환
    }


    public int ModifyMember(int ucode, string mbr_id, string mbr_name, string mbr_pwd, string mbr_gender, string mbr_phone, string mbr_addr, string mbr_picture)
    {
      int _result = 0;
      // 데이터베이스 연결 객체 생성
      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection == null)
      {
        // 연결 실패 시 에러 코드 반환
        _result = -999;
      }
      else
      {
        string fieldsQuery = "mbr_id = '" + mbr_id + "', " +
                             "mbr_name = '" + mbr_name + "', " +
                             "mbr_pwd = '" + mbr_pwd + "', " +
                             "mbr_gender = '" + mbr_gender + "', " +
                             "mbr_phone = '" + mbr_phone + "', " +
                             "mbr_addr = '" + mbr_addr + "', " +
                             "mbr_picture = " + mbr_picture + "";

        // 최종 UPDATE 쿼리 작성
        string _strQuery = "UPDATE member SET " + fieldsQuery + " WHERE mbr_ucode = " + ucode;

        // 쿼리 실행"
        _result = m_MySqlAssist.ExcuteQuery(_Connection, _strQuery);

        // 성공 시 고유 코드를 반환
        if (_result > 0)
        {
          _result = ucode;
        }
      }
      return _result;
    }
    public int AddMember(string mbr_id, string mbr_name, string mbr_pwd, string mbr_gender, string mbr_phone, string mbr_addr, string mbr_picture)
    {
      int _result = 0;
      // 데이터베이스 연결 객체 생성
      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection == null)
      {
        // 연결 실패 시 에러 코드 반환
        _result = -999;
      }
      else
      {
        // 시퀀스를 통해 유니크한 코드 생성
        int _ucode = this.GetSequence("seq_member");

        // 필드와 값을 추가할 쿼리 문자열 초기화
        string _fieldsQuery = "";
        string _valuesQuery = "";

        // 필드와 값 추가
        _fieldsQuery += "mbr_ucode,";
        _valuesQuery += string.Format("{0}, ", _ucode);

        _fieldsQuery += "mbr_id,";
        _valuesQuery += string.Format("'{0}', ", mbr_id);

        _fieldsQuery += "mbr_name,";
        _valuesQuery += string.Format("'{0}', ", mbr_name);

        _fieldsQuery += "mbr_pwd,";
        _valuesQuery += string.Format("'{0}', ", mbr_pwd);

        _fieldsQuery += "mbr_gender,";
        _valuesQuery += string.Format("'{0}', ", mbr_gender);

        _fieldsQuery += "mbr_phone,";
        _valuesQuery += string.Format("'{0}', ", mbr_phone);

        _fieldsQuery += "mbr_addr,";
        _valuesQuery += string.Format("'{0}', ", mbr_addr);

        _fieldsQuery += "mbr_picture";
        _valuesQuery += string.Format("{0}", mbr_picture);

        // 최종 INSERT 쿼리 작성
        string _strQuery = "INSERT INTO member (" + _fieldsQuery + ") VALUES (" + _valuesQuery + ")";

        // 쿼리 실행"
        _result = m_MySqlAssist.ExcuteQuery(_Connection, _strQuery);

        // 성공 시 고유 코드를 반환
        if (_result > 0)
        {
          _result = _ucode;
        }
      }
      return _result;
    }

    public int DeleteMember(int _ucode)
    {

      int _result = 0;
      DbConnection _Connection = m_MySqlAssist.NewConnection();
      if (_Connection == null)
      {
        _result = -999;
      }
      else
      {
        string _strQuery = "DELETE FROM member ";
        _strQuery += $"WHERE mbr_ucode = {_ucode} ";

        _result = m_MySqlAssist.ExcuteQuery(_Connection, _strQuery);

        if (_result > 0)
        {
          _result = _ucode;
        }
      }
      return _result;
    }
    /*
SELECT rnt_ucode, 
	rnt_rent_date,  
	rnt_limit_date, 
	bk.bk_ucode, bk.bk_title,
	mbr_ucode,
	CASE 
	WHEN rnt_limit_date < NOW() THEN '연체중'
	ELSE '대출중'
	END AS rnt_state
	
	
	FROM rent AS rnt
	JOIN book AS bk ON rnt.bk_ucode = bk.bk_ucode
WHERE rnt_return_date IS NULL
AND mbr_ucode = 1     
     */
    public DataTable ReadRent(int _mbr_ucode)
    {
      DataTable _dt = null;  // DataTable 변수 선언
      DbConnection _Connection = m_MySqlAssist.NewConnection();  // DB 연결 생성

      if (_Connection != null)  // 연결이 성공한 경우
      {
        // SQL 쿼리 작성
        string _strQuery = "SELECT rnt_ucode, rnt_limit_date, bk.bk_title, ";
        _strQuery += "CASE ";
        _strQuery += "WHEN rnt_limit_date < NOW() THEN '연체중' ";
        _strQuery += "ELSE '대출중' ";
        _strQuery += "END AS rnt_state ";
        _strQuery += "FROM rent AS rnt ";
        _strQuery += "JOIN book AS bk ON rnt.bk_ucode = bk.bk_ucode ";
        _strQuery += $"WHERE rnt_return_date IS NULL AND mbr_ucode = {_mbr_ucode} ";

        // 회원 정보를 가져오는 쿼리 실행
        _dt = m_MySqlAssist.SelectQuery(_Connection, _strQuery, "rentaling");
      }
      return _dt;  // DataTable 반환

    }



  }
}
