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

    private void tbtn_member_Click(object sender, EventArgs e)
    {
      ShowView(this.view_space, typeof(MemberView));

      mbtn_member.Checked = true;
      mbtn_book.Checked = false;
      mbtn_rent.Checked = false;
      tbtn_member.Checked = true;
      tbtn_book.Checked = false;
      tbtn_rent.Checked = false;
      btn_member.BackColor = System.Drawing.SystemColors.ButtonShadow;
      btn_rent.BackColor = System.Drawing.SystemColors.Control;
      btn_book.BackColor = System.Drawing.SystemColors.Control;

    }
    private void mbtn_member_Click(object sender, EventArgs e)
    {
      ShowView(this.view_space, typeof(MemberView));
    }
    private void btn_book_Click(object sender, EventArgs e)
    {
      ShowView(this.view_space, typeof(BookView));

    }
    private void mbtn_book_Click(object sender, EventArgs e)
    {

      ShowView(this.view_space, typeof(BookView));
    }

    private void tbtn_book_Click(object sender, EventArgs e)
    {
      ShowView(this.view_space, typeof(BookView));
      tbtn_member.Checked = false;
      tbtn_rent.Checked = false;
      tbtn_book.Checked = true;
      mbtn_member.Checked = false;
      mbtn_rent.Checked = false;
      mbtn_book.Checked = true;
      btn_member.BackColor = System.Drawing.SystemColors.Control; 
      btn_rent.BackColor = System.Drawing.SystemColors.Control;
      btn_book.BackColor = System.Drawing.SystemColors.ButtonShadow;


    }

    private void btn_rent_Click(object sender, EventArgs e)
    {
      ShowView(this.view_space, typeof(RentView));

    }

    private void mbtn_rent_Click(object sender, EventArgs e)
    {

      ShowView(this.view_space, typeof(RentView));
    }

    private void tbtn_rent_Click(object sender, EventArgs e)
    {
      ShowView(this.view_space, typeof(RentView));
      tbtn_member.Checked = false;
      tbtn_book.Checked = false;
      tbtn_rent.Checked = true;
      mbtn_member.Checked = false;
      mbtn_book.Checked = false;
      mbtn_rent.Checked = true;
      btn_member.BackColor = System.Drawing.SystemColors.Control;
      btn_rent.BackColor = System.Drawing.SystemColors.ButtonShadow;
      btn_book.BackColor = System.Drawing.SystemColors.Control;
    }

    private void main_timer_Tick(object sender, EventArgs e)
    {
      this.label_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }
  }
}
