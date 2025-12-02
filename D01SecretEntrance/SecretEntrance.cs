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
            currentPosition += turn.Sign * turn.Clicks;
            var zeroCrossings = currentPosition / 100;
            currentPosition %= 100;
            if (zeroCrossings >= 1)
            {
                numberOfZeros += zeroCrossings;
            }
            else if (currentPosition == 0)
            {
                numberOfZeros++;
            }
        }
        return numberOfZeros;
    }
}
