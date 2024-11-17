namespace diceroll.DiceRoller;

static class DiceRoller
{
    public static int RollDice()
    {
        Random rnd = new();
        return rnd.Next(1, 7);

    }
}