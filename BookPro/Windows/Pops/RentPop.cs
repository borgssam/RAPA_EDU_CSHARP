using BookPro.Lib.Manager;
using BookPro.Lib.Utils;
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

namespace BookPro.Windows.Pops
{
  public partial class RentPop : MasterPop
  {
    public RentPop()
    {
      InitializeComponent();
      InitializeObject();
    }

    private void InitializeObject(){
			cbox_kind_book.SelectedIndex = 0;
			cbox_kind_member.SelectedIndex = 0;

    }

    private void RentPop_Load(object sender, EventArgs e)
    {

    }

    private DataTable m_book_table;

		private void btn_search_book_Click(object sender, EventArgs e)
		{



		}
    
    private void DisplayBook(){


    }


		private void btn_search_member_Click(object sender, EventArgs e)
		{
			//회원 이름
			//회원 연락처
			DataTable _dt = App.Instance().DBManager.ReadMember(cbox_kind_member.SelectedIndex, this.tbox_keyword_member.Text);
			DisplayMember(_dt);

    }


    private void DisplayMember(DataTable dt){
			DataTable _dspDT = this.DisplaySet.Tables["Member"];
      _dspDT.Rows.Clear();
			foreach(DataRow _src in dt.Rows)
			{
				DataRow _dspRow = _dspDT.NewRow();
        _dspRow["mbr_ucode"] = _src["mbr_ucode"];
        _dspRow["mbr_name"] = _src["mbr_name"];
        _dspRow["mbr_phone"] = _src["mbr_phone"];
        _dspRow["rnt_state"] = _src["rnt_state"];
        _dspDT.Rows.Add(_dspRow);			
			}


    }

    private void fetch_member(DataRow src,ref DataRow dest){


    }
    
		private void grid_member_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
    private int m_mbr_ucode = -1;
		private void grid_member_SelectionChanged(object sender, EventArgs e)
		{ 

		}

    private void DisplayMemberInfo(){ 


      
    }

    private void DisplayRenting(int _mbr_ucode){


    }
    private void fetch_member(DataRow dr){
      
 

    }
    private void DisplayMember(int _ucode){


    }
		private void cbtn_stay_CheckedChanged(object sender, EventArgs e)
		{
      

		}

		private void cbtn_rent_CheckedChanged(object sender, EventArgs e)
		{
      

		}

		private void grid_book_SelectionChanged(object sender, EventArgs e)
		{


		}

		private void btn_add_cart_Click(object sender, EventArgs e)
		{


		}

		private void grid_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btn_sub_cart_Click(object sender, EventArgs e)
		{


    }

		private void btn_return_book_Click(object sender, EventArgs e)
		{      


		}

		private void btn_lost_book_Click(object sender, EventArgs e)
		{      


		}


		private void btn_add_rent_Click(object sender, EventArgs e)
		{


		}
	}
}