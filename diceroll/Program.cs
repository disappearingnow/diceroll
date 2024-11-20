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

int guess = InputHandler.TakeInput();

Console.WriteLine(AnswerChecker.CheckAnswer(guess, roll) ? "yep" : "nope");
