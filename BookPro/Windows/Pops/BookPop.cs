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
    private void InitializeObject(){


    }
    private void ApplicationIdle(object sender, EventArgs e)
    {

   
    }

    public override DialogResult ShowPop(WorkMode aWorkMode,ref object options)
    {


      return base.ShowPop(aWorkMode,ref options);
    }

    private void ReadBook(){


    }

    private void DisplayAddMode() {

    }


    private void DisplayBook() {


      
    }

    private void BookPop_Load(object sender, EventArgs e)
    {

    }

    private void btn_save_Click(object sender, EventArgs e)
    {


    }

    private void btn_close_Click(object sender, EventArgs e)
    {

    }

		private void btn_file_Click(object sender, EventArgs e)
		{          


		}
	}
}
