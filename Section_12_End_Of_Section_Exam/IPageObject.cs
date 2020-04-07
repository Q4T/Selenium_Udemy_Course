using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_12_End_Of_Section_Exam
{
    interface IPageObject
    {
       //string PageName();   I orginally set a method signiture
        string PageName { get; } // but the teacher set it as a property
        
     
    }
}
