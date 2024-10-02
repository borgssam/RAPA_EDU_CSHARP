using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookPro.Windows.Views
{
  public partial class MasterView : Form
  {
    public MasterView()
    {
      if (!DesignMode)
      {
        InitializeCustom();
        InitializeComponent();
      }
    }
    private void InitializeCustom()
    {
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Visible = false;
      this.TopLevel = false;
      this.Left = 0;
      this.Top = 0;

    }
    private void MasterView_Load(object sender, EventArgs e)
    {

    }
  }
}
