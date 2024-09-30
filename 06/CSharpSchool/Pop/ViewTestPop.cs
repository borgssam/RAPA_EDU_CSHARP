using CSharpSchool.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSchool.Pop
{
  public partial class ViewTestPop : Form
  {
    public ViewTestPop()
    {
      InitializeComponent();

      masterViews = new List<MasterView>();
    }


    private List<MasterView> masterViews;

    private void ShowView(Control aViewSpace, Type aViewType)
    {
      MasterView newView = null;
      foreach (MasterView view in masterViews)
      {
        if (view.GetType() == aViewType) {
          newView = view;
          view.Visible = true;
        } else {
          view.Visible = false;
        }
      }
      if (newView == null)
      {
        newView = (MasterView)Activator.CreateInstance(aViewType);
        newView.Parent = aViewSpace;
        newView.Dock = DockStyle.Fill;
        newView.Visible = true;
        masterViews.Add(newView);
      }

    }
    private void btn_member_Click(object sender, EventArgs e)
    {
      ShowView(this.view_space, typeof(MemberView));
    }

    private void btn_book_Click(object sender, EventArgs e)
    {
      ShowView(this.view_space, typeof(BookView));

    }

    private void btn_rent_Click(object sender, EventArgs e)
    {
      ShowView(this.view_space, typeof(RentView));

    }
  }
}
