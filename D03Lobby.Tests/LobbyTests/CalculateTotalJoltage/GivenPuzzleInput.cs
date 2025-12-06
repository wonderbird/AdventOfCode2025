namespace D03Lobby.Tests.LobbyTests.CalculateTotalJoltage;

public class GivenPuzzleInput
{
    //[Fact(Skip = "not implemented yet")]
    [Fact]
    public void WhenPuzzleInput_ReturnsExpectedResult()
    {
        var input = File.ReadAllLines("Data/PuzzleInput.txt");
        new Lobby().CalculateTotalJoltage(input, 12).Should().Be(167302518850275UL);
    }

    [Fact]
    public void Given2ActiveBatteries_WhenExampleInput_ReturnsExpectedResult()
    {
        var input = File.ReadAllLines("Data/ExampleInput.txt");
        new Lobby().CalculateTotalJoltage(input, 2).Should().Be(357UL);
    }

    [Fact]
    public void Given12ActiveBatteries_WhenExampleInput_ReturnsExpectedResult()
    {
        var input = File.ReadAllLines("Data/ExampleInput.txt");
        new Lobby().CalculateTotalJoltage(input, 12).Should().Be(3121910778619UL);
    }

    [Theory]
    [InlineData("987654321111111", 98UL)]
    [InlineData("811111111111119", 89UL)]
    [InlineData("234234234234278", 78UL)]
    [InlineData("818181911112111", 92UL)]
    public void Given2ActiveBatteries_WhenBankFromExampleInput_ReturnsExpectedResult(string bank, ulong expected)
    {
        IEnumerable<string> banks = [bank];
        new Lobby().CalculateTotalJoltage(banks, 2).Should().Be(expected);
    }

    [Theory]
    [InlineData("234234234234278", 434234234278UL)]
    public void Given12ActiveBatteries_WhenBankFromExampleInput_ReturnsExpectedResult(string bank, ulong expected)
    {
        IEnumerable<string> banks = [bank];
        new Lobby().CalculateTotalJoltage(banks, 12).Should().Be(expected);
    }
}