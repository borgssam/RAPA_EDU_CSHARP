using BookPro.Lib.Utils;
using BookPro.Windows.Pops;
using BookPro.Windows.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BookPro.Lib.Manager
{
  public class PopManager
  {
    private List<MasterPop> masterPopList;
    public PopManager() { 
      masterPopList = new List<MasterPop>();
    }

    public void ShowPop(Type aPopType)
    {
      ShowPop(aPopType, WorkMode.none);
    }

    public MasterPop FindPop(Type aPopType)
    {
        MasterPop targetPop = null;
        //기존에 Pop찾고
        foreach (MasterPop pop in masterPopList)
        {
            if (pop.GetType() == aPopType)
            {
                targetPop = pop;
            }
        }
        return targetPop;
    }

    public MasterPop GetPop(Type aPopType)
    {
			MasterPop targetPop = FindPop(aPopType);

			//없으면 생성하고
			if (targetPop == null)
			{
				targetPop = (MasterPop)Activator.CreateInstance(aPopType);
			}
      return targetPop;
		}
    
    public DialogResult ShowPop(Type aPopType, WorkMode aWorkMode)
    {
      Object _obj = null;
      return ShowPop( aPopType,  aWorkMode, ref _obj);
    }

    public DialogResult ShowPop(Type aPopType, WorkMode aWorkMode, ref Object aOption)
    {
      MasterPop targetPop = GetPop(aPopType);
      return targetPop.ShowPop(aWorkMode,ref aOption);

    }
  }
}
