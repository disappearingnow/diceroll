using diceroll.Dice;
using diceroll.MessagePrinter;
using diceroll.AnswerChecker;
using diceroll.InputHandler;

namespace diceroll.Game;

public class Game
{
    private readonly Dice.Dice _dice;
    private readonly int _maxAttempts;

    public Game()
    {
        _dice = new();
        _maxAttempts = 3;
    }

    public void PlayGame()
    {
        MessagePrinter.MessagePrinter.PrintWelcomeMessage();

        for (int i = 0; i < _maxAttempts; i++)
        {
            int guess = InputHandler.InputHandler.TakeInput();

            if (AnswerChecker.AnswerChecker.CheckAnswer(guess, _dice.RollValue))
            {
                MessagePrinter.MessagePrinter.PrintWinMessage();
                break;
            }
            else
            {
                if (i == 2)
                {
                    MessagePrinter.MessagePrinter.PrintLossMessage();
                }
                else
                {
                    MessagePrinter.MessagePrinter.PrintTryAgainMessage();
                }
            }
        }

    }
}
