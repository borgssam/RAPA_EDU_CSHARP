using BookPro.Lib.Manager;
using BookPro.Lib.Utils;
using BookPro.Windows.Pops;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookPro.Windows.Views
{
  public partial class MemberView : MasterView
  {
    public MemberView()
    {
      InitializeComponent();
      InitializeObject();
    }

    private void InitializeObject(){

      cbox_rent_status.SelectedIndex = 0;
      cbox_searchkind.SelectedIndex = 0;

    }

    private void MemberView_Load(object sender, EventArgs e)
    {

    }

    private void cbox_searchkind_SelectedIndexChanged(object sender, EventArgs e)
    {

      switch (cbox_searchkind.SelectedIndex)
      {
        case 0:
          //이름
          this.pnl_keyword.Visible = true;
          this.pnl_rent_status.Visible = false;

          break;
        case 1:
          //연락처
          this.pnl_keyword.Visible = true;
          this.pnl_rent_status.Visible = false;
          break;
        case 2:
          //대출상태
          this.pnl_keyword.Visible = false;
          this.pnl_rent_status.Visible = true;
          break;
      }
    }

		private void btn_search_Click(object sender, EventArgs e)
    {
      DataTable _dt = App.Instance().DBManager.ReadMember(cbox_searchkind.SelectedIndex, tbox_keyword.Text, cbox_rent_status.SelectedIndex);
      DisplayDataSet(_dt);


    }
    private void fetch(DataRow src, ref DataRow dest)
    {
      dest["mbr_ucode"] = src["mbr_ucode"];
      dest["mbr_name"] = src["mbr_name"];
      dest["mbr_id"] = src["mbr_id"];
      dest["mbr_pwd"] = src["mbr_pwd"];
      dest["mbr_gender"] = (src["mbr_gender"].ToString() == "m") ? "남자" : "여자";
      dest["mbr_phone"] = src["mbr_phone"];
      dest["mbr_addr"] = src["mbr_addr"];
    }

    private void DisplayDataSet(DataTable dt)
    {
      DataTable dspDT = this.DisplaySet.Tables["Member"];
      dspDT.Rows.Clear();
      foreach (DataRow dr in dt.Rows)
      {
        DataRow dspRow = dspDT.NewRow();
        fetch(dr, ref dspRow);
        dspDT.Rows.Add(dspRow);
      }
    }


    private void btn_add_member_Click(object sender, EventArgs e)
    {
      Object options = null;

      DialogResult _rt = App.Instance().PopManager.ShowPop(typeof(MemberPop), WorkMode.add, ref options);

      if (_rt == DialogResult.OK)
      {
        if (options != null)
        {
          DataRow dr = App.Instance().DBManager.ReadMember((int)options);
          DataTable dspDT = this.DisplaySet.Tables["Member"];
          DataRow dspRow = dspDT.NewRow();
          fetch(dr, ref dspRow);
          dspDT.Rows.Add(dspRow);

          int lastRowIndex = grid_member.Rows.Count - 1;
          grid_member.Rows[lastRowIndex].Selected = true;

          // 마지막 행을 포커스로 설정
          grid_member.CurrentCell = grid_member.Rows[lastRowIndex].Cells[0];
        }
      }

    }

		private void grid_member_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      DataRow _sel_row = GridAssist.SelectedRow(grid_member);

      if (_sel_row != null)
      {
        int _ucode = Convert.ToInt32(_sel_row["mbr_ucode"]);
        Object _obj = _ucode;
        DialogResult _rt = App.Instance().PopManager.ShowPop(typeof(MemberPop), WorkMode.edit, ref _obj);
        if (_rt == DialogResult.OK)
        {
          DataRow dr = App.Instance().DBManager.ReadMember((int)_ucode);
          DataTable dspDT = this.DisplaySet.Tables["Member"];

          // bk_ucode가 3인 행을 선택
          DataRow[] updateRows = dspDT.Select($"mbr_ucode = {_ucode}");

          for (int i = 0; i < updateRows.Length; i++)
          {
            //var dspRow = rowsToDelete[i];
            fetch(dr, ref updateRows[i]);
          }
          // 선택된 행 값수정
          //foreach (DataRow dspRow in rowsToDelete)
          //{
          //  fetch(dr, ref dspRow);
          //}

          // DataTable에 삭제 반영
          dspDT.AcceptChanges();
        }
      }

    }

    private void btn_delete_member_Click(object sender, EventArgs e)
    {

      if (MessageBox.Show("정말삭제하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {

        DataRow _row = GridAssist.SelectedRow(grid_member);
        int _ucode = Convert.ToInt32(_row["mbr_ucode"]);

        int result = App.Instance().DBManager.DeleteMember(_ucode);
        if (result > 0)
        {
          MessageBox.Show("삭제성공");
          DataTable _dsp_dt = this.DisplaySet.Tables["Member"];
          DataRow[] deleteRows = _dsp_dt.Select($"mbr_ucode={_ucode}");
          foreach (DataRow row in deleteRows)
          {
            row.Delete();
          }
          _dsp_dt.AcceptChanges();
        }
        else
        {
          MessageBox.Show("삭제실패");
        }
      }
    }
  }
}
