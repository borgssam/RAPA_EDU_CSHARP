using BookPro.Lib.Manager;
using BookPro.Lib.Utils;
using BookPro.Windows.Pops;
using BookPro.Windows.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookPro
{
  public partial class MainForm : Form
  {
    private ViewManager viewManager;
    private PopManager popManager;  
    private DBManager dbManager;
    public MainForm()
    {
      InitializeComponent();

      InitializeObject();

      Application.Idle += ApplicationIdle;
    }
    private void ApplicationIdle(object sender, EventArgs e)
    {
      
      if( StaffInfo.id == "" ){ 
        //로그아웃상태면
        this.Text = "도서관리프로그램";
        this.mbtn_login.Enabled = true;
        this.mbtn_logout.Enabled = false;

        this.mbtn_book.Enabled = false;
        this.mbtn_member.Enabled = false;
        this.mbtn_rent.Enabled = false;
        this.mbtn_staff.Enabled = false;

        this.tbtn_book.Enabled = false;
        this.tbtn_member.Enabled = false;
        this.tbtn_rent.Enabled = false;
      } else{

        this.Text = $"도서관리프로그램 ( { StaffInfo.name } )" ;
        this.mbtn_login.Enabled = false;
        this.mbtn_logout.Enabled = true;

        this.mbtn_book.Enabled = true;
        this.mbtn_member.Enabled = true;
        this.mbtn_rent.Enabled = true;
        this.mbtn_staff.Enabled = true;

        this.tbtn_book.Enabled = true;
        this.tbtn_member.Enabled = true;
        this.tbtn_rent.Enabled = true;

      }

      //회원관리가 보여지면
      tbtn_member.Checked = mbtn_member.Checked = viewManager.IsVisibleView(typeof(MemberView));
      //도서관리가 보여지면
      tbtn_book.Checked = mbtn_book.Checked = viewManager.IsVisibleView(typeof(BookView));
      //대여관리가 보여지면
      tbtn_rent.Checked = mbtn_rent.Checked = viewManager.IsVisibleView(typeof(RentView));
    }
    private void InitializeObject()
    {
      viewManager = new ViewManager();
      popManager = new PopManager();
      App.Instance().PopManager = popManager;
      dbManager = new DBManager();
      App.Instance().DBManager = dbManager; 
      SetDBInfo();


      login();
    }

    private void SetDBInfo()
    {
      IniAssist iniAssist = new IniAssist();
			DBInfo.addr = iniAssist.ReadString("mysql", "addr", "localhost");
			DBInfo.port = iniAssist.ReadInteger("mysql", "port", 3306);
			DBInfo.id = iniAssist.ReadString("mysql", "id", "root");
			DBInfo.pwd = iniAssist.ReadString("mysql", "pwd", "1234");
			DBInfo.database = iniAssist.ReadString("mysql", "database", "mydb");
			dbManager.SetConnectInfo(DBInfo.addr, DBInfo.port, DBInfo.id, DBInfo.pwd, DBInfo.database);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void tbtn_book_Click(object sender, EventArgs e)
    {
      ShowBookView(); ;

    }

    private void mbtn_book_Click(object sender, EventArgs e)
    {
      ShowBookView();
    }

    private void ShowBookView()
    {
      viewManager.ShowView(work_space, typeof(BookView));
    }

    private void tbtn_member_Click(object sender, EventArgs e)
    {
      ShowMemberView();

    }

    private void mbtn_member_Click(object sender, EventArgs e)
    {
      ShowMemberView();

    }
    private void ShowMemberView()
    {
      viewManager.ShowView(work_space, typeof(MemberView));

    }
    private void tbtn_rent_Click(object sender, EventArgs e)
    {
      ShowRentView();
    }

    private void mbtn_rent_Click(object sender, EventArgs e)
    {
      ShowRentView();
    }
    private void ShowRentView()
    {
      viewManager.ShowView(work_space, typeof(RentView));
    }

    private void tbtn_exit_Click(object sender, EventArgs e)
    {
      ApplicationExit();
    }

    private void mbtn_exit_Click(object sender, EventArgs e)
    {
      ApplicationExit();

    }

    private void ApplicationExit() {
      DialogResult _result = MessageBox.Show("정말 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo);
      if (_result == DialogResult.Yes) {
        Application.Exit();
      }

    }

    private void mbtn_setting_Click(object sender, EventArgs e)
    {
      //DBSettingPop _pop = new DBSettingPop();
      //DialogResult _popResult = _pop.ShowDialog();       
      DialogResult _popResult = App.Instance().PopManager.ShowPop(typeof(DBSettingPop), Lib.Utils.WorkMode.none);
      if (_popResult == DialogResult.OK)
      {
        SetDBInfo();

      } else
      {
        MessageBox.Show("대화상자가 cancel로 닫혔습니다.");
      }
    }

    private void mbtn_tool_Click(object sender, EventArgs e)
    {


    }

		private void mbtn_staff_Click(object sender, EventArgs e)
		{
      App.Instance().PopManager.ShowPop(typeof(StaffPop), WorkMode.none);

		}

		private void mbtn_login_Click(object sender, EventArgs e)
		{
      login();
    }

    private void login()
    {
      DialogResult _result = App.Instance().PopManager.ShowPop(typeof(ConnectPop), WorkMode.none);
      if (_result == DialogResult.OK)
      {
      }
    }

		private void mbtn_logout_Click(object sender, EventArgs e)
		{
      if(MessageBox.Show("로그아웃 하시겠습니까?","",MessageBoxButtons.YesNo) == DialogResult.Yes){
        StaffInfo.id = StaffInfo.name = "";
      }
		}
	}
}
