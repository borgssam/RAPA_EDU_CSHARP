using BookPro.Lib.Utils;
using BookPro.Windows.Pops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
      ShowPop(aPopType, WorkMode.none, null);
    }

    public void ShowPop(Type aPopType, WorkMode aWorkMode, Object aOption)
    {
      MasterPop targetPop = null;
      //기존에 Pop찾고
      foreach (MasterPop pop in masterPopList)
      {
        if(pop.GetType() == aPopType)
        {
          targetPop = pop;
        }
      }

      //없으면 생성하고
      if (targetPop == null) {
        targetPop = (MasterPop)Activator.CreateInstance(aPopType);
      }

      //Show

      targetPop.ShowPop(aWorkMode, aOption);

    }
  }
}
