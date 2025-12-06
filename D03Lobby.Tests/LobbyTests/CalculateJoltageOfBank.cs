namespace D03Lobby.Tests.LobbyTests;

public class CalculateJoltageOfBank
{
    [Fact]
    public void WhenSingleBattery_ReturnsItsJoltage()
    {
        new Lobby().CalculateJoltageOfBank([1], 1).Should().Be(1UL);
    }

    [Fact]
    public void WhenThreeBatteries_ReturnsTheirJoltage()
    {
        new Lobby().CalculateJoltageOfBank([1, 2, 3], 3).Should().Be(123UL);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, 234UL)]
    [InlineData(new int[] { 3, 1, 2, 4 }, 324UL)]
    [InlineData(new int[] { 4, 3, 2, 1 }, 432UL)]
    public void GivenFourBatteries_WhenActivatingThreeBatteries_ReturnsMaximumJoltage(int[] bank, ulong expected)
    {
        new Lobby().CalculateJoltageOfBank(bank.ToList(), 3).Should().Be(expected);
    }
}