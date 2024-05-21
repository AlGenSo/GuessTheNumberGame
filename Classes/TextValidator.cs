using GuessTheNumberGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberGame.Classes
{
    internal class TextValidator : IValidate
    {
        public bool IsConvertableToInt(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return false;
            }

            return Int32.TryParse(text, out int result);
        }
    }
}
