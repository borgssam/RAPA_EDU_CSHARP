using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp.Views
{
  public partial class TestPop : Form
  {

    public TestPop()
    {
      InitializeComponent();
    }

    private void btn_addButton_Click(object sender, EventArgs e)
    {
      int count = this.Controls.Count;
      int height = this.btn_addButton.Height;
      int left = this.btn_addButton.Left;
      Button btn = new Button();
      btn.Location = new Point(left, (height+10)*count);
      btn.Text = "자식버튼";
      this.Controls.Add(btn);
    }
  }
}
