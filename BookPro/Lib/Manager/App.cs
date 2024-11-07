using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPro.Lib.Manager
{
  //123
  public class App
  {
    private static App instance = null;
    private App() { }

    public static App Instance()
    {
      if (instance == null)
      {
        instance = new App();
      }
      return instance;
    }

    public PopManager PopManager {  get; set; }
    public DBManager DBManager { get; set; }
  }
}
