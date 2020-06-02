﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_12_Interfaces
{
    // lesson 142 Implementing Interfaces

    interface ITraveler
    {
        string GetDestination();
        
        string GetStartLocation();

        double DetermineMiles();
    }
}
