namespace D03Lobby.Tests.Lobby_CalculateTotalJoltage;

public class GivenPuzzleInput
{
    // Too low: 814
    [Fact(Skip = "not implemented yet")]
    // [Fact]
    public void WhenPuzzleInput_ReturnsExpectedResult()
    {
        var input = File.ReadAllLines("Data/PuzzleInput.txt");
        Lobby.CalculateTotalJoltage(input).Should().Be(357);
    }

    [Fact]
    public void WhenExampleInput_ReturnsExpectedResult()
    {
        var input = File.ReadAllLines("Data/ExampleInput.txt");
        Lobby.CalculateTotalJoltage(input).Should().Be(357);
    }

    [Theory]
    [InlineData("987654321111111", 98)]
    [InlineData("811111111111119", 89)]
    [InlineData("234234234234278", 78)]
    [InlineData("818181911112111", 92)]
    public void WhenBankFromExampleInput_ReturnsExpectedResult(string bank, int expected)
    {
        Lobby.CalculateTotalJoltage([bank]).Should().Be(expected);
    }
}