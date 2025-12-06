namespace D03Lobby.Tests.LobbyTests.CalculateTotalJoltage.GivenSingleBank;

public class AndTwoBatteries
{
    [Fact]
    public void When12_returns12()
    {
        IEnumerable<string> banks = ["12"];
        new Lobby().CalculateTotalJoltage(banks, 2).Should().Be(12);
    }

    [Fact]
    public void When32_returns32()
    {
        IEnumerable<string> banks = ["32"];
        new Lobby().CalculateTotalJoltage(banks, 2).Should().Be(32);
    }

    [Fact]
    public void When52_returns52()
    {
        IEnumerable<string> banks = ["52"];
        new Lobby().CalculateTotalJoltage(banks, 2).Should().Be(52);
    }
}
