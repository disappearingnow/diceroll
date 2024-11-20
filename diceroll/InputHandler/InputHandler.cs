namespace diceroll.InputHandler;

using diceroll.MessagePrinter;

internal class InputHandler
{
    public static int TakeInput()
    {
        bool passes;
        int num;
        do
        {
            MessagePrinter.PrintInputPrompt();
            passes = int.TryParse(Console.ReadLine(), out num);


            if (passes)
            {
                if (num < 1 || num > 6)
                {
                    passes = false;
                    continue;
                }
            }

        } while (!passes);

        return num;
    }
}

