using GuessTheNumberGame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberGame.Classes
{
    internal class LogicGuessNumberGame
    {
        public static void GuessNumberGame()
        {
            var settings = new Settings();
            var consoleReader = new ConsoleReader();
            var textValidator = new TextValidator();
            var getRandomNumberByRange = new GetRandomNumberByRange();
            var consoleWriter = new ConsoleWriter();
            int PCNumber;
            int UserNumber;
            string UserAnswer;
            int UserAttempts = 0;
            string TextVariant;

            PCNumber = getRandomNumberByRange.RandomNumber(settings.MinValue, settings.MaxValue);

            consoleWriter.WriteToConsole("Начало игры \"Угадай число\". Попробуй угадать число, которое я загадал.");
            consoleWriter.WriteToConsole($"Число лежит в диапазоне от {settings.MinValue} до {settings.MaxValue}.");
            consoleWriter.WriteToConsole($"Количество попыток: {settings.MaxAttempts}");

            while (UserAttempts < settings.MaxAttempts)
            {
                consoleWriter.WriteToConsole("Напиши число");

                UserAnswer = consoleReader.Read();

                if (!textValidator.IsConvertableToInt(UserAnswer))
                {
                    consoleWriter.WriteToConsole("Необходимо ввести число");
                }
                else
                {
                    UserNumber = Int32.Parse(UserAnswer);

                    UserAttempts++;

                    if (PCNumber == UserNumber)
                    {
                        consoleWriter.WriteToConsole("Угадал!");
                        break;
                    }
                    else
                    {
                        if (PCNumber < UserNumber)
                        {
                            TextVariant = "меньше";
                        }
                        else
                        {
                            TextVariant = "больше";
                        }
                        consoleWriter.WriteToConsole($"Не угадал. Загаданное число {TextVariant}.");
                        consoleWriter.WriteToConsole($"Осталось попыток: {settings.MaxAttempts - UserAttempts}.");
                    }
                }


            }
        }
    }
}
