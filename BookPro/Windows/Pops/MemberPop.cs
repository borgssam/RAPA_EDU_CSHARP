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

    private void InitializeObject(){


    }
    

    private void ApplicationIdle(object sender, EventArgs e)
    {

   
    }
		public override DialogResult ShowPop(WorkMode aWorkMode, ref object options)
		{			


      return base.ShowPop(aWorkMode, ref options);
		}

    private DataRow m_row = null;
    private void ReadMember(){


    }

    private void DisplayMember(){



    
    }


		private void MemberPop_Load(object sender, EventArgs e)
    {

    }

		private void btn_file_Click(object sender, EventArgs e)
		{

		}


		private void btn_close_Click(object sender, EventArgs e)
		{

		}

		private void btn_save_Click(object sender, EventArgs e)
		{

		}
    
    private void AddMember()  {


    }
    private void ModifyMember()  {
 

    }

		private void rbtn_man_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rbtn_woman_CheckedChanged(object sender, EventArgs e)
		{

		}
    private void setPicture(){


    }

		private void pbox_picture_Click(object sender, EventArgs e)
		{

		}
	}
}
