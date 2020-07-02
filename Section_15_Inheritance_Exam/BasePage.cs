using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://ultimateqa.com/complicated-page/

namespace Section_15_Inheritance_Exam
{
    public abstract class BasePage
    {
        public abstract string PageName { get; }    // this is a property
        // because the class is abstract the property must be abstract as well.
    }
}
