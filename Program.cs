using GuessTheNumberGame.Classes;

namespace GuessTheNumberGame
{
    public static class Program
    {
        static void Main()
        {
            LogicGuessNumberGame logicGuessNumberGame = new LogicGuessNumberGame(
                new GetRandomNumberByRange(),
                new ConsoleReader(),
                new ConsoleWriter(),
                new TextValidator(),
                new Settings());
            logicGuessNumberGame.StartGame();
        }
    }
}
    