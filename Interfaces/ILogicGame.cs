using GuessTheNumberGame.Interfaces;

namespace GuessTheNumberGame.Interfaces
{
    internal interface ILogicGame
    {
        private static IRandomize _randomize;
        private static IReadConsole _readConsole;
        private static IWriteConsole _writeConsole;
        private static IValidate _validate;
        private static ISettings _settings;

        public void GoGame()
        {
            StartGame();
        }

        public abstract void StartGame();
    }
}
