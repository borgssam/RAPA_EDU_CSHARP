using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPro.Lib.Utils
{
  public static class DBInfo
  {
    public static string addr = "localhost";
    public static int port = 3306;
    public static string id = "";
    public static string pwd = "";
    public static string database = "";
  }
  public static class StaffInfo{
    public static string id = "";
    public static string name = "";
  }
  
  
  public static class Constants
  {
    // Static 딕셔너리 선언 및 초기화
    public static Dictionary<string, string> work_states = new Dictionary<string, string>()
    {
      { "w", "근무중"},
      { "h", "휴무중"},
      { "g", "정직"},
      { "r", "퇴사"}
    };

    public static Dictionary<string, string> gender = new Dictionary<string, string>()
    {
      { "m", "남성"},
      { "w", "여성"}
    };
  }
}
