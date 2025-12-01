namespace D01SecretEntrance;

public readonly record struct Turn(Directions direction, int clicks)
{
    public static Turn Parse(string input)
    {
        var direction = Directions.Right;
        var clicks = int.Parse(input.Substring(1));
        return new Turn(direction, clicks);
    }
}
