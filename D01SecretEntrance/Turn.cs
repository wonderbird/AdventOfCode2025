namespace D01SecretEntrance;

public readonly record struct Turn(Directions Direction, int Clicks)
{
    public int Sign => Direction == Directions.Left ? -1 : 1;

    public static Turn Parse(string input)
    {
        var direction = input[0] == 'L' ? Directions.Left : Directions.Right;
        var clicks = int.Parse(input.Substring(1));
        return new Turn(direction, clicks);
    }
}
