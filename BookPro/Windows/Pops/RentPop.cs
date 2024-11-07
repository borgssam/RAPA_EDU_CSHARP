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


		}


    private void DisplayMember(DataTable dt){


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