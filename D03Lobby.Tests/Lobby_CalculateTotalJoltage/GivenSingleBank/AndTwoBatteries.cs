namespace D03Lobby.Tests.Lobby_CalculateTotalJoltage.GivenSingleBank;

public class AndTwoBatteries
{
    [Fact]
    public void When12_returns12()
    {
        IEnumerable<string> banks = ["12"];
        new Lobby().CalculateTotalJoltage(banks).Should().Be(12);
    }

    [Fact]
    public void When32_returns32()
    {
        IEnumerable<string> banks = ["32"];
        new Lobby().CalculateTotalJoltage(banks).Should().Be(32);
    }

    [Fact]
    public void When52_returns52()
    {
        IEnumerable<string> banks = ["52"];
        new Lobby().CalculateTotalJoltage(banks).Should().Be(52);
    }
}
