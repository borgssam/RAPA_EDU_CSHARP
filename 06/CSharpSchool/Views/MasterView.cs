using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSchool.Views
{
  public partial class MasterView : Form
  {
    public MasterView()
    {
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Visible = false;
      this.TopLevel = false;  //제일중요
      this.Left = 0;
      this.Top = 0;
      InitializeComponent();
    }

    private void MasterView_Load(object sender, EventArgs e)
    {

    }
  }
}
