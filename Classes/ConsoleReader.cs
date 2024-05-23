using GuessTheNumberGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberGame.Classes
{
    internal class ConsoleReader : IReadConsole
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
