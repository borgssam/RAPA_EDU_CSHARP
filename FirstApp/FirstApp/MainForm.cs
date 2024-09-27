using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstApp.Views;
namespace FirstApp
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void btn_confirm_Click(object sender, EventArgs e)
    {
      this.lbl_result.Text = "응답 : "+this.tbox_message.Text;
    }

    private void btn_color_Click(object sender, EventArgs e)
    {
      if (this.lbl_result.ForeColor == Color.Red) {
        this.lbl_result.ForeColor = Color.Blue;
      } else {
        this.lbl_result.ForeColor = Color.Red;
      }
    }

    private void btn_newdlg_Click(object sender, EventArgs e)
    {
      TestPop testPop = new TestPop();
      testPop.ShowDialog();
    }

    private void btn_Docking_Click(object sender, EventArgs e)
    {
      DockingPop dockingPop = new DockingPop(); 
      dockingPop.ShowDialog();
    }
  }
}
