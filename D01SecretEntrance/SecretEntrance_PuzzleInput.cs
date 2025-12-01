namespace D01SecretEntrance;

public class SecretEntrance_PuzzleInput
{
    [Fact]
    public void Returns()
    {
        var input = File.ReadAllLines("Data/PuzzleInput.txt");
        var actual = SecretEntrance.Process(input);
        actual.Should().Be(1036);
    }
}
