namespace diceroll.MessagePrinter;

static class MessagePrinter
{
    const string WelcomeMessage = "Welcome to the dice roll game.  A dice has just been rolled.  Guess that value by inputting a number between 1 and 6.  You have three attempts";
    const string InputPrompt = "Enter a number between 1 and 6.";
    const string WinMessage = "Correct!  You have won the game.";
    const string LossMessage = "You lose.  Please try again!";

    public static void PrintWelcome()
    {
        Console.WriteLine(WelcomeMessage);
    }
    public static void PrintInputPrompt()
    {
        Console.WriteLine(InputPrompt);
    }
    public static void PrintWinMessage()
    {
        Console.WriteLine(WinMessage);
    }
    public static void PrintLossMessage()
    {
        Console.WriteLine(LossMessage);
    }
}