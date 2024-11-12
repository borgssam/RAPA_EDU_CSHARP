using BookPro.Lib.Manager;
using BookPro.Lib.Utils;
using BookPro.Windows.Pops;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookPro.Windows.Views
{
  public partial class RentView : MasterView
  {
    public RentView()
    {
      InitializeComponent();
      InitializeObject();
    }

    private void InitializeObject(){
      cbox_searchkind.SelectedIndex = 0;
      cbox_rent_state.SelectedIndex = 0;

    }

    private void RentView_Load(object sender, EventArgs e)
    {

    }

		private void btn_rental_Click(object sender, EventArgs e)
		{
      App.Instance().PopManager.ShowPop(typeof(RentPop), WorkMode.none);
		}

		private void cbox_searchkind_SelectedIndexChanged(object sender, EventArgs e)
		{
      //대출일
      //반납예정일
      //반납일
      //대여상태
      //회원이름
      //회원연락처
      switch (cbox_searchkind.SelectedIndex)
      {
        case 0:
        case 1:
        case 2:
          pnl_date.Visible = true;
          pnl_rent_status.Visible = false;
          pnl_keyword.Visible = false;
          break;
        case 3:
          pnl_date.Visible = false;
          pnl_rent_status.Visible = true;
          pnl_keyword.Visible = false;
          break;
        case 4:
        case 5:
          pnl_date.Visible = false;
          pnl_rent_status.Visible = false;
          pnl_keyword.Visible = true;
          break;
        default:
          break;


      }


    }

    private void btn_search_Click(object sender, EventArgs e)
		{
      //0.대출일
      //1.반납예정일
      //2.반납일
      //3.대여상태
      //4.회원이름
      //5.회원연락처

      DataTable _dt = App.Instance().DBManager.ReadRent(cbox_searchkind.SelectedIndex, tbox_keyword.Text, date_begin.Value, date_end.Value, cbox_rent_state.SelectedIndex);
      if (_dt != null)
      {
        DisplayRent(_dt);
      }


    }
    private void DisplayRent(DataTable dt) {
      DataTable _dspDT = DisplaySet.Tables["Rent"];
      _dspDT.Rows.Clear();
      foreach (DataRow dr in dt.Rows)
      {
        DataRow _dspRow = _dspDT.NewRow();

        //대여번호, 도서이름, 대여상태, 회원이름,회원연락처, 대여일, 반납예정일 반납일
        _dspRow["rnt_ucode"] = dr["rnt_ucode"];
        _dspRow["bk_title"] = dr["bk_title"];
        _dspRow["rnt_state"] = dr["rnt_state"];
        _dspRow["mbr_name"] = dr["mbr_name"];
        _dspRow["mbr_phone"] = dr["mbr_phone"];
        _dspRow["rnt_rent_date"] = dr["rnt_rent_date"];
        _dspRow["rnt_limit_date"] = dr["rnt_limit_date"];
        _dspRow["rnt_return_date"] = dr["rnt_return_date"];
        _dspDT.Rows.Add(_dspRow);

      }

    }

    private void fetch_rent(DataRow src, ref DataRow dest) {


    
  

    }

	}
}
