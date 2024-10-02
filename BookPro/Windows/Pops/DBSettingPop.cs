using BookPro.Lib.Manager;
using BookPro.Lib.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookPro.Windows.Pops
{
  public partial class DBSettingPop : MasterPop
  {
    IniAssist iniAssist = new IniAssist();

    public String Addr
    {
      get { return tbox_addr.Text; }
      set
      {
        this.tbox_addr.Text = value;
      }
    }
    public int Port
    {
      get { return Convert.ToInt32(tbox_port.Text); }
      set
      {
        this.tbox_port.Text = value.ToString();
      }
    }
    public String Id
    {
      get { return tbox_id.Text; }
      set
      {
        this.tbox_id.Text = value;
      }
    }
    public String Pwd
    {
      get { return tbox_pwd.Text; }
      set
      {
        this.tbox_pwd.Text = value;
      }
    }
    public String Database
    {
      get { return tbox_database.Text; }
      set
      {
        this.tbox_database.Text = value;
      }
    }

    public DBSettingPop()
    {
      InitializeComponent();
    }

    public override DialogResult ShowPop(WorkMode aWorkMode, object options)
    {
      ReadIniFile();

      return base.ShowPop(aWorkMode, options);
    }

    private void ReadIniFile()
    {
      //주소, 포트, 아이디, 비번, 데이터베이스(계정)
      Addr = iniAssist.ReadString("mysql", "addr", "localhost");
      Port = iniAssist.ReadInteger("mysql", "port", 3306);
      Id = iniAssist.ReadString("mysql", "id", "root");
      Pwd = iniAssist.ReadString("mysql", "pwd", "1234");
      Database = iniAssist.ReadString("mysql", "database", "mydb");
    }

    private void DBSettingPop_Load(object sender, EventArgs e)
    {

    }

    private void btn_save_Click(object sender, EventArgs e)
    {
      iniAssist.WriteString("mysql", "addr", Addr);
      iniAssist.WriteInteger("mysql", "port", Port);
      iniAssist.WriteString("mysql", "id", Id);
      iniAssist.WriteString("mysql", "pwd", Pwd);
      iniAssist.WriteString("mysql", "database", Database);
      DialogResult = DialogResult.OK;
    }

    private void btn_close_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }
  }
}
