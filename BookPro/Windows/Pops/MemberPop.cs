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

namespace BookPro.Windows.Pops
{
  public partial class MemberPop : MasterPop
  {
    private int m_ucode = -1;
    public MemberPop()
    {
      InitializeComponent();
      InitializeObject();
      Application.Idle += ApplicationIdle;
    }

    private void InitializeObject()
    {
      this.rbtn_man.Checked = true;
      setPicture();


    }
    

    private void ApplicationIdle(object sender, EventArgs e)
    {
      if (this.workMode == WorkMode.add)
      {
        this.Text = "회원관리 - 추가";
        this.btn_save.Enabled = true;
        this.btn_save.Text = "저장";
      }
      else if (this.workMode == WorkMode.edit)
      {
        this.Text = "회원관리 - 수정";
        this.btn_save.Enabled = true;
        this.btn_save.Text = "저장";
      }


    }
		public override DialogResult ShowPop(WorkMode aWorkMode, ref object options)
    {
      if (aWorkMode == WorkMode.edit)
      {
        m_ucode = Convert.ToInt32(options);
        ReadMember();
        DisplayMember();

      }


      return base.ShowPop(aWorkMode, ref options);
		}

    private DataRow m_row = null;
    private void ReadMember()
    {
      if (m_ucode > 0)
      {
        m_row = App.Instance().DBManager.ReadMember(m_ucode);
      }

    }

    private void DisplayMember(){

      if (m_row != null)
      {
        // m_row에서 각 필드를 읽어와서 텍스트 박스나 레이블에 표시
        this.tbox_id.Text = m_row["mbr_id"].ToString();
        this.tbox_name.Text = m_row["mbr_name"].ToString();
        this.tbox_phone.Text = m_row["mbr_phone"].ToString();
        this.tbox_addr.Text = m_row["mbr_addr"].ToString();
        this.tbox_pwd.Text = m_row["mbr_pwd"].ToString();
        if (m_row["mbr_gender"].ToString() == "m") { rbtn_man.Checked = true; } else { rbtn_woman.Checked = true; }

        string _picture = "";
        if (m_row["mbr_picture"] != DBNull.Value)
        {
          _picture = m_row["mbr_picture"].ToString();
        }
        if (_picture.Length > 0)
        {
          pbox_picture.Image = BitAssist.HexStringToImage(_picture);
        }
        else if (rbtn_man.Checked)
        {
          pbox_picture.Image = Bitmap.FromFile("./images/boy.png");
        }
        else
        {
          pbox_picture.Image = Bitmap.FromFile("./images/girl.jpg");
        }
      }
      else
      {
        // m_row가 null일 경우, 모든 UI 요소 초기화

        this.tbox_id.Text = "";
        this.tbox_name.Text = "";
        this.tbox_phone.Text = "";
        this.tbox_addr.Text = "";
        rbtn_man.Checked = true;

      }



    }


		private void MemberPop_Load(object sender, EventArgs e)
    {

    }

		private void btn_file_Click(object sender, EventArgs e)
    {
      string image_file = string.Empty;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp";
      openFileDialog.InitialDirectory = Application.StartupPath;

      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        image_file = openFileDialog.FileName;
        pbox_picture.Image = Bitmap.FromFile(image_file);
      }
    }


		private void btn_close_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }

		private void btn_save_Click(object sender, EventArgs e)
    {
      if (WorkMode == Lib.Utils.WorkMode.add)
      {
        AddMember();
      }
      else if (WorkMode == WorkMode.edit)
      {
        ModifyMember();
      }

    }
    
    private void AddMember()  {

      String _picture = BitAssist.ImageToHexString(pbox_picture.Image);
      if (_picture == "") { _picture = "null"; }
      else
      {
        _picture = $"'{_picture}'";
      }

      int _result = App.Instance().DBManager.AddMember(tbox_id.Text, tbox_name.Text, tbox_pwd.Text, (rbtn_man.Checked) ? "m" : "w",
        tbox_phone.Text, tbox_addr.Text, _picture);
      if (_result > 0)
      {
        Options = _result;
        MessageBox.Show("저장성공");
        DialogResult = DialogResult.OK;
      }
      else
      {
        MessageBox.Show("저장샐패");
      }
    }
    private void ModifyMember()
    {
      String _picture = BitAssist.ImageToHexString(pbox_picture.Image);
      if (_picture == "") { _picture = "null"; }
      else
      {
        _picture = $"'{_picture}'";
      }

      int _result = App.Instance().DBManager.ModifyMember((int)Options, tbox_id.Text, tbox_name.Text, tbox_pwd.Text, (rbtn_man.Checked) ? "m" : "w",
        tbox_phone.Text, tbox_addr.Text, _picture);
      if (_result > 0)
      {
        Options = _result;
        MessageBox.Show("저장성공");
        DialogResult = DialogResult.OK;
      }
      else
      {
        MessageBox.Show("저장샐패");
      }


    }

		private void rbtn_man_CheckedChanged(object sender, EventArgs e)
    {
      setPicture();
    }

		private void rbtn_woman_CheckedChanged(object sender, EventArgs e)
    {
      setPicture();
    }
    private void setPicture()
    {
      if (rbtn_man.Checked)
      {
        pbox_picture.Image = Bitmap.FromFile("./images/boy.png");
      }
      else
      {
        pbox_picture.Image = Bitmap.FromFile("./images/girl.jpg");
      }
    }

		private void pbox_picture_Click(object sender, EventArgs e)
		{

		}
	}
}
