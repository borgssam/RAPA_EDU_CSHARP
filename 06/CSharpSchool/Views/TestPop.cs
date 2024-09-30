using CSharpSchool.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSchool.Views
{
  public partial class TestPop : Form
  {
    public TestPop()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      App app = App.Instance();
      app.name = this.tbox_1.Text;
      app.age = int.Parse(this.tbox_2.Text);
      app.gender = this.tbox_3.Text;
    }
    private Point prevPoint;
    private void button1_MouseMove(object sender, MouseEventArgs e)
    {
      String tempo = $"좌표 {e.X}, {e.Y}";
      this.label_display.Text = tempo;
      if(prevPoint == null)
      {
        prevPoint = e.Location;
      }
      using (Graphics g = this.button1.CreateGraphics())
      {
        g.DrawLine(Pens.Black, prevPoint, e.Location);
      }
      prevPoint = e.Location;
    }
  }
}
