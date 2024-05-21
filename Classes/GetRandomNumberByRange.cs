using GuessTheNumberGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberGame.Classes
{
    internal class GetRandomNumberByRange : IRandomize
    {
        public int RandomNumber(int minValue, int maxValue)
        {
            return new Random().Next(minValue, maxValue);
        }
    }
}
