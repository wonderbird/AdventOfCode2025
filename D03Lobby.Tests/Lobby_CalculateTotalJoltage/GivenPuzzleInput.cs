namespace D03Lobby.Tests.Lobby_CalculateTotalJoltage;

public class GivenPuzzleInput
{
    //[Fact(Skip = "not implemented yet")]
    [Fact]
    public void WhenPuzzleInput_ReturnsExpectedResult()
    {
        var input = File.ReadAllLines("Data/PuzzleInput.txt");
        new Lobby().CalculateTotalJoltage(input).Should().Be(16887);
    }

    [Fact]
    public void WhenExampleInput_ReturnsExpectedResult()
    {
        var input = File.ReadAllLines("Data/ExampleInput.txt");
        new Lobby().CalculateTotalJoltage(input).Should().Be(357);
    }

    [Theory]
    [InlineData("987654321111111", 98)]
    [InlineData("811111111111119", 89)]
    [InlineData("234234234234278", 78)]
    [InlineData("818181911112111", 92)]
    public void WhenBankFromExampleInput_ReturnsExpectedResult(string bank, int expected)
    {
        IEnumerable<string> banks = [bank];
        new Lobby().CalculateTotalJoltage(banks).Should().Be(expected);
    }
}