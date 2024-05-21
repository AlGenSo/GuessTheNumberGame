using GuessTheNumberGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberGame.Classes
{
    internal class Settings : ISettings
    {
        public int MinValue { get; init; }
        public int MaxValue { get; init; }
        public int MaxAttempts { get; init; }

        public Settings()
        {
            this.MinValue = 1;
            this.MaxValue = 10;
            this.MaxAttempts = 3;
        }
    }
}
