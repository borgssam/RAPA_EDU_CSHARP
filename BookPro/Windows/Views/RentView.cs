﻿using BookPro.Lib.Manager;
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
      cbox_rent_status.SelectedIndex = 0;

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
      

		}
    private void DisplayDataSet(DataTable dt) {       


    }

    private void fetch_rent(DataRow src, ref DataRow dest) {


    
  

    }

	}
}
