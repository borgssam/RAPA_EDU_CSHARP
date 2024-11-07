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
    private IniAssist iniAssist = new IniAssist();
    public String Addr
    { get { return tbox_addr.Text; } set { tbox_addr.Text = value; } }

    public int Port
    { get { return Convert.ToInt32(tbox_port.Text); } set { tbox_port.Text = value.ToString(); } }

    public String Id
    { get { return tbox_id.Text; } set { tbox_id.Text = value; } }

    public String Pwd
    { get { return tbox_pwd.Text; } set { tbox_pwd.Text = value; } }

    public String Database
    { get { return tbox_database.Text; } set { tbox_database.Text = value; } }
    
    public DBSettingPop()
    {
      InitializeComponent();
    }

    public override DialogResult ShowPop(WorkMode aWorkMode, ref object options)
    {
      //ini파일 데이터접속정보 읽어서 컨트롤에 넣기

      ReadIniFile();

      return base.ShowPop(aWorkMode,ref options);
    }

    private void ReadIniFile()
    {
      Addr     = iniAssist.ReadString("mysql", "addr", "localhost");
      Port     = iniAssist.ReadInteger("mysql", "port", 3306);
      Id       = iniAssist.ReadString("mysql", "id", "root");
      Pwd      = iniAssist.ReadString("mysql", "pwd", "1234");
      Database = iniAssist.ReadString("mysql", "database", "book");
    }

    private void DBSettingPop_Load(object sender, EventArgs e)
    {

    }

    private void btn_save_Click(object sender, EventArgs e)
    {
      iniAssist.WriteString("mysql", "addr", Addr);
      iniAssist.WriteInteger("mysql", "port", Port);
      iniAssist.WriteString("mysql", "id", Id);
      iniAssist.WriteString("mysql", "pwd",Pwd );
      iniAssist.WriteString("mysql", "database", Database);
      DialogResult = DialogResult.OK;
    }

    private void btn_close_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }
  }
}
