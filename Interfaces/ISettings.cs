using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberGame.Interfaces
{
    public interface ISettings
    {
        public int MinValue { get; init; }
        public int MaxValue { get; init; }
        public int MaxAttempts { get; init; }
    }
}
