namespace D01SecretEntrance;

public class SecretEntrance_PuzzleInput
{
    // 7379, 7406, 6765 are too high
    // [Fact(Skip = "not implemented yet")]
    [Fact]
    public void Returns()
    {
        var input = File.ReadAllLines("Data/PuzzleInput.txt");
        var actual = SecretEntrance.Process(input);
        actual.Should().Be(6228);
    }
}
