using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookPro.Lib.Manager;
using BookPro.Lib.Utils;
using BookPro.Windows.Pops;
using ZstdSharp.Unsafe;

namespace BookPro.Windows.Views
{
  public partial class BookView : MasterView
  {
    public BookView()
    {
      InitializeComponent();

      InitializeObject();
    }
    private void InitializeObject(){
      DataTable _dt = App.Instance().DBManager.ReadCategory();
      this.cbox_category.Items.Clear();
      foreach (DataRow dr in _dt.Rows) {
        cbox_category.Items.Add(new NameObject<int>(dr["ctg_name"].ToString(), Convert.ToInt32(dr["ctg_ucode"])));
      }
      if(_dt.Rows.Count > 0) { cbox_category.SelectedIndex = 0; }

      cbox_searchkind.SelectedIndex = 0;
    }

    private void BookView_Load(object sender, EventArgs e)
    {

    }

    private void btn_add_book_Click(object sender, EventArgs e)
    {
      Object _ucode = -1;
      DialogResult _result = App.Instance().PopManager.ShowPop(typeof(BookPop),WorkMode.add,ref _ucode);
      if(_result == DialogResult.OK)
      {
        DataRow dr = App.Instance().DBManager.ReadBook((int)_ucode);

        DataTable dsp_dt = this.DisplaySet.Tables["Book"];
        DataRow dspRow = dsp_dt.NewRow();
        fetch(dr,ref dspRow);
        dsp_dt.Rows.Add(dspRow);

        int lastRowIndex = grid_book.Rows.Count - 1;
        grid_book.Rows[lastRowIndex].Selected = true;
        grid_book.CurrentCell = grid_book.Rows[lastRowIndex].Cells[0];



      }
     

    }


		private void cbox_searchkind_SelectedIndexChanged(object sender, EventArgs e)
		{
      //제목  0
      //분류  1
      //저자  2
      //출판사 3
      if (cbox_searchkind.SelectedIndex == 1) {
        pnl_category.Visible = true; pnl_keyword.Visible = false;
      } else
      {
        pnl_category.Visible = false; pnl_keyword.Visible = true;
      }
    }

		private void btn_search_Click(object sender, EventArgs e)
		{
      NameObject<int> _category = (NameObject<int>)cbox_category.SelectedItem;
      // 키:_category.Name
      // 값:_category.Object
      int _ctg_ucode = Convert.ToInt32(_category.Object);
      //제목  0
      //분류  1
      //저자  2
      //출판사 3
      DataTable _dt = App.Instance().DBManager.ReadBook(cbox_searchkind.SelectedIndex, tbox_keyword.Text, _ctg_ucode);
      DisplayDataSet(_dt);

		}

    private void DisplayDataSet(DataTable dt)
    {
      DataTable dsp_dt = this.DisplaySet.Tables["Book"];
      dsp_dt.Rows.Clear();
      foreach (DataRow dr in dt.Rows)
      {
        DataRow dspRow = dsp_dt.NewRow();
        fetch( dr, ref dspRow);
        dsp_dt.Rows.Add(dspRow);
      }
    }

    private void fetch(DataRow src, ref DataRow dst)
    {
      dst["bk_ucode"] = src["bk_ucode"];
      dst["bk_title"] = src["bk_title"];
      dst["bk_writer"] = src["bk_writer"];
      dst["bk_pubs"] = src["bk_pubs"];
      dst["bk_price"] = src["bk_price"];
      dst["bk_pub_year"] = src["bk_pub_year"];
      dst["bk_regdate"] = src["bk_regdate"];
      dst["bk_erasedate"] = src["bk_erasedate"];
      //dst["bk_create_ucode"] = src["bk_create_ucode"];
      //dst["bk_create_date"] = src["bk_create_date"];
      //dst["bk_modify_ucode "] = src["bk_modify_ucode"];
      //dst["bk_modify_date"] = src["bk_modify_date"];
      //dst["ctg_ucode"] = src["ctg_ucode"];
      dst["ctg_name"] = src["ctg_name"];

    }



		private void grid_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}


    private void grid_book_MouseDoubleClick(object sender, MouseEventArgs e)
		{
      DataRow _row = GridAssist.SelectedRow(grid_book);
      Object _ucode = _row["bk_ucode"]; 
      DialogResult _result = App.Instance().PopManager.ShowPop(typeof(BookPop), WorkMode.edit, ref _ucode);

      if(_result == DialogResult.OK)
      {
        DataRow _new_row = App.Instance().DBManager.ReadBook((int)_ucode);
        fetch(_new_row, ref _row);

      }

		}

    private void btn_delete_book_Click(object sender, EventArgs e)
    {
      if(MessageBox.Show("정말삭제하시겠습니까?","",MessageBoxButtons.YesNo) == DialogResult.Yes) {
      
        DataRow _row = GridAssist.SelectedRow(grid_book);
        int _ucode = Convert.ToInt32(_row["bk_ucode"]);

        int result = App.Instance().DBManager.DeleteBook(_ucode);
        if(result >0)
        {
          MessageBox.Show("삭제성공");
          DataTable _dsp_dt = this.DisplaySet.Tables["Book"];
          DataRow[] deleteRows = _dsp_dt.Select($"bk_ucode={_ucode}");
          foreach(DataRow row in deleteRows)
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


		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void cbox_category_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
