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
            var nextPosition = currentPosition + turn.Sign * turn.Clicks; 
            if (nextPosition > 0)
            {
                var positiveZeroCrossings = nextPosition / 100;
                numberOfZeros += positiveZeroCrossings;
            }
            else if (currentPosition > 0 && nextPosition <= 0)
            {
                var negativeZeroCrossings = -(nextPosition / 100) + 1;
                numberOfZeros += negativeZeroCrossings;
            }
            else if (currentPosition == 0)
            {
                var negativeZeroCrossings = -(nextPosition / 100);
                numberOfZeros += negativeZeroCrossings;                
            }

            currentPosition = nextPosition % 100;
            if (currentPosition < 0)
            {
                currentPosition += 100;
            }
        }
        return numberOfZeros;
    }
}
