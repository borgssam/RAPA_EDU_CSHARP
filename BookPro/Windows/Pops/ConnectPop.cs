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
  public partial class ConnectPop : MasterPop
  {
    public ConnectPop()
    {
      InitializeComponent();
    }

    private void ConnectPop_Load(object sender, EventArgs e)
    {

    }

		private void btn_connect_Click(object sender, EventArgs e)
		{
      DataTable _dt = App.Instance().DBManager.ReadStaff(tbox_id.Text, tbox_pwd.Text);
      if (_dt != null && _dt.Rows.Count == 1)
      {
        String _work_state = _dt.Rows[0]["stf_work_state"].ToString();
        if (_work_state == "w")
        {
          StaffInfo.name = _dt.Rows[0]["stf_name"].ToString();
          StaffInfo.id = _dt.Rows[0]["stf_id"].ToString();
          //MessageBox.Show("접속성공");
          DialogResult = DialogResult.OK;
        } else
        {
          MessageBox.Show("현재 근무중이 아닙니다.");
        }
      } else {
        MessageBox.Show("접속실패");
      }


		}
	}
}
