using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_15_Inheritance_Exam
{
    class ComplicatedPage : BasePage
    {
        SectionOfButtons buttonsSection;
        SectionOfSocialMedia socialMediaSection;
        SectionOfRandomStuff randonStuffSection;

        public override string pageName()
        {
            return "Complicated Page";
        }


    }
}
