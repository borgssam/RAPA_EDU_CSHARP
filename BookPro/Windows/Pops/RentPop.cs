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
			//제목
			//저자
			//출판사
			int _searchIndex = cbox_kind_book.SelectedIndex;
			string _keyword = tbox_keyword_book.Text;
      m_book_table = App.Instance().DBManager.ReadBook(_searchIndex, _keyword);

			DisplayBook();





    }
    
    private void DisplayBook(){
			if(m_book_table == null) { return; }
			//List <int> stat
			string _filter = "";
			if(cbtn_stay.Checked && !cbtn_rent.Checked) { _filter = "rnt_state IN ('대기중') "; }
			else if(!cbtn_stay.Checked && cbtn_rent.Checked) { _filter = "rnt_state IN ('연체중','대출중') "; }
	
			DataRow[] rows = m_book_table.Select(_filter);

			DataTable _dspDT = DisplaySet.Tables["Book"];
			_dspDT.Rows.Clear();
			foreach(DataRow row in rows)
			{
				DataRow _dspRow = _dspDT.NewRow();
        _dspRow["bk_ucode"] = row["bk_ucode"];
        _dspRow["bk_title"] = row["bk_title"];
        _dspRow["bk_writer"] = row["bk_writer"];
        _dspRow["rnt_state"] = row["rnt_state"];

        _dspDT.Rows.Add(_dspRow);

			}

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
			DataRow _selectedRow = GridAssist.SelectedRow(grid_member);
			if(_selectedRow != null)
			{
				m_mbr_ucode = Convert.ToInt32(_selectedRow["mbr_ucode"]);
				DisplayMemberInfo();
				DisplayRenting(m_mbr_ucode);

      }
		}

    private void DisplayMemberInfo(){
			DataRow row = App.Instance().DBManager.ReadMember(m_mbr_ucode);
			label_mbr_name.Text = row["mbr_name"].ToString();
			label_mbr_phone.Text = row["mbr_phone"].ToString();
			label_rnt_state.Text = row["rnt_state"].ToString();
			string gender = row["mbr_gender"].ToString();
			if (gender == "m") { label_mbr_gender.Text = "남성"; } else { label_mbr_gender.Text = "여성"; }
			string picture = row["mbr_picture"].ToString();
			if (picture != null && picture.Length > 0) {
				pbox_picture_member.Image = BitAssist.HexStringToImage(picture);
			} else if (gender == "m") {
				pbox_picture_member.Image = Bitmap.FromFile("./images/boy.pny");
			} else
      {
        pbox_picture_member.Image = Bitmap.FromFile("./images/girl.jpg");
      }
		}

    private void DisplayRenting(int _mbr_ucode){
			DataTable dt = App.Instance().DBManager.ReadRent(_mbr_ucode);
			if (dt != null)
			{
				DataTable _dspDT = this.DisplaySet.Tables["RentaledBook"];
				_dspDT.Rows.Clear();
				foreach (DataRow dr in dt.Rows)
				{
					DataRow _dspRow = _dspDT.NewRow();
          _dspRow["rnt_ucode"] = dr["rnt_ucode"];
          _dspRow["rnt_limit_date"] = dr["rnt_limit_date"];
          _dspRow["bk_title"] = dr["bk_title"];
          _dspRow["rnt_state"] = dr["rnt_state"];
          _dspDT.Rows.Add(_dspRow);
				}      
      }
    }

    private void fetch_member(DataRow dr){
      
 

    }
    private void DisplayMember(int _ucode){


    }
		private void cbtn_stay_CheckedChanged(object sender, EventArgs e)
		{
			DisplayBook();
    }

		private void cbtn_rent_CheckedChanged(object sender, EventArgs e)
		{
			DisplayBook();
    }

		private void grid_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void grid_book_SelectionChanged(object sender, EventArgs e)
		{

			DataRow _row = GridAssist.SelectedRow(grid_book);
			if (_row != null)
			{
				int _bk_ucode = Convert.ToInt32(_row["bk_ucode"]);
				DataRow _src_row = App.Instance().DBManager.ReadBookInfo(_bk_ucode);
				this.label_bk_title.Text = _src_row["bk_title"].ToString();
				this.label_bk_writer.Text = _src_row["bk_writer"].ToString();
				this.label_bk_state.Text = _src_row["rnt_state"].ToString();
				this.label_ctg_name.Text = _src_row["ctg_name"].ToString();

				string picture = _src_row["bk_picture"].ToString();
				if (picture.Length > 0)
				{
					pbox_picture_book.Image = BitAssist.HexStringToImage(picture);
				}
				else
				{
					pbox_picture_book.Image = Bitmap.FromFile("./images/book.png");

				}
			}


    }

		private void btn_add_cart_Click(object sender, EventArgs e)
		{
			DataRow _selectedRow = GridAssist.SelectedRow(grid_book);
			if(_selectedRow != null)
      {
        int _ucode = Convert.ToInt32(_selectedRow["bk_ucode"]);
        string _rnt_state = Convert.ToString(_selectedRow["rnt_state"]);
        DataTable _cartDT = DisplaySet.Tables["Cart"];
				DataRow[] _carts = _cartDT.Select("bk_ucode=" + _ucode);
				if (_carts.Length > 0)
				{
					MessageBox.Show("이미 카드에 담겨있습니다.");
				} else if (_rnt_state != "대기중") {

          MessageBox.Show("이미 대여(연체)중인 도서는 카드에 담을 수가 없습니다.");
        } else
				{
					DataRow _cartRow = _cartDT.NewRow();
          _cartRow["bk_ucode"] = _selectedRow["bk_ucode"];
          _cartRow["bk_title"] = _selectedRow["bk_title"];
          _cartRow["bk_writer"] = _selectedRow["bk_writer"];
          _cartRow["rnt_state"] = _selectedRow["rnt_state"];

          _cartDT.Rows.Add(_cartRow);
				}			
			}
		}

		private void btn_sub_cart_Click(object sender, EventArgs e)
		{
			DataRow _selectedRow = GridAssist.SelectedRow(grid_cart);
			if(_selectedRow != null)
			{
				DataTable _cartDT = DisplaySet.Tables["Cart"];
				_cartDT.Rows.Remove(_selectedRow);
			} else
			{
				MessageBox.Show("카트에서 삭제하실 도서를 선택하세요");
			}

    }

		private void btn_return_book_Click(object sender, EventArgs e)
		{      


		}

		private void btn_lost_book_Click(object sender, EventArgs e)
		{      


		}


		private void btn_add_rent_Click(object sender, EventArgs e)
		{
			DataTable _dt = DisplaySet.Tables["Cart"];
			if (_dt.Rows.Count == 0)
			{
				MessageBox.Show("카트에 담긴 도서가 없습니다.");
			}
			else if (m_mbr_ucode <= 0)
			{
				MessageBox.Show("대여할 회원을 선택하세요");
			}
			else
			{
				List<int> bookUcodes = new List<int>();
				foreach (DataRow row in _dt.Rows)
				{
					bookUcodes.Add(Convert.ToInt32(row["bk_ucode"]));
				}

				int result = App.Instance().DBManager.AddRent(m_mbr_ucode, bookUcodes);
				if (result > 0) {
					MessageBox.Show("대여성공");
					DataRow _mbr_dr = App.Instance().DBManager.ReadMember(m_mbr_ucode);
					if (_mbr_dr != null)
					{
						DataRow _mbrRow = GridAssist.SelectedRow(grid_member);
						_mbrRow["rnt_state"] = _mbr_dr["rnt_state"];
            label_rnt_state.Text = _mbr_dr["rnt_state"].ToString();

            DisplayRenting(m_mbr_ucode);

          }

				}
			}



		}
	}
}