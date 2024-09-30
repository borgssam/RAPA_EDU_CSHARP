using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSchool.Utils
{
  public class App
  {
    public string name = "홍길동";
    public int age = 0;
    public string gender = "남자";

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
  }
}
