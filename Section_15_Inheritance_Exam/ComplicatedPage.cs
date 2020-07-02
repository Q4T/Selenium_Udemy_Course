using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_15_Inheritance_Exam
{
    class ComplicatedPage : BasePage
    {
        // properties
        // Using objects as properties is known as composition
        public SectionOfButtons buttonsSection { get; set; }
        public SectionOfSocialMedia socialMediaSection { get; set; }
        public SectionOfRandomStuff randonStuffSection { get; set; }
        public override string PageName { get => "Complicated Page"; }




    }
}
