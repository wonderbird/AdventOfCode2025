namespace D01SecretEntrance;

public static class SecretEntrance
{
    public static int Process(IEnumerable<string> rotations)
    {
        var turns = rotations.Select(Turn.Parse);
        var currentPosition = 50;
        var numberOfZeros = 0;
        foreach(var turn in turns)
        {
            currentPosition = (currentPosition + turn.Sign * turn.Clicks) % 100;
            if (currentPosition == 0)
            {
                numberOfZeros++;
            }
        }
        return numberOfZeros;
    }
}
