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
  public partial class MasterPop : Form
  {
    public MasterPop()
    {
      InitializeComponent();
    }

    private void MasterPop_Load(object sender, EventArgs e)
    {

    }

    public virtual DialogResult ShowPop(WorkMode aWorkMode, Object options)
    {
      return this.ShowDialog();
    }
  }
}
