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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BookPro.Windows.Pops
{
  public partial class BookPop : MasterPop
  {
    public BookPop()
    {
      InitializeComponent();
    }
    public override DialogResult ShowPop(WorkMode aWorkMode, object options)
    {
      if(aWorkMode == WorkMode.add)
      {
        DisplayAddMode();
        
      } else if(aWorkMode == WorkMode.edit)
      {
        DisplayEditMode(options);
      }
      return base.ShowPop(aWorkMode, options);
    }

    private void DisplayAddMode() {
      this.Text = "도서관리 - 등록";
      //모든컨트롤을 초기화
      tbox_title.Text = "";
    }
    private void DisplayEditMode(object option) {
      this.Text = "도서관리 - 수정";
      if (option != null) { 
        int code = (int)option;
        //DB 해당 도서정보 얻어오고
        //각컨트롤에 값을 대입
        tbox_title.Text = "홍길동전";
      }
    }

    private void BookPop_Load(object sender, EventArgs e)
    {

    }

    private void btn_save_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
    }

    private void btn_close_Click(object sender, EventArgs e)
    {
      this.DialogResult= DialogResult.Cancel;
    }
  }
}
