﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberGame.Interfaces
{
    internal interface IRandomize
    {
        int RandomNumber(int minValue, int maxValue);
    }
}
