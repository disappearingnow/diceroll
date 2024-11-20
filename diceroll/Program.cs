/*
 1. Game rolls dice behind the scenes
 2. Console prompts user for 3 attempts
 3. If user guess the dice's value correctly, they win
 4. If user fails to guess correct dice value, they lose
 5. Game ends
 */
using diceroll.DiceRoller;
using diceroll.MessagePrinter;
using diceroll.AnswerChecker;
using diceroll.InputHandler;

int roll = DiceRoller.RollDice();

MessagePrinter.PrintWelcomeMessage();

for (int i = 0; i < 3; i++)
{
    int guess = InputHandler.TakeInput();

    if (AnswerChecker.CheckAnswer(guess, roll))
    {
        MessagePrinter.PrintWinMessage();
        break;
    }
    else
    {
        if (i == 2)
        {
            MessagePrinter.PrintLossMessage();
        }
        else
        {
            MessagePrinter.PrintTryAgainMessage();
        }
    }
}
