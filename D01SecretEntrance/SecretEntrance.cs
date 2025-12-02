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
            if (currentPosition > 0)
            {
                var positiveZeroCrossings = currentPosition / 100;
                numberOfZeros += positiveZeroCrossings;
            }
            else if (currentPosition <= 0)
            {
                var negativeZeroCrossings = -(currentPosition / 100) + 1;
                numberOfZeros += negativeZeroCrossings;
            }
            currentPosition %= 100;
        }
        return numberOfZeros;
    }
}
