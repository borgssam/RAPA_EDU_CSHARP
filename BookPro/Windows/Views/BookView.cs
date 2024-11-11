using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookPro.Lib.Manager;
using BookPro.Lib.Utils;
using BookPro.Windows.Pops;

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


		}




		private void grid_book_MouseDoubleClick(object sender, MouseEventArgs e)
		{


		}

    private void btn_delete_book_Click(object sender, EventArgs e)
    {

    }

		private void grid_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void cbox_category_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
