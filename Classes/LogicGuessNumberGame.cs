using GuessTheNumberGame.Classes;
using GuessTheNumberGame.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberGame.Classes
{
    internal class LogicGuessNumberGame : ILogicGame
    {
        private static IRandomize _randomize;
        private static IReadConsole _readConsole;
        private static IWriteConsole _writeConsole;
        private static IValidate _validate;
        private static ISettings _settings;

        public void LogicGuessNumberGame_ILogic(
            IRandomize randomize,
            IReadConsole readConsole,
            IWriteConsole writeConsole,
            IValidate validate,
            ISettings settings
            )
        {
            _randomize = randomize;
            _readConsole = readConsole;
            _writeConsole = writeConsole;
            _validate = validate;
            _settings = settings;
        }

        public void StartGame()
        {
            int pcNumber;
            int userNumber;
            string userAnswer;
            int userAttempts = 0;
            string textVariant;

            _randomize = new GetRandomNumberByRange();
            _readConsole = new ConsoleReader();
            _writeConsole = new ConsoleWriter();
            _validate = new TextValidator();
            _settings = new Settings();


            pcNumber = _randomize.RandomNumber(_settings.MinValue, _settings.MaxValue);

            _writeConsole.WriteToConsole("Начало игры \"Угадай число\". Попробуй угадать число, которое я загадал.");
            _writeConsole.WriteToConsole($"Число лежит в диапазоне от {_settings.MinValue} до {_settings.MaxValue}.");
            _writeConsole.WriteToConsole($"Количество попыток: {_settings.MaxAttempts}");

            while (userAttempts < _settings.MaxAttempts)
            {
                _writeConsole.WriteToConsole("Напиши число");

                userAnswer = _readConsole.Read();

                if (!_validate.IsConvertableToInt(userAnswer))
                {
                    _writeConsole.WriteToConsole("Необходимо ввести число");
                }
                else
                {
                    userNumber = Int32.Parse(userAnswer);

                    userAttempts++;

                    if (pcNumber == userNumber)
                    {
                        _writeConsole.WriteToConsole("Угадал!");
                        break;
                    }
                    else
                    {
                        if (pcNumber < userNumber)
                        {
                            textVariant = "меньше";
                        }
                        else
                        {
                            textVariant = "больше";
                        }
                        _writeConsole.WriteToConsole($"Не угадал. Загаданное число {textVariant}.");
                        _writeConsole.WriteToConsole($"Осталось попыток: {_settings.MaxAttempts - userAttempts}.");
                    }
                }


            }
        }
    }
}
