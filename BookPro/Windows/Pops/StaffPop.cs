using BookPro.Lib.Manager;
using BookPro.Lib.Utils;
using BookPro.Windows.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookPro.Windows.Pops
{
  public partial class StaffPop : MasterPop
  {
    private int m_stf_ucode = -1;

    public StaffPop()
    {
      InitializeComponent();
      InitializeObject();
      Application.Idle += ApplicationIdle;
    }
    private void ApplicationIdle(object sender, EventArgs e)
    {
			if (this.workMode == WorkMode.add)
      {
				this.Text = "사원관리 - 추가";
        this.btn_save.Text = "저장";
      }
      else if (this.workMode == WorkMode.edit)
      {
        this.Text = "사원관리 - 수정";
        this.btn_save.Text = "저장";
      }
      else if (this.workMode == WorkMode.read)
      {
        this.Text = "사원관리 - 조회";
        this.btn_save.Text = "퇴사";
      }
      else if (this.workMode == WorkMode.delete)
      {
      } else
      {
        this.Text = "사원관리 - 조회";

      } 


    }

    public void InitializeObject(){
			cbox_kind.Items.Clear();
      cbox_kind.Items.Add(new NameObject<String>("이름", "stf_name"));
      cbox_kind.Items.Add(new NameObject<String>("아이디", "stf_id"));
      cbox_kind.SelectedIndex = 0;

      cbox_work_state.Items.Clear();

      foreach(var item in Constants.work_states)
      {
        cbox_work_state.Items.Add(new NameObject<string>( item.Value.ToString(), item.Key ));
      }
      cbox_work_state.SelectedIndex = 0;



    }

    private void StaffPop_Load(object sender, EventArgs e)
    {

    }


		private void btn_search_Click(object sender, EventArgs e)
		{
      ReadStaff();

		}
    private void ReadStaff(){
      NameObject<string> selectedItem = (NameObject<string>)cbox_kind.SelectedItem;
      //MessageBox.Show( selectedItem.Name + ", "+ selectedItem.Object.ToString());
      String _keyword = this.tbox_keyword.Text;
      DataTable _dt = App.Instance().DBManager.ReadStaffs(selectedItem.Object.ToString(), tbox_keyword.Text);

      DataTable _dsp_dt = this.DisplaySet.Tables["staff"];
      _dsp_dt.Rows.Clear();
      foreach(DataRow row in _dt.Rows)
      {
        DataRow _dspRow = _dsp_dt.NewRow();
        fetch(row,ref _dspRow);  
        _dsp_dt.Rows.Add(_dspRow);
      }

		}

    private void fetch(DataRow src, ref DataRow dst)
    {
      dst["stf_name"] = src["stf_name"];
      dst["stf_ucode"] = src["stf_ucode"];
      dst["stf_id"] = src["stf_id"];
      dst["stf_name"] = src["stf_name"];
      dst["stf_pwd"] = src["stf_pwd"];
      dst["stf_regdate"] = src["stf_regdate"];

      dst["stf_retiredate"] = src["stf_retiredate"];

      string _work_state = src["stf_work_state"].ToString();
      dst["stf_work_state"] = Constants.work_states[_work_state];

      string _gender = src["stf_gender"].ToString();
      dst["stf_gender"] = Constants.gender[_gender];


    }

    private void grid_staff_CellClick(object sender, DataGridViewCellEventArgs e)
    {
    //  int _idx = e.RowIndex;
    //  if (_idx > 0) { 
    //    DataRow _row = DispalySet.Tables["staff"].Rows[_idx];

    //    string _name = _row["stf_name"].ToString();
    //    int _ucode = Convert.ToInt32(_row["stf_ucode"]);
    //    //MessageBox.Show(_idx.ToString() +"=>" + _name + "," + _ucode.ToString());
    //    DataTable _dt = App.Instance().DBManager.ReadStaff(_ucode);
    //    if (_dt != null && _dt.Rows.Count == 1)
    //    {
    //      workMode = WorkMode.read;
    //      ShowStaffDetail(_dt);
    //    }
    //    else
    //    {
    //      MessageBox.Show("자료 찾을 수 없습니다.");
    //    }
    //}
    }
    private void ShowStaffDetail(DataTable _dt)
    {
      if (_dt != null && _dt.Rows.Count == 1)
      {
        DataRow row = _dt.Rows[0];
        m_stf_ucode = Convert.ToInt32(row["stf_ucode"]);
        tbox_name.Text = Convert.ToString(row["stf_name"]);
        tbox_id.Text = Convert.ToString(row["stf_id"]);
        tbox_pwd.Text = Convert.ToString(row["stf_pwd"]);
        String gender = Convert.ToString(row["stf_gender"]);
        if(gender == "m") {
          rbtn_man.Checked = true;
        } else  {
          rbtn_woman.Checked = true;
        }

        date_regdate.Value = Convert.ToDateTime(row["stf_regdate"]);
        string _work_state = Convert.ToString(row["stf_work_state"]);
        int _idx = Constants.work_states.Keys.ToList().IndexOf(_work_state);
        cbox_work_state.SelectedIndex = _idx;
        if (_work_state == "r") {
          if (row["stf_retiredate"] != DBNull.Value)
          {
            date_retired.Value = Convert.ToDateTime(row["stf_retiredate"]);
            date_retired.Visible = true;
          } else
          {
            date_retired.Value = DateTime.Now;
            date_retired.Visible = true;
          }        
        } else {
          date_retired.Visible = false;
        }

        //stf_ucode, , , , , , stf_work_state, stf_gender, stf_picture
        string _stf_picture = "";
        if (row["stf_picture"] != DBNull.Value)
        {
          _stf_picture = Convert.ToString(row["stf_picture"]);
        }
        if (_stf_picture.Length>0)
        {
          pbox_picture.Image = BitAssist.HexStringToImage(_stf_picture);
        } else if (rbtn_man.Checked) {
          pbox_picture.Image = Bitmap.FromFile("./images/boy.png");

        } else
        {
          pbox_picture.Image = Bitmap.FromFile("./images/girl.jpg");
        }
        workMode = WorkMode.read;
      }
    }
    private void grid_stafff_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{


    }

		private void grid_staff_SelectionChanged(object sender, EventArgs e)
		{

      DataRow _row = GridAssist.SelectedRow(grid_staff);
      if (_row != null)
      {
        int _ucode = Convert.ToInt32(_row["stf_ucode"]);
        DataTable _dt = App.Instance().DBManager.ReadStaff(_ucode);
        if (_dt != null && _dt.Rows.Count == 1)
        {
          workMode = WorkMode.read;
          ShowStaffDetail(_dt);
        }
        else
        {
          MessageBox.Show("자료 찾을 수 없습니다.");
        }
      }
    }

    private void cbox_work_state_SelectedIndexChanged(object sender, EventArgs e)
		{
      SetEditMode();
		}

		private void btn_file_Click(object sender, EventArgs e)
		{
      string image_file = string.Empty;
      OpenFileDialog ofDlg = new OpenFileDialog();
      ofDlg.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp";
      ofDlg.InitialDirectory = Application.StartupPath;
      if(ofDlg.ShowDialog() == DialogResult.OK)
      {
        image_file = ofDlg.FileName;
        pbox_picture.Image = Bitmap.FromFile(image_file);

        SetEditMode();
      }

		}

		private void btn_save_Click(object sender, EventArgs e)
		{
      if (workMode == WorkMode.add) {
        MessageBox.Show("추가저장합니다.");
        DoAddStaff();
      } else if(workMode == WorkMode.edit)
      {
        MessageBox.Show("수정저장합니다.");
        DoModifyStaff();
      } else if (workMode == WorkMode.read)
      {
        //MessageBox.Show("퇴사합니다.");
        DoRetireStaff();
      }
		}
    private void DoAddStaff()
    {

      string stf_id = tbox_id.Text;
      string stf_name = tbox_name.Text;
      string stf_pwd = tbox_pwd.Text;
      DateTime stf_regdate = date_regdate.Value;
      DateTime stf_retiredate = date_regdate.Value;
      NameObject<string> _selectItem = (NameObject<string>)cbox_work_state.SelectedItem;

      String stf_work_state = "w";
      if (_selectItem != null)
      {
        stf_work_state = _selectItem.Object.ToString();
      }

      string stf_gender = (rbtn_man.Checked) ? "m" : "w";

      string stf_picture = BitAssist.ImageToHexString(pbox_picture.Image);

      int _success = App.Instance().DBManager.AddStaff( stf_id, stf_name, stf_pwd, stf_regdate, stf_retiredate, stf_work_state, stf_gender, stf_picture);
      if (_success > 0)
      {
        AddGridStaff(_success);
      }

    }
    private void AddGridStaff(int _ucode)
    {
      DataTable _dt = App.Instance().DBManager.ReadStaff(_ucode);
      if (_dt != null && _dt.Rows.Count == 1)
      {
        DataRow row = _dt.Rows[0];
        DataRow _dspRow = this.DisplaySet.Tables["staff"].NewRow();
        fetch(row, ref _dspRow);
        this.DisplaySet.Tables["staff"].Rows.Add(_dspRow);
        workMode = WorkMode.read;
        this.DisplaySet.Tables["staff"].AcceptChanges();
      }

    }

    private void ResetGridStaff(int _ucode)
    {
      DataTable _dt = App.Instance().DBManager.ReadStaff(_ucode);
      if (_dt != null && _dt.Rows.Count == 1)
      {
        DataRow row = _dt.Rows[0];
        DataRow _dspRow = GridAssist.SelectedRow(grid_staff);


        fetch(row, ref _dspRow);
      }

    }

    private void DoModifyStaff()
    {
      string stf_id = tbox_id.Text;
      string stf_name = tbox_name.Text;
      string stf_pwd = tbox_pwd.Text;
      DateTime stf_regdate = date_regdate.Value;
      DateTime stf_retiredate = date_regdate.Value;
      NameObject<string> _selectItem = (NameObject<string>)cbox_work_state.SelectedItem;

      String stf_work_state = "w";
      if(_selectItem != null)
      {
       stf_work_state = _selectItem.Object.ToString();
      }

      string stf_gender = (rbtn_man.Checked) ? "m" : "w";

      string stf_picture = BitAssist.ImageToHexString(pbox_picture.Image);

      int _success = App.Instance().DBManager.ModifyStaff(m_stf_ucode, stf_id, stf_name, stf_pwd, stf_regdate, stf_retiredate, stf_work_state, stf_gender, stf_picture);
      if (_success > 0) {
        ResetGridStaff(_success);
      }
    }

    private void DoRetireStaff()
    {
      if (m_stf_ucode > 0 && workMode == WorkMode.read) { 
        int _success = App.Instance().DBManager.RetireStaff(m_stf_ucode);
        if (_success > 0) {

          ResetGridStaff(_success);

          MessageBox.Show("말소성공");
        } else
        {
          MessageBox.Show("말소실패");
        }

      }
    }

		private void btn_close_Click(object sender, EventArgs e)
		{
      DialogResult = DialogResult.Cancel;
		}

		private void tbox_name_TextChanged(object sender, EventArgs e)
		{


		}

		private void rbtn_man_CheckedChanged(object sender, EventArgs e)
		{
      SetEditMode(); setPicture();

    }

		private void rbtn_woman_CheckedChanged(object sender, EventArgs e)
		{
      SetEditMode(); setPicture();

    }

    private void setPicture(){
      if (rbtn_man.Checked)
      {
        pbox_picture.Image = Bitmap.FromFile("./images/boy.png");
      }
      else
      {

        pbox_picture.Image = Bitmap.FromFile("./images/girl.jpg");
      }


    }

		private void btn_add_Click(object sender, EventArgs e)
		{
      tbox_id.Text = string.Empty;
      tbox_name.Text = string.Empty;
      tbox_pwd.Text = string.Empty;
      rbtn_man.Checked = true;
      cbox_work_state.SelectedIndex = 0;
      this.workMode = WorkMode.add;
		}

    private void tbox_TextChanged(object sender, EventArgs e)
    {
      SetEditMode();
    }

    private void SetEditMode()
    {
      if(this.workMode != WorkMode.add)
      {
        this.workMode = WorkMode.edit;
      }
    }
  }
}
