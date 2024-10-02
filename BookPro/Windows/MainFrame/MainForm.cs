using BookPro.Lib.Manager;
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
    public MainForm()
    {
      InitializeComponent();

      InitializeObject();

      Application.Idle += ApplicationIdle;
    }
    private void ApplicationIdle(object sender, EventArgs e)
    {
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
      DialogResult _popResult = App.Instance().PopManager.ShowPop(typeof(DBSettingPop), Lib.Utils.WorkMode.none, null);
    }
  }
}
