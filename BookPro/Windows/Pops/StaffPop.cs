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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookPro.Windows.Pops
{
  public partial class StaffPop : MasterPop
  {
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
      }
      else if (this.workMode == WorkMode.edit)
      {
        this.Text = "사원관리 - 수정";
      }
      else if (this.workMode == WorkMode.read)
      {
        this.Text = "사원관리 - 조회";
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
      MessageBox.Show( selectedItem.Name + ", "+ selectedItem.Object.ToString());
      String _keyword = this.tbox_keyword.Text;
      DataTable _dt = App.Instance().DBManager.ReadStaffs(selectedItem.Object.ToString(), tbox_keyword.Text);

      DataTable _dsp_dt = this.DispalySet.Tables["staff"];
      _dsp_dt.Rows.Clear();
      foreach(DataRow row in _dt.Rows)
      {
        DataRow _dspRow = _dsp_dt.NewRow();
        _dspRow["stf_name"] = row["stf_name"];
        _dspRow["stf_ucode"] = row["stf_ucode"];
        _dspRow["stf_id"] = row["stf_id"];
        _dspRow["stf_name"] = row["stf_name"];
        _dspRow["stf_pwd"] = row["stf_pwd"];
        _dspRow["stf_regdate"] = row["stf_regdate"];

        _dspRow["stf_retiredate"] = row["stf_retiredate"];

        string _work_state = row["stf_work_state"].ToString();        
        _dspRow["stf_work_state"] = Constants.work_states[_work_state];

        string _gender = row["stf_gender"].ToString();
        _dspRow["stf_gender"] = Constants.gender[_gender];

        //   stf_ucode, stf_id, stf_name, stf_pwd, stf_regdate, stf_retiredate, stf_work_state, stf_gender

        _dsp_dt.Rows.Add(_dspRow);
      }

		}

		private void grid_stafff_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{


		}

		private void grid_staff_SelectionChanged(object sender, EventArgs e)
		{


		}



		private void cbox_work_state_SelectedIndexChanged(object sender, EventArgs e)
		{


		}

		private void btn_file_Click(object sender, EventArgs e)
		{


		}

		private void btn_save_Click(object sender, EventArgs e)
		{



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

		}

		private void rbtn_woman_CheckedChanged(object sender, EventArgs e)
		{

		}

    private void setPicture(){


    }

		private void btn_add_Click(object sender, EventArgs e)
		{

		}
	}
}
