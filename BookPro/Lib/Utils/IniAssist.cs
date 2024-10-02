using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BookPro.Lib.Utils
{
  internal class IniAssist
  {    
    [DllImport("kernel32.dll")]
    private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpReturnedString, int nSize, string lpFileName);

    [DllImport("kernel32.dll")]
    private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
    [DllImport("kernel32.dll")]
    private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

    public string Path { get; set; }

    public IniAssist() { 
      Path = System.IO.Directory.GetCurrentDirectory()+"/information.ini";
    }
    public IniAssist(string path) { Path = path; }


    //세션에 해당 키가 존재
    public bool KeyExists(string aSection, string aKey)
    {
      return ReadString(aSection, aKey).Length > 0;
    }
    public void DeleteSection(String aSection)
    {
      WriteString(aSection, null, null);
    }
    public void DeleteKey(String aSection,string aKey)
    {
      WriteString(aSection, aKey, null);
    }
    //세션  (키 : 값)
    //읽고 
    public string ReadString(string aSection, string aKey) {
      return ReadString(aSection, aKey, "");
    }
    public string ReadString(string aSection, string aKey, string aDefault) {
      StringBuilder sb = new StringBuilder(255);
      int Flag = GetPrivateProfileString(aSection, aKey, aDefault, sb, 255, Path);
      return sb.ToString();
    }
    public int ReadInteger(string aSection, string aKey)
    {
      return ReadInteger(aSection, aKey, 0);
    }
    public int ReadInteger(string aSection, string aKey, int aDefault)
    {
      StringBuilder sb = new StringBuilder(255);
      int Flag = GetPrivateProfileString(aSection, aKey, aDefault.ToString(), sb, 255, Path);
      string strTempo = sb.ToString();
      if (sb.Length > 0) {
        return Convert.ToInt32(strTempo);
      } else {
        return 0;
      }
    }

    //쓰고
    public long WriteString(string aSection, string aKey, string aValue)
    {
      return WritePrivateProfileString(aSection, aKey, aValue, Path);
    }

    public long WriteInteger(string aSection, string aKey, int aValue)
    {
      return WritePrivateProfileString(aSection, aKey, aValue.ToString(), Path);
    }


  }
}
