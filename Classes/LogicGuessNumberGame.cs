using GuessTheNumberGame.Interfaces;


namespace GuessTheNumberGame.Classes
{
    public class LogicGuessNumberGame : ILogicGame
    {
        private readonly IRandomize _randomize;
        private readonly IReadConsole _readConsole;
        private readonly IWriteConsole _writeConsole;
        private readonly IValidate _validate;
        private readonly ISettings _settings;

        public LogicGuessNumberGame(
            IRandomize randomize,
            IReadConsole readConsole,
            IWriteConsole writeConsole,
            IValidate validate,
            ISettings settings)
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
