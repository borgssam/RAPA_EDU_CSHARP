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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BookPro.Windows.Pops
{
  public partial class BookPop : MasterPop
  {
    private int m_ucode;
    public int Ucode{get{return m_ucode;}}
    private DataRow m_row=null;

    public BookPop()
    {
      InitializeComponent();
      
      InitializeObject();
      Application.Idle += ApplicationIdle;
    }
    private void InitializeObject()
    {
      DataTable _dt = App.Instance().DBManager.ReadCategory();
      this.cbox_category.Items.Clear();
      foreach (DataRow dr in _dt.Rows)
      {
        cbox_category.Items.Add(new NameObject<int>(dr["ctg_name"].ToString(), Convert.ToInt32(dr["ctg_ucode"])));
      }
      if (_dt.Rows.Count > 0) { cbox_category.SelectedIndex = 0; }


    }
    private void ApplicationIdle(object sender, EventArgs e)
    {

   
    }

    public override DialogResult ShowPop(WorkMode aWorkMode,ref object options)
    {
      if(aWorkMode == WorkMode.add)
      {
        DisplayAddMode();

      } else if(aWorkMode == WorkMode.edit)
      {
        this.Text = "도서관리 - 수정";
      }


      return base.ShowPop(aWorkMode,ref options);
    }

    private void ReadBook(){


    }

    private void DisplayAddMode() {
      this.Text = "도서관리 - 추가";
      tbox_title.Text = "";
      tbox_price.Text = "";
      tbox_pubs.Text = "";
      tbox_pub_year.Text = "";
      tbox_writer.Text = "";
      pbox_picture.Image = Bitmap.FromFile("./images/book.png");



    }


    private void DisplayBook() {


      
    }

    private void BookPop_Load(object sender, EventArgs e)
    {

    }

    private void btn_save_Click(object sender, EventArgs e)
    {
      int _result = -1;
      if (workMode == WorkMode.add) {
        MessageBox.Show("추가저장시작");
        string _title = tbox_title.Text;
        int _price = Convert.ToInt32(tbox_price.Text);
        string _pubs = tbox_pubs.Text;
        int _pub_year = Convert.ToInt32( tbox_pub_year.Text );
        string _writer = tbox_writer.Text;
        NameObject<int> _category = (NameObject<int>)cbox_category.SelectedItem;
        int _category_ucode = Convert.ToInt32(_category.Object);
        String _picture = BitAssist.ImageToHexString(pbox_picture.Image);
        if(_picture == "") { _picture = null; }
        _result = App.Instance().DBManager.AddBook( _title,_writer, _pubs, _price,_pub_year, _category_ucode, _picture);
        if(_result > 0)
        {
          this.Options = _result;
          MessageBox.Show("추가성공");
          DialogResult = DialogResult.OK;
        }
      } else if(workMode == WorkMode.edit)
      {
        MessageBox.Show("수정저장시작");

      }

    }

    private void btn_close_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }

		private void btn_file_Click(object sender, EventArgs e)
		{
      string img_file = string.Empty;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp";
      openFileDialog.InitialDirectory = Application.StartupPath;

      if(openFileDialog.ShowDialog() == DialogResult.OK)
      {
        img_file = openFileDialog.FileName;
        pbox_picture.Image = Bitmap.FromFile(img_file);
      }

		}
	}
}
