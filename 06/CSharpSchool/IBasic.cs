using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSchool
{
  internal interface IBasic
  {
    int TestInstanceMethod();
    int TestProperty { get; set; }
    //int Name;
  }
}
