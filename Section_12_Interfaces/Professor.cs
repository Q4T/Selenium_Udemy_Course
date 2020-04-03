using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_12_Interfaces
{
    // lesson 142 Implemeting Interfaces

    class Professor : Person, ITraveler
    {
        private string empId;
        private string subject;
    }
}
