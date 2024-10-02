using BookPro.Windows.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookPro.Lib.Manager
{
  internal class ViewManager
  {
    //view목록
    private List<MasterView> masterViews;
    public ViewManager()
    {
      masterViews = new List<MasterView>();
    }

    public bool IsVisibleView(Type aViewType)
    {
      bool result = false;
      foreach (MasterView view in masterViews)
      {
        if (view.GetType() == aViewType)
        {
          result = view.Visible;
          break;
        }

      }
      return result;

    }
    //show함수
    public void ShowView(Control aViewSpace, Type aViewType)
    {
      MasterView targetView = null;
      //목록에 해당 뷰가 있는지 찾기

      foreach (MasterView view in masterViews)
      { if (view.GetType() == aViewType)
        {
          targetView = view;
          targetView.Visible = true;
        }
        else
        {
          view.Visible = false;
        }
      }

      if (targetView == null  && aViewSpace != null)
      {
        targetView = (MasterView)Activator.CreateInstance(aViewType);

        targetView.Parent = aViewSpace;
        targetView.Dock = DockStyle.Fill;
        targetView.Visible = true;
        masterViews.Add(targetView);
      }
    }
  }
}
