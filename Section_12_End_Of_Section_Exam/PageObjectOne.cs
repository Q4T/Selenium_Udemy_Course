using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_12_End_Of_Section_Exam
{
    class PageObjectOne : IPageObject
    {
        /*     public string PageName()
             {
                 return "Page Name 1";
             } */

        // we can use Lambda syntax  (=>)
        public string PageName => "Page Name 1";
    }
}
