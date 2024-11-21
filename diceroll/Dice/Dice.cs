namespace diceroll.Dice;

public class Dice
{
    private readonly Random _random;
    private readonly int _rollValue;
    private const int _sides = 6;
    public Dice()
    {
        _random = new Random();
        _rollValue = _random.Next(1, _sides + 1);
    }

    public int RollValue
    {
        get => _rollValue;
    }

}