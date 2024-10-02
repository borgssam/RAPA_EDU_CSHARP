using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookPro.Lib.Manager;
using BookPro.Lib.Utils;
using BookPro.Windows.Pops;

namespace BookPro.Windows.Views
{
  public partial class BookView : MasterView
  {
    public BookView()
    {
      InitializeComponent();
    }

    private void BookView_Load(object sender, EventArgs e)
    {

    }

    private void btn_add_book_Click(object sender, EventArgs e)
    {
       DialogResult _result = App.Instance().PopManager.ShowPop(typeof(BookPop), WorkMode.add, null);
      if (_result == DialogResult.OK) {
        MessageBox.Show("ok");
      } else if (_result == DialogResult.Cancel) {
        MessageBox.Show("cancel");
      }
    }

    private void btn_delete_book_Click(object sender, EventArgs e)
    {
      App.Instance().PopManager.ShowPop(typeof(BookPop), WorkMode.edit, 3);
    }
  }
}
